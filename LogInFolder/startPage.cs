using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vistainn.Staff;

namespace Vistainn
{
    public partial class startPage : Form
    {
        Database database = new MySqlDatabase();  

        public startPage()
        {
            InitializeComponent();
        }

        //staff button - click
        private void staffButton_Click(object sender, EventArgs e)
        {
            UserAccount.SetAccount(staffEmailTextBox.Text, staffPasswordTextBox.Text);

            if (ValidateLogin("staff"))
            {
                var staffDashboard = new StaffDashboard();
                staffDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }

        //manager log in button - click
        private void manageLogInButton_Click(object sender, EventArgs e)
        {
            UserAccount.SetAccount(managerEmailTextBox.Text, managerPasswordTextBox.Text);

            if (ValidateLogin("manager"))
            {
                var managerDashboard = new ManagerDashboard();
                managerDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }

        //log in validation - method
        private bool ValidateLogin(string role)
        {
            string tableName = role == "staff" ? "staff" : "manager";
            string query = $"SELECT Password, Salt FROM {tableName} WHERE Email = @Email";

            var parameters = new Dictionary<string, object>
            {
                { "@Email", UserAccount.Email }
            };

            try
            {
                using (var reader = database.ExecuteReader(query, parameters))
                {
                    if (reader.Read())
                    {
                        string storedHash = reader["Password"].ToString();
                        string storedSalt = reader["Salt"].ToString();

                        return PasswordHashing.VerifyPassword(UserAccount.Password, storedHash, storedSalt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error validating login: {ex.Message}");
            }

            return false;
        }

        //staff forgot pass link label - click
        private void staffForgotPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string staffEmail = staffEmailTextBox.Text;

            if (string.IsNullOrWhiteSpace(staffEmail))
            {
                MessageBox.Show("Please enter your email to reset your password.");
                return;
            }

            var otp = new otpDialog(staffEmail, isManager: false);
            otp.ShowDialog();
        }

        //manager forgot pass link label - click
        private void managerForgotPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string managerEmail = managerEmailTextBox.Text;

            if (string.IsNullOrWhiteSpace(managerEmail))
            {
                MessageBox.Show("Please enter your email to reset your password.");
                return;
            }

            var otp = new otpDialog(managerEmail, isManager: true);
            otp.ShowDialog();
        }

        //manager link label - click
        private void managerLinkLabel_LinkClicked(object sender, EventArgs e)
        {
            managerPanel.Show();
            staffPanel.Hide();
        }

        //staff link label - click
        private void staffLinkLabel_LinkClicked(object sender, EventArgs e)
        {
            staffPanel.Show();
            managerPanel.Hide();
        }

        //view check box staff - click
        private void viewCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            staffPasswordTextBox.PasswordChar = viewCheckBox.Checked ? '\0' : '•';
        }

        //view check box manager - click
        private void viewCheckBoxManager_CheckedChanged(object sender, EventArgs e)
        {
            managerPasswordTextBox.PasswordChar = viewCheckBoxManager.Checked ? '\0' : '•';
        }
    }

    //user account class
    public static class UserAccount
    {
        public static string Email { get; set; }
        public static string Password { get; set; }

        public static void SetAccount(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}