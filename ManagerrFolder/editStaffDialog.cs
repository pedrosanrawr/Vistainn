using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Vistainn
{
    public partial class editStaffDialog : Form
    {
        roomForm roomForm = new roomForm();
        Database database = new Database();
        public event EventHandler OnDataUpdated;

        public editStaffDialog()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Validate that all fields are filled
            if (string.IsNullOrWhiteSpace(staffIdTextBox.Text) ||
                string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields before updating.");
                return;
            }

            // Validate email format
            if (!IsValidEmail(emailTextBox.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Check if the email already exists in the database (excluding the current staff member)
            if (IsEmailExistForUpdate(emailTextBox.Text, staffIdTextBox.Text))
            {
                MessageBox.Show("This email is already associated with another staff member.");
                return;
            }

            // Proceed with the update
            using (MySqlConnection conn = new MySqlConnection(database.connectionString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("UPDATE staff SET StaffName=@StaffName, Email=@Email" +
                                                    " WHERE StaffId=@StaffId", conn);

                cmd.Parameters.Add("@StaffId", MySqlDbType.Int32).Value = staffIdTextBox.Text;
                cmd.Parameters.Add("@StaffName", MySqlDbType.VarChar).Value = nameTextBox.Text;
                cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = emailTextBox.Text;

                cmd.ExecuteNonQuery();

                // Trigger the event after data is updated
                OnDataUpdated?.Invoke(this, EventArgs.Empty);

                MessageBox.Show("Staff information has been updated successfully.");
                this.Close();
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
                return emailRegex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }

        // Check if email already exists in the database (excluding the current staff)
        private bool IsEmailExistForUpdate(string email, string staffId)
        {
            using (MySqlConnection conn = new MySqlConnection(database.connectionString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM staff WHERE Email = @Email AND StaffId != @StaffId", conn);
                cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@StaffId", MySqlDbType.Int32).Value = staffId;

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0; // If count > 0, it means the email exists for another staff member
            }
        }
    }
}
