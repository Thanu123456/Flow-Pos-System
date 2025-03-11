using System;
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
    public partial class CreateCategory : Form
    {
        public CreateCategory()
        {
            InitializeComponent();
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
    }
 }
