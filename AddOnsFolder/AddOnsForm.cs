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
using Vistainn.AddOnsFolder;

namespace Vistainn
{
    public partial class AddOnsForm : Form
    {
        Database database = new Database();

        public AddOnsForm()
        {
            InitializeComponent();
        }

        //load form
        private void AddOnsForm_Load(object sender, EventArgs e)
        {
            fillDGV();
            filldvg2("", "");
        }

        //populate table
        public void fillDGV()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(database.connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM addons";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    aoTable.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //add button click
        private void addBookButton_Click(object sender, EventArgs e)
        {
            AddAoDialog dlg = new AddAoDialog();
            dlg.OnDataAdded += (s, args) =>
            {
                filldvg2("", ""
                    );
            };
            dlg.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (aoTable.SelectedRows.Count > 0)
            {
                EditAoDialog dlg = new EditAoDialog();

                string AoId = aoTable.SelectedRows[0].Cells[0].Value + string.Empty;
                string Name = aoTable.SelectedRows[0].Cells[1].Value + string.Empty;
                string Price = aoTable.SelectedRows[0].Cells[2].Value + string.Empty;

                dlg.aoIdTextBox.Text = AoId;
                dlg.aoNameTextBox.Text = Name;
                dlg.aoPriceTextBox.Text = Price;

                dlg.OnDataUpdated += fillDGV;

                dlg.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must select a row first.");
            }
        }

        //refresh button click
        private void refreshButton_Click(object sender, EventArgs e)
        {
            fillDGV();
        }

        public void filldvg2(string valueToSearch, string filterType)
        {
            try
            {
                valueToSearch = valueToSearch.Trim();

                string query = "SELECT * FROM addons WHERE ";

                if (filterType == "ID" && !string.IsNullOrEmpty(valueToSearch))
                {
                    query += "AoId LIKE @search";
                }
                else if (filterType == "Item Name" && !string.IsNullOrEmpty(valueToSearch))
                {
                    query += "AoName LIKE @search";
                }
                else
                {
                    query += "(AoId LIKE @search OR AoName LIKE @search)";
                }

                using (MySqlConnection conn = new MySqlConnection(database.connectionString))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + valueToSearch + "%");

                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    aoTable.DataSource = dt;
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //delete button click
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (aoTable.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(database.connectionString))
                        {
                            conn.Open();
                            foreach (DataGridViewRow row in aoTable.SelectedRows)
                            {
                                if (!row.IsNewRow)
                                {
                                    int AoId = Convert.ToInt32(row.Cells["AoId"].Value);

                                    MySqlCommand cmd = new MySqlCommand("DELETE from addons" +
                                        " WHERE AoId=@AoId", conn);
                                    cmd.Parameters.Add("@AoId", MySqlDbType.Int32).Value = AoId;

                                    cmd.ExecuteNonQuery();
                                }
                            }

                            filldvg2("", "");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("You must select at least one row to delete.");
            }
        }

        //search button click
        private void searchButton_Click(object sender, EventArgs e)
        {
            string valueToSearch = searchTextBox.Text.Trim(); 
            string filterType = searchFilterComboBox.SelectedItem != null ? searchFilterComboBox.SelectedItem.ToString() : "";

            filldvg2(valueToSearch, filterType);
        }

    }
}
