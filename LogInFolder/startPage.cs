using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Vistainn.Staff;

namespace Vistainn
{
    public partial class startPage : Form
    {
        private readonly Database database = new Database();

        public startPage()
        {
            InitializeComponent();
        }

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

        // Manager login - button click
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

        private bool ValidateLogin(string role)
        {
            string tableName = role == "staff" ? "staff" : "manager";
            string query = $"SELECT Password, Salt FROM {tableName} WHERE Email = @Email";

            using (var con = new MySqlConnection(database.connectionString))
            {
                con.Open();
                var command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@Email", UserAccount.Email);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedHash = reader["Password"].ToString();
                        string storedSalt = reader["Salt"].ToString();

                        return PasswordHashing.VerifyPassword(UserAccount.Password, storedHash, storedSalt);
                    }
                }
            }

            return false;
        }

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

        private void managerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            managerPanel.Show();
            staffPanel.Hide();
        }

        private void staffLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            staffPanel.Show();
            managerPanel.Hide();
        }

        private void viewCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            staffPasswordTextBox.PasswordChar = viewCheckBox.Checked ? '\0' : '•';
        }

        private void viewCheckBoxManager_CheckedChanged(object sender, EventArgs e)
        {
            managerPasswordTextBox.PasswordChar = viewCheckBoxManager.Checked ? '\0' : '•';
        }
    }

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
