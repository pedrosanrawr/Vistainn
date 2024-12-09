using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Vistainn
{
    public partial class changePasswordDialog : Form
    {
        private string userEmail;
        private bool isManager;

        public changePasswordDialog(string email, bool isManager = true)
        {
            InitializeComponent();
            this.userEmail = email;
            this.isManager = isManager;
            newPasswordTextBox.PasswordChar = '•';
            confirmPasswordTextBox.PasswordChar = '•';
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            if (newPassword.Length < 8)
            {
                MessageBox.Show("Password should be at least 8 characters long.");
                return;
            }

            var (hashedPassword, salt) = PasswordHashing.HashPassword(newPassword);

            string table = isManager ? "manager" : "staff";
            UpdatePasswordInDatabase(userEmail, hashedPassword, salt, table);
            this.Close();
        }

        private void UpdatePasswordInDatabase(string email, string hashedPassword, string salt, string table)
        {
            if (table != "staff" && table != "manager")
            {
                MessageBox.Show("Invalid table name.");
                return;
            }

            string query = $"UPDATE {table} SET Password = @Password, Salt = @Salt WHERE Email = @Email";

            try
            {
                using (MySqlConnection con = new MySqlConnection(new Database().connectionString))
                {
                    con.Open();
                    var command = new MySqlCommand(query, con);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@Salt", salt);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password successfully updated.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the password. Please check the email.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating password: {ex.Message}");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            newPasswordTextBox.PasswordChar = viewCheckBox.Checked ? '\0' : '•';
            confirmPasswordTextBox.PasswordChar = viewCheckBox.Checked ? '\0' : '•';
        }
    }
}
