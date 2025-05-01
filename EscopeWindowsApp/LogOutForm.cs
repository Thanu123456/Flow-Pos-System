using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace EscopeWindowsApp
{
    public partial class LogOutForm : Form
    {
        private ErrorProvider currentPasswordErrorProvider;
        private ErrorProvider newPasswordErrorProvider;
        private ErrorProvider reNewPasswordErrorProvider;
        private string username;
        private string userEmail;

        public LogOutForm(string username, string userEmail)
        {
            InitializeComponent();
            this.username = username;
            this.userEmail = userEmail;
            SetupErrorProviders();
            InitializeForm();
        }

        private void SetupErrorProviders()
        {
            currentPasswordErrorProvider = new ErrorProvider(this);
            newPasswordErrorProvider = new ErrorProvider(this);
            reNewPasswordErrorProvider = new ErrorProvider(this);
        }

        private void InitializeForm()
        {
            userNameLabel.Text = username;
            userEmailLabel.Text = userEmail;
            UpdateLogOutButtonState(); // Check POS form state on initialization
        }

        // New method to check if POS form is open and update logOutBtn state
        private void UpdateLogOutButtonState()
        {
            bool isPOSOpen = Application.OpenForms.OfType<POS>().Any();
            logOutBtn.Enabled = !isPOSOpen; // Disable if POS form is open
        }

        private bool ValidateCurrentPassword()
        {
            if (string.IsNullOrWhiteSpace(currentUserPasswordText.Text))
            {
                currentPasswordErrorProvider.SetError(currentUserPasswordText, "Current password is required");
                return false;
            }

            if (!Regex.IsMatch(currentUserPasswordText.Text, @"^\d{4}$"))
            {
                currentPasswordErrorProvider.SetError(currentUserPasswordText, "Password must be exactly 4 digits (e.g., 1234)");
                return false;
            }

            currentPasswordErrorProvider.Clear();
            return true;
        }

        private bool ValidateNewPassword()
        {
            if (string.IsNullOrWhiteSpace(newUserPasswordText.Text))
            {
                newPasswordErrorProvider.SetError(newUserPasswordText, "New password is required");
                return false;
            }

            if (!Regex.IsMatch(newUserPasswordText.Text, @"^\d{4}$"))
            {
                newPasswordErrorProvider.SetError(newUserPasswordText, "New password must be exactly 4 digits (e.g., 1234)");
                return false;
            }

            newPasswordErrorProvider.Clear();
            return true;
        }

        private bool ValidateReNewPassword()
        {
            if (string.IsNullOrWhiteSpace(reNewUserPasswordText.Text))
            {
                reNewPasswordErrorProvider.SetError(reNewUserPasswordText, "Please re-enter the new password");
                return false;
            }

            if (reNewUserPasswordText.Text != newUserPasswordText.Text)
            {
                reNewPasswordErrorProvider.SetError(reNewUserPasswordText, "Passwords do not match");
                return false;
            }

            reNewPasswordErrorProvider.Clear();
            return true;
        }

        private void currentUserPasswordText_TextChanged(object sender, EventArgs e)
        {
            ValidateCurrentPassword();
        }

        private void newUserPasswordText_TextChanged(object sender, EventArgs e)
        {
            ValidateNewPassword();
        }

        private void reNewUserPasswordText_TextChanged(object sender, EventArgs e)
        {
            ValidateReNewPassword();
        }

        private void confirmPasswordBtn_Click(object sender, EventArgs e)
        {
            bool isCurrentPasswordValid = ValidateCurrentPassword();
            bool isNewPasswordValid = ValidateNewPassword();
            bool isReNewPasswordValid = ValidateReNewPassword();

            if (!isCurrentPasswordValid || !isNewPasswordValid || !isReNewPasswordValid)
            {
                MessageBox.Show("Please correct the errors before changing the password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string currentPassword = currentUserPasswordText.Text;
            string newPassword = newUserPasswordText.Text;

            try
            {
                string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Verify current password
                    string query = "SELECT password FROM users WHERE email = @email";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", userEmail);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHashedPassword = reader["password"].ToString();
                                bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(currentPassword, storedHashedPassword);

                                if (!isPasswordCorrect)
                                {
                                    MessageBox.Show("Current password is incorrect.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("User not found.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // Update password
                    string hashedNewPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
                    string updateQuery = "UPDATE users SET password = @password WHERE email = @email";
                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@password", hashedNewPassword);
                        updateCommand.Parameters.AddWithValue("@email", userEmail);

                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            currentUserPasswordText.Clear();
                            newUserPasswordText.Clear();
                            reNewUserPasswordText.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to change password.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error changing password: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Update session_logs with session_end_time
                    string updateQuery = "UPDATE session_logs SET session_end_time = @endTime WHERE username = @username AND session_end_time IS NULL";
                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@endTime", DateTime.Now);
                        command.Parameters.AddWithValue("@username", username);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging out: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {
            // No action needed for click
        }

        private void userEmailLabel_Click(object sender, EventArgs e)
        {
            // No action needed for click
        }

        // Handle form shown event to update button state
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            UpdateLogOutButtonState();
        }

        // Handle form activated event to update button state
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            UpdateLogOutButtonState();
        }
    }
}