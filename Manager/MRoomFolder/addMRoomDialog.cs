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
    public partial class addMRoomDialog : Form
    {
        Database database = new Database();
        MRoomForm roomForm = new MRoomForm();
        public event EventHandler OnDataAdded;

        public addMRoomDialog()
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
              string.IsNullOrWhiteSpace(roomTypeTextBox.Text) ||
              string.IsNullOrWhiteSpace(rateTextBox.Text) ||
              string.IsNullOrWhiteSpace(availabilityComboBox.Text) ||
              string.IsNullOrWhiteSpace(descriptionTextBox.Text))
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

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `room`(`RoomNo`, `RoomType`, `Rate`, `Availability`, `picture`, `description`) " +
                                                        "VALUES (@roomno, @roomtype, @rate, @availability , @picture, @description)", conn);
                    cmd.Parameters.Add("@roomno", MySqlDbType.VarChar).Value = roomNoTextBox.Text;
                    cmd.Parameters.Add("@roomtype", MySqlDbType.VarChar).Value = roomTypeTextBox.Text;
                    cmd.Parameters.Add("@rate", MySqlDbType.Double).Value = rateTextBox.Text;
                    cmd.Parameters.Add("@availability", MySqlDbType.VarChar).Value = availabilityComboBox.Text;
                    cmd.Parameters.Add("@picture", MySqlDbType.Blob).Value = img;
                    cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = descriptionTextBox.Text;

                    cmd.ExecuteNonQuery();

                    OnDataAdded?.Invoke(this, EventArgs.Empty);

                    MessageBox.Show("Room information has been updated successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select an image.");
            }
        }
    }
}
