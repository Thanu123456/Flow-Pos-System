using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace EscopeWindowsApp
{
    public partial class Setting : Form
    {
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
        private ErrorProvider nameErrorProvider = new ErrorProvider();
        private ErrorProvider emailErrorProvider = new ErrorProvider();
        private ErrorProvider phoneErrorProvider = new ErrorProvider();

        public Setting()
        {
            InitializeComponent();
            SetupErrorProviders();
        }

        private void SetupErrorProviders()
        {
            nameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            emailErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            phoneErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            LoadCompanyDetails();
            UpdateSaveButtonState();
        }

        private void LoadCompanyDetails()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT name, email, phone_number, address, logo FROM company_details WHERE id = 1";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                settingNameText.Text = reader["name"]?.ToString() ?? "";
                                setEmailText.Text = reader["email"]?.ToString() ?? "";
                                setPhoneNotext.Text = reader["phone_number"]?.ToString() ?? "";
                                setAddressText.Text = reader["address"]?.ToString() ?? "";

                                if (!reader.IsDBNull(reader.GetOrdinal("logo")))
                                {
                                    byte[] logoBytes = (byte[])reader["logo"];
                                    using (MemoryStream ms = new MemoryStream(logoBytes))
                                    {
                                        setLogoBox.Image = Image.FromStream(ms);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading company details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateCompanyName()
        {
            if (string.IsNullOrWhiteSpace(settingNameText.Text))
            {
                nameErrorProvider.SetError(settingNameText, "Company name is required.");
                return false;
            }
            if (settingNameText.Text.Length < 2)
            {
                nameErrorProvider.SetError(settingNameText, "Company name must be at least 2 characters.");
                return false;
            }
            nameErrorProvider.SetError(settingNameText, string.Empty);
            return true;
        }

        private bool ValidateEmail()
        {
            if (string.IsNullOrWhiteSpace(setEmailText.Text))
            {
                emailErrorProvider.SetError(setEmailText, "Email is required.");
                return false;
            }
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(setEmailText.Text, emailPattern))
            {
                emailErrorProvider.SetError(setEmailText, "Please enter a valid email address.");
                return false;
            }
            emailErrorProvider.SetError(setEmailText, string.Empty);
            return true;
        }

        private bool ValidatePhoneNumber()
        {
            if (string.IsNullOrWhiteSpace(setPhoneNotext.Text))
            {
                phoneErrorProvider.SetError(setPhoneNotext, string.Empty);
                return true; // Phone number is optional
            }
            string phonePattern = @"^\+?\d{1,4}?[-.\s]?\(?\d{1,3}?\)?[-.\s]?\d{1,4}[-.\s]?\d{1,4}[-.\s]?\d{1,9}$";
            if (!Regex.IsMatch(setPhoneNotext.Text, phonePattern))
            {
                phoneErrorProvider.SetError(setPhoneNotext, "Please enter a valid phone number.");
                return false;
            }
            phoneErrorProvider.SetError(setPhoneNotext, string.Empty);
            return true;
        }

        private void UpdateSaveButtonState()
        {
            setSaveBtn.Enabled = ValidateCompanyName() && ValidateEmail() && ValidatePhoneNumber();
        }

        private void settingNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateCompanyName();
            UpdateSaveButtonState();
        }

        private void setEmailText_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail();
            UpdateSaveButtonState();
        }

        private void setPhoneNotext_TextChanged(object sender, EventArgs e)
        {
            ValidatePhoneNumber();
            UpdateSaveButtonState();
        }

        private void setAddressText_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private void setLogoBox_Click(object sender, EventArgs e)
        {
            setImgUploadBtn_Click(sender, e);
        }

        private void setImgUploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Title = "Select Company Logo";
                    dialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
                    dialog.FilterIndex = 1;
                    dialog.RestoreDirectory = true;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (Image originalImage = Image.FromFile(dialog.FileName))
                        {
                            Image resizedImage = ResizeImage(originalImage, setLogoBox.Width, setLogoBox.Height);
                            setLogoBox.Image = resizedImage;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedBitmap = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedBitmap))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedBitmap;
        }

        private void setSaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateCompanyName() && ValidateEmail() && ValidatePhoneNumber())
            {
                try
                {
                    byte[] imageBytes = null;
                    if (setLogoBox.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            setLogoBox.Image.Save(ms, ImageFormat.Png);
                            imageBytes = ms.ToArray();
                        }
                    }

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Check if a record exists
                        string checkQuery = "SELECT COUNT(*) FROM company_details WHERE id = 1";
                        using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                        {
                            long count = (long)checkCommand.ExecuteScalar();
                            if (count > 0)
                            {
                                // Update existing record
                                string updateQuery = @"
                                    UPDATE company_details 
                                    SET name = @name, email = @email, phone_number = @phone_number, 
                                        address = @address, logo = @logo 
                                    WHERE id = 1";
                                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@name", settingNameText.Text.Trim());
                                    command.Parameters.AddWithValue("@email", setEmailText.Text.Trim());
                                    command.Parameters.AddWithValue("@phone_number", setPhoneNotext.Text.Trim() ?? (object)DBNull.Value);
                                    command.Parameters.AddWithValue("@address", setAddressText.Text.Trim() ?? (object)DBNull.Value);
                                    command.Parameters.AddWithValue("@logo", imageBytes ?? (object)DBNull.Value);
                                    command.ExecuteNonQuery();
                                }
                                MessageBox.Show("Company details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // Insert new record
                                string insertQuery = @"
                                    INSERT INTO company_details (id, name, email, phone_number, address, logo) 
                                    VALUES (1, @name, @email, @phone_number, @address, @logo)";
                                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@name", settingNameText.Text.Trim());
                                    command.Parameters.AddWithValue("@email", setEmailText.Text.Trim());
                                    command.Parameters.AddWithValue("@phone_number", setPhoneNotext.Text.Trim() ?? (object)DBNull.Value);
                                    command.Parameters.AddWithValue("@address", setAddressText.Text.Trim() ?? (object)DBNull.Value);
                                    command.Parameters.AddWithValue("@logo", imageBytes ?? (object)DBNull.Value);
                                    command.ExecuteNonQuery();
                                }
                                MessageBox.Show("Company details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    this.Close();
                }
                catch (MySqlException myEx)
                {
                    MessageBox.Show($"Database error: {myEx.Message}\nError Code: {myEx.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving company details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void setPanel_Paint(object sender, PaintEventArgs e)
        {
            // Not implemented as per the original code
        }
    }
}