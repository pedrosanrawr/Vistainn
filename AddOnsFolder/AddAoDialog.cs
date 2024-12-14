using System;
using System.Windows.Forms;
using Vistainn;

namespace Vistainn.AddOnsFolder
{
    public partial class AddAoDialog : Form
    {
        Database database = new MySqlDatabase();
        public event EventHandler OnDataAdded;

        public AddAoDialog()
        {
            InitializeComponent();
        }

        //update button - click
        private void updateButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO addons (AoName, AoPrice) VALUES (@AoName, @AoPrice)";

            int rowsAffected = database.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                MessageBox.Show("New item has been added successfully.");
            }
            else
            {
                MessageBox.Show("Failed to add new item.");
            }
        }
    }
}
