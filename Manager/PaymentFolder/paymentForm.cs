﻿using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System;
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
            searchData("");
        }

        // load data - method
        public void LoadData()
        {
            try
            {
                string query = "SELECT p.PaymentId, b.BookingId, c.FullName, p.Amount, p.PaymentMethod, p.Status " +
                               "FROM payment p " +
                               "JOIN booking b ON p.BookingId = b.BookingId " +
                               "JOIN customer c ON b.FullName = c.FullName;";

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

        // edit button click - open the edit dialog
        private void editButton_Click(object sender, EventArgs e)
        {
            EditPaymentDialog editPaymentDialog = new EditPaymentDialog();

            if (paymentTable.SelectedRows.Count > 0)
            {
                string paymentId = paymentTable.SelectedRows[0].Cells[0].Value + string.Empty;
                string bookingId = paymentTable.SelectedRows[0].Cells[1].Value + string.Empty;
                string fullName = paymentTable.SelectedRows[0].Cells[2].Value + string.Empty;
                string amount = paymentTable.SelectedRows[0].Cells[3].Value + string.Empty;
                string paymentMethod = paymentTable.SelectedRows[0].Cells[4].Value + string.Empty;
                string status = paymentTable.SelectedRows[0].Cells[5].Value + string.Empty;

                editPaymentDialog.paymentIdTextBox.Text = paymentId;
                editPaymentDialog.bookingIdTextBox.Text = bookingId;
                editPaymentDialog.FullNameTextBox.Text = fullName;
                editPaymentDialog.AmountTextBox.Text = amount;
                editPaymentDialog.PaymentMethodTextBox.Text = paymentMethod;
                editPaymentDialog.StatusComboBox.Text = status;

                editPaymentDialog.dataUpdated += LoadData;

                editPaymentDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must select a row first.");
            }
        }

        // refresh button click - reload data
        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // search data - method
        public void searchData(string ValueToSearch)
        {
            string query = "SELECT PaymentId, BookingId, FullName, Amount, PaymentMethod, Status " +
                           "FROM payment " +
                           "WHERE CONCAT(`PaymentId`, `BookingId`, `FullName`, `Amount`, `PaymentMethod`, `Status`) " +
                           "LIKE '%" + ValueToSearch + "%'";

            using (MySqlConnection con = new MySqlConnection(database.connectionString))
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                
                adapter.Fill(dt);
                paymentTable.DataSource = dt;
            }
        }

        // search button click - search the data
        private void searchButton_Click(object sender, EventArgs e)
        {
            string valueToSearch = searchTextBox.Text.ToString();
            searchData(valueToSearch);
        }
    }
}
