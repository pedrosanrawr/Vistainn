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
        Database database = new Database();
        public paymentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(database.connectionString))
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM payment", con);
                DataTable dataTable = new DataTable();  
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();

            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
           EditDialogPayment editDialogPayment = new EditDialogPayment();
           editDialogPayment.ShowDialog();
        }
    }
}
