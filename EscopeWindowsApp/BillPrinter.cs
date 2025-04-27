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
                section.PageSetup.LeftMargin = Unit.FromCentimeter(1);
                section.PageSetup.RightMargin = Unit.FromCentimeter(1);
                section.PageSetup.TopMargin = Unit.FromCentimeter(1);
                section.PageSetup.BottomMargin = Unit.FromCentimeter(1);
            }

            Style titleStyle = document.Styles.AddStyle("Title", "Normal");
            titleStyle.Font.Size = isSmallReceipt ? 12 : 16;
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
                                pdfImage.Width = Unit.FromMillimeter(30); // Increased logo width
                                pdfImage.Height = Unit.FromMillimeter(30);
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
                Table headerTable = section.AddTable();
                headerTable.Borders.Width = 0.5;
                headerTable.Borders.Color = Colors.Black;
                headerTable.AddColumn(Unit.FromCentimeter(18));
                Row headerRow = headerTable.AddRow();
                headerRow.Shading.Color = Colors.LightGray;

                Cell headerCell = headerRow.Cells[0];
                Paragraph logoPara = headerCell.AddParagraph();
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
                                pdfImage.Width = Unit.FromCentimeter(8); // Increased logo width
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

                Paragraph headerPara1 = headerCell.AddParagraph();
                headerPara1.Style = "Title";
                headerPara1.AddText(company.Name);

                Paragraph headerPara2 = headerCell.AddParagraph();
                headerPara2.Style = "Body";
                headerPara2.AddText(company.Address);
                headerPara2.Format.Alignment = ParagraphAlignment.Center;

                Paragraph headerPara3 = headerCell.AddParagraph();
                headerPara3.Style = "Body";
                headerPara3.AddText($"Phone: {company.PhoneNumber}");
                headerPara3.Format.Alignment = ParagraphAlignment.Center;

                Paragraph headerPara4 = headerCell.AddParagraph();
                headerPara4.Style = "Body";
                headerPara4.AddText($"Email: {company.Email}");
                headerPara4.Format.Alignment = ParagraphAlignment.Center;

                Paragraph headerPara5 = headerCell.AddParagraph();
                headerPara5.Style = "Subtitle";
                headerPara5.AddText("INVOICE");

                section.AddParagraph().Format.SpaceAfter = 10;

                Table infoTable = section.AddTable();
                infoTable.AddColumn(Unit.FromCentimeter(9));
                infoTable.AddColumn(Unit.FromCentimeter(9));

                Row infoRow1 = infoTable.AddRow();
                Paragraph infoPara1 = infoRow1.Cells[0].AddParagraph();
                infoPara1.Style = "Body";
                infoPara1.AddText($"Bill No: {billNo}");

                Paragraph infoPara2 = infoRow1.Cells[1].AddParagraph();
                infoPara2.Style = "Body";
                infoPara2.AddText($"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                infoPara2.Format.Alignment = ParagraphAlignment.Right;

                Row infoRow2 = infoTable.AddRow();
                Paragraph infoPara3 = infoRow2.Cells[0].AddParagraph();
                infoPara3.Style = "Body";
                infoPara3.AddText($"Customer: {customerName}");

                Paragraph infoPara4 = infoRow2.Cells[1].AddParagraph();
                infoPara4.Style = "Body";
                infoPara4.AddText($"Cashier: {userName}");
                infoPara4.Format.Alignment = ParagraphAlignment.Right;

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
                itemsTable.AddColumn(Unit.FromCentimeter(1));
                itemsTable.AddColumn(Unit.FromCentimeter(5));
                itemsTable.AddColumn(Unit.FromCentimeter(2));
                itemsTable.AddColumn(Unit.FromCentimeter(2));
                itemsTable.AddColumn(Unit.FromCentimeter(2));
                itemsTable.AddColumn(Unit.FromCentimeter(3));
                itemsTable.AddColumn(Unit.FromCentimeter(3));

                Row tableHeaderRow = itemsTable.AddRow();
                tableHeaderRow.HeadingFormat = true;
                tableHeaderRow.Format.Font.Bold = true;
                tableHeaderRow.Shading.Color = Colors.LightBlue;
                tableHeaderRow.Cells[0].AddParagraph("No").Style = "TableHeader";
                tableHeaderRow.Cells[1].AddParagraph("Product Name").Style = "TableHeader";
                tableHeaderRow.Cells[2].AddParagraph("Variation").Style = "TableHeader";
                tableHeaderRow.Cells[3].AddParagraph("Unit").Style = "TableHeader";
                tableHeaderRow.Cells[4].AddParagraph("Qty").Style = "TableHeader";
                tableHeaderRow.Cells[5].AddParagraph("Price").Style = "TableHeader";
                tableHeaderRow.Cells[6].AddParagraph("Total").Style = "TableHeader";

                foreach (var item in cartItems)
                {
                    Row itemRow = itemsTable.AddRow();
                    itemRow.Cells[0].AddParagraph(item.ItemNumber.ToString()).Style = "Body";
                    itemRow.Cells[0].Format.Alignment = ParagraphAlignment.Center;
                    itemRow.Cells[1].AddParagraph(item.ProductName).Style = "Body";
                    itemRow.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                    itemRow.Cells[2].AddParagraph(item.VariationType).Style = "Body";
                    itemRow.Cells[2].Format.Alignment = ParagraphAlignment.Center;
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
                    itemRow.Cells[3].AddParagraph(displayUnit).Style = "Body";
                    itemRow.Cells[3].Format.Alignment = ParagraphAlignment.Center;
                    string qtyText = item.Unit == "Pieces" ? item.Quantity.ToString("N0") : item.Quantity.ToString("N2");
                    itemRow.Cells[4].AddParagraph(qtyText).Style = "Body";
                    itemRow.Cells[4].Format.Alignment = ParagraphAlignment.Center;
                    itemRow.Cells[5].AddParagraph(item.Price.ToString("N2")).Style = "Body";
                    itemRow.Cells[5].Format.Alignment = ParagraphAlignment.Right;
                    itemRow.Cells[6].AddParagraph($"LKR {item.TotalPrice:N2}").Style = "Body";
                    itemRow.Cells[6].Format.Alignment = ParagraphAlignment.Right;
                }

                section.AddParagraph().Format.SpaceAfter = 10;

                Table separatorTable2 = section.AddTable();
                separatorTable2.Borders.Width = 0;
                separatorTable2.Borders.Bottom.Width = 0.5;
                separatorTable2.AddColumn(Unit.FromCentimeter(18));
                Row separatorRow2 = separatorTable2.AddRow();
                separatorRow2.Cells[0].AddParagraph("");
                section.AddParagraph().Format.SpaceAfter = 5;

                Table summaryTable = section.AddTable();
                summaryTable.AddColumn(Unit.FromCentimeter(9));
                summaryTable.AddColumn(Unit.FromCentimeter(9));

                Row summaryRow1 = summaryTable.AddRow();
                summaryRow1.Cells[0].AddParagraph($"Total Items: {totalItems}").Style = "Body";
                summaryRow1.Cells[1].AddParagraph($"Sub Total: LKR {totalPrice + discount:N2}").Style = "Body";
                summaryRow1.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                Row summaryRow2 = summaryTable.AddRow();
                summaryRow2.Cells[0].AddParagraph($"Discount: LKR {discount:N2}").Style = "Body";
                summaryRow2.Cells[1].AddParagraph($"Total: LKR {totalPrice:N2}").Style = "Body";
                summaryRow2.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                Row summaryRow3 = summaryTable.AddRow();
                summaryRow3.Cells[0].AddParagraph($"Payment Method: {paymentMethod}").Style = "Body";

                if (paymentMethod == "Cash")
                {
                    Row summaryRow4 = summaryTable.AddRow();
                    summaryRow4.Cells[0].AddParagraph($"Cash Paid: LKR {cashPaid:N2}").Style = "Body";
                    summaryRow4.Cells[1].AddParagraph($"Balance: LKR {balance:N2}").Style = "Body";
                    summaryRow4.Cells[1].Format.Alignment = ParagraphAlignment.Right;
                }

                section.AddParagraph().Format.SpaceAfter = 20;

                Table footerTable = section.AddTable();
                footerTable.Borders.Width = 0.5;
                footerTable.Borders.Color = Colors.Black;
                footerTable.AddColumn(Unit.FromCentimeter(18));
                Row footerRow = footerTable.AddRow();
                footerRow.Shading.Color = Colors.LightGray;
                Paragraph footerPara = footerRow.Cells[0].AddParagraph();
                footerPara.Style = "Body";
                footerPara.AddText("Thank you for your purchase!");
                footerPara.Format.Alignment = ParagraphAlignment.Center;
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
