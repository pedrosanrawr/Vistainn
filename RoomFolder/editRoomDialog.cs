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
        public event EventHandler OnDataUpdated;

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

        // update button - click
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(roomNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(roomTypeTextBox.Text) ||
                string.IsNullOrWhiteSpace(rateTextBox.Text) ||
                string.IsNullOrWhiteSpace(availabilityComboBox.Text))
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

                    MySqlCommand cmd = new MySqlCommand("UPDATE room SET RoomId=@roomId, RoomType=@RoomType, RoomNo=@RoomNo, " +
                        "Rate=@Rate, Availability=@Availability, Picture=@Picture, Bathroom=@Bathroom, Bedroom=@Bedroom, " +
                        "Kitchen=@Kitchen, Technology=@Technology, General=@General, RoomCapacity=@RoomCapacity" +
                        " WHERE RoomId=@RoomId", conn);

                    cmd.Parameters.Add("@RoomId", MySqlDbType.Int32).Value = roomIdTextBox.Text;
                    cmd.Parameters.Add("@RoomType", MySqlDbType.VarChar).Value = roomTypeTextBox.Text;
                    cmd.Parameters.Add("@RoomNo", MySqlDbType.VarChar).Value = roomNoTextBox.Text;
                    cmd.Parameters.Add("@Rate", MySqlDbType.Double).Value = rateTextBox.Text;
                    cmd.Parameters.Add("@Availability", MySqlDbType.VarChar).Value = availabilityComboBox.Text;
                    cmd.Parameters.Add("@Picture", MySqlDbType.Blob).Value = img;
                    cmd.Parameters.Add("@Bathroom", MySqlDbType.VarChar).Value = bathroomTextBox.Text;
                    cmd.Parameters.Add("@Bedroom", MySqlDbType.VarChar).Value = bedroomTextBox.Text;
                    cmd.Parameters.Add("@Kitchen", MySqlDbType.VarChar).Value = kitchenTextBox.Text;
                    cmd.Parameters.Add("@Technology", MySqlDbType.VarChar).Value = technologyTextBox.Text;
                    cmd.Parameters.Add("@General", MySqlDbType.VarChar).Value = generalTextBox.Text;
                    cmd.Parameters.Add("@RoomCapacity", MySqlDbType.VarChar).Value = roomCapacityNumericUpDown.Text;

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
