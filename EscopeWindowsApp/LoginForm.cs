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
using System.Configuration;

namespace EscopeWindowsApp
{
    public partial class LoginForm : Form
    {
        private ErrorProvider emailErrorProvider;
        private ErrorProvider passwordErrorProvider;

        public LoginForm()
        {
            InitializeComponent();
            SetupErrorProviders();

            // Set default password visibility to hidden
            loginPasswordTextbox.UseSystemPasswordChar = true;
            loginPassShowCheckBox.Checked = false;

            // Match checkbox style with AddUserForm
            loginPassShowCheckBox.Text = "Show Password";
            loginPassShowCheckBox.AutoSize = true;
            loginPassShowCheckBox.Font = new Font("Segoe UI", 9F);

            // Enable key preview to capture keyboard events
            this.KeyPreview = true;
            this.KeyDown += LoginForm_KeyDown;
        }

        private void SetupErrorProviders()
        {
            emailErrorProvider = new ErrorProvider(this);
            passwordErrorProvider = new ErrorProvider(this);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private bool ValidateEmail()
        {
            if (string.IsNullOrWhiteSpace(loginUserNameTextBox.Text))
            {
                emailErrorProvider.SetError(loginUserNameTextBox, "Email is required");
                return false;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(loginUserNameTextBox.Text, emailPattern))
            {
                emailErrorProvider.SetError(loginUserNameTextBox, "Invalid email format");
                return false;
            }

            emailErrorProvider.Clear();
            return true;
        }

        private bool ValidatePassword()
        {
            if (string.IsNullOrWhiteSpace(loginPasswordTextbox.Text))
            {
                passwordErrorProvider.SetError(loginPasswordTextbox, "Password is required");
                return false;
            }

            if (!Regex.IsMatch(loginPasswordTextbox.Text, @"^\d{4}$"))
            {
                passwordErrorProvider.SetError(loginPasswordTextbox, "Password must be exactly 4 digits (e.g., 1234)");
                return false;
            }

            passwordErrorProvider.Clear();
            return true;
        }

        private void loginUserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void loginPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            ValidatePassword();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            bool isEmailValid = ValidateEmail();
            bool isPasswordValid = ValidatePassword();

            if (!isEmailValid || !isPasswordValid)
            {
                MessageBox.Show("Please correct the errors before logging in.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = loginUserNameTextBox.Text.Trim();
            string password = loginPasswordTextbox.Text;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id, first_name, last_name, email, password, role FROM users WHERE email = @email";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHashedPassword = reader["password"].ToString();
                                bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(password, storedHashedPassword);

                                if (isPasswordCorrect)
                                {
                                    string role = reader["role"].ToString();
                                    string firstName = reader["first_name"].ToString();
                                    string lastName = reader["last_name"].ToString();
                                    string userEmail = reader["email"].ToString();
                                    string username = $"{firstName} {lastName}".Trim();

                                    this.Hide();

                                    if (role == "Cashier")
                                    {
                                        POSRegister posForm = new POSRegister(username, userEmail);
                                        posForm.FormClosed += (s, args) => this.Close();
                                        posForm.Show();
                                    }
                                    else if (role == "Owner")
                                    {
                                        SideBarForm sideBarForm = new SideBarForm(username, userEmail);
                                        sideBarForm.FormClosed += (s, args) => this.Close();
                                        sideBarForm.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Unknown role: {role}. Please contact the administrator.", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        this.Show();
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid email or password.", "Login Failed",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.", "Login Failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginPassShowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility based on checkbox state
            loginPasswordTextbox.UseSystemPasswordChar = !loginPassShowCheckBox.Checked;

            // Update checkbox text for better UX
            loginPassShowCheckBox.Text = loginPassShowCheckBox.Checked ? "Hide Password" : "Show Password";

            // Set focus back to password field
            loginPasswordTextbox.Focus();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Trigger login button on Enter key
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
                loginBtn.PerformClick();
            }
            // Toggle show/hide password with Ctrl + S
            else if (e.Control && e.KeyCode == Keys.S)
            {
                loginPassShowCheckBox.Checked = !loginPassShowCheckBox.Checked;
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
            }
        }
    }
}