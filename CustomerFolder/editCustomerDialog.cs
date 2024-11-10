using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistainn.CustomerFolder
{
    public partial class editCustomerDialog : Form
    {
        public editCustomerDialog()
        {
            InitializeComponent();
        }

        //Update Button
        private void updateButton_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            customerForm customerForm = new customerForm();

            string query = "UPDATE customer SET " + "FullName = @FullName, " + "phoneNo = @PhoneNo, " + "email = @Email, " + "BookingHistory = @BookingHistory " + "WHERE CustomerId = @CustomerId";

            using (MySqlConnection con = new MySqlConnection(database.connectionString))
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FullName", this.fullNameTextBox.Text);
                cmd.Parameters.AddWithValue("@PhoneNo", this.phoneNoTextBox.Text);
                cmd.Parameters.AddWithValue("@Email", this.emailTextBox.Text);
                cmd.Parameters.AddWithValue("@BookingHistory", this.bookingHistoryTextBox.Text);
                cmd.Parameters.AddWithValue("@CustomerId", this.customerIdTextBox.Text);

                cmd.ExecuteNonQuery();
                customerForm.LoadData();

                MessageBox.Show("Customer record has been updated successfully.");
            }
        }

    }
}
