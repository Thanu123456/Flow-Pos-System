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
            string receiptPath = GenerateBillPDF(billNo, customerName, userName, totalItems, paymentMethod, totalPrice, discount, cashPaid, balance, cartItems, true);
            PrintPDF(receiptPath);

            DialogResult result = MessageBox.Show("Do you want to print an A4-sized bill?", "Print A4 Bill", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string a4Path = GenerateBillPDF(billNo, customerName, userName, totalItems, paymentMethod, totalPrice, discount, cashPaid, balance, cartItems, false);
                PrintPDF(a4Path);
            }
        }

        private static string GenerateBarcodeImage(string billNo)
        {
            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Height = 50,
                    Width = 200
                }
            };
            using (Bitmap bitmap = writer.Write(billNo))
            {
                string tempPath = Path.Combine(Path.GetTempPath(), $"barcode_{Guid.NewGuid()}.png");
                bitmap.Save(tempPath, ImageFormat.Png);
                return tempPath;
            }
        }

        private static string GenerateBillPDF(string billNo, string customerName, string userName, int totalItems, string paymentMethod, decimal totalPrice, decimal discount, decimal cashPaid, decimal balance, List<CartItem> cartItems, bool isSmallReceipt)
        {
            string pdfPath = Path.Combine(Environment.CurrentDirectory, $"{billNo}_{(isSmallReceipt ? "receipt" : "A4")}.pdf");
            List<string> tempFiles = new List<string>();

            Document document = new Document();
            Section section = document.AddSection();

            if (isSmallReceipt)
            {
                section.PageSetup.PageWidth = Unit.FromMillimeter(80);
                section.PageSetup.LeftMargin = Unit.FromMillimeter(5);
                section.PageSetup.RightMargin = Unit.FromMillimeter(5);
                section.PageSetup.TopMargin = Unit.FromMillimeter(5);
                section.PageSetup.BottomMargin = Unit.FromMillimeter(5);

                int itemCount = cartItems.Count;
                double baseHeight = 120;
                double bottomSpace = 80;
                double totalHeight = baseHeight + (itemCount * 20) + bottomSpace;
                section.PageSetup.PageHeight = Unit.FromMillimeter(totalHeight);
            }
            else
            {
                section.PageSetup.PageFormat = PageFormat.A4;
                section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
                section.PageSetup.RightMargin = Unit.FromCentimeter(2);
                section.PageSetup.TopMargin = Unit.FromCentimeter(2);
                section.PageSetup.BottomMargin = Unit.FromCentimeter(2);
            }

            // Define styles with monospace font for terminal-like appearance
            Style titleStyle = document.Styles.AddStyle("Title", "Normal");
            titleStyle.Font.Name = isSmallReceipt ? "Courier New" : "Arial";
            titleStyle.Font.Size = isSmallReceipt ? 14 : 20;
            titleStyle.Font.Bold = true;
            titleStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            titleStyle.ParagraphFormat.SpaceAfter = isSmallReceipt ? 6 : 10;

            Style subtitleStyle = document.Styles.AddStyle("Subtitle", "Normal");
            subtitleStyle.Font.Name = isSmallReceipt ? "Courier New" : "Arial";
            subtitleStyle.Font.Size = isSmallReceipt ? 12 : 14;
            subtitleStyle.Font.Bold = true;
            subtitleStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            subtitleStyle.ParagraphFormat.SpaceAfter = isSmallReceipt ? 6 : 10;

            Style bodyStyle = document.Styles.AddStyle("Body", "Normal");
            bodyStyle.Font.Name = isSmallReceipt ? "Courier New" : "Arial";
            bodyStyle.Font.Size = isSmallReceipt ? 9 : 10;
            bodyStyle.ParagraphFormat.SpaceAfter = 3;

            Style tableDataStyle = document.Styles.AddStyle("TableData", "Body");
            tableDataStyle.Font.Name = isSmallReceipt ? "Courier New" : "Arial";
            tableDataStyle.Font.Size = isSmallReceipt ? 8 : 10;

            Style tableHeaderStyle = document.Styles.AddStyle("TableHeader", "Normal");
            tableHeaderStyle.Font.Name = isSmallReceipt ? "Courier New" : "Arial";
            tableHeaderStyle.Font.Size = isSmallReceipt ? 9 : 10;
            tableHeaderStyle.Font.Bold = true;

            Style priceStyle = document.Styles.AddStyle("PriceStyle", "TableData");
            priceStyle.Font.Bold = false;

            Style boldBodyStyle = document.Styles.AddStyle("BoldBody", "Body");
            boldBodyStyle.Font.Bold = true;

            Style footerStyle = document.Styles.AddStyle("Footer", "Body");
            footerStyle.Font.Name = isSmallReceipt ? "Courier New" : "Arial";
            footerStyle.Font.Size = isSmallReceipt ? 8 : 9;
            footerStyle.Font.Italic = true;

            CompanyDetails company = LoadCompanyDetails();

            if (isSmallReceipt)
            {
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
                                pdfImage.Width = Unit.FromMillimeter(50);
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
                }

                // Company info
                Paragraph storeName = section.AddParagraph();
                storeName.Style = "Title";
                storeName.AddText(company.Name);

                Paragraph address = section.AddParagraph();
                address.Style = "Body";
                address.AddText(company.Address);
                address.Format.Alignment = ParagraphAlignment.Center;

                Paragraph phone = section.AddParagraph();
                phone.Style = "Body";
                phone.AddText($"CONTACT {company.PhoneNumber}");
                phone.Format.Alignment = ParagraphAlignment.Center;

                // Separator
                Paragraph separator1 = section.AddParagraph();
                separator1.AddText("========================================");
                separator1.Style = "Body";
                separator1.Format.Alignment = ParagraphAlignment.Center;

                // Bill details
                Paragraph cashierInfo = section.AddParagraph();
                cashierInfo.Style = "Body";
                cashierInfo.AddText($"CASHIER: {userName}".PadRight(40));
                
                Paragraph unitInfo = section.AddParagraph();
                unitInfo.Style = "Body";
                unitInfo.AddText($"UNIT NO: 1".PadRight(40));
                
                Paragraph timeInfo = section.AddParagraph();
                timeInfo.Style = "Body";
                timeInfo.AddText($"TIME: {DateTime.Now:HH:mm:ss}".PadRight(40));
                
                Paragraph invoiceInfo = section.AddParagraph();
                invoiceInfo.Style = "Body";
                invoiceInfo.AddText($"INVOICE: {billNo}".PadRight(40));

                // Separator
                Paragraph separator2 = section.AddParagraph();
                separator2.AddText("========================================");
                separator2.Style = "Body";
                separator2.Format.Alignment = ParagraphAlignment.Center;

                // Column headers - right-aligned, padded with adjusted spacing
                Paragraph headerLine = section.AddParagraph();
                headerLine.Style = "Body";
                string headerText = "QTY".PadRight(10) + "U/PRICE".PadRight(12) + "AMOUNT".PadRight(10);
                headerLine.AddText(headerText);
                headerLine.Format.Alignment = ParagraphAlignment.Right;

                // Items section
                foreach (var item in cartItems)
                {
                    // Product name line (full width, left-aligned)
                    string productDisplay = item.ProductName.ToUpper();
                    if (!string.IsNullOrEmpty(item.VariationType) && item.VariationType != "N/A")
                    {
                        productDisplay += " " + item.VariationType;
                    }
                    if (productDisplay.Length > 38) productDisplay = productDisplay.Substring(0, 38);
                    
                    Paragraph productLine = section.AddParagraph();
                    productLine.Style = "Body";
                    productLine.AddText(productDisplay);

                    // Table for QTY, U/PRICE, AMOUNT
                    Table itemTable = section.AddTable();
                    itemTable.Borders.Width = 0; // No borders
                    itemTable.AddColumn(Unit.FromMillimeter(20)); // QTY
                    itemTable.AddColumn(Unit.FromMillimeter(20)); // U/PRICE
                    itemTable.AddColumn(Unit.FromMillimeter(20)); // AMOUNT

                    Row itemRow = itemTable.AddRow();
                    
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
                            _ => item.Unit
                        };
                        qtyText = $"{item.Quantity:0.00}{unitAbbrev}";
                    }

                    // Maintain original padding with extra spacing for separation
                    string qtyColumn = qtyText.PadLeft(8).PadRight(10);      // QTY: 8 chars left, 10 chars total
                    string priceColumn = item.Price.ToString("0.00").PadLeft(10).PadRight(12);   // U/PRICE: 10 chars left, 12 chars total
                    string amountColumn = item.TotalPrice.ToString("0.00").PadLeft(10).PadRight(10); // AMOUNT: 10 chars left, 10 chars total

                    itemRow.Cells[0].AddParagraph(qtyColumn).Style = "TableData";
                    itemRow.Cells[0].Format.Alignment = ParagraphAlignment.Right;
                    itemRow.Cells[1].AddParagraph(priceColumn).Style = "TableData";
                    itemRow.Cells[1].Format.Alignment = ParagraphAlignment.Right;
                    itemRow.Cells[2].AddParagraph(amountColumn).Style = "TableData";
                    itemRow.Cells[2].Format.Alignment = ParagraphAlignment.Right;
                }

                // Separator
                Paragraph separator3 = section.AddParagraph();
                separator3.AddText("========================================");
                separator3.Style = "Body";
                separator3.Format.Alignment = ParagraphAlignment.Center;

                // Summary section
                Paragraph subTotal = section.AddParagraph();
                subTotal.Style = "Body";
                string subTotalLine = $"SUB TOTAL:{(totalPrice + discount):0.00}".Replace(":", ": LKR ");
                subTotal.AddText(subTotalLine.PadLeft(38));
                subTotal.Format.Alignment = ParagraphAlignment.Right;

                if (discount > 0)
                {
                    Paragraph discountPara = section.AddParagraph();
                    discountPara.Style = "Body";
                    string discountLine = $"DISCOUNT:{discount:0.00}".Replace(":", ": LKR ");
                    discountPara.AddText(discountLine.PadLeft(38));
                    discountPara.Format.Alignment = ParagraphAlignment.Right;
                }

                Paragraph totalPara = section.AddParagraph();
                totalPara.Style = "BoldBody";
                string totalLine = $"TOTAL:{totalPrice:0.00}".Replace(":", ": LKR ");
                totalPara.AddText(totalLine.PadLeft(38));
                totalPara.Format.Alignment = ParagraphAlignment.Right;

                Paragraph paymentPara = section.AddParagraph();
                paymentPara.Style = "Body";
                string paymentLine = $"PAYMENT: {paymentMethod}";
                paymentPara.AddText(paymentLine.PadLeft(38));
                paymentPara.Format.Alignment = ParagraphAlignment.Right;

                Paragraph itemsPara = section.AddParagraph();
                itemsPara.Style = "Body";
                string itemsLine = $"ITEMS: {totalItems}";
                itemsPara.AddText(itemsLine.PadLeft(38));
                itemsPara.Format.Alignment = ParagraphAlignment.Right;

                if (paymentMethod == "Cash")
                {
                    Paragraph cashPara = section.AddParagraph();
                    cashPara.Style = "Body";
                    string cashLine = $"CASH:{cashPaid:0.00}".Replace(":", ": LKR ");
                    cashPara.AddText(cashLine.PadLeft(38));
                    cashPara.Format.Alignment = ParagraphAlignment.Right;

                    Paragraph balancePara = section.AddParagraph();
                    balancePara.Style = "BoldBody";
                    string balanceLine = $"BALANCE:{balance:0.00}".Replace(":", ": LKR ");
                    balancePara.AddText(balanceLine.PadLeft(38));
                    balancePara.Format.Alignment = ParagraphAlignment.Right;
                }

                // Separator
                Paragraph separator4 = section.AddParagraph();
                separator4.AddText("========================================");
                separator4.Style = "Body";
                separator4.Format.Alignment = ParagraphAlignment.Center;

                // Barcode
                string barcodePath = GenerateBarcodeImage(billNo);
                tempFiles.Add(barcodePath);
                Paragraph barcodePara = section.AddParagraph();
                barcodePara.Format.Alignment = ParagraphAlignment.Center;
                var barcodeImage = barcodePara.AddImage(barcodePath);
                barcodeImage.Width = Unit.FromMillimeter(60);
                barcodeImage.LockAspectRatio = true;

                // Thank you message
                Paragraph thankYou = section.AddParagraph();
                thankYou.Style = "Subtitle";
                thankYou.AddText("THANK YOU!");
                thankYou.Format.Alignment = ParagraphAlignment.Center;
            }
            else
            {
                // A4 format remains unchanged
                Table headerTable = section.AddTable();
                headerTable.AddColumn(Unit.FromCentimeter(9));
                headerTable.AddColumn(Unit.FromCentimeter(9));

                Row headerRow1 = headerTable.AddRow();
                Paragraph logoPara = headerRow1.Cells[0].AddParagraph();
                logoPara.Format.Alignment = ParagraphAlignment.Left;
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
                                pdfImage.Width = Unit.FromCentimeter(3);
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
                    logoPara.AddText("[Logo Not Found]");
                }

                Paragraph invoiceTitle = headerRow1.Cells[1].AddParagraph();
                invoiceTitle.Style = "Title";
                invoiceTitle.AddText("INVOICE");
                invoiceTitle.Format.Alignment = ParagraphAlignment.Right;

                Row headerRow2 = headerTable.AddRow();
                Paragraph companyName = headerRow2.Cells[0].AddParagraph();
                companyName.Style = "Subtitle";
                companyName.AddText(company.Name);
                companyName.Format.Alignment = ParagraphAlignment.Left;

                Paragraph invoiceNumber = headerRow2.Cells[1].AddParagraph();
                invoiceNumber.Style = "Body";
                invoiceNumber.AddText($"INVOICE NUMBER\n#{billNo}");
                invoiceNumber.Format.Alignment = ParagraphAlignment.Right;

                Row headerRow3 = headerTable.AddRow();
                Paragraph customerInfo = headerRow3.Cells[0].AddParagraph();
                customerInfo.Style = "Body";
                customerInfo.AddText($"{customerName}\n{company.Address}\n{company.PhoneNumber}\n{company.Email}");
                customerInfo.Format.Alignment = ParagraphAlignment.Left;

                section.AddParagraph().Format.SpaceAfter = 10;

                Table separatorTable1 = section.AddTable();
                separatorTable1.Borders.Width = 0;
                separatorTable1.Borders.Bottom.Width = 0.5;
                separatorTable1.AddColumn(Unit.FromCentimeter(18));
                Row separatorRow1 = separatorTable1.AddRow();
                separatorRow1.Cells[0].AddParagraph("");
                section.AddParagraph().Format.SpaceAfter = 5;

                Table itemsTable = section.AddTable();
                itemsTable.Borders.Width = 0.5;
                itemsTable.Borders.Color = Colors.Black;
                itemsTable.AddColumn(Unit.FromCentimeter(8));
                itemsTable.AddColumn(Unit.FromCentimeter(3));
                itemsTable.AddColumn(Unit.FromCentimeter(3));
                itemsTable.AddColumn(Unit.FromCentimeter(4));

                Row tableHeaderRow = itemsTable.AddRow();
                tableHeaderRow.HeadingFormat = true;
                tableHeaderRow.Format.Font.Bold = true;
                tableHeaderRow.Shading.Color = Colors.DarkBlue;
                tableHeaderRow.Format.Font.Color = Colors.White;
                tableHeaderRow.Cells[0].AddParagraph("PRODUCT");
                tableHeaderRow.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                tableHeaderRow.Cells[1].AddParagraph("QTY").Style = "TableHeader";
                tableHeaderRow.Cells[1].Format.Alignment = ParagraphAlignment.Center;
                tableHeaderRow.Cells[2].AddParagraph("U/PRICE").Style = "TableHeader";
                tableHeaderRow.Cells[2].Format.Alignment = ParagraphAlignment.Center;
                tableHeaderRow.Cells[3].AddParagraph("AMOUNT").Style = "TableHeader";
                tableHeaderRow.Cells[3].Format.Alignment = ParagraphAlignment.Center;

                foreach (var item in cartItems)
                {
                    Row itemRow = itemsTable.AddRow();
                    string variation = string.IsNullOrEmpty(item.VariationType) || item.VariationType == "N/A" ? "" : $" ({item.VariationType})";
                    itemRow.Cells[0].AddParagraph(item.ProductName + variation).Style = "Body";
                    itemRow.Cells[0].Format.Alignment = ParagraphAlignment.Left;

                    string qtyText = item.Unit == "Pieces" ? item.Quantity.ToString("N0") : item.Quantity.ToString("N2");
                    itemRow.Cells[1].AddParagraph(qtyText).Style = "Body";
                    itemRow.Cells[1].Format.Alignment = ParagraphAlignment.Center;

                    itemRow.Cells[2].AddParagraph($"LKR {item.Price:N2}").Style = "Body";
                    itemRow.Cells[2].Format.Alignment = ParagraphAlignment.Center;

                    itemRow.Cells[3].AddParagraph($"LKR {item.TotalPrice:N2}").Style = "Body";
                    itemRow.Cells[3].Format.Alignment = ParagraphAlignment.Center;
                }

                int remainingRows = 7 - cartItems.Count;
                for (int i = 0; i < remainingRows; i++)
                {
                    Row emptyRow = itemsTable.AddRow();
                    emptyRow.Cells[0].AddParagraph("").Style = "Body";
                    emptyRow.Cells[1].AddParagraph("").Style = "Body";
                    emptyRow.Cells[2].AddParagraph("").Style = "Body";
                    emptyRow.Cells[3].AddParagraph("").Style = "Body";
                }

                section.AddParagraph().Format.SpaceAfter = 10;

                Table summaryTable = section.AddTable();
                summaryTable.AddColumn(Unit.FromCentimeter(9));
                summaryTable.AddColumn(Unit.FromCentimeter(9));

                Row signatureRow = summaryTable.AddRow();
                signatureRow.Cells[0].AddParagraph($"{userName}\nBusiness Consultant").Style = "Body";
                signatureRow.Cells[0].Format.Alignment = ParagraphAlignment.Left;

                Row summaryRow1 = summaryTable.AddRow();
                summaryRow1.Cells[1].AddParagraph($"SUBTOTAL:\nTAX:\nSUBTOTAL:").Style = "Body";
                summaryRow1.Cells[1].AddParagraph($"LKR {totalPrice + discount:N2}\nLKR 0.00\nLKR {totalPrice:N2}").Style = "Body";
                summaryRow1.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                section.AddParagraph().Format.SpaceAfter = 10;

                Table separatorTable2 = section.AddTable();
                separatorTable2.Borders.Width = 0;
                separatorTable2.Borders.Bottom.Width = 0.5;
                separatorTable2.AddColumn(Unit.FromCentimeter(18));
                Row separatorRow2 = separatorTable2.AddRow();
                separatorRow2.Cells[0].AddParagraph("");
                section.AddParagraph().Format.SpaceAfter = 5;

                Paragraph terms = section.AddParagraph();
                terms.Style = "Body";
                terms.AddText("TERM AND CONDITION\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam molestie gravida quam. Praesent consectetur, dui quis porta mattis, tortor velit pretium massa, non porta augue eros sed lacus. Vestibulum pellentesque tempus sapien sed lacinia. Nunc at ipsum eu");

                section.AddParagraph().Format.SpaceAfter = 10;

                Table footerTable = section.AddTable();
                footerTable.AddColumn(Unit.FromCentimeter(6));
                footerTable.AddColumn(Unit.FromCentimeter(6));
                footerTable.AddColumn(Unit.FromCentimeter(6));

                Row footerRow = footerTable.AddRow();
                footerRow.Cells[0].AddParagraph($"www.{company.Name.ToLower()}.com").Style = "Body";
                footerRow.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                footerRow.Cells[1].AddParagraph(company.Address).Style = "Body";
                footerRow.Cells[1].Format.Alignment = ParagraphAlignment.Center;
                footerRow.Cells[2].AddParagraph(company.PhoneNumber).Style = "Body";
                footerRow.Cells[2].Format.Alignment = ParagraphAlignment.Right;
            }

            try
            {
                PdfDocumentRenderer renderer = new PdfDocumentRenderer();
                renderer.Document = document;
                renderer.RenderDocument();
                renderer.PdfDocument.Save(pdfPath);
            }
            finally
            {
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