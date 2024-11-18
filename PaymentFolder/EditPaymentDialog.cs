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

namespace Vistainn.PaymentFolder
{
    public partial class EditPaymentDialog : Form
    {
        public EditPaymentDialog()
        {
            InitializeComponent();
        }

        //update button - click
        private void updateButton_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            paymentForm paymentForm = new paymentForm();

            string query = "UPDATE payment " +
                           "SET PaymentId = @PaymentId, BookingId = @BookingId, FullName = @FullName, Amount = @Amount, PaymentMethod = @PaymentMethod, Status = @Status " +
                           "WHERE PaymentId = @PaymentId";

            MySqlConnection con = new MySqlConnection(database.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@PaymentId", this.paymentIdTextBox.Text);
            cmd.Parameters.AddWithValue("@BookingId", this.bookingIdTextBox.Text);
            cmd.Parameters.AddWithValue("@FullName", this.FullNameTextBox.Text);
            cmd.Parameters.AddWithValue("@Amount", this.AmountTextBox.Text);
            cmd.Parameters.AddWithValue("@PaymentMethod", this.PaymentMethodTextBox.Text);
            cmd.Parameters.AddWithValue("@Status", this.StatusComboBox.Text);

            cmd.ExecuteNonQuery();
            paymentForm.LoadData();

            MessageBox.Show("Payment Record Has Been Updated");
        }
    }
}
