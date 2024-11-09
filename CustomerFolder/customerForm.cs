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

        //form function
        private void customerForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //load data
        public void LoadData()
        {
            string query = "SELECT * FROM customer";

            using (MySqlConnection con = new MySqlConnection(database.connectionString))
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    customerTable.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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

                editCustomerDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must select a row first.");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM customer";

            using (MySqlConnection con = new MySqlConnection(database.connectionString))
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    customerTable.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
