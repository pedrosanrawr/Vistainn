using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Vistainn.BookFolder;

namespace Vistainn
{
    public partial class createStafForm : Form
    {
        Database database = new MySqlDatabase();

        public createStafForm()
        {
            InitializeComponent();
        }

        private void createStafForm_Load(object sender, EventArgs e)
        {
            FillDGV("");
        }

        //populate table - method
        public void FillDGV(string valueToSearch)
        {
            string query = "SELECT * FROM staff WHERE StaffId LIKE @search OR StaffName LIKE @search OR Email LIKE @search";
            var parameters = new Dictionary<string, object>
            {
                { "@search", "%" + valueToSearch + "%" }
            };

            try
            {
                var reader = database.ExecuteReader(query, parameters);
                DataTable dt = new DataTable();
                dt.Load(reader);
                staffTable.DataSource = dt;

                staffTable.Columns["Password"].Visible = false;
                staffTable.Columns["Salt"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while fetching data: " + ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addStaffDialog addStaffDialog = new addStaffDialog(database);
            addStaffDialog.OnDataAdded += (s, args) =>
            {
                FillDGV("");
            };
            addStaffDialog.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (staffTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = staffTable.SelectedRows[0];
                string staffId = selectedRow.Cells[0].Value.ToString();
                string name = selectedRow.Cells[1].Value.ToString();
                string email = selectedRow.Cells[2].Value.ToString();

                editStaffDialog editStaffDialog = new editStaffDialog
                {
                    staffIdTextBox = { Text = staffId },
                    nameTextBox = { Text = name },
                    emailTextBox = { Text = email },
                };

                editStaffDialog.OnDataUpdated += (s, args) =>
                {
                    FillDGV("");
                };

                editStaffDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must select a row first.");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            FillDGV("");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FillDGV(searchTextBox.Text);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (staffTable.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        foreach (DataGridViewRow row in staffTable.SelectedRows)
                        {
                            if (!row.IsNewRow)
                            {
                                int staffId = Convert.ToInt32(row.Cells["StaffId"].Value);
                                string query = "DELETE FROM staff WHERE StaffId = @StaffId";
                                var parameters = new Dictionary<string, object>
                                {
                                    { "@StaffId", staffId }
                                };

                                database.ExecuteNonQuery(query, parameters);
                            }
                        }
                        FillDGV("");
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
    }
}