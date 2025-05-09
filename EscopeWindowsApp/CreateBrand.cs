using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Configuration;

namespace EscopeWindowsApp
{
    public partial class CreateBrand : Form
    {
        private bool isEditMode = false;
        private int editBrandId = -1;

        // Error providers for validation
        private ErrorProvider nameErrorProvider = new ErrorProvider();

        public CreateBrand(int brandId = -1, string name = "", byte[] logo = null)
        {
            InitializeComponent();
            SetupErrorProviders();

            if (brandId != -1)
            {
                isEditMode = true;
                editBrandId = brandId;
                this.Text = "Edit Brand";
                creBrandsSaveBtn.Text = "Update";
            }

            // Pre-fill form fields
            createBrandsNameText.Text = name;
            if (logo != null)
            {
                using (MemoryStream ms = new MemoryStream(logo))
                {
                    creBrandsLogoBox.Image = Image.FromStream(ms);
                }
            }

            UpdateSaveButtonState();

            // Enable key preview to capture keyboard events at the form level
            this.KeyPreview = true;
            this.KeyDown += CreateBrand_KeyDown;
        }

        private void CreateBrand_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle Enter key to trigger Save button
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
                creBrandsSaveBtn.PerformClick();
            }
            // Handle Escape key to trigger Cancel button
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
                creBrandsCancelBtn.PerformClick();
            }
        }

        private void SetupErrorProviders()
        {
            nameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void CreateBrand_Load(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private bool ValidateBrandName()
        {
            if (string.IsNullOrWhiteSpace(createBrandsNameText.Text))
            {
                nameErrorProvider.SetError(createBrandsNameText, "Brand name is required.");
                return false;
            }
            if (createBrandsNameText.Text.Length < 2)
            {
                nameErrorProvider.SetError(createBrandsNameText, "Brand name must be at least 2 characters.");
                return false;
            }
            nameErrorProvider.SetError(createBrandsNameText, string.Empty);
            return true;
        }

        private void UpdateSaveButtonState()
        {
            creBrandsSaveBtn.Enabled = ValidateBrandName();
        }

        private void createBrandsNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateBrandName();
            UpdateSaveButtonState();
        }

        private void creBrandImgUploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Title = "Select Brand Logo";
                    dialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
                    dialog.FilterIndex = 1;
                    dialog.RestoreDirectory = true;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (Image originalImage = Image.FromFile(dialog.FileName))
                        {
                            Image resizedImage = ResizeImage(originalImage, creBrandsLogoBox.Width, creBrandsLogoBox.Height);
                            creBrandsLogoBox.Image = resizedImage;
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

        private void creBrandsSaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateBrandName())
            {
                try
                {
                    byte[] imageBytes = null;
                    if (creBrandsLogoBox.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            creBrandsLogoBox.Image.Save(ms, ImageFormat.Png);
                            imageBytes = ms.ToArray();
                        }
                    }

                    string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        if (isEditMode)
                        {
                            string query = "UPDATE brands SET name = @name, logo = @logo WHERE id = @brandId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", createBrandsNameText.Text.Trim());
                                command.Parameters.AddWithValue("@logo", imageBytes ?? (object)DBNull.Value);
                                command.Parameters.AddWithValue("@brandId", editBrandId);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Brand updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string query = "INSERT INTO brands (name, logo) VALUES (@name, @logo)";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", createBrandsNameText.Text.Trim());
                                command.Parameters.AddWithValue("@logo", imageBytes ?? (object)DBNull.Value);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Brand created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving brand: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void creBrandsLogoBox_Click_1(object sender, EventArgs e)
        {
            // This method is empty and can be removed
        }

        private void creBrandsCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}