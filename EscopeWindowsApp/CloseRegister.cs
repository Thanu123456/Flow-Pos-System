using System;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class CloseRegister : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private ErrorProvider totCashErrorProvider;

        public CloseRegister()
        {
            InitializeComponent();
            SetupErrorProviders();
            UpdateSessionDetails();
        }

        private void SetupErrorProviders()
        {
            totCashErrorProvider = new ErrorProvider(this);
        }

        private void CloseRegister_Load(object sender, EventArgs e)
        {
            UpdateSessionDetails();
        }

        private void UpdateSessionDetails()
        {
            try
            {
                // Update date
                cashRegDateLable.Text = DateTime.Now.ToString("yyyy-MM-dd");

                // Update SessionManager values
                cashInHandAmount.Text = SessionManager.CashInHand.ToString("F2");
                cashAmount.Text = SessionManager.Cash.ToString("F2");
                cardAmount.Text = SessionManager.Card.ToString("F2");
                totSaleAmount.Text = SessionManager.TotalSales.ToString("F2");
                totRefAmount.Text = SessionManager.TotalRefund.ToString("F2");
                subTotAmount.Text = (SessionManager.TotalSales - SessionManager.TotalRefund).ToString("F2");

                // Calculate total cash (cash + cash_in_hand, since refunds are subtracted in subtotal)
                decimal totalCash = SessionManager.Cash + SessionManager.CashInHand;
                totCashText.Text = totalCash.ToString("F2");

                // Force UI update
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating session details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Fallback values
                cashRegDateLable.Text = DateTime.Now.ToString("yyyy-MM-dd");
                cashInHandAmount.Text = "0.00";
                cashAmount.Text = "0.00";
                cardAmount.Text = "0.00";
                totSaleAmount.Text = "0.00";
                totRefAmount.Text = "0.00";
                subTotAmount.Text = "0.00";
                totCashText.Text = "0.00";
            }
        }

        private bool ValidateTotalCash()
        {
            if (string.IsNullOrWhiteSpace(totCashText.Text))
            {
                totCashErrorProvider.SetError(totCashText, "Total cash is required");
                return false;
            }

            string cashPattern = @"^\d+(\.\d{1,2})?$";
            if (!Regex.IsMatch(totCashText.Text, cashPattern))
            {
                totCashErrorProvider.SetError(totCashText, "Please enter a valid positive number (e.g., 100 or 100.50)");
                return false;
            }

            if (decimal.Parse(totCashText.Text) < 0)
            {
                totCashErrorProvider.SetError(totCashText, "Total cash cannot be negative");
                return false;
            }

            totCashErrorProvider.Clear();
            return true;
        }

        private void cashInHandAmount_Click(object sender, EventArgs e)
        {
            cashInHandAmount.Text = SessionManager.CashInHand.ToString("F2");
        }

        private void cashRegDateLable_Click(object sender, EventArgs e)
        {
            cashRegDateLable.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void cashAmount_Click(object sender, EventArgs e)
        {
            cashAmount.Text = SessionManager.Cash.ToString("F2");
        }

        private void cardAmount_Click(object sender, EventArgs e)
        {
            cardAmount.Text = SessionManager.Card.ToString("F2");
        }

        private void totSaleAmount_Click(object sender, EventArgs e)
        {
            totSaleAmount.Text = SessionManager.TotalSales.ToString("F2");
        }

        private void totRefAmount_Click(object sender, EventArgs e)
        {
            totRefAmount.Text = SessionManager.TotalRefund.ToString("F2");
        }

        private void subTotAmount_Click(object sender, EventArgs e)
        {
            subTotAmount.Text = (SessionManager.TotalSales - SessionManager.TotalRefund).ToString("F2");
        }

        private void totCashText_TextChanged(object sender, EventArgs e)
        {
            ValidateTotalCash();
        }

        private void noteText_TextChanged(object sender, EventArgs e)
        {
            // No validation needed for note, as it's optional free text
        }

        private void closeRegBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateTotalCash())
            {
                MessageBox.Show("Please correct the errors before closing the register.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Session Start Time
            if (SessionManager.SessionStartTime == DateTime.MinValue)
            {
                MessageBox.Show("Session start time is not set. Please start a new session by opening the register.", "Invalid Session",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if cashbook has any records
                    string checkCashbookQuery = "SELECT COUNT(*) FROM cashbook";
                    long cashbookRecordCount;
                    using (MySqlCommand checkCommand = new MySqlCommand(checkCashbookQuery, connection))
                    {
                        cashbookRecordCount = (long)checkCommand.ExecuteScalar();
                    }

                    if (cashbookRecordCount == 0)
                    {
                        MessageBox.Show("No cashbook records found. Please open the register and set the cash in hand first.", "No Cashbook Entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Retrieve username from cashbook (assuming latest entry for current session)
                    string cashbookQuery = "SELECT username FROM cashbook ORDER BY date_time DESC LIMIT 1";
                    string username = "Unknown";

                    using (MySqlCommand cashbookCommand = new MySqlCommand(cashbookQuery, connection))
                    {
                        using (MySqlDataReader reader = cashbookCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                username = reader["username"].ToString();
                                if (string.IsNullOrWhiteSpace(username))
                                {
                                    username = "Unknown";
                                }
                            }
                        }
                    }

                    // Insert into session_logs table
                    string query = @"
                        INSERT INTO session_logs (
                            session_start_time, session_end_time, cash_in_hand, cash_amount, card_amount,
                            total_sale_amount, total_refund_amount, subtotal_amount, note, username, created_at
                        ) VALUES (
                            @sessionStartTime, @sessionEndTime, @cashInHand, @cashAmount, @cardAmount,
                            @totalSaleAmount, @totalRefundAmount, @subtotalAmount, @note, @username, @createdAt
                        )";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@sessionStartTime", SessionManager.SessionStartTime);
                        command.Parameters.AddWithValue("@sessionEndTime", DateTime.Now);
                        command.Parameters.AddWithValue("@cashInHand", decimal.Parse(cashInHandAmount.Text));
                        command.Parameters.AddWithValue("@cashAmount", decimal.Parse(cashAmount.Text));
                        command.Parameters.AddWithValue("@cardAmount", decimal.Parse(cardAmount.Text));
                        command.Parameters.AddWithValue("@totalSaleAmount", decimal.Parse(totSaleAmount.Text));
                        command.Parameters.AddWithValue("@totalRefundAmount", decimal.Parse(totRefAmount.Text));
                        command.Parameters.AddWithValue("@subtotalAmount", decimal.Parse(subTotAmount.Text));
                        command.Parameters.AddWithValue("@note", noteText.Text ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@createdAt", DateTime.Now);

                        command.ExecuteNonQuery();
                    }

                    // Reset SessionManager
                    SessionManager.ResetSession();

                    // Show success message
                    MessageBox.Show("Register closed successfully! Returning to login...", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Close all open forms except this one (to avoid issues while iterating)
                    Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();
                    foreach (Form form in openForms)
                    {
                        if (form != this)
                        {
                            form.Close();
                        }
                    }

                    // Show the LoginForm non-modally to restart the workflow
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();

                    // Close this form
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error closing register: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        
        
        private void closeRegCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}