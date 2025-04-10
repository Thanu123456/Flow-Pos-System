using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; // For System.Drawing.Color and System.Drawing.Font
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System.IO;

namespace EscopeWindowsApp
{
    public partial class Barcode : Form
    {
        private Bitmap generatedBarcode; // Store the generated barcode image

        public Barcode()
        {
            InitializeComponent();
        }

        private void Barcode_Load(object sender, EventArgs e)
        {
            // Initialize form controls if needed
        }

        private void enterProIDtextBox_TextChanged(object sender, EventArgs e)
        {
            // Clear the barcode picture box if the product ID changes
            barcodePictureBox.Image = null;
            generatedBarcode = null;
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            // Validate the product ID
            string productId = enterProIDtextBox.Text.Trim();
            if (string.IsNullOrEmpty(productId))
            {
                MessageBox.Show("Please enter a product ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the product name
            string productName = productNameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(productName))
            {
                productName = "Unknown Product"; // Default name if not provided
            }

            // Generate the barcode
            generatedBarcode = GenerateBarcode(productId, productName);
            if (generatedBarcode != null)
            {
                // Display the barcode in the picture box
                barcodePictureBox.Image = generatedBarcode;
            }
        }

        private Bitmap GenerateBarcode(string productId, string productName, int width = 200, int height = 80)
        {
            try
            {
                // Initialize the barcode writer
                var barcodeWriter = new BarcodeWriter
                {
                    Format = BarcodeFormat.CODE_128, // Use Code 128 for product barcodes
                    Options = new ZXing.Common.EncodingOptions
                    {
                        Width = width,
                        Height = height,
                        Margin = 10 // Margin around the barcode
                    }
                };

                // Encode the product ID
                string barcodeData = $"PRO{productId:D3}"; // Format like "PRO001"

                // Generate the barcode image
                var barcodeBitmap = barcodeWriter.Write(barcodeData);

                // Create a new bitmap to include the product name and ID below the barcode
                var finalBitmap = new Bitmap(width, height + 40); // Add space for two lines of text
                using (var graphics = Graphics.FromImage(finalBitmap))
                {
                    graphics.Clear(System.Drawing.Color.White); // Use System.Drawing.Color
                    graphics.DrawImage(barcodeBitmap, 0, 0); // Draw the barcode

                    // Draw the product name and ID below the barcode
                    using (var font = new System.Drawing.Font("Arial", 8)) // Use System.Drawing.Font
                    {
                        graphics.DrawString($"Product: {productName}", font, Brushes.Black, new PointF(10, height));
                        graphics.DrawString($"ID: {barcodeData}", font, Brushes.Black, new PointF(10, height + 20));
                    }
                }

                return finalBitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating barcode: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void barcodePictureBox_Click(object sender, EventArgs e)
        {
            // Optional: Add functionality if the user clicks the barcode picture box
        }

        private void qtytextBox_TextChanged(object sender, EventArgs e)
        {
            // Validate the quantity input
            if (!int.TryParse(qtytextBox.Text, out int quantity) || quantity <= 0)
            {
                qtytextBox.Text = "1"; // Default to 1 if invalid
            }
            else if (quantity > 100) // Arbitrary upper limit to prevent excessive printing
            {
                qtytextBox.Text = "100";
                MessageBox.Show("Maximum quantity is 100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            // Check if a barcode has been generated
            if (generatedBarcode == null)
            {
                MessageBox.Show("Please generate a barcode first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate the quantity
            if (!int.TryParse(qtytextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a list of barcode images based on the quantity
            var barcodeImages = new List<Bitmap>();
            for (int i = 0; i < quantity; i++)
            {
                // Clone the generated barcode for each instance
                barcodeImages.Add(new Bitmap(generatedBarcode));
            }

            // Show print preview and print
            PrintBarcodesOnA4(barcodeImages, true);
        }

        private void saveAsPdfBtn_Click(object sender, EventArgs e)
        {
            // Check if a barcode has been generated
            if (generatedBarcode == null)
            {
                MessageBox.Show("Please generate a barcode first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate the quantity
            if (!int.TryParse(qtytextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a list of barcode images based on the quantity
            var barcodeImages = new List<Bitmap>();
            for (int i = 0; i < quantity; i++)
            {
                // Clone the generated barcode for each instance
                barcodeImages.Add(new Bitmap(generatedBarcode));
            }

            // Save as PDF using PDFsharp-MigraDoc
            SaveBarcodesAsPDF(barcodeImages);
        }

        private void PrintBarcodesOnA4(List<Bitmap> barcodeImages, bool showPreview = false)
        {
            if (barcodeImages == null || barcodeImages.Count == 0)
            {
                MessageBox.Show("No barcodes to print.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var printDocument = new System.Drawing.Printing.PrintDocument())
                {
                    printDocument.PrintPage += (sender, e) =>
                    {
                        // A4 dimensions in pixels (1 inch = 96 pixels at 96 DPI)
                        float a4Width = 8.27f * 96;  // 793 pixels
                        float a4Height = 11.69f * 96; // 1122 pixels
                        float margin = 0.5f * 96; // 0.5 inch margin on all sides

                        // Label dimensions (adjust to fit 30 barcodes per page: 5 rows x 6 columns)
                        float labelWidth = (a4Width - 2 * margin) / 6; // 6 columns
                        float labelHeight = (a4Height - 2 * margin) / 5; // 5 rows

                        // Calculate number of labels per row and column
                        int labelsPerRow = 6; // 6 labels per row
                        int labelsPerColumn = 5; // 5 labels per column
                        int totalLabelsPerPage = labelsPerRow * labelsPerColumn; // 30 labels per page

                        int currentImageIndex = 0;

                        // Loop through pages
                        for (int page = 0; currentImageIndex < barcodeImages.Count; page++)
                        {
                            // Start position for the first label on the page
                            float startX = margin;
                            float startY = margin;

                            // Draw labels for the current page
                            for (int i = 0; i < totalLabelsPerPage && currentImageIndex < barcodeImages.Count; i++)
                            {
                                int row = i / labelsPerRow;
                                int col = i % labelsPerRow;

                                // Calculate position of the current label
                                float x = startX + col * labelWidth;
                                float y = startY + row * labelHeight;

                                // Draw the barcode image, scaling it to fit the label
                                e.Graphics.DrawImage(barcodeImages[currentImageIndex], x, y, labelWidth - 10, labelHeight - 10);

                                currentImageIndex++;
                            }

                            // Indicate if there are more pages to print
                            e.HasMorePages = currentImageIndex < barcodeImages.Count;
                        }
                    };

                    if (showPreview)
                    {
                        // Show print preview
                        using (var printPreviewDialog = new PrintPreviewDialog())
                        {
                            printPreviewDialog.Document = printDocument;
                            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                            {
                                // Show print dialog after preview
                                using (var printDialog = new PrintDialog())
                                {
                                    printDialog.Document = printDocument;
                                    if (printDialog.ShowDialog() == DialogResult.OK)
                                    {
                                        printDocument.Print();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        // Show print dialog directly
                        using (var printDialog = new PrintDialog())
                        {
                            printDialog.Document = printDocument;
                            if (printDialog.ShowDialog() == DialogResult.OK)
                            {
                                printDocument.Print();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error printing barcodes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Dispose of the barcode images to free memory
                foreach (var bitmap in barcodeImages)
                {
                    bitmap?.Dispose();
                }
            }
        }

        private void SaveBarcodesAsPDF(List<Bitmap> barcodeImages)
        {
            if (barcodeImages == null || barcodeImages.Count == 0)
            {
                MessageBox.Show("No barcodes to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show save file dialog
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (.pdf)|.pdf";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.AddExtension = true;
                saveFileDialog.FileName = "Barcodes.pdf";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    // Create a new PDF document using PDFsharp
                    using (var pdfDocument = new PdfDocument())
                    {
                        // A4 dimensions in points (1 point = 1/72 inch)
                        double a4Width = 8.27 * 72; // 595 points
                        double a4Height = 11.69 * 72; // 842 points
                        double margin = 0.5 * 72; // 0.5 inch margin in points

                        // Label dimensions (adjust to fit 30 barcodes per page: 5 rows x 6 columns)
                        double labelWidth = (a4Width - 2 * margin) / 6; // 6 columns
                        double labelHeight = (a4Height - 2 * margin) / 5; // 5 rows

                        // Calculate number of labels per row and column
                        int labelsPerRow = 6; // 6 labels per row
                        int labelsPerColumn = 5; // 5 labels per column
                        int totalLabelsPerPage = labelsPerRow * labelsPerColumn; // 30 labels per page

                        int currentImageIndex = 0;

                        // Loop through pages
                        while (currentImageIndex < barcodeImages.Count)
                        {
                            // Add a new page
                            PdfPage page = pdfDocument.AddPage();
                            page.Width = a4Width;
                            page.Height = a4Height;

                            using (XGraphics gfx = XGraphics.FromPdfPage(page))
                            {
                                // Start position for the first label on the page
                                double startX = margin;
                                double startY = margin;

                                // Draw labels for the current page
                                for (int i = 0; i < totalLabelsPerPage && currentImageIndex < barcodeImages.Count; i++)
                                {
                                    int row = i / labelsPerRow;
                                    int col = i % labelsPerRow;

                                    // Calculate position of the current label
                                    double x = startX + col * labelWidth;
                                    double y = startY + row * labelHeight;

                                    // Convert Bitmap to XImage
                                    using (var ms = new MemoryStream())
                                    {
                                        barcodeImages[currentImageIndex].Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                        ms.Position = 0; // Reset the stream position to the beginning
                                        XImage xImage = XImage.FromStream(ms);
                                        gfx.DrawImage(xImage, x, y, labelWidth - 10, labelHeight - 10);
                                    }

                                    currentImageIndex++;
                                }
                            }
                        }

                        // Save the PDF document
                        pdfDocument.Save(saveFileDialog.FileName);
                    }

                    MessageBox.Show("PDF saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Dispose of the barcode images to free memory
                    foreach (var bitmap in barcodeImages)
                    {
                        bitmap?.Dispose();
                    }
                }
            }
        }

        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add functionality if needed when product name changes
        }

        private void enterProIDtextBox_TextChanged_1(object sender, EventArgs e)
        {
            // Clear the barcode picture box if the product ID changes
            barcodePictureBox.Image = null;
            generatedBarcode = null;
        }

        private void productNameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            // Optional: Add functionality if needed when product name changes
        }
    }
}