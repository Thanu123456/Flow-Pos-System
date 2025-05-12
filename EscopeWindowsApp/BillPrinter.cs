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
                double baseHeight = 120; // Base height without items (mm)
                double bottomSpace = 80; // Buffer for summary, barcode, and footer
                double totalHeight = baseHeight + (itemCount * 20) + bottomSpace; // 20 mm per item (2 rows)
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

            Style titleStyle = document.Styles.AddStyle("Title", "Normal");
            titleStyle.Font.Name = "Arial";
            titleStyle.Font.Size = isSmallReceipt ? 14 : 20;
            titleStyle.Font.Bold = true;
            titleStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            titleStyle.ParagraphFormat.SpaceAfter = isSmallReceipt ? 6 : 10;

            Style subtitleStyle = document.Styles.AddStyle("Subtitle", "Normal");
            subtitleStyle.Font.Name = "Arial";
            subtitleStyle.Font.Size = isSmallReceipt ? 12 : 14;
            subtitleStyle.Font.Bold = true;
            subtitleStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            subtitleStyle.ParagraphFormat.SpaceAfter = isSmallReceipt ? 6 : 10;

            Style bodyStyle = document.Styles.AddStyle("Body", "Normal");
            bodyStyle.Font.Name = "Courier New";
            bodyStyle.Font.Size = isSmallReceipt ? 9 : 10;
            bodyStyle.ParagraphFormat.SpaceAfter = 3;

            Style tableDataStyle = document.Styles.AddStyle("TableData", "Body");
            tableDataStyle.Font.Name = "Courier New";
            tableDataStyle.Font.Size = isSmallReceipt ? 9 : 10;

            Style priceStyle = document.Styles.AddStyle("PriceStyle", "TableData");
            priceStyle.Font.Bold = true;

            Style tableHeaderStyle = document.Styles.AddStyle("TableHeader", "Normal");
            tableHeaderStyle.Font.Name = "Courier New";
            tableHeaderStyle.Font.Size = isSmallReceipt ? 9 : 10;
            tableHeaderStyle.Font.Bold = true;

            Style boldBodyStyle = document.Styles.AddStyle("BoldBody", "Body");
            boldBodyStyle.Font.Bold = true;

            Style footerStyle = document.Styles.AddStyle("Footer", "Body");
            footerStyle.Font.Name = "Arial";
            footerStyle.Font.Size = isSmallReceipt ? 8 : 9;
            footerStyle.Font.Italic = true;

            CompanyDetails company = LoadCompanyDetails();

            if (isSmallReceipt)
            {
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

                Table separator1 = section.AddTable();
                separator1.AddColumn(Unit.FromMillimeter(74));
                Row sepRow1 = separator1.AddRow();
                sepRow1.Borders.Top.Width = 0;
                sepRow1.Borders.Left.Width = 0;
                sepRow1.Borders.Right.Width = 0;
                sepRow1.Borders.Bottom.Width = 0.5;
                sepRow1.Borders.Bottom.Style = MigraDoc.DocumentObjectModel.BorderStyle.DashLargeGap; section.AddParagraph().Format.SpaceAfter = 6;

                Table cashierTable = section.AddTable();
                cashierTable.AddColumn(Unit.FromMillimeter(37));
                cashierTable.AddColumn(Unit.FromMillimeter(37));

                Row cashierRow = cashierTable.AddRow();
                cashierRow.Cells[0].AddParagraph("CASHIER:").Style = "BoldBody";
                cashierRow.Cells[1].AddParagraph(userName).Style = "Body";
                cashierRow.Cells[1].Format.Alignment = ParagraphAlignment.Left;

                Row unitRow = cashierTable.AddRow();
                unitRow.Cells[0].AddParagraph("UNIT NO:").Style = "BoldBody";
                unitRow.Cells[1].AddParagraph("1").Style = "Body";
                unitRow.Cells[1].Format.Alignment = ParagraphAlignment.Left;

                Row timeRow = cashierTable.AddRow();
                timeRow.Cells[0].AddParagraph("START TIME:").Style = "BoldBody";
                timeRow.Cells[1].AddParagraph(DateTime.Now.ToString("HH:mm:ss")).Style = "Body";
                timeRow.Cells[1].Format.Alignment = ParagraphAlignment.Left;

                Row invoiceRow = cashierTable.AddRow();
                invoiceRow.Cells[0].AddParagraph("INVOICE NO:").Style = "BoldBody";
                invoiceRow.Cells[1].AddParagraph(billNo).Style = "Body";
                invoiceRow.Cells[1].Format.Alignment = ParagraphAlignment.Left;

                Table separator2 = section.AddTable();
                separator2.AddColumn(Unit.FromMillimeter(74));
                Row sepRow2 = separator2.AddRow();
                sepRow2.Borders.Top.Width = 0;
                sepRow2.Borders.Left.Width = 0;
                sepRow2.Borders.Right.Width = 0;
                sepRow2.Borders.Bottom.Width = 0.5;
                sepRow1.Borders.Bottom.Style = MigraDoc.DocumentObjectModel.BorderStyle.DashLargeGap;
                section.AddParagraph().Format.SpaceAfter = 6;

                Table itemsHeaderTable = section.AddTable();
                itemsHeaderTable.AddColumn(Unit.FromMillimeter(17));
                itemsHeaderTable.AddColumn(Unit.FromMillimeter(19));
                itemsHeaderTable.AddColumn(Unit.FromMillimeter(19));
                itemsHeaderTable.AddColumn(Unit.FromMillimeter(19));

                Row itemsHeaderRow = itemsHeaderTable.AddRow();
                itemsHeaderRow.Shading.Color = Colors.LightGray;
                itemsHeaderRow.Cells[0].AddParagraph("QTY").Style = "TableHeader";
                itemsHeaderRow.Cells[0].Format.Alignment = ParagraphAlignment.Right;
                itemsHeaderRow.Cells[1].AddParagraph("U/PRICE").Style = "TableHeader";
                itemsHeaderRow.Cells[1].Format.Alignment = ParagraphAlignment.Right;
                itemsHeaderRow.Cells[2].AddParagraph("PRICE").Style = "TableHeader";
                itemsHeaderRow.Cells[2].Format.Alignment = ParagraphAlignment.Right;
                itemsHeaderRow.Cells[3].AddParagraph("VALUE").Style = "TableHeader";
                itemsHeaderRow.Cells[3].Format.Alignment = ParagraphAlignment.Right;

                foreach (var item in cartItems)
                {
                    Table productTable = section.AddTable();
                    productTable.AddColumn(Unit.FromMillimeter(74));

                    Row productRow = productTable.AddRow();
                    string variation = string.IsNullOrEmpty(item.VariationType) || item.VariationType == "N/A" ? "" : $" {item.VariationType}";
                    string productDisplay = item.ProductName.ToUpper() + variation;
                    if (productDisplay.Length > 30) productDisplay = productDisplay.Substring(0, 30); // Truncate to fit
                    productRow.Cells[0].AddParagraph(productDisplay).Style = "TableData";
                    productRow.Cells[0].Format.Alignment = ParagraphAlignment.Left;

                    Table itemRowTable = section.AddTable();
                    itemRowTable.AddColumn(Unit.FromMillimeter(17));
                    itemRowTable.AddColumn(Unit.FromMillimeter(19));
                    itemRowTable.AddColumn(Unit.FromMillimeter(19));
                    itemRowTable.AddColumn(Unit.FromMillimeter(19));

                    Row itemRow = itemRowTable.AddRow();
                    string qtyText;
                    if (item.Unit == "Pieces")
                    {
                        qtyText = item.Quantity.ToString("N0").PadLeft(7, ' ');
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
                        qtyText = $"{item.Quantity:N2}{unitAbbrev}".PadLeft(7, ' ');
                    }
                    itemRow.Cells[0].AddParagraph(qtyText).Style = "TableData";
                    itemRow.Cells[0].Format.Alignment = ParagraphAlignment.Right;

                    string unitPriceText = string.Format("{0,10:0.00}", item.Price);
                    itemRow.Cells[1].AddParagraph(unitPriceText).Style = "TableData";
                    itemRow.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                    string priceText = string.Format("{0,10:0.00}", item.Price);
                    itemRow.Cells[2].AddParagraph(priceText).Style = "TableData";
                    itemRow.Cells[2].Format.Alignment = ParagraphAlignment.Right;

                    string valueText = string.Format("{0,10:0.00}", item.TotalPrice);
                    itemRow.Cells[3].AddParagraph(valueText).Style = "PriceStyle";
                    itemRow.Cells[3].Format.Alignment = ParagraphAlignment.Right;
                }

                Table separator3 = section.AddTable();
                separator3.AddColumn(Unit.FromMillimeter(74));
                Row sepRow3 = separator3.AddRow();
                sepRow3.Borders.Top.Width = 0;
                sepRow3.Borders.Left.Width = 0;
                sepRow3.Borders.Right.Width = 0;
                sepRow3.Borders.Bottom.Width = 0.5;
                sepRow1.Borders.Bottom.Style = MigraDoc.DocumentObjectModel.BorderStyle.DashLargeGap;
                section.AddParagraph().Format.SpaceAfter = 6;

                Table summaryTable = section.AddTable();
                summaryTable.AddColumn(Unit.FromMillimeter(37));
                summaryTable.AddColumn(Unit.FromMillimeter(37));
                summaryTable.Shading.Color = Colors.WhiteSmoke;

                Row summaryRow1 = summaryTable.AddRow();
                summaryRow1.Cells[0].AddParagraph("SUB TOTAL").Style = "BoldBody";
                summaryRow1.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                summaryRow1.Cells[1].AddParagraph($"LKR{string.Format("{0,12:0.00}", totalPrice + discount)}").Style = "BoldBody";
                summaryRow1.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                Row summaryRow2 = summaryTable.AddRow();
                summaryRow2.Cells[0].AddParagraph("DISCOUNT").Style = "Body";
                summaryRow2.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                summaryRow2.Cells[1].AddParagraph($"LKR{string.Format("{0,12:0.00}", discount)}").Style = "Body";
                summaryRow2.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                Row summaryRow3 = summaryTable.AddRow();
                summaryRow3.Cells[0].AddParagraph("TOTAL").Style = "BoldBody";
                summaryRow3.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                summaryRow3.Cells[1].AddParagraph($"LKR{string.Format("{0,12:0.00}", totalPrice)}").Style = "BoldBody";
                summaryRow3.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                Row summaryRow4 = summaryTable.AddRow();
                summaryRow4.Cells[0].AddParagraph("PAYMENT METHOD").Style = "Body";
                summaryRow4.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                summaryRow4.Cells[1].AddParagraph(paymentMethod).Style = "Body";
                summaryRow4.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                Row itemsCountRow = summaryTable.AddRow();
                itemsCountRow.Cells[0].AddParagraph("NO OF ITEMS").Style = "Body";
                itemsCountRow.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                itemsCountRow.Cells[1].AddParagraph(totalItems.ToString()).Style = "Body";
                itemsCountRow.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                if (paymentMethod == "Cash")
                {
                    Row summaryRow5 = summaryTable.AddRow();
                    summaryRow5.Cells[0].AddParagraph("CASH").Style = "BoldBody";
                    summaryRow5.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    summaryRow5.Cells[1].AddParagraph($"LKR{string.Format("{0,12:0.00}", cashPaid)}").Style = "BoldBody";
                    summaryRow5.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                    Row summaryRow6 = summaryTable.AddRow();
                    summaryRow6.Cells[0].AddParagraph("BALANCE").Style = "BoldBody";
                    summaryRow6.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    summaryRow6.Cells[1].AddParagraph($"LKR{string.Format("{0,12:0.00}", balance)}").Style = "BoldBody";
                    summaryRow6.Cells[1].Format.Alignment = ParagraphAlignment.Right;
                }

                Table separator4 = section.AddTable();
                separator4.AddColumn(Unit.FromMillimeter(74));
                Row sepRow4 = separator4.AddRow();
                sepRow4.Borders.Top.Width = 0;
                sepRow4.Borders.Left.Width = 0;
                sepRow4.Borders.Right.Width = 0;
                sepRow4.Borders.Bottom.Width = 0.5;
                sepRow1.Borders.Bottom.Style = MigraDoc.DocumentObjectModel.BorderStyle.DashLargeGap;
                section.AddParagraph().Format.SpaceAfter = 6;

                string barcodePath = GenerateBarcodeImage(billNo);
                tempFiles.Add(barcodePath);
                Paragraph barcodePara = section.AddParagraph();
                barcodePara.Format.Alignment = ParagraphAlignment.Center;
                var barcodeImage = barcodePara.AddImage(barcodePath);
                barcodeImage.Width = Unit.FromMillimeter(60);
                barcodeImage.LockAspectRatio = true;
                section.AddParagraph().Format.SpaceAfter = 6;

                Paragraph thankYou = section.AddParagraph();
                thankYou.Style = "Subtitle";
                thankYou.AddText("THANK YOU!");
                thankYou.Format.Alignment = ParagraphAlignment.Center;
            }
            else
            {
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