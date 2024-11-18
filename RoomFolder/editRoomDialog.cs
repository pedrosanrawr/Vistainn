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

namespace Vistainn.RoomFolder
{
    public partial class editRoomDialog : Form
    {
        roomForm roomForm = new roomForm();
        Database database = new Database();

        public editRoomDialog()
        {
            InitializeComponent();
        }

        //insert photo button - click
        private void insertPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Choose Image (*.JPG; *.PNG; *.GIF;) | *.jpg; *.png; *.gif;"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                roomPhotoPictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        //update button - click
        private void updateButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(roomNoTextBox.Text) ||
                          string.IsNullOrWhiteSpace(roomTypeTextBox.Text) ||
                          string.IsNullOrWhiteSpace(rateTextBox.Text) ||
                          string.IsNullOrWhiteSpace(availabilityComboBox.Text) ||
                          string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields before inserting.");
                return;
            }

            if (roomPhotoPictureBox.Image != null)
            {
                using (MySqlConnection conn = new MySqlConnection(database.connectionString))
                {
                    conn.Open();
                    MemoryStream ms = new MemoryStream();
                    roomPhotoPictureBox.Image.Save(ms, roomPhotoPictureBox.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    MySqlCommand cmd = new MySqlCommand("UPDATE room SET RoomId=@roomId, RoomNo=@roomno, RoomType=@roomtype, Rate=@rate, Availability=@availability, picture=@picture, description=@description WHERE RoomId=@roomId", conn);
                    cmd.Parameters.Add("@roomid", MySqlDbType.Int32).Value = roomIdTextBox.Text;
                    cmd.Parameters.Add("@roomno", MySqlDbType.VarChar).Value = roomNoTextBox.Text;
                    cmd.Parameters.Add("@roomtype", MySqlDbType.VarChar).Value = roomTypeTextBox.Text;
                    cmd.Parameters.Add("@rate", MySqlDbType.Double).Value = rateTextBox.Text;
                    cmd.Parameters.Add("@availability", MySqlDbType.VarChar).Value = availabilityComboBox.Text;
                    cmd.Parameters.Add("@picture", MySqlDbType.Blob).Value = img;
                    cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = descriptionTextBox.Text;

                    cmd.ExecuteNonQuery();
                    roomForm.fillDGV("");

                    MessageBox.Show("Room information has been updated successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select an image.");
            }
        }

        //delete button - click
        private void deleteButton_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conn = new MySqlConnection(database.connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE from room WHERE RoomId=@roomId", conn);
                cmd.Parameters.Add("@roomId", MySqlDbType.Int32).Value = roomIdTextBox.Text;

                cmd.ExecuteNonQuery();
                roomForm.fillDGV("");
                clearfields();
                MessageBox.Show("Data deleted successfully");
            }
        }

        //clear fields - method
        public void clearfields()
        {
            roomNoTextBox.Text = "";
            roomTypeTextBox.Text = "";
            rateTextBox.Text = "";
            availabilityComboBox.SelectedIndex = -1; ;
            roomPhotoPictureBox.Image = null;
            descriptionTextBox.Text = "";
        }
    }
}
