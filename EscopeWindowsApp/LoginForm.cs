using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Linq.Expressions;

namespace EscopeWindowsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginUserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginPasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginForgotPasswordlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void loginToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            ////string email = loginUserNameTextBox.Text.Trim();
            ////string password = loginPasswordTextbox.Text;

            ////if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            ////{
            ////    MessageBox.Show("Please enter both email and password.");
            ////    return;
            ////}

            ////string connectionString = "server=localhost;port=3306;database=your_database;uid=your_username;pwd=your_password;";

            ////using (MySqlConnection connection = new MySqlConnection(connectionString))
            ////{
            ////    try
            ////    {
            ////        connection.Open();

            ////        // Use a parameterized query to prevent SQL injection attacks
            ////        string query = "SELECT COUNT(*) FROM users WHERE email = @Email AND password = @Password";
            ////        using (MySqlCommand command = new MySqlCommand(query, connection))
            ////        {
            ////            command.Parameters.AddWithValue("@Email", email);
            ////            command.Parameters.AddWithValue("@Password", password);

            ////            int userCount = Convert.ToInt32(command.ExecuteScalar());

            ////            if (userCount > 0)
            ////            {
            ////                MessageBox.Show("Login successful!");

            ////                // Open the main application form and hide the login form
            ////                MainForm mainForm = new MainForm();
            ////                mainForm.Show();
            ////                this.Hide();
            ////            }
            ////            else
            ////            {
            ////                MessageBox.Show("Invalid email or password!");
            ////            }
            ////        }
            ////    }
            ////    catch (Exception ex)
            ////    {
            ////        MessageBox.Show("An error occurred: " + ex.Message);
            ////    }
            ////    finally
            ////    {
            ////        connection.Close();
            ////    }
            //}
        }
    }
}
