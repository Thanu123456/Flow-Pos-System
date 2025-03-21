using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace EscopeWindowsApp
{
    public partial class CreateBrand : Form
    {
        private ErrorProvider brandNameErrorProvider = new ErrorProvider();

        public CreateBrand()
        {
            InitializeComponent();
            SetupErrorProviders();
        }

        private void SetupErrorProviders()
        {
            brandNameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void CreateBrand_Load(object sender, EventArgs e)
        {
        }

        private bool ValidateBrandName()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createBrandsNameText.Text);
            if (!isValid)
            {
                brandNameErrorProvider.SetError(createBrandsNameText, "Brand name is required.");
            }
            else if (createBrandsNameText.Text.Length < 2)
            {
                brandNameErrorProvider.SetError(createBrandsNameText, "Brand name must be at least 2 characters.");
                isValid = false;
            }
            else
            {
                brandNameErrorProvider.SetError(createBrandsNameText, string.Empty);
            }
            return isValid;
        }

        private void createBrandsNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateBrandName();
        }

        private void creBrandImgUploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Title = "Select Image";
                    dialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;)|*.jpg;*.jpeg;*.png;*.bmp;|All Files (*.*)|*.*";
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

                    string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO brands (name, logo) VALUES (@name, @logo)";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@name", createBrandsNameText.Text.Trim());
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

                    MessageBox.Show("Brand created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating brand: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void creBrandsCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Remove unused methods
        private void creBrandsLogoBox_Click(object sender, EventArgs e)
        {
            // This method is redundant since creBrandImgUploadBtn_Click handles image upload
        }

        private void creBrandsLogoBox_Click_1(object sender, EventArgs e)
        {
            // This method is empty and can be removed
        }
    }
}