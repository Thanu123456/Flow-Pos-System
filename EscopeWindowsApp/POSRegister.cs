using System;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class POSRegister : Form
    {
        private ErrorProvider cashInHandErrorProvider;
        private string userEmail;
        private string userName;

        public POSRegister(string username = "", string email = "")
        {
            InitializeComponent();
            SetupErrorProviders();
            this.userName = username;
            this.userEmail = email;

            // Enable key preview to capture keyboard events
            this.KeyPreview = true;
            this.KeyDown += POSRegister_KeyDown;

            // Restrict cashInHandText to numeric input
            cashInHandText.KeyPress += CashInHandText_KeyPress;
        }

        private void SetupErrorProviders()
        {
            cashInHandErrorProvider = new ErrorProvider(this);
        }

        private void POSRegister_Load(object sender, EventArgs e)
        {
            // Reset the session when the form loads (new cashier session)
            SessionManager.ResetSession();
            UpdateSaveButtonState(); // Initialize button state
        }

        private bool ValidateCashInHand()
        {
            if (string.IsNullOrWhiteSpace(cashInHandText.Text))
            {
                cashInHandErrorProvider.SetError(cashInHandText, "Cash in hand is required");
                return false;
            }

            string cashPattern = @"^\d+(\.\d{1,2})?$";
            if (!Regex.IsMatch(cashInHandText.Text, cashPattern))
            {
                cashInHandErrorProvider.SetError(cashInHandText, "Please enter a valid positive number (e.g., 100 or 100.50)");
                return false;
            }

            if (decimal.Parse(cashInHandText.Text) <= 0)
            {
                cashInHandErrorProvider.SetError(cashInHandText, "Cash in hand must be greater than 0");
                return false;
            }

            cashInHandErrorProvider.Clear();
            return true;
        }

        private void UpdateSaveButtonState()
        {
            posRegSaveBtn.Enabled = ValidateCashInHand();
        }

        private void cashInHandText_TextChanged(object sender, EventArgs e)
        {
            ValidateCashInHand();
            UpdateSaveButtonState();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // This method appears unused; keeping it as is per the original code
        }

        private void posRegSaveBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateCashInHand())
            {
                MessageBox.Show("Please correct the errors before submitting.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO cashbook (username, useremail, cash_in_hand, date_time) " +
                                   "VALUES (@username, @useremail, @cashInHand, @dateTime)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", userName ?? "Unknown");
                        command.Parameters.AddWithValue("@useremail", userEmail ?? "Unknown");
                        command.Parameters.AddWithValue("@cashInHand", decimal.Parse(cashInHandText.Text));
                        command.Parameters.AddWithValue("@dateTime", DateTime.Now);
                        command.ExecuteNonQuery();
                    }

                    // Initialize SessionManager with Cash in Hand and session start time
                    SessionManager.CashInHand = decimal.Parse(cashInHandText.Text);
                    SessionManager.SessionStartTime = DateTime.Now;
                }

                this.Hide();
                POS posForm = new POS(this.userName, this.userEmail);
                posForm.FormClosed += (s, args) => this.Close();
                posForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving to cashbook: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void POSRegister_KeyDown(object sender, KeyEventArgs e)
        {
            // Trigger posRegSaveBtn on Enter key
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
                posRegSaveBtn.PerformClick();
            }
        }

        private void CashInHandText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, a single decimal point, and control keys (e.g., backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Block non-numeric input except decimal point
            }
            else if (e.KeyChar == '.' && cashInHandText.Text.Contains('.'))
            {
                e.Handled = true; // Prevent multiple decimal points
            }
            else if (e.KeyChar == '.' && cashInHandText.Text.Length == 0)
            {
                e.Handled = true; // Prevent decimal point as the first character
            }
            else if (char.IsDigit(e.KeyChar))
            {
                // Prevent more than 2 decimal places
                int decimalIndex = cashInHandText.Text.IndexOf('.');
                if (decimalIndex >= 0 && cashInHandText.Text.Length - decimalIndex > 2)
                {
                    e.Handled = true; // Block additional digits after 2 decimal places
                }
            }
        }
    }
}