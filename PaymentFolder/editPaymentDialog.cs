using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vistainn.PaymentFolder
{
    public partial class editPaymentDialog : Form
    {
        public event Action DataUpdated;
        Database database = new MySqlDatabase();

        public editPaymentDialog()
        {
            InitializeComponent();
        }

        //update button - click
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE payment " +
                               "SET BookingId = @BookingId, FullName = @FullName, Amount = @Amount, PaymentMethod = @PaymentMethod, Status = @Status " +
                               "WHERE BookingId = @BookingId";

                var parameters = new Dictionary<string, object>
                {
                    { "@BookingId", this.bookingIdTextBox.Text },
                    { "@FullName", this.FullNameTextBox.Text },
                    { "@Amount", this.AmountTextBox.Text },
                    { "@PaymentMethod", this.paymentMethodComboBox.Text },
                    { "@Status", this.StatusComboBox.Text }
                };

                database.ExecuteNonQuery(query, parameters);
                DataUpdated?.Invoke();

                this.Close();
                MessageBox.Show("Payment record has been updated.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error updating payment: " + ex.Message);
            }
        }

    }
}
