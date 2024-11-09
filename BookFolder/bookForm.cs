using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Vistainn.BookFolder;

namespace Vistainn
{
    public partial class bookForm : Form
    {
        //call database
        Database database = new Database();

        public bookForm()
        {
            InitializeComponent();
        }

        //populate data
        public void populateBookingButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(database.connectionString))
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM booking", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        //edit dialog - book 
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            editDialogBook editDialogBook = new editDialogBook();
            editDialogBook.ShowDialog();
        }

    }
}
