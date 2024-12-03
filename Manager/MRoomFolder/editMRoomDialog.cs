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
    public partial class editMRoomDialog : Form
    {
        MRoomForm roomForm = new MRoomForm();
        Database database = new Database();
        public event EventHandler OnDataUpdated;

        public editMRoomDialog()
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

        // update button - click
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(roomNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(roomTypeTextBox.Text) ||
                string.IsNullOrWhiteSpace(rateTextBox.Text) ||
                string.IsNullOrWhiteSpace(availabilityComboBox.Text) ||
                string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields before updating.");
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

                    MySqlCommand cmd = new MySqlCommand("UPDATE room SET RoomId=@roomId, RoomNo=@roomno, RoomType=@roomtype, " +
                        "Rate=@rate, Availability=@availability, picture=@picture, description=@description WHERE RoomId=@roomId", conn);
                    cmd.Parameters.Add("@roomid", MySqlDbType.Int32).Value = roomIdTextBox.Text;
                    cmd.Parameters.Add("@roomno", MySqlDbType.VarChar).Value = roomNoTextBox.Text;
                    cmd.Parameters.Add("@roomtype", MySqlDbType.VarChar).Value = roomTypeTextBox.Text;
                    cmd.Parameters.Add("@rate", MySqlDbType.Double).Value = rateTextBox.Text;
                    cmd.Parameters.Add("@availability", MySqlDbType.VarChar).Value = availabilityComboBox.Text;
                    cmd.Parameters.Add("@picture", MySqlDbType.Blob).Value = img;
                    //cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = descriptionTextBox.Text;

                    cmd.ExecuteNonQuery();
                    OnDataUpdated?.Invoke(this, EventArgs.Empty);

                    MessageBox.Show("Room information has been updated successfully.");
                    this.Close(); 
                }
            }
            else
            {
                MessageBox.Show("Please select an image.");
            }
        }
    }
}
