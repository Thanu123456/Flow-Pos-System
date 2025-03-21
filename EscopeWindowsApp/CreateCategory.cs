using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace EscopeWindowsApp
{
    public partial class CreateCategory : Form
    {
        private bool isEditMode = false;
        private int editCategoryId = -1;
        private ErrorProvider nameErrorProvider = new ErrorProvider();

        public CreateCategory(int categoryId = -1, string name = "", byte[] logo = null)
        {
            InitializeComponent();
            SetupErrorProviders();

            if (categoryId != -1)
            {
                isEditMode = true;
                editCategoryId = categoryId;
                this.Text = "Edit Category";
                creCategorySaveBtn.Text = "Update";
            }

            createCategoryNameText.Text = name;
            if (logo != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(logo))
                    {
                        creCategoryLogoBox.Image = Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading logo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            UpdateSaveButtonState();
        }

        private void SetupErrorProviders()
        {
            nameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void CreateCategory_Load(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private bool ValidateCategoryName()
        {
            if (string.IsNullOrWhiteSpace(createCategoryNameText.Text))
            {
                nameErrorProvider.SetError(createCategoryNameText, "Category name is required.");
                return false;
            }
            if (createCategoryNameText.Text.Length < 2)
            {
                nameErrorProvider.SetError(createCategoryNameText, "Category name must be at least 2 characters.");
                return false;
            }
            nameErrorProvider.SetError(createCategoryNameText, string.Empty);
            return true;
        }

        private void UpdateSaveButtonState()
        {
            creCategorySaveBtn.Enabled = ValidateCategoryName();
        }

        private void createCategoryNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateCategoryName();
            UpdateSaveButtonState();
        }

        private void creCategoryImgUploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Title = "Select Category Logo";
                    dialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
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
                            creCategoryLogoBox.Image.Save(ms, ImageFormat.Png);
                            imageBytes = ms.ToArray();
                        }
                    }

                    string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        if (isEditMode)
                        {
                            string query = "UPDATE categories SET name = @name, logo = @logo WHERE id = @categoryId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", createCategoryNameText.Text.Trim());
                                command.Parameters.AddWithValue("@logo", imageBytes ?? (object)DBNull.Value);
                                command.Parameters.AddWithValue("@categoryId", editCategoryId);
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected == 0)
                                {
                                    throw new Exception($"No category found with ID {editCategoryId} to update.");
                                }
                            }
                            MessageBox.Show("Category updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string query = "INSERT INTO categories (name, logo) VALUES (@name, @logo)";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", createCategoryNameText.Text.Trim());
                                command.Parameters.AddWithValue("@logo", imageBytes ?? (object)DBNull.Value);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Category created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show($"Error saving category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void creCategoryLogoBox_Click(object sender, EventArgs e)
        {
            // Optional: Uncomment to trigger image upload on click
            // creCategoryImgUploadBtn_Click(sender, e);
        }
    }
}