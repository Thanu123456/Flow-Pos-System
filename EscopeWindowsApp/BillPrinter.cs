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
using System.Diagnostics;

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

        public static void PrintRefundBill(string originalBillNo, string refundBillNo, string userName, int totalItems, decimal totalRefundAmount, List<CartItem> refundItems, string refundReason, string refundNotes)
        {
            string receiptPath = GenerateProfessionalRefundBillPDF(originalBillNo, refundBillNo, userName, totalItems, totalRefundAmount, refundItems, refundReason, refundNotes);
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
                    PureBarcode = true
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

            section.PageSetup.PageWidth = Unit.FromMillimeter(80);
            section.PageSetup.LeftMargin = Unit.FromMillimeter(3);
            section.PageSetup.RightMargin = Unit.FromMillimeter(3);
            section.PageSetup.TopMargin = Unit.FromMillimeter(5);
            section.PageSetup.BottomMargin = Unit.FromMillimeter(5);

            int itemCount = cartItems.Count;
            double baseHeight = 66;
            double bottomSpace = 50;
            if (paymentMethod == "Cash") baseHeight += 5;
            double totalHeight = baseHeight + bottomSpace + 10 + (10 * itemCount);
            if (totalHeight > 640) totalHeight = 640;
            totalHeight -= 10; // Cut 1cm from the bottom of the bill
            section.PageSetup.PageHeight = Unit.FromMillimeter(totalHeight);

            Style titleStyle = document.Styles.AddStyle("Title", "Normal");
            titleStyle.Font.Name = "Courier New";
            titleStyle.Font.Size = 12;
            titleStyle.Font.Bold = true;
            titleStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            titleStyle.ParagraphFormat.SpaceAfter = 4;

            Style bodyStyle = document.Styles.AddStyle("Body", "Normal");
            bodyStyle.Font.Name = "Courier New";
            bodyStyle.Font.Size = 8;
            bodyStyle.ParagraphFormat.SpaceAfter = 0;

            Style boldBodyStyle = document.Styles.AddStyle("BoldBody", "Body");
            boldBodyStyle.Font.Bold = true;

            Style rightAlignStyle = document.Styles.AddStyle("RightAlign", "Body");
            rightAlignStyle.ParagraphFormat.Alignment = ParagraphAlignment.Right;

            Style centerStyle = document.Styles.AddStyle("Center", "Body");
            centerStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;

            CompanyDetails company = LoadCompanyDetails();

            Paragraph logoPara = section.AddParagraph();
            logoPara.Format.Alignment = ParagraphAlignment.Center;
            if (company.Logo != null && company.Logo.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(company.Logo))
                    using (Image image = Image.FromStream(ms))
                    {
                        string tempImagePath = Path.Combine(Path.GetTempPath(), $"logo_{Guid.NewGuid()}.png");
                        image.Save(tempImagePath, ImageFormat.Png);
                        tempFiles.Add(tempImagePath);
                        var pdfImage = logoPara.AddImage(tempImagePath);
                        pdfImage.Width = Unit.FromMillimeter(45);
                        pdfImage.LockAspectRatio = true;
                    }
                }
                catch (Exception ex)
                {
                    logoPara.AddText($"[Error loading logo: {ex.Message}]");
                }
            }
            else
            {
                logoPara.AddText("E SCOPE INTERNATIONAL");
                logoPara.Style = "Title";
            }

            Paragraph storeName = section.AddParagraph();
            storeName.Style = "Title";
            storeName.AddText(company.Name);

            Paragraph address = section.AddParagraph();
            address.Style = "Center";
            address.AddText(company.Address);

            Paragraph phone = section.AddParagraph();
            phone.Style = "Center";
            phone.AddText($"CONTACT: {company.PhoneNumber}");

            Paragraph separator1 = section.AddParagraph();
            separator1.AddText("============================================");
            separator1.Style = "Center";

            Table dateTimeTable = section.AddTable();
            dateTimeTable.Borders.Width = 0;
            dateTimeTable.AddColumn("3.5cm");
            dateTimeTable.AddColumn("3.9cm");

            Row dateTimeRow = dateTimeTable.AddRow();
            dateTimeRow.Format.Font.Name = "Courier New";
            dateTimeRow.Format.Font.Size = 8;
            dateTimeRow.Cells[0].AddParagraph($"DATE: {DateTime.Now:dd/MM/yyyy}").Format.Alignment = ParagraphAlignment.Left;
            dateTimeRow.Cells[1].AddParagraph($"TIME: {DateTime.Now:HH:mm:ss}").Format.Alignment = ParagraphAlignment.Right;

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

            Paragraph separator2 = section.AddParagraph();
            separator2.AddText("============================================");
            separator2.Style = "Center";

            Table itemsTable = section.AddTable();
            itemsTable.Style = "Table";
            itemsTable.Borders.Width = 0.25;
            itemsTable.Borders.Left.Width = 0;
            itemsTable.Borders.Right.Width = 0;
            itemsTable.Borders.Top.Width = 0;
            itemsTable.Borders.Bottom.Width = 0;
            itemsTable.Rows.LeftIndent = 0;

            Column column = itemsTable.AddColumn("1.8cm");
            column.Format.Alignment = ParagraphAlignment.Right;
            column = itemsTable.AddColumn("2.8cm");
            column.Format.Alignment = ParagraphAlignment.Right;
            column = itemsTable.AddColumn("2.8cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            Row headerRow1 = itemsTable.AddRow();
            headerRow1.HeadingFormat = true;
            headerRow1.Format.Font.Size = 7;
            headerRow1.Format.Font.Name = "Courier New";
            headerRow1.Format.Font.Bold = false;
            headerRow1.Cells[0].MergeRight = 2;
            headerRow1.Cells[0].AddParagraph("");
            headerRow1.Cells[0].Format.Alignment = ParagraphAlignment.Left;

            Row headerRow2 = itemsTable.AddRow();
            headerRow2.HeadingFormat = true;
            headerRow2.Format.Font.Size = 8;
            headerRow2.Format.Font.Name = "Courier New";
            headerRow2.Format.Font.Bold = true;
            headerRow2.Cells[0].AddParagraph("QTY");
            headerRow2.Cells[0].Format.Alignment = ParagraphAlignment.Right;
            headerRow2.Cells[1].AddParagraph("PRICE");
            headerRow2.Cells[1].Format.Alignment = ParagraphAlignment.Right;
            headerRow2.Cells[2].AddParagraph("AMOUNT");
            headerRow2.Cells[2].Format.Alignment = ParagraphAlignment.Right;

            foreach (var item in cartItems)
            {
                Row descRow = itemsTable.AddRow();
                descRow.Height = Unit.FromMillimeter(5);
                descRow.Format.Font.Size = 8;
                descRow.Format.Font.Name = "Courier New";
                descRow.Cells[0].MergeRight = 2;

                string productDisplay = item.ProductName.ToUpper();
                if (!string.IsNullOrEmpty(item.VariationType) && item.VariationType != "N/A")
                {
                    productDisplay += $" ({item.VariationType})";
                }
                if (productDisplay.Length > 40) productDisplay = productDisplay.Substring(0, 37) + "...";
                descRow.Cells[0].AddParagraph(productDisplay);
                descRow.Cells[0].Format.Alignment = ParagraphAlignment.Left;

                Row dataRow = itemsTable.AddRow();
                dataRow.Height = Unit.FromMillimeter(5);
                dataRow.Format.Font.Size = 8;
                dataRow.Format.Font.Name = "Courier New";

                string qtyText = item.Unit == "Pieces" ? item.Quantity.ToString("0") : $"{item.Quantity:0.00}{GetStandardUnitAbbreviation(item.Unit)}";
                dataRow.Cells[0].AddParagraph(qtyText);
                dataRow.Cells[0].Format.Alignment = ParagraphAlignment.Right;
                dataRow.Cells[1].AddParagraph(item.Price.ToString("0.00"));
                dataRow.Cells[1].Format.Alignment = ParagraphAlignment.Right;
                dataRow.Cells[2].AddParagraph(item.TotalPrice.ToString("0.00"));
                dataRow.Cells[2].Format.Alignment = ParagraphAlignment.Right;
            }

            Paragraph separator3 = section.AddParagraph();
            separator3.AddText("============================================");
            separator3.Style = "Center";

            decimal subTotal = totalPrice + discount;
            Table summaryTable = section.AddTable();
            summaryTable.Borders.Width = 0;
            summaryTable.AddColumn("3.5cm");
            summaryTable.AddColumn("3.9cm");

            Row row = summaryTable.AddRow();
            row.Format.Font.Name = "Courier New";
            row.Format.Font.Size = 8;
            row.Cells[0].AddParagraph("SUB TOTAL:").Format.Alignment = ParagraphAlignment.Left;
            row.Cells[1].AddParagraph($"LKR {subTotal:0.00}").Format.Alignment = ParagraphAlignment.Right;

            if (discount > 0)
            {
                row = summaryTable.AddRow();
                row.Format.Font.Name = "Courier New";
                row.Format.Font.Size = 8;
                row.Cells[0].AddParagraph("DISCOUNT:").Format.Alignment = ParagraphAlignment.Left;
                row.Cells[1].AddParagraph($"LKR {discount:0.00}").Format.Alignment = ParagraphAlignment.Right;
            }

            row = summaryTable.AddRow();
            row.Format.Font.Name = "Courier New";
            row.Format.Font.Size = 8;
            row.Format.Font.Bold = true;
            row.Cells[0].AddParagraph("TOTAL:").Format.Alignment = ParagraphAlignment.Left;
            row.Cells[1].AddParagraph($"LKR {totalPrice:0.00}").Format.Alignment = ParagraphAlignment.Right;

            row = summaryTable.AddRow();
            row.Format.Font.Name = "Courier New";
            row.Format.Font.Size = 8;
            row.Cells[0].AddParagraph("PAYMENT:").Format.Alignment = ParagraphAlignment.Left;
            row.Cells[1].AddParagraph(paymentMethod.ToUpper()).Format.Alignment = ParagraphAlignment.Right;

            if (paymentMethod == "Cash")
            {
                row = summaryTable.AddRow();
                row.Format.Font.Name = "Courier New";
                row.Format.Font.Size = 8;
                row.Cells[0].AddParagraph("CASH PAID:").Format.Alignment = ParagraphAlignment.Left;
                row.Cells[1].AddParagraph($"LKR {cashPaid:0.00}").Format.Alignment = ParagraphAlignment.Right;

                row = summaryTable.AddRow();
                row.Format.Font.Name = "Courier New";
                row.Format.Font.Size = 8;
                row.Format.Font.Bold = true;
                row.Cells[0].AddParagraph("BALANCE:").Format.Alignment = ParagraphAlignment.Left;
                row.Cells[1].AddParagraph($"LKR {balance:0.00}").Format.Alignment = ParagraphAlignment.Right;
            }

            row = summaryTable.AddRow();
            row.Format.Font.Name = "Courier New";
            row.Format.Font.Size = 8;
            row.Cells[0].AddParagraph("TOTAL ITEMS:").Format.Alignment = ParagraphAlignment.Left;
            row.Cells[1].AddParagraph(totalItems.ToString()).Format.Alignment = ParagraphAlignment.Right;

            Paragraph separator4 = section.AddParagraph();
            separator4.AddText("============================================");
            separator4.Style = "Center";

            string barcodePath = GenerateBarcodeImage(billNo);
            tempFiles.Add(barcodePath);
            Paragraph barcodePara = section.AddParagraph();
            barcodePara.Format.Alignment = ParagraphAlignment.Center;
            var barcodeImage = barcodePara.AddImage(barcodePath);
            barcodeImage.Width = Unit.FromMillimeter(55);
            barcodeImage.LockAspectRatio = true;

            Paragraph thankYou = section.AddParagraph();
            thankYou.Style = "Title";
            thankYou.AddText("THANK YOU FOR YOUR VISIT!");

            Paragraph softwareCompany = section.AddParagraph();
            softwareCompany.Style = "Center";
            softwareCompany.Format.Font.Size = 7;
            softwareCompany.Format.Font.Color = Colors.Black;
            softwareCompany.Format.Font.Bold = true;
            softwareCompany.AddText("Software by E-Scope International - 077 198 6400");

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

        private static string GenerateProfessionalRefundBillPDF(string originalBillNo, string refundBillNo, string userName, int totalItems, decimal totalRefundAmount, List<CartItem> refundItems, string refundReason, string refundNotes)
        {
            string pdfPath = Path.Combine(Environment.CurrentDirectory, $"{refundBillNo}_refund_receipt.pdf");
            List<string> tempFiles = new List<string>();

            Document document = new Document();
            Section section = document.AddSection();

            section.PageSetup.PageWidth = Unit.FromMillimeter(80);
            section.PageSetup.LeftMargin = Unit.FromMillimeter(3);
            section.PageSetup.RightMargin = Unit.FromMillimeter(3);
            section.PageSetup.TopMargin = Unit.FromMillimeter(5);
            section.PageSetup.BottomMargin = Unit.FromMillimeter(5);

            int itemCount = refundItems.Count;
            double baseHeight = 66;
            double bottomSpace = 50;
            double totalHeight = baseHeight + bottomSpace + 10 + (10 * itemCount);
            if (totalHeight > 640) totalHeight = 640;
            totalHeight -= 5; // Cut 0.5cm from the bottom of the bill
            section.PageSetup.PageHeight = Unit.FromMillimeter(totalHeight);

            Style titleStyle = document.Styles.AddStyle("Title", "Normal");
            titleStyle.Font.Name = "Courier New";
            titleStyle.Font.Size = 12;
            titleStyle.Font.Bold = true;
            titleStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            titleStyle.ParagraphFormat.SpaceAfter = 4;

            Style bodyStyle = document.Styles.AddStyle("Body", "Normal");
            bodyStyle.Font.Name = "Courier New";
            bodyStyle.Font.Size = 8;
            bodyStyle.ParagraphFormat.SpaceAfter = 0;

            Style boldBodyStyle = document.Styles.AddStyle("BoldBody", "Body");
            boldBodyStyle.Font.Bold = true;

            Style rightAlignStyle = document.Styles.AddStyle("RightAlign", "Body");
            rightAlignStyle.ParagraphFormat.Alignment = ParagraphAlignment.Right;

            Style centerStyle = document.Styles.AddStyle("Center", "Body");
            centerStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;

            CompanyDetails company = LoadCompanyDetails();

            Paragraph logoPara = section.AddParagraph();
            logoPara.Format.Alignment = ParagraphAlignment.Center;
            if (company.Logo != null && company.Logo.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(company.Logo))
                    using (Image image = Image.FromStream(ms))
                    {
                        string tempImagePath = Path.Combine(Path.GetTempPath(), $"logo_{Guid.NewGuid()}.png");
                        image.Save(tempImagePath, ImageFormat.Png);
                        tempFiles.Add(tempImagePath);
                        var pdfImage = logoPara.AddImage(tempImagePath);
                        pdfImage.Width = Unit.FromMillimeter(45);
                        pdfImage.LockAspectRatio = true;
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

            Paragraph storeName = section.AddParagraph();
            storeName.Style = "Title";
            storeName.AddText(company.Name);

            Paragraph address = section.AddParagraph();
            address.Style = "Center";
            address.AddText(company.Address);

            Paragraph phone = section.AddParagraph();
            phone.Style = "Center";
            phone.AddText($"CONTACT: {company.PhoneNumber}");

            Paragraph separator1 = section.AddParagraph();
            separator1.AddText("============================================");
            separator1.Style = "Center";

            Paragraph refundHeader = section.AddParagraph();
            refundHeader.Style = "Title";
            refundHeader.AddText("REFUND RECEIPT");

            Table dateTimeTable = section.AddTable();
            dateTimeTable.Borders.Width = 0;
            dateTimeTable.AddColumn("3.5cm");
            dateTimeTable.AddColumn("3.9cm");

            Row dateTimeRow = dateTimeTable.AddRow();
            dateTimeRow.Format.Font.Name = "Courier New";
            dateTimeRow.Format.Font.Size = 8;
            dateTimeRow.Cells[0].AddParagraph($"DATE: {DateTime.Now:dd/MM/yyyy}").Format.Alignment = ParagraphAlignment.Left;
            dateTimeRow.Cells[1].AddParagraph($"TIME: {DateTime.Now:HH:mm:ss}").Format.Alignment = ParagraphAlignment.Right;

            Table invoiceTable = section.AddTable();
            invoiceTable.Borders.Width = 0;
            invoiceTable.AddColumn("3.5cm");
            invoiceTable.AddColumn("3.9cm");

            Row originalInvoiceRow = invoiceTable.AddRow();
            originalInvoiceRow.Format.Font.Name = "Courier New";
            originalInvoiceRow.Format.Font.Size = 8;
            originalInvoiceRow.Cells[0].AddParagraph("ORIGINAL BILL NO:").Format.Alignment = ParagraphAlignment.Left;
            originalInvoiceRow.Cells[1].AddParagraph(originalBillNo).Format.Alignment = ParagraphAlignment.Right;

            Row refundInvoiceRow = invoiceTable.AddRow();
            refundInvoiceRow.Format.Font.Name = "Courier New";
            refundInvoiceRow.Format.Font.Size = 8;
            refundInvoiceRow.Cells[0].AddParagraph("REFUND INVOICE NO:").Format.Alignment = ParagraphAlignment.Left;
            refundInvoiceRow.Cells[1].AddParagraph(refundBillNo).Format.Alignment = ParagraphAlignment.Right;

            Paragraph cashierPara = section.AddParagraph();
            cashierPara.Style = "Body";
            cashierPara.AddText($"CASHIER: {userName}");

            Paragraph separator2 = section.AddParagraph();
            separator2.AddText("============================================");
            separator2.Style = "Center";

            Table itemsTable = section.AddTable();
            itemsTable.Style = "Table";
            itemsTable.Borders.Width = 0.25;
            itemsTable.Borders.Left.Width = 0;
            itemsTable.Borders.Right.Width = 0;
            itemsTable.Borders.Top.Width = 0;
            itemsTable.Borders.Bottom.Width = 0;
            itemsTable.Rows.LeftIndent = 0;

            Column column = itemsTable.AddColumn("1.8cm");
            column.Format.Alignment = ParagraphAlignment.Right;
            column = itemsTable.AddColumn("2.8cm");
            column.Format.Alignment = ParagraphAlignment.Right;
            column = itemsTable.AddColumn("2.8cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            Row headerRow1 = itemsTable.AddRow();
            headerRow1.HeadingFormat = true;
            headerRow1.Format.Font.Size = 7;
            headerRow1.Format.Font.Name = "Courier New";
            headerRow1.Format.Font.Bold = false;
            headerRow1.Cells[0].MergeRight = 2;
            headerRow1.Cells[0].AddParagraph("");
            headerRow1.Cells[0].Format.Alignment = ParagraphAlignment.Left;

            Row headerRow2 = itemsTable.AddRow();
            headerRow2.HeadingFormat = true;
            headerRow2.Format.Font.Size = 8;
            headerRow2.Format.Font.Name = "Courier New";
            headerRow2.Format.Font.Bold = true;
            headerRow2.Cells[0].AddParagraph("QTY");
            headerRow2.Cells[0].Format.Alignment = ParagraphAlignment.Right;
            headerRow2.Cells[1].AddParagraph("PRICE");
            headerRow2.Cells[1].Format.Alignment = ParagraphAlignment.Right;
            headerRow2.Cells[2].AddParagraph("AMOUNT");
            headerRow2.Cells[2].Format.Alignment = ParagraphAlignment.Right;

            foreach (var item in refundItems)
            {
                Row descRow = itemsTable.AddRow();
                descRow.Height = Unit.FromMillimeter(5);
                descRow.Format.Font.Size = 8;
                descRow.Format.Font.Name = "Courier New";
                descRow.Cells[0].MergeRight = 2;

                string productDisplay = item.ProductName.ToUpper();
                if (!string.IsNullOrEmpty(item.VariationType) && item.VariationType != "N/A")
                {
                    productDisplay += $" ({item.VariationType})";
                }
                if (productDisplay.Length > 40) productDisplay = productDisplay.Substring(0, 37) + "...";
                descRow.Cells[0].AddParagraph(productDisplay);
                descRow.Cells[0].Format.Alignment = ParagraphAlignment.Left;

                Row dataRow = itemsTable.AddRow();
                dataRow.Height = Unit.FromMillimeter(5);
                dataRow.Format.Font.Size = 8;
                dataRow.Format.Font.Name = "Courier New";

                string qtyText = item.Unit == "Pieces" ? (-item.Quantity).ToString("0") : $"{(-item.Quantity):0.00}{GetStandardUnitAbbreviation(item.Unit)}";
                dataRow.Cells[0].AddParagraph(qtyText);
                dataRow.Cells[0].Format.Alignment = ParagraphAlignment.Right;
                dataRow.Cells[1].AddParagraph(item.Price.ToString("0.00"));
                dataRow.Cells[1].Format.Alignment = ParagraphAlignment.Right;
                dataRow.Cells[2].AddParagraph(item.TotalPrice.ToString("0.00"));
                dataRow.Cells[2].Format.Alignment = ParagraphAlignment.Right;
            }

            Paragraph separator3 = section.AddParagraph();
            separator3.AddText("============================================");
            separator3.Style = "Center";

            Table summaryTable = section.AddTable();
            summaryTable.Borders.Width = 0;
            summaryTable.AddColumn("3.5cm");
            summaryTable.AddColumn("3.9cm");

            Row row = summaryTable.AddRow();
            row.Format.Font.Name = "Courier New";
            row.Format.Font.Size = 8;
            row.Format.Font.Bold = true;
            row.Cells[0].AddParagraph("REFUND TOTAL:").Format.Alignment = ParagraphAlignment.Left;
            row.Cells[1].AddParagraph($"LKR {totalRefundAmount:0.00}").Format.Alignment = ParagraphAlignment.Right;

            row = summaryTable.AddRow();
            row.Format.Font.Name = "Courier New";
            row.Format.Font.Size = 8;
            row.Cells[0].AddParagraph("TOTAL ITEMS:").Format.Alignment = ParagraphAlignment.Left;
            row.Cells[1].AddParagraph(totalItems.ToString()).Format.Alignment = ParagraphAlignment.Right;

            row = summaryTable.AddRow();
            row.Format.Font.Name = "Courier New";
            row.Format.Font.Size = 8;
            row.Cells[0].AddParagraph("REASON:").Format.Alignment = ParagraphAlignment.Left;
            row.Cells[1].AddParagraph(refundReason).Format.Alignment = ParagraphAlignment.Right;

            if (!string.IsNullOrEmpty(refundNotes))
            {
                row = summaryTable.AddRow();
                row.Format.Font.Name = "Courier New";
                row.Format.Font.Size = 8;
                row.Cells[0].AddParagraph("NOTES:").Format.Alignment = ParagraphAlignment.Left;
                row.Cells[1].AddParagraph(refundNotes).Format.Alignment = ParagraphAlignment.Right;
            }

            Paragraph separator4 = section.AddParagraph();
            separator4.AddText("============================================");
            separator4.Style = "Center";

            string barcodePath = GenerateBarcodeImage(refundBillNo);
            tempFiles.Add(barcodePath);
            Paragraph barcodePara = section.AddParagraph();
            barcodePara.Format.Alignment = ParagraphAlignment.Center;
            var barcodeImage = barcodePara.AddImage(barcodePath);
            barcodeImage.Width = Unit.FromMillimeter(55);
            barcodeImage.LockAspectRatio = true;

            Paragraph thankYou = section.AddParagraph();
            thankYou.Style = "Title";
            thankYou.AddText("THANK YOU FOR YOUR VISIT!");

            Paragraph softwareCompany = section.AddParagraph();
            softwareCompany.Style = "Center";
            softwareCompany.Format.Font.Size = 7;
            softwareCompany.Format.Font.Color = Colors.Black;
            softwareCompany.Format.Font.Bold = true;
            softwareCompany.AddText("Software by E-Scope International - 077 198 6400");

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

        private static string GetStandardUnitAbbreviation(string unitName)
        {
            if (string.IsNullOrEmpty(unitName))
                return "";

            switch (unitName.ToLower())
            {
                case "kilogram":
                    return "KG";
                case "meter":
                    return "M";
                case "liter":
                    return "L";
                default:
                    return unitName.Length > 0 ? unitName.Substring(0, 1).ToUpper() : "";
            }
        }

        private static void PrintPDF(string pdfPath)
        {
            try
            {
                if (!File.Exists(pdfPath))
                {
                    MessageBox.Show($"Receipt file not found: {pdfPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Attempt to print directly to the default printer using the "print" verb
                ProcessStartInfo printInfo = new ProcessStartInfo
                {
                    FileName = pdfPath,
                    Verb = "print",
                    UseShellExecute = true,
                    CreateNoWindow = true
                };

                using (Process printProcess = Process.Start(printInfo))
                {
                    // Wait for the process to exit to ensure printing is initiated
                    printProcess.WaitForExit(5000); // Timeout after 5 seconds
                    if (!printProcess.HasExited)
                    {
                        printProcess.Kill();
                        throw new Exception("Printing process did not complete in time.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Fallback: Open the PDF in the default viewer if direct printing fails
                try
                {
                    ProcessStartInfo openInfo = new ProcessStartInfo
                    {
                        FileName = pdfPath,
                        UseShellExecute = true
                    };
                    Process.Start(openInfo);
                    MessageBox.Show($"Unable to print receipt directly: {ex.Message}. The receipt has been opened for manual printing.", "Printing Issue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception openEx)
                {
                    MessageBox.Show($"Error opening receipt: {openEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}