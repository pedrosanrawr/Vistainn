using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistainn.RoomFolder;

namespace Vistainn.BookFolder
{
    public partial class addDialogBook : Form
    {
        Database database = new Database();
        public event EventHandler OnDataAdded;

        public addDialogBook()
        {
            InitializeComponent();
            LoadRoomTypeCB();
        }

        //room no combo box
        private void LoadRoomNoCB(string selectedRoomType)
        {
            string query = "SELECT RoomNo FROM room WHERE RoomType = @RoomType";
            MySqlConnection con = new MySqlConnection(database.connectionString);
            con.Open();
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@RoomType", selectedRoomType);
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

        //room type combo box
        private void LoadRoomTypeCB()
        {
            string query = "SELECT RoomType from room GROUP BY RoomType";
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


        //room type combo box - event
        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRoomType = roomTypeComboBox.SelectedItem.ToString();
            LoadRoomNoCB(selectedRoomType);
        }

        //add button - click
        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fullNameTextBox.Text) ||
              string.IsNullOrWhiteSpace(phoneNoTextBox.Text) ||
              string.IsNullOrWhiteSpace(emailTextBox.Text) ||
              string.IsNullOrWhiteSpace(roomNoComboBox.Text) ||
              string.IsNullOrWhiteSpace(roomTypeComboBox.Text) ||
              string.IsNullOrWhiteSpace(paxNumericUpDown.Text))
            {
                MessageBox.Show("Please fill all the important fields before inserting.");
                return;
            }

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

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `booking`(`FullName`, `PhoneNo`, `Email`, `RoomNo`, `RoomType`, `Pax`,`CheckIn`, `CheckOut`, `AoName`, `AoPrice`, `AoQty`, `Status`) " +
                                                        "VALUES (@FullName, @PhoneNo, @Email, @RoomNo , @RoomType, @Pax ,@CheckIn, @CheckOut, @AoName, @AoPrice, @AoQty, @Status)", conn);

                    cmd.Parameters.Add("@FullName", MySqlDbType.VarChar).Value = fullNameTextBox.Text;
                    cmd.Parameters.Add("@PhoneNo", MySqlDbType.VarChar).Value = phoneNoTextBox.Text;
                    cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = emailTextBox.Text;
                    cmd.Parameters.Add("@RoomNo", MySqlDbType.VarChar).Value = roomNoComboBox.Text;
                    cmd.Parameters.Add("@RoomType", MySqlDbType.VarChar).Value = roomTypeComboBox.Text;
                    cmd.Parameters.Add("@Pax", MySqlDbType.VarChar).Value = paxNumericUpDown.Text;
                    cmd.Parameters.Add("@CheckIn", MySqlDbType.Date).Value = checkInDateTimePicker.Value;
                    cmd.Parameters.Add("@CheckOut", MySqlDbType.Date).Value = checkOutDateTimePicker.Value;
                    cmd.Parameters.Add("@AoName", MySqlDbType.VarChar).Value = aoNameTextBox.Text;
                    cmd.Parameters.Add("@AoPrice", MySqlDbType.VarChar).Value = aoPriceTextBox.Text;
                    cmd.Parameters.Add("@AoQty", MySqlDbType.VarChar).Value = aoQuantityTextBox.Text;
                    cmd.Parameters.Add("@Status", MySqlDbType.VarChar).Value = statusComboBox.Text;


                    cmd.ExecuteNonQuery();


                    OnDataAdded?.Invoke(this, EventArgs.Empty);

                    MessageBox.Show("Book information has been added successfully.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
