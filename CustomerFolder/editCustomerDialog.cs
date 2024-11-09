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

        private void updateButton_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            customerForm customerForm = new customerForm();

            string query = "UPDATE customer SET FullName = '" + this.fullNameTextBox.Text + "', phoneNo = '" + this.phoneNoTextBox.Text + "', email = '" + this.emailTextBox.Text + "', BookingHistory ='" + this.bookingHistoryTextBox.Text + "'";
            MySqlConnection con = new MySqlConnection(database.connectionString);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been updated successfully");
            con.Close();
        }
    }
}
