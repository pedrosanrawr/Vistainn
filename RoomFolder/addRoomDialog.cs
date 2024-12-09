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
    public partial class addRoomDialog : Form
    {
        Database database = new Database();
        public event EventHandler OnDataAdded;

        public addRoomDialog()
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

        //add button - click
        private void addButton_Click(object sender, EventArgs e)
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
                return;
            }

            double rate;
            if (!double.TryParse(rateTextBox.Text, out rate))
            {
                MessageBox.Show("Invalid rate format. Please enter a valid number.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(database.connectionString))
            {
                string checkRoomNoQuery = "SELECT COUNT(*) FROM room WHERE RoomNo = @roomno";
                MySqlCommand checkCmd = new MySqlCommand(checkRoomNoQuery, conn);
                checkCmd.Parameters.Add("@roomno", MySqlDbType.VarChar).Value = roomNoTextBox.Text;

                conn.Open();
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                conn.Close();

                if (count > 0)
                {
                    MessageBox.Show("Room number already exists. Please choose a different RoomNo.");
                    return;
                }
            }

            if (roomPhotoPictureBox.Image != null)
            {
                using (MySqlConnection conn = new MySqlConnection(database.connectionString))
                {
                    conn.Open();
                    MemoryStream ms = new MemoryStream();
                    roomPhotoPictureBox.Image.Save(ms, roomPhotoPictureBox.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `room`(`RoomNo`, `RoomType`, `Rate`, `Availability`, `Picture`, `Bedroom`,`Bathroom`, `Kitchen`, `Technology`, `General`, `RoomCapacity`) " +
                                                        "VALUES (@RoomNo, @RoomType, @Rate, @Availability , @Picture, @Bedroom ,@Bathroom, @Kitchen, @Technology, @General, @RoomCapacity)", conn);
                    cmd.Parameters.Add("@RoomNo", MySqlDbType.VarChar).Value = roomNoTextBox.Text;
                    cmd.Parameters.Add("@RoomType", MySqlDbType.VarChar).Value = roomTypeComboBox.Text;
                    cmd.Parameters.Add("@Rate", MySqlDbType.Double).Value = rateTextBox.Text;
                    cmd.Parameters.Add("@Availability", MySqlDbType.VarChar).Value = "Available";
                    cmd.Parameters.Add("@Picture", MySqlDbType.Blob).Value = img;
                    cmd.Parameters.Add("@Bedroom", MySqlDbType.VarChar).Value = bedroomTextBox.Text;
                    cmd.Parameters.Add("@Bathroom", MySqlDbType.VarChar).Value = bathroomTextBox.Text;
                    cmd.Parameters.Add("@Kitchen", MySqlDbType.VarChar).Value = kitchenTextBox.Text;
                    cmd.Parameters.Add("@Technology", MySqlDbType.VarChar).Value = technologyTextBox.Text;
                    cmd.Parameters.Add("@General", MySqlDbType.VarChar).Value = generalTextBox.Text;
                    cmd.Parameters.Add("@RoomCapacity", MySqlDbType.VarChar).Value = roomCapacityNumericUpDown.Text;


                    cmd.ExecuteNonQuery();

                    OnDataAdded?.Invoke(this, EventArgs.Empty);

                    MessageBox.Show("Room information has been added successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select an image.");
            }
        }

    }
}
