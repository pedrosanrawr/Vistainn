using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Vistainn
{
    public partial class addStaffDialog : Form
    {
        Database database = new MySqlDatabase();
        public event EventHandler OnDataAdded;

        //constructor
        public addStaffDialog(Database database)
        {
            InitializeComponent();
        }

        //add button - click
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

            if (IsEmailExist(emailTextBox.Text))
            {
                MessageBox.Show("This email is already associated with another staff member.");
                return;
            }

            if (!ValidateName(nameTextBox.Text))
            {
                return;
            }

            var (hashedPassword, salt) = PasswordHashing.HashPassword(passwordTextBox.Text);
            AddStaffToDatabase(nameTextBox.Text, emailTextBox.Text, hashedPassword, salt);
        }
        
        //add staff - method
        private void AddStaffToDatabase(string name, string email, string hashedPassword, string salt)
        {
            try
            {
                using (var connection = database.CreateConnection())
                {
                    database.OpenConnection(connection);
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO `staff` (`StaffName`, `Email`, `Password`, `Salt`) " +
                                          "VALUES (@Name, @Email, @Password, @Salt)";

                        cmd.Parameters.Add(new MySqlParameter("@Name", MySqlDbType.VarChar) { Value = name });
                        cmd.Parameters.Add(new MySqlParameter("@Email", MySqlDbType.VarChar) { Value = email });
                        cmd.Parameters.Add(new MySqlParameter("@Password", MySqlDbType.VarChar) { Value = hashedPassword });
                        cmd.Parameters.Add(new MySqlParameter("@Salt", MySqlDbType.VarChar) { Value = salt });

                        cmd.ExecuteNonQuery();
                    }
                }

                OnDataAdded?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Staff information has been added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding staff: {ex.Message}");
            }
        }

        //email validation - method
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

        //prevent multiple email - method
        private bool IsEmailExist(string email)
        {
            try
            {
                using (var connection = database.CreateConnection())
                {
                    database.OpenConnection(connection);
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT COUNT(*) FROM `staff` WHERE `Email` = @Email";
                        cmd.Parameters.Add(new MySqlParameter("@Email", MySqlDbType.VarChar) { Value = email });

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking email existence: {ex.Message}");
                return false;
            }
        }

        //view check box - click
        private void viewColumnPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility(viewColumnPasswordCheckBox.Checked);
        }

        //toggle pass - method
        private void TogglePasswordVisibility(bool isChecked)
        {
            passwordTextBox.PasswordChar = isChecked ? '\0' : '•';
        }

        //name validation
        public static bool ValidateName(string name)
        {
            const string pattern = @"^[a-zA-Z\s.'-]+$";

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name cannot be empty.");
                return false;
            }

            if (!Regex.IsMatch(name, pattern))
            {
                MessageBox.Show("Name can only contain letters, spaces, apostrophes, hyphens, and periods.");
                return false;
            }

            return true;
        }

        //load add staff dialog
        private void addStaffDialog_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '•';
        }
    }
}
