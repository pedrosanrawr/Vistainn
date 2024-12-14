using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vistainn.AddOnsFolder
{
    public partial class EditAoDialog : Form
    {
        Database database = new MySqlDatabase();
        public event Action OnDataUpdated;

        public EditAoDialog()
        {
            InitializeComponent();
        }

        //edit button - click
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection conn = database.CreateConnection())
                {
                    database.OpenConnection(conn);

                    string query = "UPDATE addons SET AoId = @AoId, AoName = @AoName, AoPrice = @AoPrice WHERE AoId = @AoId";
                    IDbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = query;

                    var paramAoId = cmd.CreateParameter();
                    paramAoId.ParameterName = "@AoId";
                    paramAoId.Value = int.Parse(aoIdTextBox.Text);
                    cmd.Parameters.Add(paramAoId);

                    var paramAoName = cmd.CreateParameter();
                    paramAoName.ParameterName = "@AoName";
                    paramAoName.Value = aoNameTextBox.Text;
                    cmd.Parameters.Add(paramAoName);

                    var paramAoPrice = cmd.CreateParameter();
                    paramAoPrice.ParameterName = "@AoPrice";
                    paramAoPrice.Value = aoPriceTextBox.Text;
                    cmd.Parameters.Add(paramAoPrice);

                    cmd.ExecuteNonQuery();
                }

                OnDataUpdated?.Invoke();

                MessageBox.Show("The item has updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
