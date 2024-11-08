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


namespace Vistainn.PaymentFolder
{
    public partial class EditDialogPayment : Form
    {
        Database database = new Database();
        public EditDialogPayment()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(database.connectionString))
            {
                try
                {
                    con.Open();
                    string query = "Select PaymentId, BookingId, Amount, PaymentMethod, Status from payment PaymentId= @PaymentId";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("BookingId", int.Parse(BookingIdTextbox.Text));

                        using (MySqlDataReader srd = cmd.ExecuteReader())
                        {
                            if (srd.Read())
                            {
                                PaymentIdTextbox.Text = srd.GetString("PaymentId");
                                BookingIdTextbox.Text = srd.GetString("BookingId");
                                AmountTextBox.Text = srd.GetString("Amount");
                                StatusComboBox.Text = srd.GetString("Status");
                                PaymentMethodComboBox.Text = srd.GetString("PaymentMethod");

                            }
                            else
                            {
                                MessageBox.Show("No Data found with the Provided ID");
                            }
                        }
                    }
                }

                catch(Exception ex )
                {

                    MessageBox.Show("An Error Occured"+ ex.Message);
                
                }
               
            }
             
        }
    }
}
