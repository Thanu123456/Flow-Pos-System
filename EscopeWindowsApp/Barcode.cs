using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class Barcode : Form
    {
        private Bitmap generatedBarcode; // Store the generated barcode image
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;"; // Same as other forms

        public Barcode()
        {
            InitializeComponent();
        }

        private void Barcode_Load(object sender, EventArgs e)
        {
            // Initialize the DataGridView columns on form load
            InitializeSerialNoDataGridView();
            // Load all serial numbers initially
            LoadSerialNumbers("");
        }

        private void InitializeSerialNoDataGridView()
        {
            serialNoDataGridView.Columns.Clear();
            serialNoDataGridView.Columns.Add("Count", "Count");
            serialNoDataGridView.Columns.Add("ProductID", "Product ID");
            serialNoDataGridView.Columns.Add("ProductName", "Product Name");
            serialNoDataGridView.Columns.Add("VariationType", "Variation Type");
            serialNoDataGridView.Columns.Add("SerialNumber", "Serial Number");
            serialNoDataGridView.Columns.Add("Date", "Date");
            serialNoDataGridView.AllowUserToAddRows = false; // Disable adding rows manually
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

            // Generate the barcode with higher resolution for better print and PDF quality
            generatedBarcode = GenerateBarcode(productId, productName);
            if (generatedBarcode != null)
            {
                // Display the barcode in the picture box
                barcodePictureBox.Image = generatedBarcode;
            }
        }

        private Bitmap GenerateBarcode(string productId, string productName)
        {
            try
            {
                // Barcode size in mm
                double barcodeWidthMm = 70; // 70 mm
                double barcodeHeightMm = 29.7; // 29.7 mm

                // Calculate pixel size at 300 DPI for high quality
                double pixelsPerMm = 300.0 / 25.4;
                int width = (int)(barcodeWidthMm * pixelsPerMm); // 70 mm at 300 DPI
                int height = (int)(barcodeHeightMm * pixelsPerMm); // 29.7 mm at 300 DPI

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
                int textHeight = (int)(20 * (300.0 / 72.0)); // 20 pixels at 72 DPI, scaled to 300 DPI
                var finalBitmap = new Bitmap(width, height + textHeight * 2); // Space for two lines of text
                using (var graphics = Graphics.FromImage(finalBitmap))
                {
                    graphics.Clear(System.Drawing.Color.White);
                    graphics.DrawImage(barcodeBitmap, 0, 0); // Draw the barcode

                    // Improve rendering quality
                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                    // Draw the product name and ID below the barcode with a font scaled for 300 DPI
                    float fontSize = 12 * (300.0f / 72.0f); // Scale font size from 72 DPI to 300 DPI
                    using (var font = new System.Drawing.Font("Arial", fontSize))
                    {
                        graphics.DrawString($"Product: {productName}", font, Brushes.Black, new PointF(10, height));
                        graphics.DrawString($"ID: {barcodeData}", font, Brushes.Black, new PointF(10, height + textHeight));
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
            if (generatedBarcode == null)
            {
                MessageBox.Show("Please generate a barcode first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(qtytextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var barcodeImages = new List<Bitmap>();
            for (int i = 0; i < quantity; i++)
            {
                barcodeImages.Add(new Bitmap(generatedBarcode));
            }

            PrintBarcodesOnA4(barcodeImages, true);
        }

        private void saveAsPdfBtn_Click(object sender, EventArgs e)
        {
            if (generatedBarcode == null)
            {
                MessageBox.Show("Please generate a barcode first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(qtytextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var barcodeImages = new List<Bitmap>();
            for (int i = 0; i < quantity; i++)
            {
                barcodeImages.Add(new Bitmap(generatedBarcode));
            }

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
                    printDocument.DefaultPageSettings.PrinterResolution = new System.Drawing.Printing.PrinterResolution
                    {
                        X = 300,
                        Y = 300
                    };

                    printDocument.PrintPage += (sender, e) =>
                    {
                        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                        e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                        float a4Width = 8.27f * 96;
                        float a4Height = 11.69f * 96;
                        float margin = 0.5f * 96;

                        float labelWidth = (a4Width - 2 * margin) / 3;
                        float labelHeight = (a4Height - 2 * margin) / 10;

                        int labelsPerRow = 3;
                        int labelsPerColumn = 10;
                        int totalLabelsPerPage = labelsPerRow * labelsPerColumn;

                        float pixelsPerMm = 96.0f / 25.4f;
                        float barcodeWidth = 70 * pixelsPerMm;
                        float barcodeHeight = 29.7f * pixelsPerMm + 20;

                        int currentImageIndex = 0;

                        for (int page = 0; currentImageIndex < barcodeImages.Count; page++)
                        {
                            float startX = margin;
                            float startY = margin;

                            for (int i = 0; i < totalLabelsPerPage && currentImageIndex < barcodeImages.Count; i++)
                            {
                                int row = i / labelsPerRow;
                                int col = i % labelsPerRow;

                                float x = startX + col * labelWidth;
                                float y = startY + row * labelHeight;

                                float xOffset = (labelWidth - barcodeWidth) / 2;
                                float yOffset = (labelHeight - barcodeHeight) / 2;
                                float drawX = x + xOffset;
                                float drawY = y + yOffset;

                                e.Graphics.DrawImage(barcodeImages[currentImageIndex], drawX, drawY, barcodeWidth, barcodeHeight);
                                currentImageIndex++;
                            }

                            e.HasMorePages = currentImageIndex < barcodeImages.Count;
                        }
                    };

                    if (showPreview)
                    {
                        using (var printPreviewDialog = new PrintPreviewDialog())
                        {
                            printPreviewDialog.Document = printDocument;
                            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                            {
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

            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.AddExtension = true;
                saveFileDialog.FileName = "Barcodes.pdf";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    using (var pdfDocument = new PdfDocument())
                    {
                        pdfDocument.Options.CompressContentStreams = true;
                        pdfDocument.Options.NoCompression = false;

                        double a4Width = 8.27 * 72;
                        double a4Height = 11.69 * 72;
                        double margin = 0.5 * 72;

                        double labelWidth = (a4Width - 2 * margin) / 3;
                        double labelHeight = (a4Height - 2 * margin) / 10;

                        int labelsPerRow = 3;
                        int labelsPerColumn = 10;
                        int totalLabelsPerPage = labelsPerRow * labelsPerColumn;

                        double pointsPerMm = 72.0 / 25.4;
                        double barcodeWidth = 70 * pointsPerMm;
                        double barcodeHeight = 29.7 * pointsPerMm + 20;

                        int currentImageIndex = 0;

                        while (currentImageIndex < barcodeImages.Count)
                        {
                            PdfPage page = pdfDocument.AddPage();
                            page.Width = a4Width;
                            page.Height = a4Height;

                            using (XGraphics gfx = XGraphics.FromPdfPage(page, XGraphicsUnit.Point))
                            {
                                double startX = margin;
                                double startY = margin;

                                for (int i = 0; i < totalLabelsPerPage && currentImageIndex < barcodeImages.Count; i++)
                                {
                                    int row = i / labelsPerRow;
                                    int col = i % labelsPerRow;

                                    double x = startX + col * labelWidth;
                                    double y = startY + row * labelHeight;

                                    double xOffset = (labelWidth - barcodeWidth) / 2;
                                    double yOffset = (labelHeight - barcodeHeight) / 2;
                                    double drawX = x + xOffset;
                                    double drawY = y + yOffset;

                                    using (var ms = new MemoryStream())
                                    {
                                        barcodeImages[currentImageIndex].Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                        ms.Position = 0;
                                        XImage xImage = XImage.FromStream(ms);
                                        gfx.DrawImage(xImage, drawX, drawY, barcodeWidth, barcodeHeight);
                                    }

                                    currentImageIndex++;
                                }
                            }
                        }

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
            barcodePictureBox.Image = null;
            generatedBarcode = null;
        }

        private void productNameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            // Optional: Add functionality if needed when the product name changes
        }

        private void productSearchText_TextChanged(object sender, EventArgs e)
        {
            // Search serial_numbers table by product name, product ID, or serial number
            string searchText = productSearchText.Text.Trim();
            LoadSerialNumbers(searchText);
        }

        private void LoadSerialNumbers(string searchText)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT product_id, product_name, variation_type, serial_number, created_at
                        FROM serial_numbers
                        WHERE product_name LIKE @searchText
                           OR product_id = @productId
                           OR serial_number LIKE @searchText
                        ORDER BY created_at DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@searchText", $"%{searchText}%");
                        cmd.Parameters.AddWithValue("@productId", int.TryParse(searchText, out int id) ? id : (object)DBNull.Value);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            serialNoDataGridView.Rows.Clear();
                            int count = 1;
                            while (reader.Read())
                            {
                                serialNoDataGridView.Rows.Add(
                                    count++.ToString(),
                                    reader["product_id"].ToString(),
                                    reader["product_name"].ToString(),
                                    reader["variation_type"]?.ToString() ?? "N/A",
                                    reader["serial_number"].ToString(),
                                    Convert.ToDateTime(reader["created_at"]).ToString("yyyy-MM-dd HH:mm:ss")
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading serial numbers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialNoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Auto-fill text boxes and copy serial number to clipboard when SerialNumber column is clicked
            if (e.RowIndex >= 0 && e.ColumnIndex == serialNoDataGridView.Columns["SerialNumber"].Index)
            {
                DataGridViewRow row = serialNoDataGridView.Rows[e.RowIndex];
                string serialNumber = row.Cells["SerialNumber"].Value?.ToString();
                string productName = row.Cells["ProductName"].Value?.ToString();

                if (!string.IsNullOrEmpty(serialNumber))
                {
                    // Auto-fill the text boxes
                    enterProIDtextBox.Text = serialNumber; // Set serial number in enterProIDtextBox
                    productNameTextBox.Text = productName ?? "Unknown Product"; // Set product name, default to "Unknown Product" if null

                    // Copy to clipboard (existing functionality)
                    Clipboard.SetText(serialNumber);
                    
                }
            }
        }
    }
}