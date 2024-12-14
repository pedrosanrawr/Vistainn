using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vistainn.RoomFolder
{
    public partial class addRoomDialog : Form
    {
        Database database = new MySqlDatabase();
        public event EventHandler OnDataAdded;

        public addRoomDialog()
        {
            InitializeComponent();
        }

        //insert photo button - click
        private void insertPhotoButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Choose Image (*.JPG; *.PNG; *.GIF;) | *.jpg; *.png; *.gif;"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                roomPhotoPictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        //add button - click
        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                double rate;
                if (!double.TryParse(rateTextBox.Text, out rate))
                {
                    MessageBox.Show("Invalid rate format. Please enter a valid number.");
                    return;
                }

                if (IsRoomNumberUnique(roomNoTextBox.Text))
                {
                    byte[] img = null;
                    if (roomPhotoPictureBox.Image != null)
                    {
                        img = ConvertImageToByteArray(roomPhotoPictureBox.Image);
                    }

                    AddRoomToDatabase(roomNoTextBox.Text, roomTypeComboBox.Text, rate, img);

                    OnDataAdded?.Invoke(this, EventArgs.Empty);

                    MessageBox.Show("Room information has been added successfully.");
                }
                else
                {
                    MessageBox.Show("Room number already exists. Please choose a different RoomNo.");
                }
            }
        }

        //validate inputs - method
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(roomNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(roomTypeComboBox.Text) ||
                string.IsNullOrWhiteSpace(rateTextBox.Text) ||
                string.IsNullOrWhiteSpace(bedroomTextBox.Text) ||
                string.IsNullOrWhiteSpace(bathroomTextBox.Text) ||
                string.IsNullOrWhiteSpace(kitchenTextBox.Text) ||
                string.IsNullOrWhiteSpace(technologyTextBox.Text) ||
                string.IsNullOrWhiteSpace(generalTextBox.Text) ||
                string.IsNullOrWhiteSpace(roomCapacityNumericUpDown.Text))
            {
                MessageBox.Show("Please fill all the fields before inserting.");
                return false;
            }
            return true;
        }

        //unique room number - method
        private bool IsRoomNumberUnique(string roomNo)
        {
            string query = "SELECT COUNT(*) FROM room WHERE RoomNo = @roomno";
            var parameters = new Dictionary<string, object> { { "@roomno", roomNo } };

            using (IDataReader reader = database.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                {
                    int count = reader.GetInt32(0);
                    return count == 0; 
                }
            }

            return false;
        }

        //convert image to byte
        private byte[] ConvertImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        //add room - method
        private void AddRoomToDatabase(string roomNo, string roomType, double rate, byte[] img)
        {
            string query = "INSERT INTO `room`(`RoomNo`, `RoomType`, `Rate`, `Availability`, `Picture`, `Bedroom`, `Bathroom`, `Kitchen`, `Technology`, `General`, `RoomCapacity`) " +
                           "VALUES (@RoomNo, @RoomType, @Rate, @Availability, @Picture, @Bedroom, @Bathroom, @Kitchen, @Technology, @General, @RoomCapacity)";

            var parameters = new Dictionary<string, object>
            {
                { "@RoomNo", roomNo },
                { "@RoomType", roomType },
                { "@Rate", rate },
                { "@Availability", "Available" },
                { "@Picture", img },
                { "@Bedroom", bedroomTextBox.Text },
                { "@Bathroom", bathroomTextBox.Text },
                { "@Kitchen", kitchenTextBox.Text },
                { "@Technology", technologyTextBox.Text },
                { "@General", generalTextBox.Text },
                { "@RoomCapacity", roomCapacityNumericUpDown.Text }
            };

            database.ExecuteNonQuery(query, parameters);
        }
    }
}