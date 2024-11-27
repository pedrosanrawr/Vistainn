using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using Vistainn.CustomerFolder;

namespace Vistainn
{
    public partial class customerForm : Form
    {
        //database instantiation
        Database database = new Database();

        public customerForm()
        {
            InitializeComponent();
        }

        //form - load
        private void customerForm_Load(object sender, EventArgs e)
        {
            LoadData();
            searchData("");
        }

        //load data - method
        public void LoadData()
        {
            string query = "SELECT CustomerId, FullName, email, phoneNo, BookingHistory FROM customer";

            MySqlConnection con = new MySqlConnection(database.connectionString);
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            customerTable.DataSource = dt;
            con.Close();
        }

        //edit button - click
        private void editButton_Click(object sender, EventArgs e)
        {
            editCustomerDialog editCustomerDialog = new editCustomerDialog();

            if (customerTable.SelectedRows.Count > 0)
            {
                string customerId = customerTable.SelectedRows[0].Cells[0].Value + string.Empty;
                string fullName = customerTable.SelectedRows[0].Cells[1].Value + string.Empty;
                string phoneNo = customerTable.SelectedRows[0].Cells[3].Value + string.Empty;
                string email = customerTable.SelectedRows[0].Cells[2].Value + string.Empty;
                string bookingHistory = customerTable.SelectedRows[0].Cells[4].Value + string.Empty;

                editCustomerDialog.customerIdTextBox.Text = customerId;
                editCustomerDialog.fullNameTextBox.Text = fullName;
                editCustomerDialog.phoneNoTextBox.Text = phoneNo;
                editCustomerDialog.emailTextBox.Text = email;
                editCustomerDialog.bookingHistoryTextBox.Text = bookingHistory;

                editCustomerDialog.OnDataUpdated += (s, args) =>
                {
                    LoadData();
                };

                editCustomerDialog.ShowDialog();
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

        //search - method
        public void searchData(string valueToSearch)
        {
            string query = "SELECT CustomerId, FullName, email, phoneNo, BookingHistory " +
                           "FROM customer " +
                           "WHERE CONCAT(`CustomerId`, `FullName`, `email`, `phoneNo`, `BookingHistory`) " +
                           "like '%" + valueToSearch + "%'";

            MySqlConnection con = new MySqlConnection(database.connectionString);
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            customerTable.DataSource = dt;
            con.Close();
        }

        //search button - click
        private void searchButton_Click(object sender, EventArgs e)
        {
            string valueToSearch = searchTextBox.Text.ToString();
            searchData(valueToSearch);
        }
    }
}
