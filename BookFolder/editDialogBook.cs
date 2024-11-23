using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistainn.BookFolder
{
    public partial class editBookDialog : Form
    {
        Database database = new Database();
        public event Action OnBookingUpdated;

        public editBookDialog()
        {
            InitializeComponent();
            LoadRoomNoCB();
            LoadRoomTypeCB();
        }

        //populate room no. in combo box
        private void LoadRoomNoCB()
        {
            string query = "SELECT RoomNo from Room";
            MySqlConnection con = new MySqlConnection(database.connectionString);
            con.Open();
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();
            List<string> roomNo = new List<string>();
            while (reader.Read())
            {
                roomNo.Add(reader["RoomNo"].ToString());
            }
            roomNoComboBox.Items.Clear();
            roomNoComboBox.Items.AddRange(roomNo.ToArray());
            con.Close();
        }

        //populate room type in combo box
        private void LoadRoomTypeCB()
        {
            string query = "SELECT RoomType from Room";
            MySqlConnection con = new MySqlConnection(database.connectionString);
            con.Open();
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();
            List<string> roomType = new List<string>();
            while (reader.Read())
            {
                roomType.Add(reader["RoomType"].ToString());
            }
            roomTypeComboBox.Items.Clear();
            roomTypeComboBox.Items.AddRange(roomType.ToArray());
            con.Close();
        }

        //update button - click
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (checkInDateTimePicker.Value.Date > checkOutDateTimePicker.Value.Date)
            {
                MessageBox.Show("Check-in date cannot be later than check-out date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(database.connectionString))
                {
                    conn.Open();
                    string query = "UPDATE booking SET FullName=@name, RoomNo=@roomno, RoomType=@roomtype, `check_in`=@in, `check_out`=@out, Status=@status WHERE BookingId=@bookingid";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.Add("@bookingid", MySqlDbType.Int32).Value = int.Parse(bookingIdTextBox.Text.Trim());
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = fullNameTextBox.Text.Trim();
                    cmd.Parameters.Add("@roomno", MySqlDbType.VarChar).Value = roomNoComboBox.Text.Trim();
                    cmd.Parameters.Add("@roomtype", MySqlDbType.VarChar).Value = roomTypeComboBox.Text.Trim();
                    cmd.Parameters.Add("@in", MySqlDbType.DateTime).Value = checkInDateTimePicker.Value;
                    cmd.Parameters.Add("@out", MySqlDbType.DateTime).Value = checkOutDateTimePicker.Value;
                    cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = statusComboBox.Text.Trim();

                    cmd.ExecuteNonQuery();
                }

                OnBookingUpdated?.Invoke();

                MessageBox.Show("Booking updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
