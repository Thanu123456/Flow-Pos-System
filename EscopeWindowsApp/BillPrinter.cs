using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;
using System.Drawing;

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
                Name = "SUPERMARKET",
                Address = "Lorem ipsum 258, City Index - 02025",
                PhoneNumber = "Tel.: +456-466-987-02",
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
                                details.Name = reader["name"]?.ToString() ?? "SUPERMARKET";
                                details.Email = reader["email"]?.ToString() ?? "Not Available";
                                details.PhoneNumber = reader["phone_number"]?.ToString() ?? "Not Available";
                                details.Address = reader["address"]?.ToString() ?? "Not Available";
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

        private static string GenerateBillPDF(string billNo, string customerName, string userName, int totalItems, string paymentMethod, decimal totalPrice, decimal discount, decimal cashPaid, decimal balance, List<CartItem> cartItems, bool isSmallReceipt)
        {
            string pdfPath = Path.Combine(Environment.CurrentDirectory, $"{billNo}_{(isSmallReceipt ? "receipt" : "A4")}.pdf");
            string tempImagePath = null;

            Document document = new Document();
            Section section = document.AddSection();

            if (isSmallReceipt)
            {
                section.PageSetup.PageWidth = Unit.FromMillimeter(80);
                section.PageSetup.PageHeight = Unit.FromMillimeter(297);
                section.PageSetup.LeftMargin = Unit.FromMillimeter(5);
                section.PageSetup.RightMargin = Unit.FromMillimeter(5);
                section.PageSetup.TopMargin = Unit.FromMillimeter(5);
                section.PageSetup.BottomMargin = Unit.FromMillimeter(5);
            }
            else
            {
                section.PageSetup.PageFormat = PageFormat.A4;
                section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
                section.PageSetup.RightMargin = Unit.FromCentimeter(2);
                section.PageSetup.TopMargin = Unit.FromCentimeter(2);
                section.PageSetup.BottomMargin = Unit.FromCentimeter(2);
            }

            Style titleStyle = document.Styles.AddStyle("Title", "Normal");
            titleStyle.Font.Size = isSmallReceipt ? 12 : 20;
            titleStyle.Font.Bold = true;
            titleStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            titleStyle.ParagraphFormat.SpaceAfter = isSmallReceipt ? 5 : 10;

            Style subtitleStyle = document.Styles.AddStyle("Subtitle", "Normal");
            subtitleStyle.Font.Size = isSmallReceipt ? 10 : 14;
            subtitleStyle.Font.Bold = true;
            subtitleStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            subtitleStyle.ParagraphFormat.SpaceAfter = isSmallReceipt ? 5 : 10;

            Style bodyStyle = document.Styles.AddStyle("Body", "Normal");
            bodyStyle.Font.Size = isSmallReceipt ? 8 : 10;
            bodyStyle.ParagraphFormat.SpaceAfter = 2;

            Style tableHeaderStyle = document.Styles.AddStyle("TableHeader", "Normal");
            tableHeaderStyle.Font.Size = isSmallReceipt ? 8 : 10;
            tableHeaderStyle.Font.Bold = true;
            tableHeaderStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;

            CompanyDetails company = LoadCompanyDetails();

            if (isSmallReceipt)
            {
                Paragraph logoPara = section.AddParagraph();
                logoPara.Format.Alignment = ParagraphAlignment.Center;
                if (company.Logo != null && company.Logo.Length > 0)
                {
                    try
                    {
                        using (MemoryStream ms = new MemoryStream(company.Logo))
                        {
                            using (var image = Image.FromStream(ms))
                            {
                                tempImagePath = Path.Combine(Path.GetTempPath(), $"logo_{Guid.NewGuid()}.png");
                                image.Save(tempImagePath, ImageFormat.Png);
                                var pdfImage = logoPara.AddImage(tempImagePath);
                                pdfImage.Width = Unit.FromMillimeter(50);
                                pdfImage.LockAspectRatio = true;
                            }
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

                Paragraph storeName = section.AddParagraph();
                storeName.Style = "Title";
                storeName.AddText(company.Name);

                Paragraph address = section.AddParagraph();
                address.Style = "Body";
                address.AddText(company.Address);
                address.Format.Alignment = ParagraphAlignment.Center;

                Paragraph phone = section.AddParagraph();
                phone.Style = "Body";
                phone.AddText($"Tel.: {company.PhoneNumber}");
                phone.Format.Alignment = ParagraphAlignment.Center;

                Paragraph separator1 = section.AddParagraph();
                separator1.Style = "Body";
                separator1.AddText("............................");
                separator1.Format.Alignment = ParagraphAlignment.Center;
                section.AddParagraph().Format.SpaceAfter = 5;

                Table cashierTable = section.AddTable();
                cashierTable.AddColumn(Unit.FromMillimeter(35));
                cashierTable.AddColumn(Unit.FromMillimeter(35));

                Row cashierRow1 = cashierTable.AddRow();
                cashierRow1.Cells[0].AddParagraph("Cashier:").Style = "Body";
                cashierRow1.Cells[1].AddParagraph("#3").Style = "Body";
                cashierRow1.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                Row cashierRow2 = cashierTable.AddRow();
                cashierRow2.Cells[0].AddParagraph($"Manager: {userName}").Style = "Body";

                Row billNoRow = cashierTable.AddRow();
                billNoRow.Cells[0].AddParagraph($"Bill No: {billNo}").Style = "Body";

                Paragraph separator2 = section.AddParagraph();
                separator2.Style = "Body";
                separator2.AddText("............................");
                separator2.Format.Alignment = ParagraphAlignment.Center;
                section.AddParagraph().Format.SpaceAfter = 5;

                Table itemsHeaderTable = section.AddTable();
                itemsHeaderTable.AddColumn(Unit.FromMillimeter(35));
                itemsHeaderTable.AddColumn(Unit.FromMillimeter(15));
                itemsHeaderTable.AddColumn(Unit.FromMillimeter(20));

                Row itemsHeaderRow = itemsHeaderTable.AddRow();
                itemsHeaderRow.Cells[0].AddParagraph("Name").Style = "Body";
                itemsHeaderRow.Cells[1].AddParagraph("Qty").Style = "Body";
                itemsHeaderRow.Cells[2].AddParagraph("Price").Style = "Body";
                itemsHeaderRow.Cells[2].Format.Alignment = ParagraphAlignment.Right;

                foreach (var item in cartItems)
                {
                    Table itemRowTable = section.AddTable();
                    itemRowTable.AddColumn(Unit.FromMillimeter(35));
                    itemRowTable.AddColumn(Unit.FromMillimeter(15));
                    itemRowTable.AddColumn(Unit.FromMillimeter(20));

                    Row itemRow = itemRowTable.AddRow();
                    itemRow.Cells[0].AddParagraph($"{item.ProductName} ({item.VariationType})").Style = "Body";
                    string displayUnit;
                    if (item.Unit == "Liter")
                    {
                        displayUnit = "L";
                    }
                    else if (item.Unit == "Kilogram")
                    {
                        displayUnit = "Kg";
                    }
                    else if (item.Unit == "Meter")
                    {
                        displayUnit = "M";
                    }
                    else
                    {
                        displayUnit = item.Unit;
                    }
                    string qtyText = item.Unit == "Pieces" ? item.Quantity.ToString("N0") : $"{item.Quantity:N2} {displayUnit}";
                    itemRow.Cells[1].AddParagraph(qtyText).Style = "Body";
                    itemRow.Cells[2].AddParagraph($"LKR {item.TotalPrice:N2}").Style = "Body";
                    itemRow.Cells[2].Format.Alignment = ParagraphAlignment.Right;
                }

                Paragraph separator3 = section.AddParagraph();
                separator3.Style = "Body";
                separator3.AddText("............................");
                separator3.Format.Alignment = ParagraphAlignment.Center;
                section.AddParagraph().Format.SpaceAfter = 5;

                Table summaryTable = section.AddTable();
                summaryTable.AddColumn(Unit.FromMillimeter(35));
                summaryTable.AddColumn(Unit.FromMillimeter(35));

                Row summaryRow1 = summaryTable.AddRow();
                summaryRow1.Cells[0].AddParagraph("Sub TOTAL").Style = "Subtitle";
                summaryRow1.Cells[1].AddParagraph($"LKR {totalPrice + discount:N2}").Style = "Subtitle";
                summaryRow1.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                Row summaryRow2 = summaryTable.AddRow();
                summaryRow2.Cells[0].AddParagraph("Discount").Style = "Body";
                summaryRow2.Cells[1].AddParagraph($"LKR {discount:N2}").Style = "Body";
                summaryRow2.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                Row summaryRow3 = summaryTable.AddRow();
                summaryRow3.Cells[0].AddParagraph("Total").Style = "Body";
                summaryRow3.Cells[1].AddParagraph($"LKR {totalPrice:N2}").Style = "Body";
                summaryRow3.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                Row summaryRow4 = summaryTable.AddRow();
                summaryRow4.Cells[0].AddParagraph("Payment Method").Style = "Body";
                summaryRow4.Cells[1].AddParagraph(paymentMethod).Style = "Body";
                summaryRow4.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                if (paymentMethod == "Cash")
                {
                    Row summaryRow5 = summaryTable.AddRow();
                    summaryRow5.Cells[0].AddParagraph("Cash").Style = "Body";
                    summaryRow5.Cells[1].AddParagraph($"LKR {cashPaid:N2}").Style = "Body";
                    summaryRow5.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                    Row summaryRow6 = summaryTable.AddRow();
                    summaryRow6.Cells[0].AddParagraph("Balance").Style = "Body";
                    summaryRow6.Cells[1].AddParagraph($"LKR {balance:N2}").Style = "Body";
                    summaryRow6.Cells[1].Format.Alignment = ParagraphAlignment.Right;
                }

                Paragraph separator4 = section.AddParagraph();
                separator4.Style = "Body";
                separator4.AddText("............................");
                separator4.Format.Alignment = ParagraphAlignment.Center;
                section.AddParagraph().Format.SpaceAfter = 5;

                Paragraph barcode = section.AddParagraph();
                barcode.Style = "Body";
                barcode.AddText("██████████████████████████");
                barcode.Format.Alignment = ParagraphAlignment.Center;

                Paragraph thankYou = section.AddParagraph();
                thankYou.Style = "Subtitle";
                thankYou.AddText("THANK YOU!");
                thankYou.Format.Alignment = ParagraphAlignment.Center;

                Paragraph gladToSee = section.AddParagraph();
                gladToSee.Style = "Body";
                gladToSee.AddText("Glad to see you again!");
                gladToSee.Format.Alignment = ParagraphAlignment.Center;
            }
            else
            {
                // Header Section
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
                        using (MemoryStream ms = new MemoryStream(company.Logo))
                        {
                            using (var image = Image.FromStream(ms))
                            {
                                tempImagePath = Path.Combine(Path.GetTempPath(), $"logo_{Guid.NewGuid()}.png");
                                image.Save(tempImagePath, ImageFormat.Png);
                                var pdfImage = logoPara.AddImage(tempImagePath);
                                pdfImage.Width = Unit.FromCentimeter(3);
                                pdfImage.LockAspectRatio = true;
                            }
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

                // Separator
                Table separatorTable1 = section.AddTable();
                separatorTable1.Borders.Width = 0;
                separatorTable1.Borders.Bottom.Width = 0.5;
                separatorTable1.AddColumn(Unit.FromCentimeter(18));
                Row separatorRow1 = separatorTable1.AddRow();
                separatorRow1.Cells[0].AddParagraph("");
                section.AddParagraph().Format.SpaceAfter = 5;

                // Items Table
                Table itemsTable = section.AddTable();
                itemsTable.Borders.Width = 0.5;
                itemsTable.Borders.Color = Colors.Black;
                itemsTable.AddColumn(Unit.FromCentimeter(2));
                itemsTable.AddColumn(Unit.FromCentimeter(8));
                itemsTable.AddColumn(Unit.FromCentimeter(3));
                itemsTable.AddColumn(Unit.FromCentimeter(2));
                itemsTable.AddColumn(Unit.FromCentimeter(3));

                Row tableHeaderRow = itemsTable.AddRow();
                tableHeaderRow.HeadingFormat = true;
                tableHeaderRow.Format.Font.Bold = true;
                tableHeaderRow.Shading.Color = Colors.DarkBlue;
                tableHeaderRow.Format.Font.Color = Colors.White;
                tableHeaderRow.Cells[0].AddParagraph("NO").Style = "TableHeader";
                tableHeaderRow.Cells[1].AddParagraph("PRODUCT").Style = "TableHeader";
                tableHeaderRow.Cells[2].AddParagraph("PRICE").Style = "TableHeader";
                tableHeaderRow.Cells[3].AddParagraph("QTY").Style = "TableHeader";
                tableHeaderRow.Cells[4].AddParagraph("TOTAL").Style = "TableHeader";

                foreach (var item in cartItems)
                {
                    Row itemRow = itemsTable.AddRow();
                    itemRow.Cells[0].AddParagraph(item.ItemNumber.ToString()).Style = "Body";
                    itemRow.Cells[0].Format.Alignment = ParagraphAlignment.Center;
                    itemRow.Cells[1].AddParagraph($"{item.ProductName} ({item.VariationType})").Style = "Body";
                    itemRow.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                    itemRow.Cells[2].AddParagraph($"LKR {item.Price:N2}").Style = "Body";
                    itemRow.Cells[2].Format.Alignment = ParagraphAlignment.Center;
                    string qtyText = item.Unit == "Pieces" ? item.Quantity.ToString("N0") : item.Quantity.ToString("N2");
                    itemRow.Cells[3].AddParagraph(qtyText).Style = "Body";
                    itemRow.Cells[3].Format.Alignment = ParagraphAlignment.Center;
                    itemRow.Cells[4].AddParagraph($"LKR {item.TotalPrice:N2}").Style = "Body";
                    itemRow.Cells[4].Format.Alignment = ParagraphAlignment.Center;
                }

                // Add empty rows to match the invoice design (up to 7 rows)
                int remainingRows = 7 - cartItems.Count;
                for (int i = 0; i < remainingRows; i++)
                {
                    Row emptyRow = itemsTable.AddRow();
                    emptyRow.Cells[0].AddParagraph("").Style = "Body";
                    emptyRow.Cells[1].AddParagraph("").Style = "Body";
                    emptyRow.Cells[2].AddParagraph("").Style = "Body";
                    emptyRow.Cells[3].AddParagraph("").Style = "Body";
                    emptyRow.Cells[4].AddParagraph("").Style = "Body";
                }

                section.AddParagraph().Format.SpaceAfter = 10;

                // Summary Section
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

                // Separator
                Table separatorTable2 = section.AddTable();
                separatorTable2.Borders.Width = 0;
                separatorTable2.Borders.Bottom.Width = 0.5;
                separatorTable2.AddColumn(Unit.FromCentimeter(18));
                Row separatorRow2 = separatorTable2.AddRow();
                separatorRow2.Cells[0].AddParagraph("");
                section.AddParagraph().Format.SpaceAfter = 5;

                // Terms and Conditions
                Paragraph terms = section.AddParagraph();
                terms.Style = "Body";
                terms.AddText("TERM AND CONDITION\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam molestie gravida quam. Praesent consectetur, dui quis porta mattis, tortor velit pretium massa, non porta augue eros sed lacus. Vestibulum pellentesque tempus sapien sed lacinia. Nunc at ipsum eu");

                section.AddParagraph().Format.SpaceAfter = 10;

                // Footer
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
                if (!string.IsNullOrEmpty(tempImagePath) && File.Exists(tempImagePath))
                {
                    try
                    {
                        File.Delete(tempImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting temporary logo file: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
