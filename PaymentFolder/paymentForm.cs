using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Vistainn.PaymentFolder;

namespace Vistainn
{
    public partial class paymentForm : Form
    {
        // database instantiation
        Database database = new Database();

        public paymentForm()
        {
            InitializeComponent();
        }

        // form - Load
        private void paymentForm_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }

        // load data - method
        public void LoadData()
        {
            try
            {
                string query = @" SELECT booking.BookingId, booking.FullName, payment.Amount, payment.PaymentMethod, payment.Status
                FROM booking
                LEFT JOIN payment ON booking.BookingId = payment.BookingId";

                using (MySqlConnection con = new MySqlConnection(database.connectionString))
                {
                    con.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
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


        // edit button click
        private void editButton_Click(object sender, EventArgs e)
        {
            editPaymentDialog editPaymentDialog = new editPaymentDialog();

            if (paymentTable.SelectedRows.Count > 0)
            {
                string bookingId = paymentTable.SelectedRows[0].Cells[0].Value + string.Empty;
                string fullName = paymentTable.SelectedRows[0].Cells[1].Value + string.Empty;
                string amount = paymentTable.SelectedRows[0].Cells[2].Value + string.Empty;
                string paymentMethod = paymentTable.SelectedRows[0].Cells[3].Value + string.Empty;
                string status = paymentTable.SelectedRows[0].Cells[4].Value + string.Empty;

                editPaymentDialog.bookingIdTextBox.Text = bookingId;
                editPaymentDialog.FullNameTextBox.Text = fullName;
                editPaymentDialog.AmountTextBox.Text = amount;
                editPaymentDialog.paymentMethodComboBox.Text = paymentMethod;
                editPaymentDialog.StatusComboBox.Text = status;

                editPaymentDialog.dataUpdated += LoadData;

                editPaymentDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must select a row first.");
            }
        }

        // refresh button click
        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // search data - method
        public void searchData(string valueToSearch, string filterType)
        {
            try
            {
                string query = @"SELECT booking.BookingId, booking.FullName, payment.Amount, payment.PaymentMethod, payment.Status
                         FROM booking
                         LEFT JOIN payment ON booking.BookingId = payment.BookingId
                         WHERE ";

                if (filterType == "ID")
                {
                    query += "booking.BookingId LIKE @search";
                }
                else if (filterType == "Customer's Name")
                {
                    query += "booking.FullName LIKE @search";
                }
                else if (filterType == "Status")
                {
                    query += "payment.Status LIKE @search";
                }

                else
                {
                    query += @"CONCAT(booking.BookingId, booking.FullName, payment.Amount, payment.PaymentMethod, payment.Status) 
                       LIKE @search";
                }

                using (MySqlConnection con = new MySqlConnection(database.connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@search", "%" + valueToSearch + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            string valueToSearch = searchTextBox.Text.Trim(); 
            string filterType = searchFilterComboBox.SelectedItem != null ? searchFilterComboBox.SelectedItem.ToString() : ""; 

            searchData(valueToSearch, filterType);
        }

    }
}
