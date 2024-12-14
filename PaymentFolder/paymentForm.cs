using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Vistainn.PaymentFolder;

namespace Vistainn
{
    public partial class paymentForm : Form
    {
        Database database = new MySqlDatabase();

        public paymentForm()
        {
            InitializeComponent();
        }

        //load payment form
        private void paymentForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //populate table
        public void LoadData()
        {
            try
            {
                string query = @"SELECT booking.BookingId, booking.FullName, payment.Amount, payment.PaymentMethod, payment.Status
                                 FROM booking
                                 LEFT JOIN payment ON booking.BookingId = payment.BookingId";

                var parameters = new Dictionary<string, object>(); 
                using (var reader = database.ExecuteReader(query, parameters))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    paymentTable.DataSource = dt;
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading payment data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //edit button - click
        private void editButton_Click(object sender, EventArgs e)
        {
            editPaymentDialog editPaymentDialog = new editPaymentDialog(); 

            if (paymentTable.SelectedRows.Count > 0)
            {
                string bookingId = paymentTable.SelectedRows[0].Cells[0].Value.ToString();
                string fullName = paymentTable.SelectedRows[0].Cells[1].Value.ToString();
                string amount = paymentTable.SelectedRows[0].Cells[2].Value.ToString();
                string paymentMethod = paymentTable.SelectedRows[0].Cells[3].Value.ToString();
                string status = paymentTable.SelectedRows[0].Cells[4].Value.ToString();

                editPaymentDialog.bookingIdTextBox.Text = bookingId;
                editPaymentDialog.FullNameTextBox.Text = fullName;
                editPaymentDialog.AmountTextBox.Text = amount;
                editPaymentDialog.paymentMethodComboBox.Text = paymentMethod;
                editPaymentDialog.StatusComboBox.Text = status;

                editPaymentDialog.DataUpdated += LoadData;

                editPaymentDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must select a row first.");
            }
        }

        //refresh button - click
        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //search data - method
        public void SearchData(string valueToSearch, string filterType)
        {
            try
            {
                string query = @"SELECT booking.BookingId, booking.FullName, payment.Amount, payment.PaymentMethod, payment.Status
                         FROM booking
                         LEFT JOIN payment ON booking.BookingId = payment.BookingId
                         WHERE ";

                var parameters = new Dictionary<string, object>
                {
                    { "@search", "%" + valueToSearch + "%" }
                };

                if (filterType == "ID")
                {
                    query += "booking.BookingId LIKE @search";
                }
                else if (filterType == "CUSTOMER'S NAME")
                {
                    query += "booking.FullName LIKE @search";
                }
                else if (filterType == "STATUS")
                {
                    query += "payment.Status LIKE @search";
                }
                else
                {
                    query += @"CONCAT(booking.BookingId, booking.FullName, payment.Amount, payment.PaymentMethod, payment.Status)
                               LIKE @search";
                }

                using (var reader = database.ExecuteReader(query, parameters))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    paymentTable.DataSource = dt;
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading payment data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //search button - click
        private void searchButton_Click(object sender, EventArgs e)
        {
            string valueToSearch = searchTextBox.Text.Trim();
            string filterType = searchFilterComboBox.SelectedItem != null ? searchFilterComboBox.SelectedItem.ToString() : "";

            SearchData(valueToSearch, filterType);
        }
    }
}
