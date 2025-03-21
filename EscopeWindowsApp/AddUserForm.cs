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
    public partial class AddUserForm : Form
    {
        private bool isEditMode = false;
        private int editUserId = -1;

        public AddUserForm() : this(-1, "", "", "", "", "") // Default constructor for creating a new user
        {
        }
        public AddUserForm(int userId, string firstName, string lastName, string email, string phoneNumber, string role)
        {
            InitializeComponent();
            SetupErrorProviders();

            if (userId != -1)
            {
                isEditMode = true;
                editUserId = userId;
                this.Text = "Edit User"; // Change form title to indicate editing
                createSaveBtn.Text = "Update"; // Change button text to "Update"
            }

            // Pre-fill the form fields
            createUserFirstText.Text = firstName;
            createUserLastText.Text = lastName;
            createUserEmailText.Text = email;
            createUserPhoneText.Text = phoneNumber;
            CreateUserRoleCombo.SelectedItem = role;

            // Since we're editing, password fields are optional (user may not want to change the password)
            createUserPassText.Text = ""; // Leave blank
            createUserCpassText.Text = ""; // Leave blank
        }

        private ErrorProvider firstNameErrorProvider;
        private ErrorProvider lastNameErrorProvider;
        private ErrorProvider emailErrorProvider;
        private ErrorProvider phoneErrorProvider;
        private ErrorProvider passwordErrorProvider;
        private ErrorProvider confirmPasswordErrorProvider;
        private ErrorProvider roleErrorProvider;

        private void SetupErrorProviders()
        {
            firstNameErrorProvider = new ErrorProvider(this);
            lastNameErrorProvider = new ErrorProvider(this);
            emailErrorProvider = new ErrorProvider(this);
            phoneErrorProvider = new ErrorProvider(this);
            passwordErrorProvider = new ErrorProvider(this);
            confirmPasswordErrorProvider = new ErrorProvider(this);
            roleErrorProvider = new ErrorProvider(this);
        }

        private bool ValidateFirstName()
        {
            if (string.IsNullOrWhiteSpace(createUserFirstText.Text))
            {
                firstNameErrorProvider.SetError(createUserFirstText, "First Name is required");
                return false;
            }

            if (createUserFirstText.Text.Length < 2)
            {
                firstNameErrorProvider.SetError(createUserFirstText, "First Name must be at least 2 characters");
                return false;
            }

            firstNameErrorProvider.Clear();
            return true;
        }

        private bool ValidateLastName()
        {
            if (string.IsNullOrWhiteSpace(createUserLastText.Text))
            {
                lastNameErrorProvider.SetError(createUserLastText, "Last Name is required");
                return false;
            }

            if (createUserLastText.Text.Length < 2)
            {
                lastNameErrorProvider.SetError(createUserLastText, "Last Name must be at least 2 characters");
                return false;
            }

            lastNameErrorProvider.Clear();
            return true;
        }

        private bool ValidateEmail()
        {
            if (string.IsNullOrWhiteSpace(createUserEmailText.Text))
            {
                emailErrorProvider.SetError(createUserEmailText, "Email is required");
                return false;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(createUserEmailText.Text, emailPattern))
            {
                emailErrorProvider.SetError(createUserEmailText, "Invalid email format");
                return false;
            }

            emailErrorProvider.Clear();
            return true;
        }

        private bool ValidatePhoneNumber()
        {
            if (string.IsNullOrWhiteSpace(createUserPhoneText.Text))
            {
                phoneErrorProvider.SetError(createUserPhoneText, "Phone Number is required");
                return false;
            }

            string phonePattern = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$";
            if (!Regex.IsMatch(createUserPhoneText.Text, phonePattern))
            {
                phoneErrorProvider.SetError(createUserPhoneText, "Invalid phone number format");
                return false;
            }

            phoneErrorProvider.Clear();
            return true;
        }

        private bool ValidatePassword()
        {
            if (isEditMode && string.IsNullOrWhiteSpace(createUserPassText.Text))
            {
                passwordErrorProvider.Clear();
                return true; // Password is optional in edit mode
            }

            if (string.IsNullOrWhiteSpace(createUserPassText.Text))
            {
                passwordErrorProvider.SetError(createUserPassText, "Password is required");
                return false;
            }

            if (createUserPassText.Text.Length < 8)
            {
                passwordErrorProvider.SetError(createUserPassText, "Password must be at least 8 characters");
                return false;
            }

            if (!Regex.IsMatch(createUserPassText.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$"))
            {
                passwordErrorProvider.SetError(createUserPassText, "Password must include uppercase, lowercase, number, and special character");
                return false;
            }

            passwordErrorProvider.Clear();
            return true;
        }

        private bool ValidateConfirmPassword()
        {
            if (isEditMode && string.IsNullOrWhiteSpace(createUserCpassText.Text))
            {
                confirmPasswordErrorProvider.Clear();
                return true; // Confirm password is optional in edit mode
            }

            if (string.IsNullOrWhiteSpace(createUserCpassText.Text))
            {
                confirmPasswordErrorProvider.SetError(createUserCpassText, "Confirm Password is required");
                return false;
            }

            if (createUserPassText.Text != createUserCpassText.Text)
            {
                confirmPasswordErrorProvider.SetError(createUserCpassText, "Passwords do not match");
                return false;
            }

            confirmPasswordErrorProvider.Clear();
            return true;
        }

        private bool ValidateRole()
        {
            if (CreateUserRoleCombo.SelectedIndex == -1)
            {
                roleErrorProvider.SetError(CreateUserRoleCombo, "Role selection is required");
                return false;
            }

            roleErrorProvider.Clear();
            return true;
        }

        // New method to update the Save button's state based on all validations
        private void UpdateSaveButtonState()
        {
            bool isValid = ValidateFirstName() && ValidateLastName() && ValidateEmail() &&
                           ValidatePhoneNumber() && ValidatePassword() && ValidateConfirmPassword() &&
                           ValidateRole();
            createSaveBtn.Enabled = isValid;
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            // Set the initial state of the Save button when the form loads
            UpdateSaveButtonState();
        }

        // Modified event handlers to update the Save button state
        private void addUserNameText_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private void createUserLastText_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private void createUserEmailText_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private void createUserPhoneText_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private void createUserPassText_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private void createUserCpassText_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private void CreateUserRoleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private void createSaveBtn_Click(object sender, EventArgs e)
        {
            bool isFirstNameValid = ValidateFirstName();
            bool isLastNameValid = ValidateLastName();
            bool isEmailValid = ValidateEmail();
            bool isPhoneValid = ValidatePhoneNumber();
            bool isPasswordValid = ValidatePassword();
            bool isConfirmPasswordValid = ValidateConfirmPassword();
            bool isRoleValid = ValidateRole();

            if (isFirstNameValid && isLastNameValid && isEmailValid &&
                isPhoneValid && isPasswordValid && isConfirmPasswordValid && isRoleValid)
            {
                try
                {
                    string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        if (isEditMode)
                        {
                            // Update existing user
                            string query = "UPDATE users SET first_name = @firstName, last_name = @lastName, " +
                                          "email = @email, phone_number = @phoneNumber, role = @role";
                            // Only update password if a new one is provided
                            if (!string.IsNullOrWhiteSpace(createUserPassText.Text))
                            {
                                query += ", password = @password";
                            }
                            query += " WHERE id = @userId";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@firstName", createUserFirstText.Text.Trim());
                                command.Parameters.AddWithValue("@lastName", createUserLastText.Text.Trim());
                                command.Parameters.AddWithValue("@email", createUserEmailText.Text.Trim());
                                command.Parameters.AddWithValue("@phoneNumber", createUserPhoneText.Text.Trim());
                                command.Parameters.AddWithValue("@role", CreateUserRoleCombo.SelectedItem.ToString());
                                if (!string.IsNullOrWhiteSpace(createUserPassText.Text))
                                {
                                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(createUserPassText.Text);
                                    command.Parameters.AddWithValue("@password", hashedPassword);
                                }
                                command.Parameters.AddWithValue("@userId", editUserId);
                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show("User updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Insert new user (existing logic)
                            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(createUserPassText.Text);
                            string query = "INSERT INTO users (first_name, last_name, email, phone_number, password, role) " +
                                           "VALUES (@firstName, @lastName, @email, @phoneNumber, @password, @role)";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@firstName", createUserFirstText.Text.Trim());
                                command.Parameters.AddWithValue("@lastName", createUserLastText.Text.Trim());
                                command.Parameters.AddWithValue("@email", createUserEmailText.Text.Trim());
                                command.Parameters.AddWithValue("@phoneNumber", createUserPhoneText.Text.Trim());
                                command.Parameters.AddWithValue("@password", hashedPassword);
                                command.Parameters.AddWithValue("@role", CreateUserRoleCombo.SelectedItem.ToString());
                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show("User registration successful!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving user: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void createCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}