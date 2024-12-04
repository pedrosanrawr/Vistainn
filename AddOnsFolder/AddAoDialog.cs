using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistainn.AddOnsFolder
{
    public partial class AddAoDialog : Form
    {
        Database database = new Database();
        public event EventHandler OnDataAdded;

        public AddAoDialog()
        {
            InitializeComponent();
        }

        //add button
        private void updateButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(database.connectionString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO addons(AoName, AoPrice) VALUES (@AoName, @AoPrice)", conn);
                cmd.Parameters.Add("@AoName", MySqlDbType.VarChar).Value = itemNameTextBox.Text;
                cmd.Parameters.Add("@AoPrice", MySqlDbType.VarChar).Value = priceTextBox.Text;


                cmd.ExecuteNonQuery();

                OnDataAdded?.Invoke(this, EventArgs.Empty);

                MessageBox.Show("New item has been added successfully.");
            }
        }
    }
}
