using Guna.UI2.WinForms;
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
using Vistainn.RoomFolder;

namespace Vistainn
{
    public partial class roomForm : Form
    {
        Database database = new Database();

        public roomForm()
        {
            InitializeComponent();
        }

        //room form - load
        private void roomForm_Load(object sender, EventArgs e)
        {
            fillDGV("");
        }

        //populate data
        public void fillDGV(string valueToSearch)
        {
            using (MySqlConnection conn = new MySqlConnection(database.connectionString))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * " +
                    "FROM room " +
                    "WHERE RoomId like @search or RoomNo LIKE @search OR RoomType LIKE @search OR Rate LIKE @search OR Availability LIKE @search", conn);
                cmd.Parameters.AddWithValue("@search", "%" + valueToSearch + "%");

                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                roomTable.RowTemplate.Height = 60;
                roomTable.AllowUserToAddRows = false;
                roomTable.DataSource = dt;

                DataGridViewImageColumn imgcol = new DataGridViewImageColumn
                {
                    ImageLayout = DataGridViewImageCellLayout.Stretch
                };
                imgcol = (DataGridViewImageColumn)roomTable.Columns[5];
            }
        }

        //add button - click
        private void addButton_Click(object sender, EventArgs e)
        {
            addRoomDialog addRoomDialog = new addRoomDialog();
            addRoomDialog.OnDataAdded += (s, args) =>
            {
                fillDGV("");
            };
            addRoomDialog.ShowDialog();
        }

        //edit button - click
        private void editButton_Click(object sender, EventArgs e)
        {
            editRoomDialog editRoomDialog = new editRoomDialog();

            if (roomTable.SelectedRows.Count > 0)
            {
                string RoomId = roomTable.SelectedRows[0].Cells[0].Value + string.Empty;
                string RoomType = roomTable.SelectedRows[0].Cells[1].Value + string.Empty;
                string RoomNo = roomTable.SelectedRows[0].Cells[2].Value + string.Empty;
                string Rate = roomTable.SelectedRows[0].Cells[3].Value + string.Empty;
                string Availability = roomTable.SelectedRows[0].Cells[4].Value + string.Empty;
                byte[] Picture = (byte[])roomTable.SelectedRows[0].Cells[5].Value;
                MemoryStream ms = new MemoryStream(Picture);
                string Bathroom = roomTable.SelectedRows[0].Cells[6].Value + string.Empty;
                string Bedroom = roomTable.SelectedRows[0].Cells[7].Value + string.Empty;
                string Kitchen = roomTable.SelectedRows[0].Cells[8].Value + string.Empty;
                string Technology = roomTable.SelectedRows[0].Cells[9].Value + string.Empty;
                string General = roomTable.SelectedRows[0].Cells[10].Value + string.Empty;
                string RoomCapacity = roomTable.SelectedRows[0].Cells[11].Value + string.Empty;


                editRoomDialog.roomIdTextBox.Text = RoomId;
                editRoomDialog.roomTypeTextBox.Text = RoomType;
                editRoomDialog.roomNoTextBox.Text = RoomNo;
                editRoomDialog.rateTextBox.Text = Rate;
                editRoomDialog.availabilityComboBox.Text = Availability;
                editRoomDialog.roomPhotoPictureBox.Image = Image.FromStream(ms);
                editRoomDialog.bathroomTextBox.Text = Bathroom;
                editRoomDialog.bedroomTextBox.Text = Bedroom;
                editRoomDialog.kitchenTextBox.Text = Kitchen;
                editRoomDialog.technologyTextBox.Text = Technology;
                editRoomDialog.generalTextBox.Text = General;
                editRoomDialog.roomCapacityNumericUpDown.Text = RoomCapacity;

                editRoomDialog.OnDataUpdated += (s, args) =>
                {
                    fillDGV("");
                };

                editRoomDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must select a row first.");
            }
        }

        //refresh button - click
        private void refreshButton_Click(object sender, EventArgs e)
        {
            fillDGV("");
        }

        //search button - click
        private void searchButton_Click(object sender, EventArgs e)
        {
            fillDGV(searchTextBox.Text);
        }

        //delete button
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (roomTable.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(database.connectionString))
                        {
                            conn.Open();
                            foreach (DataGridViewRow row in roomTable.SelectedRows)
                            {
                                if (!row.IsNewRow)
                                {
                                    int roomId = Convert.ToInt32(row.Cells["RoomId"].Value);

                                    MySqlCommand cmd = new MySqlCommand("DELETE from room WHERE RoomId=@roomId", conn);
                                    cmd.Parameters.Add("@roomId", MySqlDbType.Int32).Value = roomId;

                                    cmd.ExecuteNonQuery();
                                }
                            }

                            fillDGV("");
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
    }
}
