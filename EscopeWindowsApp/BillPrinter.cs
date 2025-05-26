using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using MySql.Data.MySqlClient;
using ZXing;
using ZXing.Common;

namespace EscopeWindowsApp
{
    public class BillPrinter
    {
        public class CartItem
        {
            public int ItemNumber { get; set; }
            public string ProductName { get; set; }
            public string VariationType { get; set; }
            public string Unit { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal TotalPrice { get; set; }
        }

        private class CompanyDetails
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public byte[] Logo { get; set; }
        }

        private static CompanyDetails LoadCompanyDetails()
        {
            string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
            CompanyDetails details = new CompanyDetails
            {
                Name = "SEVEN SUPER CITY (PVT) LTD.",
                Address = "NO.250, ANGURUWATHOTA ROAD, HORANA",
                PhoneNumber = "034 2 261511",
                Email = "Not Available"
            };

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
                                details.Name = reader["name"]?.ToString() ?? "SEVEN SUPER CITY (PVT) LTD.";
                                details.Email = reader["email"]?.ToString() ?? "Not Available";
                                details.PhoneNumber = reader["phone_number"]?.ToString() ?? "034 2 261511";
                                details.Address = reader["address"]?.ToString() ?? "NO.250, ANGURUWATHOTA ROAD, HORANA";
                                if (!reader.IsDBNull(reader.GetOrdinal("logo")))
                                {
                                    details.Logo = (byte[])reader["logo"];
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

            return details;
        }

        public static void PrintBill(string billNo, string customerName, string userName, int totalItems, string paymentMethod, decimal totalPrice, decimal discount, decimal cashPaid, decimal balance, List<CartItem> cartItems, bool isCardPayment)
        {
            string receiptPath = GenerateProfessionalBillPDF(billNo, customerName, userName, totalItems, paymentMethod, totalPrice, discount, cashPaid, balance, cartItems);
            PrintPDF(receiptPath);
        }

        private static string GenerateBarcodeImage(string billNo)
        {
            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Height = 50,
                    Width = 200,
                    PureBarcode = true // This prevents text from being displayed below the barcode
                }
            };
            using (Bitmap bitmap = writer.Write(billNo))
            {
                string tempPath = Path.Combine(Path.GetTempPath(), $"barcode_{Guid.NewGuid()}.png");
                bitmap.Save(tempPath, ImageFormat.Png);
                return tempPath;
            }
        }

        private static string GenerateProfessionalBillPDF(string billNo, string customerName, string userName, int totalItems, string paymentMethod, decimal totalPrice, decimal discount, decimal cashPaid, decimal balance, List<CartItem> cartItems)
        {
            string pdfPath = Path.Combine(Environment.CurrentDirectory, $"{billNo}_receipt.pdf");
            List<string> tempFiles = new List<string>();

            Document document = new Document();
            Section section = document.AddSection();

            // Set terminal size (80mm width) - Professional thermal receipt size
            section.PageSetup.PageWidth = Unit.FromMillimeter(80);
            section.PageSetup.LeftMargin = Unit.FromMillimeter(3);
            section.PageSetup.RightMargin = Unit.FromMillimeter(3);
            section.PageSetup.TopMargin = Unit.FromMillimeter(5);
            section.PageSetup.BottomMargin = Unit.FromMillimeter(5);

            // Calculate dynamic height based on content
            int itemCount = cartItems.Count;
            double baseHeight = 66; // Header (logo, company details, bill details)
            double bottomSpace = 50; // Summary, barcode, footer, buffer
            if (paymentMethod == "Cash") baseHeight += 5; // Add 5 mm for cash payment rows

            double totalHeight;

            if (itemCount == 0)
            {
                totalHeight = baseHeight + bottomSpace; // No items
            }
            else if (itemCount >= 1 && itemCount <= 5)
            {
                totalHeight = 150 + (10 * (itemCount - 1)); // 150 mm for 1 item, 170 mm for 3 items, 190 mm for 5 items
            }
            else if (itemCount > 5 && itemCount <= 10)
            {
                totalHeight = 190 + (5 * (itemCount - 5)); // 190 mm for 5 items, 215 mm for 10 items
            }
            else if (itemCount > 10 && itemCount <= 15)
            {
                totalHeight = 215 + (5 * (itemCount - 10)); // 215 mm for 10 items, 240 mm for 15 items
            }
            else if (itemCount > 15 && itemCount <= 20)
            {
                totalHeight = 240 + (5 * (itemCount - 15)); // 240 mm for 15 items, 265 mm for 20 items
            }
            else if (itemCount > 20 && itemCount <= 30)
            {
                totalHeight = 265 + (10 * (itemCount - 20) / 2); // 265 mm for 20 items, 315 mm for 30 items
            }
            else if (itemCount > 30 && itemCount <= 40)
            {
                totalHeight = 315 + (10 * (itemCount - 30) / 2); // 315 mm for 30 items, 365 mm for 40 items
            }
            else if (itemCount > 40 && itemCount <= 50)
            {
                totalHeight = 365 + (10 * (itemCount - 40) / 2); // 365 mm for 40 items, 415 mm for 50 items
            }
            else if (itemCount > 50 && itemCount <= 60)
            {
                totalHeight = 415 + (10 * (itemCount - 50) / 2); // 415 mm for 50 items, 465 mm for 60 items
            }
            else if (itemCount > 60 && itemCount <= 70)
            {
                totalHeight = 465 + (10 * (itemCount - 60) / 2); // 465 mm for 60 items, 515 mm for 70 items
            }
            else if (itemCount > 70 && itemCount <= 80)
            {
                totalHeight = 515 + (10 * (itemCount - 70) / 2); // 515 mm for 70 items, 565 mm for 80 items
            }
            else if (itemCount > 80 && itemCount <= 100)
            {
                totalHeight = 565 + (15 * (itemCount - 80) / 4); // 565 mm for 80 items, 640 mm for 100 items
            }
            else
            {
                totalHeight = 640; // Cap at 640 mm for >100 items
            }

            section.PageSetup.PageHeight = Unit.FromMillimeter(totalHeight);

            // Define professional styles for thermal receipt
            Style titleStyle = document.Styles.AddStyle("Title", "Normal");
            titleStyle.Font.Name = "Courier New";
            titleStyle.Font.Size = 12;
            titleStyle.Font.Bold = true;
            titleStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            titleStyle.ParagraphFormat.SpaceAfter = 4;

            Style bodyStyle = document.Styles.AddStyle("Body", "Normal");
            bodyStyle.Font.Name = "Courier New";
            bodyStyle.Font.Size = 8;
            bodyStyle.ParagraphFormat.SpaceAfter = 0; // Reduced from 2 to remove extra gap

            Style boldBodyStyle = document.Styles.AddStyle("BoldBody", "Body");
            boldBodyStyle.Font.Bold = true;

            Style rightAlignStyle = document.Styles.AddStyle("RightAlign", "Body");
            rightAlignStyle.ParagraphFormat.Alignment = ParagraphAlignment.Right;

            Style centerStyle = document.Styles.AddStyle("Center", "Body");
            centerStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;

            CompanyDetails company = LoadCompanyDetails();

            // Logo section
            Paragraph logoPara = section.AddParagraph();
            logoPara.Format.Alignment = ParagraphAlignment.Center;
            if (company.Logo != null && company.Logo.Length > 0)
            {
                try
                {
                    MemoryStream ms = new MemoryStream(company.Logo);
                    try
                    {
                        Image image = Image.FromStream(ms);
                        try
                        {
                            string tempImagePath = Path.Combine(Path.GetTempPath(), $"logo_{Guid.NewGuid()}.png");
                            image.Save(tempImagePath, ImageFormat.Png);
                            tempFiles.Add(tempImagePath);
                            var pdfImage = logoPara.AddImage(tempImagePath);
                            pdfImage.Width = Unit.FromMillimeter(45);
                            pdfImage.LockAspectRatio = true;
                        }
                        finally
                        {
                            image.Dispose();
                        }
                    }
                    finally
                    {
                        ms.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    logoPara.AddText($"[Error loading logo: {ex.Message}]");
                }
            }
            else
            {
                logoPara.AddText("SEVEN SUPER CITY");
                logoPara.Style = "Title";
            }

            // Company information section
            Paragraph storeName = section.AddParagraph();
            storeName.Style = "Title";
            storeName.AddText(company.Name);

            Paragraph address = section.AddParagraph();
            address.Style = "Center";
            address.AddText(company.Address);

            Paragraph phone = section.AddParagraph();
            phone.Style = "Center";
            phone.AddText($"CONTACT: {company.PhoneNumber}");

            // Top separator
            Paragraph separator1 = section.AddParagraph();
            separator1.AddText("============================================");
            separator1.Style = "Center";

            // Bill details section
            Paragraph dateTimePara = section.AddParagraph();
            dateTimePara.Style = "Body";
            dateTimePara.AddText($"DATE: {DateTime.Now:dd/MM/yyyy}  TIME: {DateTime.Now:HH:mm:ss}");

            Paragraph invoicePara = section.AddParagraph();
            invoicePara.Style = "Body";
            invoicePara.AddText($"INVOICE NO: {billNo}");

            Paragraph cashierPara = section.AddParagraph();
            cashierPara.Style = "Body";
            cashierPara.AddText($"CASHIER: {userName}");

            if (!string.IsNullOrEmpty(customerName) && customerName != "Walk-in Customer")
            {
                Paragraph customerPara = section.AddParagraph();
                customerPara.Style = "Body";
                customerPara.AddText($"CUSTOMER: {customerName}");
            }

            // Items section separator
            Paragraph separator2 = section.AddParagraph();
            separator2.AddText("============================================");
            separator2.Style = "Center";

            // Create professional table with separate columns
            Table itemsTable = section.AddTable();
            itemsTable.Style = "Table";
            itemsTable.Borders.Width = 0.25;
            itemsTable.Borders.Left.Width = 0;
            itemsTable.Borders.Right.Width = 0;
            itemsTable.Borders.Top.Width = 0;
            itemsTable.Borders.Bottom.Width = 0;
            itemsTable.Rows.LeftIndent = 0;

            // Define column widths for 80mm thermal receipt (total 74mm printable)
            Column column = itemsTable.AddColumn("1.8cm"); // Quantity
            column.Format.Alignment = ParagraphAlignment.Right;

            column = itemsTable.AddColumn("2.8cm"); // Unit Price
            column.Format.Alignment = ParagraphAlignment.Right;

            column = itemsTable.AddColumn("2.8cm"); // Amount
            column.Format.Alignment = ParagraphAlignment.Right;

            // Add table header rows
            Row headerRow1 = itemsTable.AddRow();
            headerRow1.HeadingFormat = true;
            headerRow1.Format.Font.Size = 7;
            headerRow1.Format.Font.Name = "Courier New";
            headerRow1.Format.Font.Bold = false;
            // headerRow1.Shading.Color = Colors.LightGray;
            headerRow1.Cells[0].MergeRight = 2; // Merge all 3 columns for DESCRIPTION
            headerRow1.Cells[0].AddParagraph("");
            headerRow1.Cells[0].Format.Alignment = ParagraphAlignment.Left;

            Row headerRow2 = itemsTable.AddRow();
            headerRow2.HeadingFormat = true;
            headerRow2.Format.Font.Size = 8;
            headerRow2.Format.Font.Name = "Courier New";
            headerRow2.Format.Font.Bold = true;
            // headerRow2.Shading.Color = Colors.LightGray;
            headerRow2.Cells[0].AddParagraph("QTY");
            headerRow2.Cells[0].Format.Alignment = ParagraphAlignment.Right;
            headerRow2.Cells[1].AddParagraph("PRICE");
            headerRow2.Cells[1].Format.Alignment = ParagraphAlignment.Right;
            headerRow2.Cells[2].AddParagraph("AMOUNT");
            headerRow2.Cells[2].Format.Alignment = ParagraphAlignment.Right;

            // Add items to table (2 rows per item)
            foreach (var item in cartItems)
            {
                // First row: Description
                Row descRow = itemsTable.AddRow();
                descRow.Height = Unit.FromMillimeter(6); // Reduced from 9 mm
                descRow.Format.Font.Size = 8;
                descRow.Format.Font.Name = "Courier New";
                descRow.Cells[0].MergeRight = 2; // Merge all 3 columns for description

                // Product name and variation
                string productDisplay = item.ProductName.ToUpper();
                if (!string.IsNullOrEmpty(item.VariationType) && item.VariationType != "N/A")
                {
                    productDisplay += $" ({item.VariationType})";
                }

                // Truncate if too long (adjusted for wider space)
                if (productDisplay.Length > 40)
                    productDisplay = productDisplay.Substring(0, 37) + "...";

                descRow.Cells[0].AddParagraph(productDisplay);
                descRow.Cells[0].Format.Alignment = ParagraphAlignment.Left;

                // Second row: QTY, PRICE, AMOUNT
                Row dataRow = itemsTable.AddRow();
                dataRow.Height = Unit.FromMillimeter(6); // Reduced from 9 mm
                dataRow.Format.Font.Size = 8;
                dataRow.Format.Font.Name = "Courier New";

                // Format quantity based on unit type
                string qtyText;
                if (item.Unit == "Pieces")
                {
                    qtyText = item.Quantity.ToString("0");
                }
                else
                {
                    string unitAbbrev = item.Unit switch
                    {
                        "Kilogram" => "KG",
                        "Liter" => "L",
                        "Meter" => "M",
                        _ => item.Unit.Substring(0, Math.Min(2, item.Unit.Length))
                    };
                    qtyText = $"{item.Quantity:0.00}{unitAbbrev}";
                }

                dataRow.Cells[0].AddParagraph(qtyText);
                dataRow.Cells[0].Format.Alignment = ParagraphAlignment.Right;

                dataRow.Cells[1].AddParagraph(item.Price.ToString("0.00"));
                dataRow.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                dataRow.Cells[2].AddParagraph(item.TotalPrice.ToString("0.00"));
                dataRow.Cells[2].Format.Alignment = ParagraphAlignment.Right;
            }

            // Summary section separator
            Paragraph separator3 = section.AddParagraph();
            separator3.AddText("============================================");
            separator3.Style = "Center";

            // Professional summary section with labels left-aligned and values right-aligned
            decimal subTotal = totalPrice + discount;

            Table summaryTable = section.AddTable();
            summaryTable.Borders.Width = 0; // No borders
            summaryTable.AddColumn("3.5cm");
            summaryTable.AddColumn("3.9cm");

            // Sub Total row
            Row row = summaryTable.AddRow();
            row.Format.Font.Name = "Courier New";
            row.Format.Font.Size = 8;
            row.Cells[0].AddParagraph("SUB TOTAL:").Format.Alignment = ParagraphAlignment.Left;
            row.Cells[1].AddParagraph($"LKR {subTotal:0.00}").Format.Alignment = ParagraphAlignment.Right;

            // Discount row if applicable
            if (discount > 0)
            {
                row = summaryTable.AddRow();
                row.Format.Font.Name = "Courier New";
                row.Format.Font.Size = 8;
                row.Cells[0].AddParagraph("DISCOUNT:").Format.Alignment = ParagraphAlignment.Left;
                row.Cells[1].AddParagraph($"LKR {discount:0.00}").Format.Alignment = ParagraphAlignment.Right;
            }

            // Total row
            row = summaryTable.AddRow();
            row.Format.Font.Name = "Courier New";
            row.Format.Font.Size = 8;
            row.Format.Font.Bold = true; // Make total bold
            row.Cells[0].AddParagraph("TOTAL:").Format.Alignment = ParagraphAlignment.Left;
            row.Cells[1].AddParagraph($"LKR {totalPrice:0.00}").Format.Alignment = ParagraphAlignment.Right;

            // Payment method row
            row = summaryTable.AddRow();
            row.Format.Font.Name = "Courier New";
            row.Format.Font.Size = 8;
            row.Cells[0].AddParagraph("PAYMENT:").Format.Alignment = ParagraphAlignment.Left;
            row.Cells[1].AddParagraph(paymentMethod.ToUpper()).Format.Alignment = ParagraphAlignment.Right;

            if (paymentMethod == "Cash")
            {
                // Cash paid row
                row = summaryTable.AddRow();
                row.Format.Font.Name = "Courier New";
                row.Format.Font.Size = 8;
                row.Cells[0].AddParagraph("CASH PAID:").Format.Alignment = ParagraphAlignment.Left;
                row.Cells[1].AddParagraph($"LKR {cashPaid:0.00}").Format.Alignment = ParagraphAlignment.Right;

                // Balance row
                row = summaryTable.AddRow();
                row.Format.Font.Name = "Courier New";
                row.Format.Font.Size = 8;
                row.Format.Font.Bold = true; // Make balance bold
                row.Cells[0].AddParagraph("BALANCE:").Format.Alignment = ParagraphAlignment.Left;
                row.Cells[1].AddParagraph($"LKR {balance:0.00}").Format.Alignment = ParagraphAlignment.Right;
            }

            // Total items row
            row = summaryTable.AddRow();
            row.Format.Font.Name = "Courier New";
            row.Format.Font.Size = 8;
            row.Cells[0].AddParagraph("TOTAL ITEMS:").Format.Alignment = ParagraphAlignment.Left;
            row.Cells[1].AddParagraph(totalItems.ToString()).Format.Alignment = ParagraphAlignment.Right;

            // Final separator
            Paragraph separator4 = section.AddParagraph();
            separator4.AddText("============================================");
            separator4.Style = "Center";

            // Barcode section
            string barcodePath = GenerateBarcodeImage(billNo);
            tempFiles.Add(barcodePath);
            Paragraph barcodePara = section.AddParagraph();
            barcodePara.Format.Alignment = ParagraphAlignment.Center;
            var barcodeImage = barcodePara.AddImage(barcodePath);
            barcodeImage.Width = Unit.FromMillimeter(55);
            barcodeImage.LockAspectRatio = true;

            // Professional footer section
            Paragraph thankYou = section.AddParagraph();
            thankYou.Style = "Title";
            thankYou.AddText("THANK YOU FOR YOUR VISIT!");

            Paragraph softwareCompany = section.AddParagraph();
            softwareCompany.Style = "Center";
            softwareCompany.Format.Font.Size = 7; // Slightly smaller text
            softwareCompany.AddText("Software by E-Scope International - 077 198 6400");

            // Save PDF with proper resource cleanup
            try
            {
                PdfDocumentRenderer renderer = new PdfDocumentRenderer();
                renderer.Document = document;
                renderer.RenderDocument();
                renderer.PdfDocument.Save(pdfPath);
            }
            finally
            {
                // Clean up temporary files
                foreach (string tempFile in tempFiles)
                {
                    if (File.Exists(tempFile))
                    {
                        try
                        {
                            File.Delete(tempFile);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting temporary file: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }

            return pdfPath;
        }

        private static void PrintPDF(string pdfPath)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = pdfPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error printing PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}