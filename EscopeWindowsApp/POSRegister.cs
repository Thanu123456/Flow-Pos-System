using System;
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
        }

        private void SetupErrorProviders()
        {
            cashInHandErrorProvider = new ErrorProvider(this);
        }

        private void POSRegister_Load(object sender, EventArgs e)
        {
            // Reset the session when the form loads (new cashier session)
            SessionManager.ResetSession();
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

        private void cashInHandText_TextChanged(object sender, EventArgs e)
        {
            ValidateCashInHand();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
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
                string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
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

                    MessageBox.Show("Cash in hand saved successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Hide();
                POS posForm = new POS();
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
    }
}