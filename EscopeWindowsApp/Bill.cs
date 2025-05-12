using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ZXing;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Diagnostics;
using System.IO;
using System.Drawing.Printing;
using MigraDoc.DocumentObjectModel.Shapes;
using Microsoft.Win32;

namespace EscopeWindowsApp
{
    public partial class Bill : Form
    {
        private readonly string _billNo;
        private readonly List<CartItem> _cartItems;
        private readonly string _customerName;
        private readonly string _userName;
        private readonly int _totalItems;
        private readonly string _paymentMethod;
        private readonly decimal _totalPrice;
        private readonly decimal _discount;
        private readonly decimal _cashPaid;
        private readonly decimal _balance;
        private readonly bool _isCardPayment;
        private readonly string _connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
        private readonly string _logPath = @"C:\Temp\BillDebug.log";
        private readonly string _billsFolder = @"C:\Bills";

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

        public Bill(string billNo, List<CartItem> cartItems, string customerName, string userName,
                    int totalItems, string paymentMethod, decimal totalPrice, decimal discount,
                    decimal cashPaid, decimal balance, bool isCardPayment)
        {
            InitializeComponent();
            _billNo = billNo;
            _cartItems = cartItems;
            _customerName = customerName;
            _userName = userName;
            _totalItems = totalItems;
            _paymentMethod = paymentMethod;
            _totalPrice = totalPrice;
            _discount = discount;
            _cashPaid = cashPaid;
            _balance = balance;
            _isCardPayment = isCardPayment;
            this.Visible = false; // Hide the form
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            try
            {
                Log("Starting bill generation for BillNo: " + _billNo);
                var companyDetails = LoadCompanyDetails();

                billNumberLabel.Text = _billNo;
                userNameLabel.Text = _userName;
                dateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd");
                timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");

                subTotalLabel.Text = string.Format("LKR {0:N2}", _totalPrice + _discount);
                dicountPriceLabel.Text = string.Format("LKR {0:N2}", _discount);
                totalAmountLabel.Text = string.Format("LKR {0:N2}", _totalPrice);
                paymentMethodLabel.Text = _paymentMethod;
                noOfItemsLabel.Text = _totalItems.ToString();

                ConfigureBillingItemsDataGridView();
                LoadBillingItems();

                PrintBill(companyDetails);
                Log("Bill generation and printing completed for BillNo: " + _billNo);
            }
            catch (Exception ex)
            {
                string error = string.Format("Error generating bill: {0}\nStackTrace: {1}", ex.Message, ex.StackTrace);
                Log(error);
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        private void Log(string message)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_logPath));
                File.AppendAllText(_logPath, string.Format("[{0}] {1}\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), message));
            }
            catch { } // Silent fail for logging
        }

        private (string Name, string Email, string PhoneNumber, string Address, byte[] Logo) LoadCompanyDetails()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT name, email, phone_number, address, logo FROM company_details WHERE id = 1";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["name"] != DBNull.Value ? reader["name"].ToString() : "SUPERMARKET";
                                string email = reader["email"] != DBNull.Value ? reader["email"].ToString() : "Not Available";
                                string phone = reader["phone_number"] != DBNull.Value ? reader["phone_number"].ToString() : "Not Available";
                                string address = reader["address"] != DBNull.Value ? reader["address"].ToString() : "Not Available";
                                byte[] logo = reader["logo"] != DBNull.Value ? (byte[])reader["logo"] : null;

                                companyNameLabel.Text = name;
                                emailLabel.Text = email;
                                phoneNumberLabel.Text = phone;
                                billLogoPicBox.Image = logo != null ? System.Drawing.Image.FromStream(new MemoryStream(logo)) : null; billLogoPicBox.SizeMode = PictureBoxSizeMode.Zoom;

                                return (name, email, phone, address, logo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string error = string.Format("Error loading company details: {0}", ex.Message);
                Log(error);
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                companyNameLabel.Text = "Error";
                emailLabel.Text = "Error";
                phoneNumberLabel.Text = "Error";
                billLogoPicBox.Image = null;
            }
            return ("SUPERMARKET", "Not Available", "Not Available", "Not Available", null);
        }

        private void ConfigureBillingItemsDataGridView()
        {
            billingItemsDataGridView.AutoGenerateColumns = false;
            billingItemsDataGridView.Columns.Clear();

            billingItemsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Product",
                HeaderText = "PRODUCT",
                DataPropertyName = "ProductName",
                Width = 150
            });

            billingItemsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                HeaderText = "QTY",
                DataPropertyName = "Quantity",
                Width = 50,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            billingItemsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UnitPrice",
                HeaderText = "U/PRICE",
                DataPropertyName = "Price",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N2" }
            });

            billingItemsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalPrice",
                HeaderText = "PRICE (LKR)",
                DataPropertyName = "TotalPrice",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N2" }
            });

            billingItemsDataGridView.AllowUserToAddRows = false;
            billingItemsDataGridView.ReadOnly = true;
            billingItemsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadBillingItems()
        {
            DataTable itemsTable = new DataTable();
            itemsTable.Columns.Add("ProductName", typeof(string));
            itemsTable.Columns.Add("Quantity", typeof(string));
            itemsTable.Columns.Add("Price", typeof(decimal));
            itemsTable.Columns.Add("TotalPrice", typeof(decimal));

            foreach (var item in _cartItems)
            {
                string variation = string.IsNullOrEmpty(item.VariationType) || item.VariationType == "N/A" ? "" : string.Format(" ({0})", item.VariationType);
                string displayUnit;
                if (item.Unit == "Liter")
                    displayUnit = "L";
                else if (item.Unit == "Kilogram")
                    displayUnit = "Kg";
                else if (item.Unit == "Meter")
                    displayUnit = "M";
                else
                    displayUnit = item.Unit;

                string qtyText = item.Unit == "Pieces" ? item.Quantity.ToString("N0") : string.Format("{0:N2} {1}", item.Quantity, displayUnit);
                itemsTable.Rows.Add(
                    item.ProductName.ToUpper() + variation,
                    qtyText,
                    item.Price,
                    item.TotalPrice
                );
            }

            billingItemsDataGridView.DataSource = itemsTable;
        }

        private void PrintBill((string Name, string Email, string PhoneNumber, string Address, byte[] Logo) companyDetails)
        {
            try
            {
                Log("Starting PDF generation for BillNo: " + _billNo);
                Document document = new Document();
                Section section = document.AddSection();
                section.PageSetup.PageWidth = Unit.FromMillimeter(80);
                section.PageSetup.PageHeight = Unit.FromMillimeter(100 + _cartItems.Count * 10);
                section.PageSetup.TopMargin = Unit.FromMillimeter(5);
                section.PageSetup.LeftMargin = Unit.FromMillimeter(5);
                section.PageSetup.RightMargin = Unit.FromMillimeter(5);

                if (companyDetails.Logo != null)
                {
                    string logoPath = Path.Combine(Path.GetTempPath(), "logo_" + _billNo + ".png");
                    File.WriteAllBytes(logoPath, companyDetails.Logo);
                    Log("Logo saved to: " + logoPath);
                    var logo = section.AddImage(logoPath);
                    logo.Width = Unit.FromMillimeter(20);
                    logo.Height = Unit.FromMillimeter(10);
                    logo.LockAspectRatio = true;
                    logo.RelativeHorizontal = RelativeHorizontal.Page;
                    logo.Left = ShapePosition.Center;
                    try
                    {
                        File.Delete(logoPath);
                        Log("Temporary logo deleted: " + logoPath);
                    }
                    catch (Exception ex)
                    {
                        Log("Error deleting temporary logo: " + ex.Message);
                    }
                }

                var paragraph = section.AddParagraph();
                paragraph.Format.Alignment = ParagraphAlignment.Center;
                paragraph.Format.SpaceBefore = Unit.FromMillimeter(2);
                paragraph.AddFormattedText(companyDetails.Name, new MigraDoc.DocumentObjectModel.Font("Arial", 10) { Bold = true });
                paragraph.AddLineBreak();
                paragraph.AddFormattedText(companyDetails.Address, new MigraDoc.DocumentObjectModel.Font("Arial", 8));
                paragraph.AddLineBreak();
                paragraph.AddFormattedText(string.Format("Phone: {0}", companyDetails.PhoneNumber), new MigraDoc.DocumentObjectModel.Font("Arial", 8));
                paragraph.AddLineBreak();
                paragraph.AddFormattedText(string.Format("Email: {0}", companyDetails.Email), new MigraDoc.DocumentObjectModel.Font("Arial", 8));

                paragraph = section.AddParagraph();
                paragraph.Format.SpaceBefore = Unit.FromMillimeter(5);
                paragraph.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 8);
                paragraph.AddText(string.Format("Bill No: {0}", _billNo));
                paragraph.AddLineBreak();
                paragraph.AddText(string.Format("Date: {0}", dateLabel.Text));
                paragraph.AddLineBreak();
                paragraph.AddText(string.Format("Time: {0}", timeLabel.Text));
                paragraph.AddLineBreak();
                paragraph.AddText(string.Format("Cashier: {0}", _userName));
                paragraph.AddLineBreak();
                paragraph.AddText(string.Format("Customer: {0}", _customerName));

                Table table = section.AddTable();
                table.Borders.Width = 0.5;
                table.Format.Font = new MigraDoc.DocumentObjectModel.Font("Courier New", 8);
                Column col1 = table.AddColumn(Unit.FromMillimeter(35)); col1.Format.Alignment = ParagraphAlignment.Left;
                Column col2 = table.AddColumn(Unit.FromMillimeter(10)); col2.Format.Alignment = ParagraphAlignment.Right;
                Column col3 = table.AddColumn(Unit.FromMillimeter(15)); col3.Format.Alignment = ParagraphAlignment.Right;
                Column col4 = table.AddColumn(Unit.FromMillimeter(15)); col4.Format.Alignment = ParagraphAlignment.Right;

                Row headerRow = table.AddRow();
                headerRow.HeadingFormat = true;
                headerRow.Cells[0].AddParagraph("PRODUCT");
                headerRow.Cells[1].AddParagraph("QTY");
                headerRow.Cells[2].AddParagraph("U/PRICE");
                headerRow.Cells[3].AddParagraph("PRICE (LKR)");

                foreach (var item in _cartItems)
                {
                    string variation = string.IsNullOrEmpty(item.VariationType) || item.VariationType == "N/A" ? "" : string.Format(" ({0})", item.VariationType);
                    string displayUnit;
                    if (item.Unit == "Liter")
                        displayUnit = "L";
                    else if (item.Unit == "Kilogram")
                        displayUnit = "Kg";
                    else if (item.Unit == "Meter")
                        displayUnit = "M";
                    else
                        displayUnit = item.Unit;

                    string qtyText = item.Unit == "Pieces" ? item.Quantity.ToString("N0") : string.Format("{0:N2} {1}", item.Quantity, displayUnit);
                    Row row = table.AddRow();
                    row.Cells[0].AddParagraph(item.ProductName.ToUpper() + variation);
                    row.Cells[1].AddParagraph(qtyText);
                    row.Cells[2].AddParagraph(string.Format("{0:N2}", item.Price));
                    row.Cells[3].AddParagraph(string.Format("{0:N2}", item.TotalPrice));
                }

                paragraph = section.AddParagraph();
                paragraph.Format.SpaceBefore = Unit.FromMillimeter(5);
                paragraph.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 8);
                paragraph.AddText(string.Format("Subtotal: LKR {0:N2}", _totalPrice + _discount));
                paragraph.AddLineBreak();
                paragraph.AddText(string.Format("Discount: LKR {0:N2}", _discount));
                paragraph.AddLineBreak();
                paragraph.AddText(string.Format("Total: LKR {0:N2}", _totalPrice));
                paragraph.AddLineBreak();
                paragraph.AddText(string.Format("Payment Method: {0}", _paymentMethod));
                paragraph.AddLineBreak();
                paragraph.AddText(string.Format("Items: {0}", _totalItems));
                if (_isCardPayment)
                {
                    paragraph.AddLineBreak();
                    paragraph.AddText("Card Payment");
                }
                else
                {
                    paragraph.AddLineBreak();
                    paragraph.AddText(string.Format("Cash Paid: LKR {0:N2}", _cashPaid));
                    paragraph.AddLineBreak();
                    paragraph.AddText(string.Format("Balance: LKR {0:N2}", _balance));
                }

                var barcode = GenerateBarcodeImage();
                if (barcode != null)
                {
                    string barcodePath = Path.Combine(Path.GetTempPath(), "barcode_" + _billNo + ".png");
                    barcode.Save(barcodePath, System.Drawing.Imaging.ImageFormat.Png);
                    Log("Barcode saved to: " + barcodePath);
                    var barcodeImage = section.AddImage(barcodePath);
                    barcodeImage.Width = Unit.FromMillimeter(50);
                    barcodeImage.Height = Unit.FromMillimeter(10);
                    barcodeImage.LockAspectRatio = true;
                    barcodeImage.RelativeHorizontal = RelativeHorizontal.Page;
                    barcodeImage.Left = ShapePosition.Center;
                    barcodeImage.Top = Unit.FromMillimeter(5);
                    try
                    {
                        File.Delete(barcodePath);
                        Log("Temporary barcode deleted: " + barcodePath);
                    }
                    catch (Exception ex)
                    {
                        Log("Error deleting temporary barcode: " + ex.Message);
                    }
                }

                string pdfPath = Path.Combine(Path.GetTempPath(), string.Format("Bill_{0}.pdf", _billNo));
                PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
                renderer.Document = document;
                renderer.RenderDocument();
                renderer.PdfDocument.Save(pdfPath);
                Log("Temporary PDF created: " + pdfPath);

                if (!File.Exists(pdfPath))
                {
                    Log("Error: Temporary PDF does not exist at: " + pdfPath);
                    MessageBox.Show("Failed to create the PDF file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool printerAvailable = IsPrinterAvailable();
                if (printerAvailable)
                {
                    Log("Printer detected, attempting to print PDF: " + pdfPath);
                    bool pdfPrinted = PrintPDF(pdfPath);
                    if (!pdfPrinted)
                    {
                        Log("PDF printing failed for: " + pdfPath);
                        MessageBox.Show("Failed to print the bill.", "Printing Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    DeleteTempFile(pdfPath);
                }
                else
                {
                    Log("No printer detected, attempting to open PDF in default browser: " + pdfPath);
                    bool opened = false;

                    // Try default PDF handler
                    if (IsPdfHandlerSet())
                    {
                        try
                        {
                            ProcessStartInfo info = new ProcessStartInfo
                            {
                                FileName = pdfPath,
                                UseShellExecute = true
                            };
                            Process.Start(info);
                            Log("PDF opening initiated with default handler: " + pdfPath);
                            opened = true;
                        }
                        catch (Exception ex)
                        {
                            Log("Error opening PDF with default handler: " + ex.Message);
                        }
                    }
                    else
                    {
                        Log("No default PDF handler set for .pdf files");
                    }

                    // Fallback: Try opening with default browser using file:// URL
                    if (!opened)
                    {
                        try
                        {
                            string fileUrl = $"file:///{pdfPath.Replace("\\", "/")}";
                            ProcessStartInfo info = new ProcessStartInfo
                            {
                                FileName = fileUrl,
                                UseShellExecute = true
                            };
                            Process.Start(info);
                            Log("PDF opening initiated with file URL in default browser: " + fileUrl);
                            opened = true;
                        }
                        catch (Exception ex)
                        {
                            Log("Error opening PDF with file URL: " + ex.Message);
                        }
                    }

                    // Fallback: Try Microsoft Edge
                    if (!opened)
                    {
                        try
                        {
                            ProcessStartInfo info = new ProcessStartInfo
                            {
                                FileName = "msedge.exe",
                                Arguments = $"\"{pdfPath}\"",
                                UseShellExecute = false
                            };
                            Process.Start(info);
                            Log("PDF opening initiated with Edge: " + pdfPath);
                            opened = true;
                        }
                        catch (Exception ex)
                        {
                            Log("Error opening PDF with Edge: " + ex.Message);
                        }
                    }

                    if (!opened)
                    {
                        // Save to Desktop for manual inspection
                        string fallbackPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), string.Format("Bill_{0}.pdf", _billNo));
                        File.Copy(pdfPath, fallbackPath, true);
                        Log("PDF opening failed, saved to: " + fallbackPath);
                        MessageBox.Show($"Failed to open the bill in the browser. The PDF has been saved to: {fallbackPath}\nPlease open it manually and ensure a default browser is set for PDF files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Delay deletion to ensure browser opens the file
                        Task.Delay(10000).ContinueWith(_ => DeleteTempFile(pdfPath));
                    }
                }
            }
            catch (Exception ex)
            {
                string error = string.Format("Error in PrintBill: {0}\nStackTrace: {1}", ex.Message, ex.StackTrace);
                Log(error);
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsPrinterAvailable()
        {
            try
            {
                PrinterSettings settings = new PrinterSettings();
                bool available = PrinterSettings.InstalledPrinters.Count > 0 && settings.IsValid;
                Log("Printer availability check: " + (available ? "Printers detected: " + string.Join(", ", PrinterSettings.InstalledPrinters.Cast<string>()) : "No printers detected"));
                return available;
            }
            catch (Exception ex)
            {
                Log("Error checking printer availability: " + ex.Message);
                return false;
            }
        }

        private bool IsPdfHandlerSet()
        {
            try
            {
                using (RegistryKey key = Registry.ClassesRoot.OpenSubKey(".pdf"))
                {
                    if (key != null)
                    {
                        string handler = key.GetValue("") as string;
                        Log("PDF handler check: " + (string.IsNullOrEmpty(handler) ? "No handler set" : "Handler set: " + handler));
                        return !string.IsNullOrEmpty(handler);
                    }
                }
                Log("PDF handler check: No .pdf registry key found");
                return false;
            }
            catch (Exception ex)
            {
                Log("Error checking PDF handler: " + ex.Message);
                return false;
            }
        }

        private void DeleteTempFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Log("Temporary file deleted: " + filePath);
                }
            }
            catch (Exception ex)
            {
                Log("Error deleting temporary file: " + ex.Message);
            }
        }

        private System.Drawing.Bitmap GenerateBarcodeImage()
        {
            try
            {
                var writer = new BarcodeWriter
                {
                    Format = BarcodeFormat.CODE_128,
                    Options = new ZXing.Common.EncodingOptions
                    {
                        Height = 50,
                        Width = 200
                    }
                };
                return writer.Write(_billNo);
            }
            catch (Exception ex)
            {
                Log("Error generating barcode: " + ex.Message);
                return null;
            }
        }

        private bool PrintPDF(string pdfPath)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo
                {
                    Verb = "print",
                    FileName = pdfPath,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                Process process = Process.Start(info);
                process.WaitForExit(10000); // Wait up to 10 seconds
                Log("PDF print attempt completed for: " + pdfPath + ", ExitCode: " + process.ExitCode);
                return process.ExitCode == 0;
            }
            catch (Exception ex)
            {
                Log("Error printing PDF: " + ex.Message);
                return false;
            }
        }

        private void billLogoPicBox_Click(object sender, EventArgs e) { }
        private void companyNameLabel_Click(object sender, EventArgs e) { }
        private void phoneNumberLabel_Click(object sender, EventArgs e) { }
        private void emailLabel_Click(object sender, EventArgs e) { }
        private void billNumberLabel_Click(object sender, EventArgs e) { }
        private void userNameLabel_Click(object sender, EventArgs e) { }
        private void timeLabel_Click(object sender, EventArgs e) { }
        private void dateLabel_Click(object sender, EventArgs e) { }
        private void billingItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void subTotalLabel_Click(object sender, EventArgs e) { }
        private void dicountPriceLabel_Click(object sender, EventArgs e) { }
        private void totalAmountLabel_Click(object sender, EventArgs e) { }
        private void paymentMethodLabel_Click(object sender, EventArgs e) { }
        private void barcodePicBox_Click(object sender, EventArgs e) { }
        private void noOfItemsLabel_Click(object sender, EventArgs e) { }
    }
}