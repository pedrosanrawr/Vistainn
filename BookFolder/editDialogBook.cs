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

namespace Vistainn.BookFolder
{
    public partial class editDialogBook : Form
    {
        Database database = new Database();

        public editDialogBook()
        {
            InitializeComponent();
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(database.connectionString))
            {
                try

                {
                    con.Open();

                    string query = "SELECT BookingId, FullName, RoomNo, RoomType, Date, Status FROM booking WHERE BookingId = @BookingId";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BookingId", int.Parse(bookingIdTextBox.Text));

                        using (MySqlDataReader srd = cmd.ExecuteReader())
                        {
                            if (srd.Read())
                            {
                                customerNameTextBox.Text = srd.GetString("FullName");
                                roomNoTextBox.Text = srd.GetString("RoomNo");
                                roomTypetextBox.Text = srd.GetString("RoomType");
                                dateTextBox.Text = srd.GetString("Date");
                                statusComboBox.Text = srd.GetString("Status");
                            }
                            else
                            {
                                MessageBox.Show("No booking found with the provided ID.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        
        }
    }
}
