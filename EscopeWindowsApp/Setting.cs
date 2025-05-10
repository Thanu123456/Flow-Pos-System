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
using System.Configuration;

namespace EscopeWindowsApp
{
    public partial class Setting : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private ErrorProvider nameErrorProvider = new ErrorProvider();
        private ErrorProvider emailErrorProvider = new ErrorProvider();
        private ErrorProvider phoneErrorProvider = new ErrorProvider();

        // Store initial values to track changes
        private string initialName;
        private string initialEmail;
        private string initialPhoneNumber;
        private string initialAddress;
        private byte[] initialLogoBytes;
        private bool logoChanged;

        public Setting()
        {
            InitializeComponent();
            SetupErrorProviders();
            setLogoBox.SizeMode = PictureBoxSizeMode.CenterImage; // Prevent stretching in PictureBox
            // Restrict phone number input
            setPhoneNotext.KeyPress += setPhoneNotext_KeyPress;
            // Set Enter key to trigger save button
            this.AcceptButton = setSaveBtn;
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
            // Store initial values after loading
            initialName = settingNameText.Text;
            initialEmail = setEmailText.Text;
            initialPhoneNumber = setPhoneNotext.Text;
            initialAddress = setAddressText.Text;
            initialLogoBytes = GetImageBytes(setLogoBox.Image);
            logoChanged = false;
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

            // Split input by '/' to handle two phone numbers
            string[] phoneNumbers = setPhoneNotext.Text.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            if (phoneNumbers.Length > 2)
            {
                phoneErrorProvider.SetError(setPhoneNotext, "Please enter up to two phone numbers separated by '/'.");
                return false;
            }

            // Regex pattern for a single phone number (digits only)
            string phonePattern = @"^\d+$";
            foreach (string phone in phoneNumbers)
            {
                if (!Regex.IsMatch(phone.Trim(), phonePattern))
                {
                    phoneErrorProvider.SetError(setPhoneNotext, "Each phone number must contain only digits.");
                    return false;
                }
            }

            phoneErrorProvider.SetError(setPhoneNotext, string.Empty);
            return true;
        }

        private bool HasChanges()
        {
            // Check if text fields have changed
            bool textChanged = settingNameText.Text != initialName ||
                              setEmailText.Text != initialEmail ||
                              setPhoneNotext.Text != initialPhoneNumber ||
                              setAddressText.Text != initialAddress;

            // Check if logo has changed
            bool logoModified = logoChanged;

            return textChanged || logoModified;
        }

        private byte[] GetImageBytes(Image image)
        {
            if (image == null)
                return null;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void UpdateSaveButtonState()
        {
            setSaveBtn.Enabled = ValidateCompanyName() && ValidateEmail() && ValidatePhoneNumber() && HasChanges();
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

        private void setPhoneNotext_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits and '/' only, plus control keys (e.g., Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent non-numeric and non-/ characters
            }
            // Prevent multiple '/' characters
            if (e.KeyChar == '/' && setPhoneNotext.Text.Contains('/'))
            {
                e.Handled = true;
            }
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
                            setLogoBox.Image?.Dispose(); // Dispose of previous image to prevent memory leaks
                            setLogoBox.Image = resizedImage;
                            logoChanged = true; // Mark logo as changed
                            UpdateSaveButtonState();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image ResizeImage(Image image, int maxWidth, int maxHeight)
        {
            // Calculate the aspect ratio
            double aspectRatio = (double)image.Width / image.Height;
            int newWidth, newHeight;

            // Determine new dimensions while preserving aspect ratio
            if (image.Width > image.Height)
            {
                newWidth = maxWidth;
                newHeight = (int)(maxWidth / aspectRatio);
                if (newHeight > maxHeight)
                {
                    newHeight = maxHeight;
                    newWidth = (int)(maxHeight * aspectRatio);
                }
            }
            else
            {
                newHeight = maxHeight;
                newWidth = (int)(maxHeight * aspectRatio);
                if (newWidth > maxWidth)
                {
                    newWidth = maxWidth;
                    newHeight = (int)(maxWidth / aspectRatio);
                }
            }

            // Create a new bitmap with the calculated dimensions
            Bitmap resizedBitmap = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(resizedBitmap))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
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
                    // Update initial values after saving
                    initialName = settingNameText.Text;
                    initialEmail = setEmailText.Text;
                    initialPhoneNumber = setPhoneNotext.Text;
                    initialAddress = setAddressText.Text;
                    initialLogoBytes = GetImageBytes(setLogoBox.Image);
                    logoChanged = false;
                    UpdateSaveButtonState();
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