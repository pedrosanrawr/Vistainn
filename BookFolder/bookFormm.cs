using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Vistainn.BookFolder;

namespace Vistainn
{
    public partial class bookFormm : Form
    {
        Database database = new MySqlDatabase();

        public bookFormm()
        {
            InitializeComponent();
        }

        //load book form
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
                using (IDbConnection conn = database.CreateConnection())
                {
                    database.OpenConnection(conn);

                    string query = "SELECT * FROM booking";
                    IDbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = query;

                    MySqlDataAdapter adp = new MySqlDataAdapter((MySqlCommand)cmd);
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

        //add button - click
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

                string BookingId = bookTable.SelectedRows[0].Cells[0].Value.ToString();
                string FullName = bookTable.SelectedRows[0].Cells[1].Value.ToString();
                string PhoneNo = bookTable.SelectedRows[0].Cells[2].Value.ToString();
                string Email = bookTable.SelectedRows[0].Cells[3].Value.ToString();
                string RoomNo = bookTable.SelectedRows[0].Cells[4].Value.ToString();
                string RoomType = bookTable.SelectedRows[0].Cells[5].Value.ToString();
                string Pax = bookTable.SelectedRows[0].Cells[6].Value.ToString();
                string CheckIn = bookTable.SelectedRows[0].Cells[7].Value.ToString();
                string CheckOut = bookTable.SelectedRows[0].Cells[8].Value.ToString();
                string AoName = bookTable.SelectedRows[0].Cells[9].Value.ToString();
                string AoPrice = bookTable.SelectedRows[0].Cells[10].Value.ToString();
                string AoQty = bookTable.SelectedRows[0].Cells[11].Value.ToString();
                string Status = bookTable.SelectedRows[0].Cells[12].Value.ToString();

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

        //search table
        public void filldvg2(string valueToSearch, string filterType)
        {
            try
            {
                valueToSearch = valueToSearch.Trim();
                string query = "";
                IDbCommand cmd;

                if (filterType == "ID")
                {
                    query = "SELECT * FROM booking WHERE BookingId LIKE @search";
                }
                else if (filterType == "CUSTOMER'S NAME")
                {
                    query = "SELECT * FROM booking WHERE FullName LIKE @search";
                }
                else if (filterType == "ROOM NUMBER")
                {
                    query = "SELECT * FROM booking WHERE RoomNo LIKE @search";
                }
                else
                {
                    query = "SELECT * FROM booking WHERE CONCAT(BookingId, FullName, PhoneNo, Email, RoomNo, RoomType, " +
                            "Pax, CheckIn, CheckOut, AoName, AoPrice, AoQty, Status) LIKE @search";
                }

                using (IDbConnection conn = database.CreateConnection())
                {
                    database.OpenConnection(conn);

                    cmd = conn.CreateCommand();
                    cmd.CommandText = query;

                    IDbDataParameter searchParam = cmd.CreateParameter();
                    searchParam.ParameterName = "@search";
                    searchParam.Value = "%" + valueToSearch + "%";  
                    cmd.Parameters.Add(searchParam);

                    MySqlDataAdapter adp = new MySqlDataAdapter((MySqlCommand)cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    bookTable.DataSource = dt;
                }
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

        //delete button - click
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
                        using (IDbConnection conn = database.CreateConnection())
                        {
                            database.OpenConnection(conn);

                            foreach (DataGridViewRow row in bookTable.SelectedRows)
                            {
                                if (!row.IsNewRow)
                                {
                                    string bookingId = row.Cells[0].Value.ToString();

                                    string deletePaymentQuery = "DELETE FROM payment WHERE BookingId = @bookingId";
                                    IDbCommand deletePaymentCmd = conn.CreateCommand();
                                    deletePaymentCmd.CommandText = deletePaymentQuery;

                                    IDbDataParameter deletePaymentParam = deletePaymentCmd.CreateParameter();
                                    deletePaymentParam.ParameterName = "@bookingId";
                                    deletePaymentParam.Value = bookingId;
                                    deletePaymentCmd.Parameters.Add(deletePaymentParam);
                                    deletePaymentCmd.ExecuteNonQuery();

                                    string deleteBookingQuery = "DELETE FROM booking WHERE BookingId = @bookingId";
                                    IDbCommand deleteBookingCmd = conn.CreateCommand();
                                    deleteBookingCmd.CommandText = deleteBookingQuery;

                                    IDbDataParameter deleteBookingParam = deleteBookingCmd.CreateParameter();
                                    deleteBookingParam.ParameterName = "@bookingId";
                                    deleteBookingParam.Value = bookingId;
                                    deleteBookingCmd.Parameters.Add(deleteBookingParam);
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