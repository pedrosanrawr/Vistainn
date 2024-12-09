using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Vistainn.BookFolder;

namespace Vistainn
{
    public partial class bookFormm : Form
    {
        Database database = new Database();

        public bookFormm()
        {
            InitializeComponent();
        }

        //book form - load
        private void bookForm_Load(object sender, EventArgs e)
        {
            fillDGV();
            filldvg2("", "");
        }

        //populate table
        public void fillDGV()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(database.connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM booking";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    bookTable.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //add button click
        private void addBookButton_Click(object sender, EventArgs e)
        {
            addDialogBook addDialogMBook = new addDialogBook();
            addDialogMBook.OnDataAdded += (s, args) =>
            {
                fillDGV();
                filldvg2("", "");
            };
            addDialogMBook.ShowDialog();
        }


        //edit button - click
        private void editButton_Click(object sender, EventArgs e)
        {
            if (bookTable.SelectedRows.Count > 0)
            {
                editBookDialog editBookDialog = new editBookDialog();

                string BookingId = bookTable.SelectedRows[0].Cells[0].Value + string.Empty;
                string FullName = bookTable.SelectedRows[0].Cells[1].Value + string.Empty;
                string PhoneNo = bookTable.SelectedRows[0].Cells[2].Value + string.Empty;
                string Email = bookTable.SelectedRows[0].Cells[3].Value + string.Empty;
                string RoomNo = bookTable.SelectedRows[0].Cells[4].Value + string.Empty;
                string RoomType = bookTable.SelectedRows[0].Cells[5].Value + string.Empty;
                string Pax = bookTable.SelectedRows[0].Cells[6].Value + string.Empty;
                string CheckIn = bookTable.SelectedRows[0].Cells[7].Value + string.Empty;
                string CheckOut = bookTable.SelectedRows[0].Cells[8].Value + string.Empty;
                string AoName = bookTable.SelectedRows[0].Cells[9].Value + string.Empty;
                string AoPrice = bookTable.SelectedRows[0].Cells[10].Value + string.Empty;
                string AoQty = bookTable.SelectedRows[0].Cells[11].Value + string.Empty;
                string Status = bookTable.SelectedRows[0].Cells[12].Value + string.Empty;

                editBookDialog.bookingIdTextBox.Text = BookingId;
                editBookDialog.fullNameTextBox.Text = FullName;
                editBookDialog.phoneNoTextBox.Text = PhoneNo;
                editBookDialog.emailTextBox.Text = Email;
                editBookDialog.roomNoComboBox.Text = RoomNo;
                editBookDialog.roomTypeComboBox.Text = RoomType;
                editBookDialog.paxNumericUpDown.Text = Pax;
                editBookDialog.checkInDateTimePicker.Text = CheckIn;
                editBookDialog.checkOutDateTimePicker.Text = CheckOut;
                editBookDialog.aoNameTextBox.Text = AoName;
                editBookDialog.aoPriceTextBox.Text = AoPrice;
                editBookDialog.aoQuantityTextBox.Text = AoQty;
                editBookDialog.statusComboBox.Text = Status;

                editBookDialog.OnBookingUpdated += fillDGV;

                editBookDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must select a row first.");
            }
        }


        //refresh button - click
        private void refreshButton_Click(object sender, EventArgs e)
        {
            fillDGV();
        }

        //search data - method
        public void filldvg2(string valueToSearch, string filterType)
        {
            try
            {
                valueToSearch = valueToSearch.Trim();

                string query = "";
                MySqlCommand cmd;

                if (filterType == "ID" && !string.IsNullOrEmpty(valueToSearch))
                {
                    query = "SELECT * FROM booking WHERE BookingId LIKE @search";
                }
                else if (filterType == "Customer's Name" && !string.IsNullOrEmpty(valueToSearch))
                {
                    query = "SELECT * FROM booking WHERE FullName LIKE @search";
                }
                else if (filterType == "Room Number" && !string.IsNullOrEmpty(valueToSearch))
                {
                    query = "SELECT * FROM booking WHERE RoomNo LIKE @search";
                }
                else
                {
                    query = "SELECT * FROM booking WHERE CONCAT(BookingId, FullName, PhoneNo, Email, RoomNo, " +
                            "RoomType, Pax, CheckIn, CheckOut, AoName, AoPrice, AoQty, Status) LIKE @search";
                }

                using (MySqlConnection conn = new MySqlConnection(database.connectionString))
                {
                    conn.Open();

                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + valueToSearch + "%");

                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    bookTable.DataSource = dt;
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //search button - click
        private void searchButton_Click(object sender, EventArgs e)
        {
            string valueToSearch = searchTextBox.Text.ToString(); 
            string filterType = searchFilterComboBox.SelectedItem != null ? searchFilterComboBox.SelectedItem.ToString() : ""; 

            filldvg2(valueToSearch, filterType);
        }

        //delete button click
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (bookTable.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected rows?",
                                                           "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(database.connectionString))
                        {
                            conn.Open();

                            foreach (DataGridViewRow row in bookTable.SelectedRows)
                            {
                                if (!row.IsNewRow)
                                {
                                    string bookingId = row.Cells[0].Value.ToString();

                                    string deletePaymentQuery = "DELETE FROM payment WHERE BookingId = @bookingId";
                                    MySqlCommand deletePaymentCmd = new MySqlCommand(deletePaymentQuery, conn);
                                    deletePaymentCmd.Parameters.AddWithValue("@bookingId", bookingId);
                                    deletePaymentCmd.ExecuteNonQuery();

                                    string deleteBookingQuery = "DELETE FROM booking WHERE BookingId = @bookingId";
                                    MySqlCommand deleteBookingCmd = new MySqlCommand(deleteBookingQuery, conn);
                                    deleteBookingCmd.Parameters.AddWithValue("@bookingId", bookingId);
                                    deleteBookingCmd.ExecuteNonQuery();
                                }
                            }

                            fillDGV();

                            if (Application.OpenForms["paymentForm"] is paymentForm paymentForm)
                            {
                                paymentForm.LoadData();
                            }

                            MessageBox.Show("Selected bookings and payments deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (MySqlException sqlEx)
                    {
                        MessageBox.Show("Database error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("You must select at least one row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
