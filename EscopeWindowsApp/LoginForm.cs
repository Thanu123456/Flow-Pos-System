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
    public partial class LoginForm : Form
    {
        private ErrorProvider emailErrorProvider;
        private ErrorProvider passwordErrorProvider;

        public LoginForm()
        {
            InitializeComponent();
            SetupErrorProviders();
        }

        private void SetupErrorProviders()
        {
            emailErrorProvider = new ErrorProvider(this);
            passwordErrorProvider = new ErrorProvider(this);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Optional: Initialize form state if needed
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

            // Check if the password is exactly 4 digits
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
            // Validate email and password format before proceeding
            bool isEmailValid = ValidateEmail();
            bool isPasswordValid = ValidatePassword();

            if (!isEmailValid || !isPasswordValid)
            {
                MessageBox.Show("Please correct the errors before logging in.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proceed with login
            string email = loginUserNameTextBox.Text.Trim();
            string password = loginPasswordTextbox.Text;

            try
            {
                string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to find the user by email
                    string query = "SELECT id, first_name, last_name, email, password, role FROM users WHERE email = @email";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // User found, verify the password
                                string storedHashedPassword = reader["password"].ToString();
                                bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(password, storedHashedPassword);

                                if (isPasswordCorrect)
                                {
                                    // Login successful
                                    string role = reader["role"].ToString();
                                    int userId = Convert.ToInt32(reader["id"]);
                                    string firstName = reader["first_name"].ToString();
                                    string lastName = reader["last_name"].ToString();
                                    string userEmail = reader["email"].ToString();
                                    string username = $"{firstName} {lastName}".Trim(); // Combine first and last name

                                    // Open the appropriate form based on the role
                                    this.Hide(); // Hide the login form

                                    if (role == "Cashier")
                                    {
                                        POSRegister posForm = new POSRegister(username, userEmail); // Pass username and email
                                        posForm.FormClosed += (s, args) => this.Close(); // Close LoginForm when POSRegister is closed
                                        posForm.Show();
                                    }
                                    else if (role == "Owner")
                                    {
                                        SideBarForm sideBarForm = new SideBarForm();
                                        sideBarForm.FormClosed += (s, args) => this.Close(); // Close LoginForm when SideBarForm is closed
                                        sideBarForm.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Unknown role: {role}. Please contact the administrator.", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        this.Show(); // Show the login form again if the role is invalid
                                        return;
                                    }
                                }
                                else
                                {
                                    // Password is incorrect
                                    MessageBox.Show("Invalid email or password.", "Login Failed",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                // User not found
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
    }
}