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

namespace Vistainn.AddOnsFolder
{
    public partial class EditAoDialog : Form
    {
        Database database = new Database();
        public event Action OnDataUpdated;

        public EditAoDialog()
        {
            InitializeComponent();
        }

        //edit button
        private void updateButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(database.connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE addons SET AoId=@AoId, AoName=@AoName, AoPrice=@AoPrice WHERE AoId=@AoId", conn);

                cmd.Parameters.Add("@AoId", MySqlDbType.Int32).Value = int.Parse(aoIdTextBox.Text);
                cmd.Parameters.Add("@AoName", MySqlDbType.VarChar).Value = aoNameTextBox.Text;
                cmd.Parameters.Add("@AoPrice", MySqlDbType.VarChar).Value = aoPriceTextBox.Text;

                cmd.ExecuteNonQuery();
            }

            OnDataUpdated?.Invoke();

            MessageBox.Show("The item has updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
