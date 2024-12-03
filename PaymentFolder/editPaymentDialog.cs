using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

namespace Vistainn.PaymentFolder
{
    public partial class editPaymentDialog : Form
    {
        public event Action dataUpdated;

        public editPaymentDialog()
        {
            InitializeComponent();
        }

        //update button - click
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Database database = new Database();
                string query = "UPDATE payment " +
                               "SET BookingId = @BookingId, FullName = @FullName, Amount = @Amount, PaymentMethod = @PaymentMethod, Status = @Status " +
                               "WHERE BookingId = @BookingId";

                using (MySqlConnection con = new MySqlConnection(database.connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@BookingId", this.bookingIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@FullName", this.FullNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Amount", this.AmountTextBox.Text);
                    cmd.Parameters.AddWithValue("@PaymentMethod", this.paymentMethodComboBox.Text);
                    cmd.Parameters.AddWithValue("@Status", this.StatusComboBox.Text);

                    cmd.ExecuteNonQuery();
                }

                dataUpdated?.Invoke();

                this.Close();

                MessageBox.Show("Payment Record Has Been Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating payment: " + ex.Message);
            }
        }
    }
}
