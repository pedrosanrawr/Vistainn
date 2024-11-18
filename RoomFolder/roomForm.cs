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
                roomTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        //add button - click
        private void addButton_Click(object sender, EventArgs e)
        {
            addRoomDialog addRoomDialog = new addRoomDialog();
            addRoomDialog.ShowDialog();
        }

        //edit button - click
        private void editButton_Click(object sender, EventArgs e)
        {
            editRoomDialog editRoomDialog = new editRoomDialog();

            if (roomTable.SelectedRows.Count > 0)
            {
                string roomId = roomTable.SelectedRows[0].Cells[0].Value + string.Empty;
                string roomNo = roomTable.SelectedRows[0].Cells[1].Value + string.Empty;
                string roomType = roomTable.SelectedRows[0].Cells[2].Value + string.Empty;
                string rate = roomTable.SelectedRows[0].Cells[3].Value + string.Empty;
                string availability = roomTable.SelectedRows[0].Cells[4].Value + string.Empty;
                byte[] img = (byte[])roomTable.SelectedRows[0].Cells[5].Value;
                MemoryStream ms = new MemoryStream(img);
                string description = roomTable.SelectedRows[0].Cells[6].Value + string.Empty;

                editRoomDialog.roomIdTextBox.Text = roomId;
                editRoomDialog.roomNoTextBox.Text = roomNo;
                editRoomDialog.roomTypeTextBox.Text = roomType;
                editRoomDialog.rateTextBox.Text = rate;
                editRoomDialog.availabilityComboBox.Text = availability;
                editRoomDialog.roomPhotoPictureBox.Image = Image.FromStream(ms);
                editRoomDialog.descriptionTextBox.Text = description;

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
    }
}
