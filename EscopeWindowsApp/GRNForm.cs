using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.Configuration;
using System.IO.Ports;
using System.Timers;

namespace EscopeWindowsApp
{
    public partial class GRNForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private string paymentMethod;
        private bool isFormLoading = true;
        private int? currentProductId = null;
        private string currentVariationType = null;
        private bool isSerialNumberRequired = false;
        private ListBox suggestionListBox;
        private bool isUsbScannerEnabled = false;
        private bool isBluetoothScannerEnabled = false;
        private SerialPort bluetoothSerialPort;
        private string scannedBarcodeBuffer = "";
        private System.Timers.Timer usbScanTimer;
        private const int USB_SCAN_TIMEOUT = 100; // 100ms timeout to detect end of USB scan

        public GRNForm()
        {
            InitializeComponent();
            InitializeSuggestionListBox();
            InitializeBluetoothScanner();
            InitializeUsbScanTimer();
            CustomizeDateTimePicker();

            // Disable DateTimePicker by default
            grnExpireDatePicker.Enabled = false;

            // Subscribe to form key press event for scanner input and Enter key handling
            this.KeyPreview = true;
            this.KeyDown += GRNForm_KeyDown; // For Enter key
            this.KeyPress += GRNForm_KeyPress; // For USB scanner input

            // Add KeyPress event handlers for numeric-only input
            grnQuantityText.KeyPress += NumericTextBox_KeyPress;
            grnCostPriText.KeyPress += NumericTextBox_KeyPress;
            grnRetPriText.KeyPress += NumericTextBox_KeyPress;
            grnNetPriceText.KeyPress += NumericTextBox_KeyPress;
        }

        #region Numeric Input Validation
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like backspace), digits, and a single decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Prevent non-numeric input
                return;
            }

            // Allow only one decimal point
            TextBox textBox = sender as TextBox;
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true; // Prevent additional decimal points
            }
        }
        #endregion

        #region DateTimePicker Customization
        private void CustomizeDateTimePicker()
        {
            grnExpireDatePicker.FillColor = System.Drawing.Color.White;
            grnExpireDatePicker.HoverState.FillColor = System.Drawing.Color.White;
        }
        #endregion

        #region Scanner Initialization and Handling
        private void InitializeBluetoothScanner()
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                if (ports.Length > 0)
                {
                    bluetoothSerialPort = new SerialPort(ports[0], 9600)
                    {
                        ReadTimeout = 500,
                        WriteTimeout = 500
                    };
                    bluetoothSerialPort.DataReceived += BluetoothSerialPort_DataReceived;
                }
                else
                {
                    bluetoothSerialPort = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing Bluetooth scanner: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bluetoothSerialPort = null;
            }
        }

        private void InitializeUsbScanTimer()
        {
            usbScanTimer = new System.Timers.Timer(USB_SCAN_TIMEOUT)
            {
                AutoReset = false
            };
            usbScanTimer.Elapsed += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(scannedBarcodeBuffer))
                {
                    BeginInvoke(new Action(() =>
                    {
                        ProcessScannedBarcode(scannedBarcodeBuffer.Trim());
                        scannedBarcodeBuffer = "";
                    }));
                }
            };
        }

        private void BluetoothSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = bluetoothSerialPort.ReadExisting().Trim();
                if (!string.IsNullOrEmpty(data))
                {
                    BeginInvoke(new Action(() =>
                    {
                        ProcessScannedBarcode(data);
                    }));
                }
            }
            catch (Exception ex)
            {
                BeginInvoke(new Action(() =>
                {
                    MessageBox.Show($"Error reading Bluetooth scanner data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }

        private void usbScanToggleBtn_CheckedChanged(object sender, EventArgs e)
        {
            isUsbScannerEnabled = usbScanToggleBtn.Checked;
            if (isUsbScannerEnabled)
            {
                MessageBox.Show("USB Scanner enabled. Scan a barcode to auto-fill product details.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActiveControl = null;
            }
            else
            {
                MessageBox.Show("USB Scanner disabled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bluToggleBtn_CheckedChanged(object sender, EventArgs e)
        {
            isBluetoothScannerEnabled = bluToggleBtn.Checked;
            try
            {
                if (isBluetoothScannerEnabled)
                {
                    if (bluetoothSerialPort != null && !bluetoothSerialPort.IsOpen)
                    {
                        bluetoothSerialPort.Open();
                        MessageBox.Show("Bluetooth Scanner enabled. Scan a barcode to auto-fill product details.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ActiveControl = null;
                    }
                    else if (bluetoothSerialPort == null)
                    {
                        MessageBox.Show("No COM ports found for Bluetooth scanner. Please configure manually.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        bluToggleBtn.Checked = false;
                        isBluetoothScannerEnabled = false;
                    }
                }
                else
                {
                    if (bluetoothSerialPort != null && bluetoothSerialPort.IsOpen)
                    {
                        bluetoothSerialPort.Close();
                        MessageBox.Show("Bluetooth Scanner disabled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error toggling Bluetooth scanner: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isBluetoothScannerEnabled = false;
                bluToggleBtn.Checked = false;
            }
        }

        private void GRNForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                addToListBtn_Click(this, EventArgs.Empty);
            }
        }

        private void GRNForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isUsbScannerEnabled)
            {
                scannedBarcodeBuffer += e.KeyChar;
                usbScanTimer.Stop();
                usbScanTimer.Start();
                e.Handled = true;
            }
        }

        private void ProcessScannedBarcode(string barcode)
        {
            if (!string.IsNullOrEmpty(barcode))
            {
                DataTable products = SearchProducts(barcode);
                if (products.Rows.Count > 0)
                {
                    int productId = Convert.ToInt32(products.Rows[0]["id"]);
                    FillProductDetails(productId);
                    grnQuantityText.Text = "1";
                    UpdateNetPrice();
                }
                else
                {
                    MessageBox.Show($"No product found for barcode: '{barcode}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Webcam Handling
        private void webcamScanBtn_Click(object sender, EventArgs e)
        {
            using (CodeReaderForm codeReader = new CodeReaderForm())
            {
                if (codeReader.ShowDialog() == DialogResult.OK)
                {
                    string scannedBarcode = codeReader.ScannedCode;
                    ProcessScannedBarcode(scannedBarcode);
                }
            }
        }
        #endregion

        #region Form Initialization
        private void InitializeSuggestionListBox()
        {
            suggestionListBox = new ListBox
            {
                Visible = false,
                Width = grnProSearchText.Width,
                Font = grnProSearchText.Font,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(grnProSearchText.Location.X, grnProSearchText.Location.Y + grnProSearchText.Height + 2)
            };
            this.Controls.Add(suggestionListBox);

            suggestionListBox.Click += SuggestionListBox_Click;
            suggestionListBox.KeyDown += SuggestionListBox_KeyDown;
        }

        private void GRNForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (grnDataGridView.Columns.Count == 0)
                {
                    grnDataGridView.Columns.Add("ProductID", "Product ID");
                    grnDataGridView.Columns.Add("ProductName", "Product Name");
                    grnDataGridView.Columns.Add("VariationType", "Variation Type");
                    grnDataGridView.Columns.Add("Quantity", "Quantity");
                    grnDataGridView.Columns.Add("CostPrice", "Cost Price");
                    grnDataGridView.Columns.Add("RetailPrice", "Retail Price");
                    grnDataGridView.Columns.Add("NetPrice", "Net Price");
                    grnDataGridView.Columns.Add("ExpiryDate", "Expiry Date");
                    grnDataGridView.Columns.Add("Warranty", "Warranty");
                    grnDataGridView.Columns.Add("Unit", "Unit");
                    grnDataGridView.Columns.Add("SerialNumber", "Serial Number");

                    // Add Delete column with icon
                    DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        HeaderText = "",
                        Text = ""
                    };
                    grnDataGridView.Columns.Add(deleteColumn);

                    // Subscribe to CellPainting event for custom icon rendering
                    grnDataGridView.CellPainting += grnDataGridView_CellPainting;
                }

                grnDataGridView.AllowUserToAddRows = false;
                grnProSearchText.Text = "";
                grnWarrantyComboBox.Items.AddRange(new object[] { "No Warranty", "6 Months", "1 Year", "2 Years" });
                grnWarrantyComboBox.SelectedIndex = 0;

                int nextId = GetNextGRNId();
                grnNoLabel.Text = nextId.ToString("D4");

                UpdateUnitLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading GRNForm: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"GRNForm load error: {ex}");
            }
            finally
            {
                isFormLoading = false;
            }
        }

        private void grnDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == grnDataGridView.Columns["Delete"].Index)
            {
                e.PaintBackground(e.CellBounds, true);
                Image deleteIcon = Properties.Resources.delete ?? SystemIcons.Warning.ToBitmap();
                int iconSize = (int)(Math.Min(e.CellBounds.Width, e.CellBounds.Height) * 0.7);
                if (iconSize <= 0) iconSize = 16;
                int x = e.CellBounds.X + (e.CellBounds.Width - iconSize) / 2;
                int y = e.CellBounds.Y + (e.CellBounds.Height - iconSize) / 2;
                e.Graphics.DrawImage(deleteIcon, x, y, iconSize, iconSize);
                e.Handled = true;
            }
        }
        #endregion

        #region Payment Method Handling
        private void cashPaymentRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (cashPaymentRadioBtn.Checked)
                paymentMethod = "Cash";
        }

        private void chequePaymentRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (chequePaymentRadioBtn.Checked)
                paymentMethod = "Cheque";
        }

        private void creaditPayementRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (creaditPayementRadioBtn.Checked)
                paymentMethod = "Credit";
        }
        #endregion

        #region Product Search
        private void grnProSearchText_TextChanged(object sender, EventArgs e)
        {
            if (isFormLoading || isUsbScannerEnabled || isBluetoothScannerEnabled) return;

            string searchText = grnProSearchText.Text.Trim();
            suggestionListBox.Items.Clear();
            suggestionListBox.Visible = false;

            if (!string.IsNullOrEmpty(searchText))
            {
                DataTable products = SearchProducts(searchText);
                if (products.Rows.Count > 0)
                {
                    foreach (DataRow row in products.Rows)
                    {
                        suggestionListBox.Items.Add(new ProductSuggestion
                        {
                            ProductId = Convert.ToInt32(row["id"]),
                            DisplayText = $"PRO{row["id"]:D3} - {row["name"]}"
                        });
                    }
                    suggestionListBox.Visible = suggestionListBox.Items.Count > 0;
                    if (suggestionListBox.Visible)
                    {
                        suggestionListBox.BringToFront();
                    }
                }
            }
            else
            {
                ClearProductDetails();
            }
        }

        private DataTable SearchProducts(string searchText)
        {
            try
            {
                searchText = searchText.Trim();
                Console.WriteLine($"Searching products with text: '{searchText}'");

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT p.id, p.name, p.barcode, 
                               c.name AS category, 
                               v.name AS variation_name, 
                               u.unit_name, 
                               pr.cost_price, pr.retail_price
                        FROM products p
                        LEFT JOIN categories c ON p.category_id = c.id
                        LEFT JOIN variations v ON p.variation_type_id = v.id
                        LEFT JOIN units u ON p.unit_id = u.id
                        LEFT JOIN pricing pr ON p.id = pr.product_id
                        WHERE p.barcode = @searchText
                           OR p.barcode LIKE @searchTextLike
                           OR p.name LIKE @searchTextLike
                           OR p.id = @searchId
                        ORDER BY p.name";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@searchText", searchText);
                        cmd.Parameters.AddWithValue("@searchTextLike", "%" + searchText + "%");
                        int searchId = searchText.StartsWith("PRO") && int.TryParse(searchText.Substring(3), out int id) ? id : (int.TryParse(searchText, out id) ? id : -1);
                        cmd.Parameters.AddWithValue("@searchId", searchId != -1 ? searchId : (object)DBNull.Value);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        Console.WriteLine($"Query executed: {query}");
                        Console.WriteLine($"Parameters: searchText='{searchText}', searchTextLike='%{searchText}%', searchId={searchId}");
                        Console.WriteLine($"Rows returned: {dt.Rows.Count}");
                        foreach (DataRow row in dt.Rows)
                        {
                            Console.WriteLine($"Found: ID={row["id"]}, Name={row["name"]}, Barcode={row["barcode"]}, Unit={row["unit_name"]}, CostPrice={row["cost_price"]}");
                        }

                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                BeginInvoke(new Action(() =>
                {
                    MessageBox.Show($"Error searching products for '{searchText}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
                Console.WriteLine($"Search products error: {ex}");
                return new DataTable();
            }
        }

        private class ProductSuggestion
        {
            public int ProductId { get; set; }
            public string DisplayText { get; set; }

            public override string ToString() => DisplayText;
        }

        private void SuggestionListBox_Click(object sender, EventArgs e)
        {
            if (suggestionListBox.SelectedItem != null)
            {
                SelectSuggestion();
            }
        }

        private void SuggestionListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && suggestionListBox.SelectedItem != null)
            {
                SelectSuggestion();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                suggestionListBox.Visible = false;
                grnProSearchText.Focus();
                e.Handled = true;
            }
        }

        private void SelectSuggestion()
        {
            if (suggestionListBox.SelectedItem is ProductSuggestion suggestion)
            {
                grnProSearchText.Text = suggestion.DisplayText;
                FillProductDetails(suggestion.ProductId);
                suggestionListBox.Visible = false;
                grnProSearchText.Focus();
            }
        }

        private void grnProSearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (suggestionListBox.Visible)
            {
                if (e.KeyCode == Keys.Down)
                {
                    if (suggestionListBox.Items.Count > 0)
                    {
                        suggestionListBox.SelectedIndex = Math.Min(suggestionListBox.SelectedIndex + 1, suggestionListBox.Items.Count - 1);
                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (suggestionListBox.Items.Count > 0)
                    {
                        suggestionListBox.SelectedIndex = Math.Max(suggestionListBox.SelectedIndex - 1, 0);
                        e.Handled = true;
                    }
                }
                else if (e.KeyCode == Keys.Enter && suggestionListBox.SelectedItem != null)
                {
                    SelectSuggestion();
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    suggestionListBox.Visible = false;
                    e.Handled = true;
                }
            }
        }

        private void grnProSearchText_Leave(object sender, EventArgs e)
        {
            var timer = new System.Windows.Forms.Timer { Interval = 200 };
            timer.Tick += (s, args) =>
            {
                suggestionListBox.Visible = false;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }
        #endregion

        #region Auto-Fill Product Details
        private void FillProductDetails(int productId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT p.id, p.name, c.name AS category, v.name AS variation_name, u.unit_name AS unit_name
                        FROM products p
                        LEFT JOIN categories c ON p.category_id = c.id
                        LEFT JOIN variations v ON p.variation_type_id = v.id
                        LEFT JOIN units u ON p.unit_id = u.id
                        WHERE p.id = @productId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                grnProIDText.Text = $"PRO{productId:D3}";
                                grnProNameText.Text = reader["name"].ToString();
                                grnProCatText.Text = reader["category"].ToString();
                                grnVarText.Text = reader.IsDBNull(reader.GetOrdinal("variation_name")) ? "N/A" : reader["variation_name"].ToString();
                                grnStockText.Text = "0";
                                grnUnitText.Text = reader["unit_name"] != DBNull.Value ? reader["unit_name"].ToString() : "N/A";

                                grnProIDText.ReadOnly = true;
                                grnProNameText.ReadOnly = true;
                                grnProCatText.ReadOnly = true;
                                grnVarText.ReadOnly = true;
                                grnStockText.ReadOnly = true;
                                grnUnitText.ReadOnly = true;

                                currentProductId = productId;

                                if (!reader.IsDBNull(reader.GetOrdinal("variation_name")))
                                {
                                    LoadVariationTypes(productId);
                                    grnVarTypCombo.Enabled = true;
                                }
                                else
                                {
                                    grnVarTypCombo.Items.Clear();
                                    grnVarTypCombo.Enabled = false;
                                    LoadSinglePricing(productId);
                                    LoadStockForNoVariation(productId);
                                    currentVariationType = null;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                BeginInvoke(new Action(() =>
                {
                    MessageBox.Show($"Error filling product details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
                Console.WriteLine($"Fill product details error: {ex}");
            }
        }

        private void LoadVariationTypes(int productId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT DISTINCT pr.variation_type 
                        FROM pricing pr
                        JOIN products p ON pr.product_id = p.id
                        WHERE p.id = @productId AND pr.variation_type IS NOT NULL";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            grnVarTypCombo.Items.Clear();
                            while (reader.Read())
                            {
                                grnVarTypCombo.Items.Add(reader["variation_type"].ToString());
                            }
                            if (grnVarTypCombo.Items.Count > 0)
                                grnVarTypCombo.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                BeginInvoke(new Action(() =>
                {
                    MessageBox.Show($"Error loading variation types: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
                Console.WriteLine($"Load variation types error: {ex}");
            }
        }

        private void LoadSinglePricing(int productId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT cost_price, retail_price FROM pricing " +
                                  "WHERE product_id = @productId AND variation_type IS NULL LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                grnCostPriText.Text = reader["cost_price"].ToString();
                                grnRetPriText.Text = reader["retail_price"].ToString();

                                grnCostPriText.ReadOnly = true;
                                grnRetPriText.ReadOnly = true;

                                UpdateNetPrice();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                BeginInvoke(new Action(() =>
                {
                    MessageBox.Show($"Error loading single pricing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
                Console.WriteLine($"Load single pricing error: {ex}");
            }
        }

        private void LoadStockForNoVariation(int productId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COALESCE(SUM(stock), 0) AS total_stock " +
                                  "FROM stock WHERE product_id = @productId AND variation_type IS NULL";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        object result = cmd.ExecuteScalar();
                        grnStockText.Text = result != null ? result.ToString() : "0";
                    }
                }
            }
            catch (Exception ex)
            {
                BeginInvoke(new Action(() =>
                {
                    MessageBox.Show($"Error loading stock for product without variation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
                Console.WriteLine($"Load stock no variation error: {ex}");
                grnStockText.Text = "0";
            }
        }
        #endregion

        #region Variation Type and Pricing
        private void grnVarTypCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentProductId.HasValue && grnVarTypCombo.SelectedItem != null)
            {
                currentVariationType = grnVarTypCombo.SelectedItem.ToString();
                LoadPricingDetails(currentProductId.Value, currentVariationType);
                LoadStockForVariation(currentProductId.Value, currentVariationType);
            }
        }

        private void LoadPricingDetails(int productId, string variationType)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT cost_price, retail_price FROM pricing " +
                                  "WHERE product_id = @productId AND variation_type = @variationType LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@variationType", variationType);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                grnCostPriText.Text = reader["cost_price"].ToString();
                                grnRetPriText.Text = reader["retail_price"].ToString();

                                grnCostPriText.ReadOnly = true;
                                grnRetPriText.ReadOnly = true;

                                UpdateNetPrice();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                BeginInvoke(new Action(() =>
                {
                    MessageBox.Show($"Error loading pricing details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
                Console.WriteLine($"Load pricing details error: {ex}");
            }
        }

        private void LoadStockForVariation(int productId, string variationType)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COALESCE(SUM(stock), 0) AS total_stock " +
                                  "FROM stock WHERE product_id = @productId AND variation_type = @variationType";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@variationType", variationType);
                        object result = cmd.ExecuteScalar();
                        grnStockText.Text = result != null ? result.ToString() : "0";
                    }
                }
            }
            catch (Exception ex)
            {
                BeginInvoke(new Action(() =>
                {
                    MessageBox.Show($"Error loading stock for variation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
                Console.WriteLine($"Load stock variation error: {ex}");
                grnStockText.Text = "0";
            }
        }
        #endregion

        #region Net Price Calculation
        private void grnQuantityText_TextChanged(object sender, EventArgs e)
        {
            UpdateNetPrice();
        }

        private void UpdateNetPrice()
        {
            if (decimal.TryParse(grnQuantityText.Text, out decimal quantity) &&
                decimal.TryParse(grnCostPriText.Text, out decimal costPrice))
            {
                grnNetPriceText.Text = (quantity * costPrice).ToString("F2");
            }
            else
            {
                grnNetPriceText.Text = "0.00";
            }
        }
        #endregion

        #region Add to List
        private void addToListBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grnProIDText.Text) || string.IsNullOrEmpty(grnQuantityText.Text))
            {
                MessageBox.Show("Please select a product and enter quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(grnQuantityText.Text, out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string formattedProductId = grnProIDText.Text;
            int productId = int.Parse(formattedProductId.Replace("PRO", ""));
            string variationType = grnVarTypCombo.SelectedItem?.ToString() ?? "N/A";
            string warranty = grnWarrantyComboBox.SelectedItem?.ToString() ?? "No Warranty";
            string unit = grnUnitText.Text;

            string expiryDateDisplay = expireDateCheckBox.Checked ? grnExpireDatePicker.Value.ToString("yyyy-MM-dd") : "N/A";

            if (isSerialNumberRequired)
            {
                if (quantity != (int)quantity)
                {
                    MessageBox.Show("Serial numbers require whole number quantities.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AddBarcodeForm barcodeForm = new AddBarcodeForm(productId.ToString(), variationType, (int)quantity);
                barcodeForm.FormClosed += (s, args) =>
                {
                    if (barcodeForm.IsSaved)
                    {
                        foreach (DataGridViewRow row in grnDataGridView.Rows)
                        {
                            if (row.Cells["ProductID"].Value.ToString() == formattedProductId &&
                                row.Cells["VariationType"].Value.ToString() == variationType)
                            {
                                decimal existingQuantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                                decimal newQuantity = existingQuantity + quantity;
                                row.Cells["Quantity"].Value = newQuantity;
                                row.Cells["NetPrice"].Value = (newQuantity * Convert.ToDecimal(row.Cells["CostPrice"].Value)).ToString("F2");
                                ClearItemFields();
                                return;
                            }
                        }

                        grnDataGridView.Rows.Add(
                            formattedProductId,
                            grnProNameText.Text,
                            variationType,
                            grnQuantityText.Text,
                            grnCostPriText.Text,
                            grnRetPriText.Text,
                            grnNetPriceText.Text,
                            expiryDateDisplay,
                            warranty,
                            unit,
                            "Yes"
                        );

                        ClearItemFields();
                    }
                };
                barcodeForm.ShowDialog();
            }
            else
            {
                foreach (DataGridViewRow row in grnDataGridView.Rows)
                {
                    if (row.Cells["ProductID"].Value.ToString() == formattedProductId &&
                        row.Cells["VariationType"].Value.ToString() == variationType)
                    {
                        decimal existingQuantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                        decimal newQuantity = existingQuantity + quantity;
                        row.Cells["Quantity"].Value = newQuantity;
                        row.Cells["NetPrice"].Value = (newQuantity * Convert.ToDecimal(row.Cells["CostPrice"].Value)).ToString("F2");
                        ClearItemFields();
                        return;
                    }
                }

                grnDataGridView.Rows.Add(
                    formattedProductId,
                    grnProNameText.Text,
                    variationType,
                    grnQuantityText.Text,
                    grnCostPriText.Text,
                    grnRetPriText.Text,
                    grnNetPriceText.Text,
                    expiryDateDisplay,
                    warranty,
                    unit,
                    "No"
                );

                ClearItemFields();
            }
        }

        private void ClearItemFields()
        {
            grnProIDText.Text = "";
            grnProNameText.Text = "";
            grnProCatText.Text = "";
            grnVarText.Text = "";
            grnStockText.Text = "";
            grnQuantityText.Text = "";
            grnCostPriText.Text = "";
            grnRetPriText.Text = "";
            grnNetPriceText.Text = "0.00";
            grnUnitText.Text = "";
            grnProSearchText.Text = "";

            grnVarTypCombo.Items.Clear();
            grnVarTypCombo.Enabled = false;
            grnWarrantyComboBox.SelectedIndex = 0;

            expireDateCheckBox.Checked = false;
            grnExpireDatePicker.Enabled = false;
            grnExpireDatePicker.Value = DateTime.Now;

            currentProductId = null;
            currentVariationType = null;
            isSerialNumberRequired = false;
            checkSerialNumber.Checked = false;

            UpdateUnitLabels();
        }
        #endregion

        #region Delete Row Handling
        private void grnDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == grnDataGridView.Columns["Delete"].Index)
            {
                grnDataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }
        #endregion

        #region Save GRN
        private void grnSaveBtn_Click(object sender, EventArgs e)
        {
            if (grnDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Please add products to the GRN.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(paymentMethod))
            {
                MessageBox.Show("Please select a payment method.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        // Insert into grn table
                        string grnQuery = "INSERT INTO grn (grn_no, payment_method, total_amount, date) " +
                                          "VALUES (@grnNo, @paymentMethod, @totalAmount, @date)";
                        using (MySqlCommand cmd = new MySqlCommand(grnQuery, conn, transaction))
                        {
                            string grnNo = GenerateGRNNumber();
                            cmd.Parameters.AddWithValue("@grnNo", grnNo);
                            cmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);
                            cmd.Parameters.AddWithValue("@totalAmount", CalculateTotalAmount());
                            cmd.Parameters.AddWithValue("@date", DateTime.Now);
                            cmd.ExecuteNonQuery();
                            long grnId = cmd.LastInsertedId;

                            StockManager stockManager = new StockManager(connectionString);

                            foreach (DataGridViewRow row in grnDataGridView.Rows)
                            {
                                string varType = row.Cells["VariationType"].Value?.ToString();
                                if (varType == "N/A") varType = null;
                                string formattedProductId = row.Cells["ProductID"].Value.ToString();
                                int productId = int.Parse(formattedProductId.Replace("PRO", ""));
                                decimal quantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                                decimal costPrice = Convert.ToDecimal(row.Cells["CostPrice"].Value);
                                decimal netPrice = Convert.ToDecimal(row.Cells["NetPrice"].Value);
                                string expiryDateStr = row.Cells["ExpiryDate"].Value?.ToString();
                                object expiryDate = expiryDateStr == "N/A" ? new DateTime(2099, 12, 31) : DateTime.Parse(expiryDateStr);
                                string warranty = row.Cells["Warranty"].Value?.ToString() ?? "No Warranty";
                                string unit = row.Cells["Unit"].Value?.ToString();
                                string serialNumberFlag = row.Cells["SerialNumber"].Value.ToString();

                                // Insert into grn_items
                                string itemQuery = @"
                            INSERT INTO grn_items (grn_id, product_id, variation_type, quantity, cost_price, net_price, expiry_date, warranty, unit, serial_numbers)
                            VALUES (@grnId, @productId, @variationType, @quantity, @costPrice, @netPrice, @expiryDate, @warranty, @unit, @serialNumbers)";
                                using (MySqlCommand itemCmd = new MySqlCommand(itemQuery, conn, transaction))
                                {
                                    itemCmd.Parameters.AddWithValue("@grnId", grnId);
                                    itemCmd.Parameters.AddWithValue("@productId", productId);
                                    itemCmd.Parameters.AddWithValue("@variationType", varType ?? (object)DBNull.Value);
                                    itemCmd.Parameters.AddWithValue("@quantity", quantity);
                                    itemCmd.Parameters.AddWithValue("@costPrice", costPrice);
                                    itemCmd.Parameters.AddWithValue("@netPrice", netPrice);
                                    itemCmd.Parameters.AddWithValue("@expiryDate", expiryDate);
                                    itemCmd.Parameters.AddWithValue("@warranty", warranty);
                                    itemCmd.Parameters.AddWithValue("@unit", unit == "N/A" ? (object)DBNull.Value : unit);
                                    itemCmd.Parameters.AddWithValue("@serialNumbers", serialNumberFlag);
                                    itemCmd.ExecuteNonQuery();

                                    // Get last inserted grn_items id
                                    long grnItemsId = itemCmd.LastInsertedId;

                                    // Insert into stock_details
                                    string stockDetailsQuery = @"
                                INSERT INTO stock_details (grn_items_id, remaining_qty)
                                VALUES (@grnItemsId, @quantity)";
                                    using (MySqlCommand stockDetailsCmd = new MySqlCommand(stockDetailsQuery, conn, transaction))
                                    {
                                        stockDetailsCmd.Parameters.AddWithValue("@grnItemsId", grnItemsId);
                                        stockDetailsCmd.Parameters.AddWithValue("@quantity", quantity);
                                        stockDetailsCmd.ExecuteNonQuery();
                                    }
                                }

                                // Update stock using StockManager
                                stockManager.UpdateStock(productId, varType, quantity, unit, true);
                            }

                            transaction.Commit();
                            MessageBox.Show("GRN saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    if (currentProductId.HasValue)
                    {
                        if (currentVariationType == null)
                            LoadStockForNoVariation(currentProductId.Value);
                        else
                            LoadStockForVariation(currentProductId.Value, currentVariationType);
                    }

                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving GRN: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Save GRN error: {ex}");
            }
        }


        private void ClearProductDetails()
        {
            grnProIDText.Text = "";
            grnProNameText.Text = "";
            grnProCatText.Text = "";
            grnVarText.Text = "";
            grnStockText.Text = "";
            grnVarTypCombo.Items.Clear();
            grnVarTypCombo.Enabled = false;
            grnQuantityText.Text = "";
            grnCostPriText.Text = "";
            grnRetPriText.Text = "";
            grnNetPriceText.Text = "0.00";
            grnUnitText.Text = "";
            expireDateCheckBox.Checked = false;
            grnExpireDatePicker.Enabled = false;
            grnExpireDatePicker.Value = DateTime.Now;
            grnWarrantyComboBox.SelectedIndex = 0;
            currentProductId = null;
            currentVariationType = null;

            UpdateUnitLabels();
        }

        private void ResetForm()
        {
            grnDataGridView.Rows.Clear();
            grnProSearchText.Text = "";
            ClearProductDetails();
            paymentMethod = null;
            cashPaymentRadioBtn.Checked = false;
            chequePaymentRadioBtn.Checked = false;
            creaditPayementRadioBtn.Checked = false;
            checkSerialNumber.Checked = false;
            isSerialNumberRequired = false;
        }

        private string GenerateGRNNumber()
        {
            return "GRN-" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private decimal CalculateTotalAmount()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in grnDataGridView.Rows)
            {
                if (decimal.TryParse(row.Cells["NetPrice"].Value?.ToString(), out decimal netPrice))
                {
                    total += netPrice;
                }
            }
            return total;
        }
        #endregion

        #region Barcode Form
        private void OpenAddBarcodeForm(string productId, string variationType, decimal quantity)
        {
            try
            {
                int qty = (int)quantity;
                if (qty != quantity)
                {
                    MessageBox.Show("Serial numbers require whole number quantities.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string numericProductId = productId.Replace("PRO", "");
                AddBarcodeForm barcodeForm = new AddBarcodeForm(numericProductId, variationType, qty);
                barcodeForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening barcode form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Open barcode form error: {ex}");
            }
        }
        #endregion

        #region Cancel
        private void grnCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Previous GRN
        private void previousGRNBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is PreviousGRN)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            PreviousGRN previousGRN = new PreviousGRN();
            previousGRN.Show();
        }
        private void expireDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            grnExpireDatePicker.Enabled = expireDateCheckBox.Checked;

            if (expireDateCheckBox.Checked)
            {
                // Set date to one month from today when checkbox is checked
                grnExpireDatePicker.Value = DateTime.Now.AddMonths(1);
            }
        }

        private int GetNextGRNId()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MAX(id) FROM grn";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        private void siticoneDateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void grnNoLabel_Click(object sender, EventArgs e)
        {
            try
            {
                int nextId = GetNextGRNId();
                grnNoLabel.Text = nextId.ToString("D4");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting next GRN ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void creatProductLabel_Click(object sender, EventArgs e) { }
        private void grnPictureBox_Click(object sender, EventArgs e) { }
        private void ceaditPayementLabel_Click(object sender, EventArgs e) { }
        private void grnPricingPanel_Paint(object sender, PaintEventArgs e) { }
        private void grnPriceLabel_Click(object sender, EventArgs e) { }
        private void cashPaymentLabel_Click(object sender, EventArgs e) { }
        private void grnCostPriText_TextChanged(object sender, EventArgs e) { }
        private void grnRetPriText_TextChanged(object sender, EventArgs e) { }
        private void grnNetPriceText_TextChanged(object sender, EventArgs e) { }
        private void grnStockText_TextChanged(object sender, EventArgs e) { }
        private void grnVarText_TextChanged(object sender, EventArgs e) { }
        private void grnProCatText_TextChanged(object sender, EventArgs e) { }
        private void expireDateText_TextChanged(object sender, EventArgs e) { }
        private void grnWarrantyComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void grnProIDText_TextChanged(object sender, EventArgs e) { }
        private void grnProNameText_TextChanged(object sender, EventArgs e) { }

        private void UpdateUnitLabels()
        {
            string unit = grnUnitText.Text.Trim().ToLower();
            switch (unit)
            {
                case "liter":
                    sUnitNameLabel.Text = "L";
                    qUnitNameLabel.Text = "L";
                    break;
                case "kilogram":
                    sUnitNameLabel.Text = "Kg";
                    qUnitNameLabel.Text = "Kg";
                    break;
                case "meter":
                    sUnitNameLabel.Text = "M";
                    qUnitNameLabel.Text = "M";
                    break;
                default:
                    sUnitNameLabel.Text = "";
                    qUnitNameLabel.Text = "";
                    break;
            }
        }

        private void grnUnitText_TextChanged(object sender, EventArgs e)
        {
            UpdateUnitLabels();
        }

        private void sUnitNameLabel_Click(object sender, EventArgs e) { }
        private void qUnitNameLabel_Click(object sender, EventArgs e) { }
        #endregion

        #region Serial Number Handling
        private void checkSerialNumber_CheckedChanged(object sender, EventArgs e)
        {
            isSerialNumberRequired = checkSerialNumber.Checked;
        }
        #endregion
    }
}