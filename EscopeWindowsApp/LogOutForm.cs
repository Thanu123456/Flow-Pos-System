﻿using System;
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
using System.Configuration;
using System.Diagnostics;

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

            // Set default password visibility to hidden
            currentUserPasswordText.UseSystemPasswordChar = true;
            newUserPasswordText.UseSystemPasswordChar = true;
            reNewUserPasswordText.UseSystemPasswordChar = true;

            // Enable key preview to capture Enter key
            this.KeyPreview = true;
            this.KeyDown += LogOutForm_KeyDown;

            // Restrict password text boxes to numeric input
            currentUserPasswordText.KeyPress += PasswordTextBox_KeyPress;
            newUserPasswordText.KeyPress += PasswordTextBox_KeyPress;
            reNewUserPasswordText.KeyPress += PasswordTextBox_KeyPress;
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
            UpdateLogOutButtonState();
        }

        private void UpdateLogOutButtonState()
        {
            bool isPOSOpen = Application.OpenForms.OfType<POS>().Any();
            logOutBtn.Enabled = !isPOSOpen;
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
                string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

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
                string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE session_logs SET session_end_time = @endTime WHERE username = @username AND session_end_time IS NULL";
                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@endTime", DateTime.Now);
                        command.Parameters.AddWithValue("@username", username);
                        command.ExecuteNonQuery();
                    }
                }

                // Restart the application with --start-with-login argument
                string executablePath = Application.ExecutablePath;
                Process.Start(executablePath, "--start-with-login");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging out: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {
        }

        private void userEmailLabel_Click(object sender, EventArgs e)
        {
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            UpdateLogOutButtonState();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            UpdateLogOutButtonState();
        }

        private void currentPassShowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            currentUserPasswordText.UseSystemPasswordChar = !currentPassShowCheckBox.Checked;
            currentUserPasswordText.Focus();
        }

        private void newPassShowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            newUserPasswordText.UseSystemPasswordChar = !newPassShowCheckBox.Checked;
            newUserPasswordText.Focus();
        }

        private void confirmPassShowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            reNewUserPasswordText.UseSystemPasswordChar = !confirmPassShowCheckBox.Checked;
            reNewUserPasswordText.Focus();
        }

        private void LogOutForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                confirmPasswordBtn.PerformClick();
            }
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                var textbox = sender as Control;
                if (textbox != null && textbox.Text.Length >= 4)
                {
                    e.Handled = true;
                }
            }
        }
    }
}