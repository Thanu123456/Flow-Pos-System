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

namespace EscopeWindowsApp
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
            SetupErrorProviders();
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

            // Set error icons
            //firstNameErrorProvider.Icon = Properties.Resources.ErrorIcon; // You'll need to add an error icon resource
            //lastNameErrorProvider.Icon = Properties.Resources.ErrorIcon;
            //emailErrorProvider.Icon = Properties.Resources.ErrorIcon;
            //phoneErrorProvider.Icon = Properties.Resources.ErrorIcon;
            //passwordErrorProvider.Icon = Properties.Resources.ErrorIcon;
            //confirmPasswordErrorProvider.Icon = Properties.Resources.ErrorIcon;
            //roleErrorProvider.Icon = Properties.Resources.ErrorIcon;
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

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        private void addUserNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateFirstName();
        }

        private void createUserLastText_TextChanged(object sender, EventArgs e)
        {
            ValidateLastName();
        }

        private void createUserEmailText_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void createUserPhoneText_TextChanged(object sender, EventArgs e)
        {
            ValidatePhoneNumber();
        }

        private void createUserPassText_TextChanged(object sender, EventArgs e)
        {
            ValidatePassword();
            ValidateConfirmPassword();
        }

        private void createUserCpassText_TextChanged(object sender, EventArgs e)
        {
            ValidateConfirmPassword();
        }

        private void CreateUserRoleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateRole();
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
                    MessageBox.Show("User registration successful!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error registering user: {ex.Message}", "Error",
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
