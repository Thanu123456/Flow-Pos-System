using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging; // Added namespace for ImageFormat

namespace EscopeWindowsApp
{
    public partial class CreateCategory : Form
    {
        private ErrorProvider nameErrorProvider = new ErrorProvider();

        public CreateCategory()
        {
            InitializeComponent();
            SetupErrorProviders();
        }

        private void SetupErrorProviders()
        {
            nameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void CreateCategory_Load(object sender, EventArgs e)
        {
        }

        private bool ValidateCategoryName()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createCategoryNameText.Text);
            if (!isValid)
            {
                nameErrorProvider.SetError(createCategoryNameText, "Category name is required.");
            }
            else if (createCategoryNameText.Text.Length < 2)
            {
                nameErrorProvider.SetError(createCategoryNameText, "Category name must be at least 2 characters.");
                isValid = false;
            }
            else
            {
                nameErrorProvider.SetError(createCategoryNameText, string.Empty);
            }
            return isValid;
        }

        private void createCategoryNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateCategoryName();
        }

        private void creCategoryImgUploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Title = "Select Image";
                    dialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files (*.*)|*.*";
                    dialog.FilterIndex = 1;
                    dialog.RestoreDirectory = true;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (Image originalImage = Image.FromFile(dialog.FileName))
                        {
                            Image resizedImage = ResizeImage(originalImage, creCategoryLogoBox.Width, creCategoryLogoBox.Height);
                            creCategoryLogoBox.Image = resizedImage;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void creCategorySaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateCategoryName())
            {
                try
                {
                    byte[] imageBytes = null;
                    if (creCategoryLogoBox.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            // Explicitly specify PNG format instead of using RawFormat
                            creCategoryLogoBox.Image.Save(ms, ImageFormat.Png);
                            imageBytes = ms.ToArray();
                        }
                    }

                    string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO categories (name, logo) VALUES (@name, @logo)";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@name", createCategoryNameText.Text.Trim());
                            if (imageBytes != null)
                            {
                                command.Parameters.AddWithValue("@logo", imageBytes);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@logo", DBNull.Value);
                            }
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Category created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void creCategoryCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}