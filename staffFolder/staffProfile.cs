using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Vistainn
{
    public partial class staffProfile : Form
    {
        Database database = new Database();
        public staffProfile()
        {
            InitializeComponent();
        }

        private void staffProfile_Load(object sender, EventArgs e)
        {
            emailLabel.Text = UserAccount.Email;
            oldPassTextBox.PasswordChar = '•';  
            newPassTextBox.PasswordChar = '•';
            rNewPassTextBox.PasswordChar = '•';
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                startPage login = new startPage();
                login.Show();
                this.Hide();
            }
        }

        private void viewPasswordChange_CheckedChanged(object sender, EventArgs e)
        {
            if (viewPasswordChange.Checked)
            {
                oldPassTextBox.PasswordChar = '\0';  
                newPassTextBox.PasswordChar = '\0';
                rNewPassTextBox.PasswordChar = '\0';
            }
            else
            {
                oldPassTextBox.PasswordChar = '•';  
                newPassTextBox.PasswordChar = '•';
                rNewPassTextBox.PasswordChar = '•';
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPassTextBox.Text;
            string newPassword = newPassTextBox.Text;
            string confirmPassword = rNewPassTextBox.Text;

            if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("The new password and confirmation password do not match.");
                return;
            }

            if (newPassword.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }

            if (!VerifyOldPassword(oldPassword))
            {
                MessageBox.Show("The old password is incorrect.");
                return;
            }

            if (UpdatePasswordInDatabase(newPassword))
            {
                MessageBox.Show("Password changed successfully.");
                oldPassTextBox.Clear();
                newPassTextBox.Clear();
                rNewPassTextBox.Clear();
            }
            else
            {
                MessageBox.Show("An error occurred while changing the password.");
            }
        }

        private bool VerifyOldPassword(string oldPassword)
        {
            string query = "SELECT Password, Salt FROM staff WHERE Email = @Email";

            using (MySqlConnection conn = new MySqlConnection(database.connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", UserAccount.Email);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string storedHash = reader["Password"].ToString();
                        string storedSalt = reader["Salt"].ToString();

                        return PasswordHashing.VerifyPassword(oldPassword, storedHash, storedSalt);
                    }
                    else
                    {
                        return false; 
                    }
                }
            }
        }

        private bool UpdatePasswordInDatabase(string newPassword)
        {
            var (hashedPassword, salt) = PasswordHashing.HashPassword(newPassword);

            string query = "UPDATE staff SET Password = @Password, Salt = @Salt WHERE Email = @Email";

            using (MySqlConnection conn = new MySqlConnection(database.connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", UserAccount.Email);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword); 
                        cmd.Parameters.AddWithValue("@Salt", salt); 

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating password: " + ex.Message);
                    return false;
                }
            }
        }
    }
}