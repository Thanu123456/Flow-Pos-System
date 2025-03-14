﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class CreateBrand : Form
    {
        // Error providers for validation
        private ErrorProvider brandNameErrorProvider = new ErrorProvider();
        private ErrorProvider brandLogoErrorProvider = new ErrorProvider();

        // Variable to hold the selected brand logo image path
        private string brandLogoPath = string.Empty;

        public CreateBrand()
        {
            InitializeComponent();
            SetupErrorProviders();
        }

        private void SetupErrorProviders()
        {
            brandNameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            brandLogoErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void CreateBrand_Load(object sender, EventArgs e)
        {
            // Initialization code here if needed
        }

        private void createBrandsNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateBrandName();
        }

        private bool ValidateBrandName()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createBrandsNameText.Text);
            if (!isValid)
            {
                brandNameErrorProvider.SetError(createBrandsNameText, "Brand name is required.");
            }
            else
            {
                brandNameErrorProvider.SetError(createBrandsNameText, string.Empty);
            }
            return isValid;
        }

        private void creBrandsLogoBox_Click(object sender, EventArgs e)
        {
            // Open file dialog to select the brand logo (only .jpg files allowed)
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JPEG files (*.jpg)|*.jpg",
                Title = "Select Brand Logo"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                brandLogoPath = openFileDialog.FileName;
                // Display the selected image in the PictureBox
                creBrandsLogoBox.Image = Image.FromFile(brandLogoPath);
                brandLogoErrorProvider.SetError(creBrandsLogoBox, string.Empty);
            }
        }

        private bool ValidateBrandLogo()
        {
            bool isValid = !string.IsNullOrEmpty(brandLogoPath);
            if (!isValid)
            {
                brandLogoErrorProvider.SetError(creBrandsLogoBox, "Brand logo is required.");
            }
            else
            {
                brandLogoErrorProvider.SetError(creBrandsLogoBox, string.Empty);
            }
            return isValid;
        }

        private void creBrandsSaveBtn_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateBrandName() & ValidateBrandLogo();

            if (isValid)
            {
                // Save the brand to the database
                // Add your code to save the brand here
                MessageBox.Show("Brand created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
      }
}
