using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Vistainn.BookFolder
{
    public partial class editBookDialog : Form
    {
        Database database = new MySqlDatabase();

        public event Action OnBookingUpdated;

        public editBookDialog()
        {
            InitializeComponent();
        }

        //load room no combo box
        private void LoadRoomNoCB(string selectedRoomType)
        {
            string query = "SELECT RoomNo FROM room WHERE RoomType = @RoomType";
            var parameters = new Dictionary<string, object>
            {
                { "@RoomType", selectedRoomType }
            };

            var roomNo = new List<string>();
            try
            {
                using (var reader = ((MySqlDatabase)database).ExecuteReader(query, parameters))
                {
                    while (reader.Read())
                    {
                        roomNo.Add(reader["RoomNo"].ToString());
                    }
                }

                roomNoComboBox.Items.Clear();
                roomNoComboBox.Items.AddRange(roomNo.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading room numbers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //selected room type combo box
        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRoomType = roomTypeComboBox.SelectedItem.ToString();
            LoadRoomNoCB(selectedRoomType);
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
                string query = "UPDATE booking SET BookingId=@BookingId, FullName=@FullName, PhoneNo=@PhoneNo, Email=@Email, " +
                               "RoomNo=@RoomNo, RoomType=@RoomType, Pax=@Pax, CheckIn=@CheckIn, " +
                               "CheckOut=@CheckOut, AoName=@AoName, AoPrice=@AoPrice, AoQty=@AoQty, Status=@Status " +
                               "WHERE BookingId=@BookingId";

                var parameters = new Dictionary<string, object>
                {
                    { "@BookingId", int.Parse(bookingIdTextBox.Text) },
                    { "@FullName", fullNameTextBox.Text },
                    { "@PhoneNo", phoneNoTextBox.Text },
                    { "@Email", emailTextBox.Text },
                    { "@RoomNo", roomNoComboBox.Text },
                    { "@RoomType", roomTypeComboBox.Text },
                    { "@Pax", paxNumericUpDown.Text },
                    { "@CheckIn", checkInDateTimePicker.Value },
                    { "@CheckOut", checkOutDateTimePicker.Value },
                    { "@AoName", aoNameTextBox.Text },
                    { "@AoPrice", aoPriceTextBox.Text },
                    { "@AoQty", aoQuantityTextBox.Text },
                    { "@Status", statusComboBox.Text }
                };

                ((MySqlDatabase)database).ExecuteNonQuery(query, parameters);

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