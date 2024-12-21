using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Vistainn.BookFolder
{
    public partial class addDialogBook : Form
    {
        Database database = new MySqlDatabase();
        public event EventHandler OnDataAdded;

        public addDialogBook()
        {
            InitializeComponent();
        }

        //load room no combo box - method
        private void LoadRoomNoCB(string selectedRoomType)
        {
            string query = "SELECT RoomNo FROM room WHERE RoomType = @RoomType";
            try
            {
                using (IDbConnection con = database.CreateConnection())
                {
                    database.OpenConnection(con);
                    IDbCommand command = con.CreateCommand();
                    command.CommandText = query;
                    AddParameter(command, "@RoomType", selectedRoomType);

                    List<string> roomNo = new List<string>();
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roomNo.Add(reader["RoomNo"].ToString());
                        }
                    }

                    roomNoComboBox.Items.Clear();
                    roomNoComboBox.Items.AddRange(roomNo.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading room numbers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //selected room type change - method
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

                    using (var transaction = conn.BeginTransaction())
                    {
                        MySqlCommand cmdBooking = new MySqlCommand(
                            "INSERT INTO `booking`(`FullName`, `PhoneNo`, `Email`, `RoomNo`, `RoomType`, `Pax`, `CheckIn`, `CheckOut`, `AoName`, `AoPrice`, `AoQty`, `Status`) " +
                            "VALUES (@FullName, @PhoneNo, @Email, @RoomNo, @RoomType, @Pax, @CheckIn, @CheckOut, @AoName, @AoPrice, @AoQty, @Status)", conn, transaction);

                        AddParameter(cmdBooking);

                        cmdBooking.ExecuteNonQuery();
                        int bookingId = Convert.ToInt32(cmdBooking.LastInsertedId);

                        MySqlCommand cmdPayment = new MySqlCommand(
                            "INSERT INTO `payment`(`BookingId`, `FullName`, `Amount`, `PaymentMethod`, `Status`) " +
                            "VALUES (@BookingId, @FullName, @Amount, @PaymentMethod, @Status)", conn, transaction);

                        AddParameter(cmdPayment, bookingId);

                        cmdPayment.ExecuteNonQuery();

                        transaction.Commit();

                        OnDataAdded?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show("Booking and payment information has been added successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //booking parameter
        private void AddParameter(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@FullName", fullNameTextBox.Text);
            cmd.Parameters.AddWithValue("@PhoneNo", phoneNoTextBox.Text);
            cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@RoomNo", roomNoComboBox.Text);
            cmd.Parameters.AddWithValue("@RoomType", roomTypeComboBox.Text);
            cmd.Parameters.AddWithValue("@Pax", paxNumericUpDown.Value);
            cmd.Parameters.AddWithValue("@CheckIn", checkInDateTimePicker.Value);
            cmd.Parameters.AddWithValue("@CheckOut", checkOutDateTimePicker.Value);
            cmd.Parameters.AddWithValue("@AoName", aoNameTextBox.Text);
            cmd.Parameters.AddWithValue("@AoPrice", decimal.TryParse(aoPriceTextBox.Text, out var aoPrice) ? aoPrice : 0);
            cmd.Parameters.AddWithValue("@AoQty", int.TryParse(aoQuantityTextBox.Text, out var aoQty) ? aoQty : 0);
            cmd.Parameters.AddWithValue("@Status", statusComboBox.Text);
        }

        //payment parameter
        private void AddParameter(MySqlCommand cmd, int bookingId)
        {
            cmd.Parameters.AddWithValue("@BookingId", bookingId);
            cmd.Parameters.AddWithValue("@FullName", fullNameTextBox.Text);
            cmd.Parameters.AddWithValue("@Amount", DBNull.Value); 
            cmd.Parameters.AddWithValue("@PaymentMethod", DBNull.Value);
            cmd.Parameters.AddWithValue("@Status", "Pending"); 
        }

        //load room no parameter
        private void AddParameter(IDbCommand cmd, string parameterName, object value)
        {
            IDbDataParameter param = cmd.CreateParameter();
            param.ParameterName = parameterName;
            param.Value = value ?? DBNull.Value;
            cmd.Parameters.Add(param);
        }
    }
}
