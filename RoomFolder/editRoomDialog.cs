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
        Database database = new MySqlDatabase(); 
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

        //update button - click
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(roomNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(roomTypeComboBox.Text) ||
                string.IsNullOrWhiteSpace(rateTextBox.Text) ||
                string.IsNullOrWhiteSpace(availabilityComboBox.Text))
            {
                MessageBox.Show("Please fill all the fields before updating.");
                return;
            }

            if (roomPhotoPictureBox.Image != null)
            {
                byte[] img = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    roomPhotoPictureBox.Image.Save(ms, roomPhotoPictureBox.Image.RawFormat);
                    img = ms.ToArray();
                }

                var parameters = new Dictionary<string, object>
                {
                    { "@RoomId", roomIdTextBox.Text },
                    { "@RoomType", roomTypeComboBox.Text },
                    { "@RoomNo", roomNoTextBox.Text },
                    { "@Rate", rateTextBox.Text },
                    { "@Availability", availabilityComboBox.Text },
                    { "@Picture", img },
                    { "@Bathroom", bathroomTextBox.Text },
                    { "@Bedroom", bedroomTextBox.Text },
                    { "@Kitchen", kitchenTextBox.Text },
                    { "@Technology", technologyTextBox.Text },
                    { "@General", generalTextBox.Text },
                    { "@RoomCapacity", roomCapacityNumericUpDown.Text }
                };

                string query = "UPDATE room SET RoomType=@RoomType, RoomNo=@RoomNo, Rate=@Rate, Availability=@Availability, " +
                               "Picture=@Picture, Bathroom=@Bathroom, Bedroom=@Bedroom, Kitchen=@Kitchen, Technology=@Technology, " +
                               "General=@General, RoomCapacity=@RoomCapacity WHERE RoomId=@RoomId";

                int rowsAffected = database.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    OnDataUpdated?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show("Room information has been updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update room information.");
                }
            }
            else
            {
                MessageBox.Show("Please select an image.");
            }
        }
    }
}