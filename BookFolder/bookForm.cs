﻿using System;
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
    public partial class bookForm : Form
    {
        Database database = new Database();

        public bookForm()
        {
            InitializeComponent();
        }

        //book form - load
        private void bookForm_Load(object sender, EventArgs e)
        {
            fillDGV();
            filldvg2("");
        }

        //populate table
        public void fillDGV()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(database.connectionString))
                {
                    conn.Open();

                    string query = "SELECT BookingId, FullName, RoomNo, RoomType, check_in, check_out, Status FROM booking";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    bookTable.DataSource = dt;
                    bookTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //edit button - click
        private void editButton_Click(object sender, EventArgs e)
        {

            editBookDialog editBookDialog = new editBookDialog();

            if (bookTable.SelectedRows.Count > 0)
            {
                string bookingId = bookTable.SelectedRows[0].Cells[0].Value + string.Empty;
                string fullName = bookTable.SelectedRows[0].Cells[1].Value + string.Empty;
                string roomNo = bookTable.SelectedRows[0].Cells[2].Value + string.Empty;
                string roomType = bookTable.SelectedRows[0].Cells[3].Value + string.Empty;
                string checkIn = bookTable.SelectedRows[0].Cells[4].Value + string.Empty;
                string checkOut = bookTable.SelectedRows[0].Cells[5].Value + string.Empty;
                string status = bookTable.SelectedRows[0].Cells[6].Value + string.Empty;

                editBookDialog.bookingIdTextBox.Text = bookingId;
                editBookDialog.fullNameTextBox.Text = fullName;
                editBookDialog.roomNoComboBox.Text = roomNo;
                editBookDialog.roomTypeComboBox.Text = roomType;
                editBookDialog.checkInDateTimePicker.Text = checkIn;
                editBookDialog.checkOutDateTimePicker.Text = checkOut;
                editBookDialog.statusComboBox.Text = status;

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
        public void filldvg2(string valueToSearch)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(database.connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM booking WHERE BookingId LIKE @search OR FullName LIKE @search OR RoomNo LIKE @search";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@search", "%" + valueToSearch + "%");
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    bookTable.DataSource = dt;
                    bookTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //search button - click
        private void searchButton_Click(object sender, EventArgs e)
        {
            string valueToSearch = searchTextBox.Text.ToString();
            filldvg2(valueToSearch);
        }
    }
}
