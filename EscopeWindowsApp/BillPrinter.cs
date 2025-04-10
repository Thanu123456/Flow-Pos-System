using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

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

        public static void PrintBill(string billNo, string customerName, string userName, int totalItems, string paymentMethod, decimal totalPrice, decimal discount, decimal cashPaid, decimal balance, List<CartItem> cartItems, bool isCardPayment)
        {
            // Print the small receipt (80mm wide) for both cash and card payments
            string receiptPath = GenerateBillPDF(billNo, customerName, userName, totalItems, paymentMethod, totalPrice, discount, cashPaid, balance, cartItems, true);
            PrintPDF(receiptPath);

            // Ask if the user wants to print an A4-sized bill
            DialogResult result = MessageBox.Show("Do you want to print an A4-sized bill?", "Print A4 Bill", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string a4Path = GenerateBillPDF(billNo, customerName, userName, totalItems, paymentMethod, totalPrice, discount, cashPaid, balance, cartItems, false);
                PrintPDF(a4Path);
            }
        }

        private static string GenerateBillPDF(string billNo, string customerName, string userName, int totalItems, string paymentMethod, decimal totalPrice, decimal discount, decimal cashPaid, decimal balance, List<CartItem> cartItems, bool isSmallReceipt)
        {
            // Define the PDF file path
            string pdfPath = Path.Combine(Environment.CurrentDirectory, $"{billNo}_{(isSmallReceipt ? "receipt" : "A4")}.pdf");

            // Create a new MigraDoc document
            Document document = new Document();
            Section section = document.AddSection();

            // Set page size and margins based on the type of receipt
            if (isSmallReceipt)
            {
                // 80mm wide (thermal printer size), height can be dynamic
                section.PageSetup.PageWidth = Unit.FromMillimeter(80);
                section.PageSetup.PageHeight = Unit.FromMillimeter(297); // A4 height, will be adjusted dynamically
                section.PageSetup.LeftMargin = Unit.FromMillimeter(5);
                section.PageSetup.RightMargin = Unit.FromMillimeter(5);
                section.PageSetup.TopMargin = Unit.FromMillimeter(5);
                section.PageSetup.BottomMargin = Unit.FromMillimeter(5);
            }
            else
            {
                // A4 size
                section.PageSetup.PageFormat = PageFormat.A4;
                section.PageSetup.LeftMargin = Unit.FromCentimeter(1);
                section.PageSetup.RightMargin = Unit.FromCentimeter(1);
                section.PageSetup.TopMargin = Unit.FromCentimeter(1);
                section.PageSetup.BottomMargin = Unit.FromCentimeter(1);
            }

            // Define styles for consistent design
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

            if (isSmallReceipt)
            {
                // Small Receipt (80mm) Design
                // Logo
                Paragraph logoPara = section.AddParagraph();
                logoPara.Format.Alignment = ParagraphAlignment.Center;
                string logoPath = @"D:\E Scope\Logo\logopos.png";
                if (File.Exists(logoPath))
                {
                    var image = logoPara.AddImage(logoPath);
                    image.Width = Unit.FromMillimeter(30); // Adjust the width to fit the 80mm receipt
                    image.LockAspectRatio = true;
                }
                else
                {
                    logoPara.AddText("[Logo Not Found]");
                }

                // Header: Store Information
                Paragraph storeName = section.AddParagraph();
                storeName.Style = "Title";
                storeName.AddText("SUPERMARKET");

                Paragraph address = section.AddParagraph();
                address.Style = "Body";
                address.AddText("Lorem ipsum 258");
                address.Format.Alignment = ParagraphAlignment.Center;

                Paragraph cityIndex = section.AddParagraph();
                cityIndex.Style = "Body";
                cityIndex.AddText("City Index - 02025");
                cityIndex.Format.Alignment = ParagraphAlignment.Center;

                Paragraph phone = section.AddParagraph();
                phone.Style = "Body";
                phone.AddText("Tel.: +456-466-987-02");
                phone.Format.Alignment = ParagraphAlignment.Center;

                // Dotted line separator (using text)
                Paragraph separator1 = section.AddParagraph();
                separator1.Style = "Body";
                separator1.AddText("............................");
                separator1.Format.Alignment = ParagraphAlignment.Center;
                section.AddParagraph().Format.SpaceAfter = 5;

                // Cashier and Manager
                Table cashierTable = section.AddTable();
                cashierTable.AddColumn(Unit.FromMillimeter(35));
                cashierTable.AddColumn(Unit.FromMillimeter(35));

                Row cashierRow1 = cashierTable.AddRow();
                cashierRow1.Cells[0].AddParagraph("Cashier:").Style = "Body";
                cashierRow1.Cells[1].AddParagraph("#3").Style = "Body";
                cashierRow1.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                Row cashierRow2 = cashierTable.AddRow();
                cashierRow2.Cells[0].AddParagraph($"Manager: {userName}").Style = "Body";

                // Add Bill Number
                Row billNoRow = cashierTable.AddRow();
                billNoRow.Cells[0].AddParagraph($"Bill No: {billNo}").Style = "Body";

                // Dotted line separator (using text)
                Paragraph separator2 = section.AddParagraph();
                separator2.Style = "Body";
                separator2.AddText("............................");
                separator2.Format.Alignment = ParagraphAlignment.Center;
                section.AddParagraph().Format.SpaceAfter = 5;

                // Items Header
                Table itemsHeaderTable = section.AddTable();
                itemsHeaderTable.AddColumn(Unit.FromMillimeter(35));
                itemsHeaderTable.AddColumn(Unit.FromMillimeter(15));
                itemsHeaderTable.AddColumn(Unit.FromMillimeter(20));

                Row itemsHeaderRow = itemsHeaderTable.AddRow();
                itemsHeaderRow.Cells[0].AddParagraph("Name").Style = "Body";
                itemsHeaderRow.Cells[1].AddParagraph("Qty").Style = "Body";
                itemsHeaderRow.Cells[2].AddParagraph("Price").Style = "Body";
                itemsHeaderRow.Cells[2].Format.Alignment = ParagraphAlignment.Right;

                // Items List (without table, using aligned text)
                foreach (var item in cartItems)
                {
                    Table itemRowTable = section.AddTable();
                    itemRowTable.AddColumn(Unit.FromMillimeter(35));
                    itemRowTable.AddColumn(Unit.FromMillimeter(15));
                    itemRowTable.AddColumn(Unit.FromMillimeter(20));

                    Row itemRow = itemRowTable.AddRow();
                    itemRow.Cells[0].AddParagraph($"{item.ProductName} ({item.VariationType})").Style = "Body";
                    // Map the unit to its abbreviation for display
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
                        displayUnit = item.Unit; // Keep the original unit if not Liter, Kilogram, or Meter
                    }
                    // Show quantity without decimals for "Pieces", with unit and decimals for others
                    string qtyText = item.Unit == "Pieces" ? item.Quantity.ToString("N0") : $"{item.Quantity:N2} {displayUnit}";
                    itemRow.Cells[1].AddParagraph(qtyText).Style = "Body";
                    itemRow.Cells[2].AddParagraph($"LKR {item.TotalPrice:N2}").Style = "Body";
                    itemRow.Cells[2].Format.Alignment = ParagraphAlignment.Right;
                }

                // Dotted line separator (using text)
                Paragraph separator3 = section.AddParagraph();
                separator3.Style = "Body";
                separator3.AddText("............................");
                separator3.Format.Alignment = ParagraphAlignment.Center;
                section.AddParagraph().Format.SpaceAfter = 5;

                // Summary
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
                    summaryRow5.Cells[0].AddParagraph("Cash").Style = "Body"; // Changed "CASH" to "Cash"
                    summaryRow5.Cells[1].AddParagraph($"LKR {cashPaid:N2}").Style = "Body";
                    summaryRow5.Cells[1].Format.Alignment = ParagraphAlignment.Right;

                    Row summaryRow6 = summaryTable.AddRow();
                    summaryRow6.Cells[0].AddParagraph("Balance").Style = "Body"; // Changed "CHANGE" to "Balance"
                    summaryRow6.Cells[1].AddParagraph($"LKR {balance:N2}").Style = "Body";
                    summaryRow6.Cells[1].Format.Alignment = ParagraphAlignment.Right;
                }

                // Dotted line separator (using text)
                Paragraph separator4 = section.AddParagraph();
                separator4.Style = "Body";
                separator4.AddText("............................");
                separator4.Format.Alignment = ParagraphAlignment.Center;
                section.AddParagraph().Format.SpaceAfter = 5;

                // Barcode Placeholder (MigraDoc doesn't support barcodes directly, so we'll use text)
                Paragraph barcode = section.AddParagraph();
                barcode.Style = "Body";
                barcode.AddText("██████████████████████████");
                barcode.Format.Alignment = ParagraphAlignment.Center;

                // Footer
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
                // A4 Bill Design
                // Logo
                Table headerTable = section.AddTable();
                headerTable.Borders.Width = 0.5;
                headerTable.Borders.Color = Colors.Black;
                headerTable.AddColumn(Unit.FromCentimeter(18));
                Row headerRow = headerTable.AddRow();
                headerRow.Shading.Color = Colors.LightGray;

                Cell headerCell = headerRow.Cells[0];
                Paragraph logoPara = headerCell.AddParagraph();
                logoPara.Format.Alignment = ParagraphAlignment.Center;
                string logoPath = @"D:\E Scope\Logo\logopos.png";
                if (File.Exists(logoPath))
                {
                    var image = logoPara.AddImage(logoPath);
                    image.Width = Unit.FromCentimeter(5); // Adjust the width to fit the A4 page
                    image.LockAspectRatio = true;
                }
                else
                {
                    logoPara.AddText("[Logo Not Found]");
                }

                Paragraph headerPara1 = headerCell.AddParagraph();
                headerPara1.Style = "Title";
                headerPara1.AddText("Escope POS System");

                Paragraph headerPara2 = headerCell.AddParagraph();
                headerPara2.Style = "Body";
                headerPara2.AddText("123 Business Street, City, Country");
                headerPara2.Format.Alignment = ParagraphAlignment.Center;

                Paragraph headerPara3 = headerCell.AddParagraph();
                headerPara3.Style = "Body";
                headerPara3.AddText("Phone: +123-456-7890");
                headerPara3.Format.Alignment = ParagraphAlignment.Center;

                Paragraph headerPara4 = headerCell.AddParagraph();
                headerPara4.Style = "Subtitle";
                headerPara4.AddText("INVOICE");

                section.AddParagraph().Format.SpaceAfter = 10;

                // Invoice Details
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

                // Line separator
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
                itemsTable.AddColumn(Unit.FromCentimeter(1));  // No
                itemsTable.AddColumn(Unit.FromCentimeter(5));  // Product Name
                itemsTable.AddColumn(Unit.FromCentimeter(2));  // Variation
                itemsTable.AddColumn(Unit.FromCentimeter(2));  // Unit
                itemsTable.AddColumn(Unit.FromCentimeter(2));  // Qty
                itemsTable.AddColumn(Unit.FromCentimeter(3));  // Price
                itemsTable.AddColumn(Unit.FromCentimeter(3));  // Total

                // Table Header
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

                // Table Body
                foreach (var item in cartItems)
                {
                    Row itemRow = itemsTable.AddRow();
                    itemRow.Cells[0].AddParagraph(item.ItemNumber.ToString()).Style = "Body";
                    itemRow.Cells[0].Format.Alignment = ParagraphAlignment.Center;
                    itemRow.Cells[1].AddParagraph(item.ProductName).Style = "Body";
                    itemRow.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                    itemRow.Cells[2].AddParagraph(item.VariationType).Style = "Body";
                    itemRow.Cells[2].Format.Alignment = ParagraphAlignment.Center;
                    // Map the unit to its abbreviation for display
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
                        displayUnit = item.Unit; // Keep the original unit if not Liter, Kilogram, or Meter
                    }
                    itemRow.Cells[3].AddParagraph(displayUnit).Style = "Body";
                    itemRow.Cells[3].Format.Alignment = ParagraphAlignment.Center;
                    // Show quantity without decimals for "Pieces", with decimals for others
                    string qtyText = item.Unit == "Pieces" ? item.Quantity.ToString("N0") : item.Quantity.ToString("N2");
                    itemRow.Cells[4].AddParagraph(qtyText).Style = "Body";
                    itemRow.Cells[4].Format.Alignment = ParagraphAlignment.Center;
                    itemRow.Cells[5].AddParagraph(item.Price.ToString("N2")).Style = "Body";
                    itemRow.Cells[5].Format.Alignment = ParagraphAlignment.Right;
                    itemRow.Cells[6].AddParagraph($"LKR {item.TotalPrice:N2}").Style = "Body";
                    itemRow.Cells[6].Format.Alignment = ParagraphAlignment.Right;
                }

                section.AddParagraph().Format.SpaceAfter = 10;

                // Line separator
                Table separatorTable2 = section.AddTable();
                separatorTable2.Borders.Width = 0;
                separatorTable2.Borders.Bottom.Width = 0.5;
                separatorTable2.AddColumn(Unit.FromCentimeter(18));
                Row separatorRow2 = separatorTable2.AddRow();
                separatorRow2.Cells[0].AddParagraph("");
                section.AddParagraph().Format.SpaceAfter = 5;

                // Summary
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

                // Footer with Border
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

            // Render the document to PDF
            PdfDocumentRenderer renderer = new PdfDocumentRenderer();
            renderer.Document = document;
            renderer.RenderDocument();

            // Save the PDF
            renderer.PdfDocument.Save(pdfPath);

            return pdfPath;
        }

        private static void PrintPDF(string pdfPath)
        {
            try
            {
                // Open the PDF for printing
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