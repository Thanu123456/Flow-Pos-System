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

namespace EscopeWindowsApp
{
    public partial class POSRegister : Form
    {
        private ErrorProvider cashInHandErrorProvider;
        private string userEmail; // To store the logged-in user's email
        private string userName;  // To store the logged-in user's username

        // Constructor to accept username and email from LoginForm
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
            // Optional: Initialize form state if needed
        }

        private bool ValidateCashInHand()
        {
            if (string.IsNullOrWhiteSpace(cashInHandText.Text))
            {
                cashInHandErrorProvider.SetError(cashInHandText, "Cash in hand is required");
                return false;
            }

            // Check if the input is a valid positive number (allowing decimals)
            string cashPattern = @"^\d+(\.\d{1,2})?$";
            if (!Regex.IsMatch(cashInHandText.Text, cashPattern))
            {
                cashInHandErrorProvider.SetError(cashInHandText, "Please enter a valid positive number (e.g., 100 or 100.50)");
                return false;
            }

            // Ensure the amount is greater than 0
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

        private void posRegSaveBtn_Click(object sender, EventArgs e)
        {
            // Validate the cash-in-hand amount
            if (!ValidateCashInHand())
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proceed with saving to the cashbook table
            try
            {
                string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert the data into the cashbook table
                    string query = "INSERT INTO cashbook (username, useremail, cash_in_hand, date_time) " +
                                   "VALUES (@username, @useremail, @cashInHand, @dateTime)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", userName);
                        command.Parameters.AddWithValue("@useremail", userEmail);
                        command.Parameters.AddWithValue("@cashInHand", decimal.Parse(cashInHandText.Text));
                        command.Parameters.AddWithValue("@dateTime", DateTime.Now);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cash in hand saved successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Open the POS form and close the POSRegister form
                this.Hide();
                POS posForm = new POS();
                posForm.FormClosed += (s, args) => this.Close(); // Close POSRegister when POS form is closed
                posForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving to cashbook: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}