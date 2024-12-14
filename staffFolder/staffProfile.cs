using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vistainn
{
    public partial class staffProfile : Form
    {
        Database database = new MySqlDatabase();

        public staffProfile()
        {
            InitializeComponent();
        }

        //load staff profile form
        private void staffProfile_Load(object sender, EventArgs e)
        {
            emailLabel.Text = UserAccount.Email;
            oldPassTextBox.PasswordChar = '•';
            newPassTextBox.PasswordChar = '•';
            rNewPassTextBox.PasswordChar = '•';
        }

        //log out button - click
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

        //view pass check box
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

        //change button click
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

        //verify old password - method
        private bool VerifyOldPassword(string oldPassword)
        {
            string query = "SELECT Password, Salt FROM staff WHERE Email = @Email";
            var parameters = new Dictionary<string, object>
            {
                { "@Email", UserAccount.Email }
            };

            var reader = database.ExecuteReader(query, parameters);
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

        //update pass - method
        private bool UpdatePasswordInDatabase(string newPassword)
        {
            var (hashedPassword, salt) = PasswordHashing.HashPassword(newPassword);

            string query = "UPDATE staff SET Password = @Password, Salt = @Salt WHERE Email = @Email";
            var parameters = new Dictionary<string, object>
            {
                { "@Email", UserAccount.Email },
                { "@Password", hashedPassword },
                { "@Salt", salt }
            };

            try
            {
                int rowsAffected = database.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message);
                return false;
            }
        }
    }
}
