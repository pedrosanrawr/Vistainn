using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Vistainn
{
    public partial class editStaffDialog : Form
    {
        public event EventHandler OnDataUpdated;
        Database database = new MySqlDatabase();

        public editStaffDialog()
        {
            InitializeComponent();
        }

        //update button - click
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(staffIdTextBox.Text) ||
                string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields before updating.");
                return;
            }

            if (!IsValidEmail(emailTextBox.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (IsEmailExistForUpdate(emailTextBox.Text, staffIdTextBox.Text))
            {
                MessageBox.Show("This email is already associated with another staff member.");
                return;
            }

            if (!addStaffDialog.ValidateName(nameTextBox.Text))
            {
                return;
            }

            try
            {
                database.ExecuteNonQuery(
                    "UPDATE staff SET StaffName=@StaffName, Email=@Email WHERE StaffId=@StaffId",
                    new Dictionary<string, object>
                    {
                        { "@StaffId", staffIdTextBox.Text },
                        { "@StaffName", nameTextBox.Text },
                        { "@Email", emailTextBox.Text }
                    }
                );

                OnDataUpdated?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Staff information has been updated successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        //email validation - method
        private bool IsValidEmail(string email)
        {
            var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return emailRegex.IsMatch(email);
        }

        //prevent multiple email
        private bool IsEmailExistForUpdate(string email, string staffId)
        {
            string query = "SELECT COUNT(*) FROM staff WHERE Email = @Email AND StaffId != @StaffId";
            var parameters = new Dictionary<string, object>
            {
                { "@Email", email },
                { "@StaffId", staffId }
            };

            using (var reader = database.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                {
                    return Convert.ToInt32(reader[0]) > 0;
                }
            }

            return false;
        }
    }
}
