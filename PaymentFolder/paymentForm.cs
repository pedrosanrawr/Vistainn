using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Vistainn.PaymentFolder;

namespace Vistainn
{

    public partial class paymentForm : Form
    {
        //database instantiation
        Database database = new Database();

        public paymentForm()
        {
            InitializeComponent();
        }
        
        //form - load
        private void paymentForm_Load(object sender, EventArgs e)
        {
            LoadData();
            searchData("");
        }

        //load data - method
        public void LoadData()
        {
            string query = "SELECT PaymentId, BookingId, FullName, Amount, PaymentMethod, Status FROM payment;";

            MySqlConnection con = new MySqlConnection(database.connectionString);
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            paymentTable.DataSource = dt;
            con.Close();
        }

        //edit button - click
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

                editPaymentDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must select a row first.");
            }
        }

        //refresh buttin - click
        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //search data - method
        public void searchData(string ValueToSearch)
        {
            string query = "SELECT PaymentId, BookingId, FullName, Amount, PaymentMethod, Status " +
                           "FROM payment " +
                           "WHERE CONCAT(`PaymentId`, `BookingId`, `FullName`, `Amount`, `PaymentMethod`, `Status`) " +
                           "like '%" + ValueToSearch + "%'";

            MySqlConnection con = new MySqlConnection(database.connectionString);
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            paymentTable.DataSource = dt;
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

