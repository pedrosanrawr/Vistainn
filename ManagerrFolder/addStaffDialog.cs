using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Vistainn
{
    public partial class addStaffDialog : Form
    {
        Database database = new Database();
        public event EventHandler OnDataAdded;

        public addStaffDialog()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields before inserting.");
                return;
            }

            if (!IsValidEmail(emailTextBox.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Check if email already exists in the database
            if (IsEmailExist(emailTextBox.Text))
            {
                MessageBox.Show("This email is already associated with another staff member.");
                return;
            }

            // Hash the password before saving it
            var (hashedPassword, salt) = PasswordHashing.HashPassword(passwordTextBox.Text);

            using (MySqlConnection conn = new MySqlConnection(database.connectionString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO `staff`(`StaffName`, `Email`, `Password`, `Salt`) " +
                                                    "VALUES (@Name, @Email, @Password, @Salt)", conn);
                cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = nameTextBox.Text;
                cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = emailTextBox.Text;
                cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = hashedPassword; // Store the hashed password
                cmd.Parameters.Add("@Salt", MySqlDbType.VarChar).Value = salt; // Store the salt

                cmd.ExecuteNonQuery();

                // Trigger the event after data is added
                OnDataAdded?.Invoke(this, EventArgs.Empty);

                MessageBox.Show("Staff information has been added successfully.");
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

        // Check if email already exists in the database
        private bool IsEmailExist(string email)
        {
            using (MySqlConnection conn = new MySqlConnection(database.connectionString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM `staff` WHERE `Email` = @Email", conn);
                cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = email;

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0; // If count > 0, it means the email exists
            }
        }

        private void viewColumnPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (viewColumnPasswordCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '•';
            }
        }

        private void addStaffDialog_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '•';
        }
    }
}