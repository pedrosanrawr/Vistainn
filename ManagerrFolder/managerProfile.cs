using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vistainn
{
    public partial class managerProfile : Form
    {
        Database database = new Database();

        public managerProfile()
        {
            InitializeComponent();
        }

        private void managerProfile_Load(object sender, EventArgs e)
        {
            emailLabel.Text = UserAccount.Email;
            fillDGV("");

            oldPassTextBox.PasswordChar = '•';
            newPassTextBox.PasswordChar = '•';
            rNewPasswordTextBox.PasswordChar = '•';
        }


        // populate - method
        public void fillDGV(string valueToSearch)
        {
            string query = "SELECT * FROM staff WHERE StaffId LIKE @search OR StaffName LIKE @search OR Email LIKE @search";
            using (MySqlConnection conn = new MySqlConnection(database.connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + valueToSearch + "%");

                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    try
                    {
                        adp.Fill(dt);
                        staffTable.DataSource = dt;

                        // Hide Password and Salt columns
                        staffTable.Columns["Password"].Visible = false;
                        staffTable.Columns["Salt"].Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while fetching data: " + ex.Message);
                    }
                }
            }
        }

        // add staff - button click
        private void addButton_Click(object sender, EventArgs e)
        {
            addStaffDialog addStaffDialog = new addStaffDialog();
            addStaffDialog.OnDataAdded += (s, args) =>
            {
                fillDGV("");
            };
            addStaffDialog.ShowDialog();
        }

        // edit staff - button click
        private void editButton_Click(object sender, EventArgs e)
        {
            if (staffTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = staffTable.SelectedRows[0];
                string staffId = selectedRow.Cells[0].Value.ToString();
                string name = selectedRow.Cells[1].Value.ToString();
                string email = selectedRow.Cells[2].Value.ToString();

                // open edit staff then populate
                editStaffDialog editStaffDialog = new editStaffDialog
                {
                    staffIdTextBox = { Text = staffId },
                    nameTextBox = { Text = name },
                    emailTextBox = { Text = email },
                };

                editStaffDialog.OnDataUpdated += (s, args) =>
                {
                    fillDGV("");
                };

                editStaffDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must select a row first.");
            }
        }

        // refresh - button click
        private void refreshButton_Click(object sender, EventArgs e)
        {
            fillDGV("");
        }

        // seach - button click
        private void searchButton_Click(object sender, EventArgs e)
        {
            fillDGV(searchTextBox.Text);
        }

        // delete - button click
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (staffTable.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(database.connectionString))
                        {
                            conn.Open();
                            foreach (DataGridViewRow row in staffTable.SelectedRows)
                            {
                                if (!row.IsNewRow)
                                {
                                    int staffId = Convert.ToInt32(row.Cells["StaffId"].Value);
                                    MySqlCommand cmd = new MySqlCommand("DELETE FROM staff WHERE StaffId = @StaffId", conn);
                                    cmd.Parameters.Add("@StaffId", MySqlDbType.Int32).Value = staffId;
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            fillDGV("");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("You must select at least one row to delete.");
            }
        }

        // log out - button click
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
                rNewPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                oldPassTextBox.PasswordChar = '•';
                newPassTextBox.PasswordChar = '•';
                rNewPasswordTextBox.PasswordChar = '•';
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPassTextBox.Text;
            string newPassword = newPassTextBox.Text;
            string confirmPassword = rNewPasswordTextBox.Text;

            // Validate the inputs
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

            var (hashedPassword, salt) = PasswordHashing.HashPassword(newPassword);

            if (UpdatePasswordInDatabase(hashedPassword, salt))
            {
                MessageBox.Show("Password changed successfully.");
                oldPassTextBox.Clear();
                newPassTextBox.Clear();
                rNewPasswordTextBox.Clear();
            }
            else
            {
                MessageBox.Show("An error occurred while changing the password.");
            }
        }

        private bool VerifyOldPassword(string oldPassword)
        {
            string query = "SELECT Password, Salt FROM manager WHERE Email = @Email";

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

                        // Verify the entered password with the stored hash and salt
                        return PasswordHashing.VerifyPassword(oldPassword, storedHash, storedSalt);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private bool UpdatePasswordInDatabase(string hashedPassword, string salt)
        {
            string query = "UPDATE manager SET Password = @Password, Salt = @Salt WHERE Email = @Email";

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
