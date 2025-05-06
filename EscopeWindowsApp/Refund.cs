using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Configuration;
using System.IO.Ports;
using System.Timers;

namespace EscopeWindowsApp
{
    public partial class Refund : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private DataTable billProductsTable;
        private int selectedProductId;
        private decimal totalRefundAmount = 0m;
        private bool isUsbScannerEnabled = false;
        private bool isBluetoothScannerEnabled = false;
        private SerialPort bluetoothSerialPort;
        private string scannedBarcodeBuffer = "";
        private System.Timers.Timer usbScanTimer;
        private const int USB_SCAN_TIMEOUT = 100; // 100ms timeout to detect end of USB scan

        public Refund()
        {
            InitializeComponent();
            ConfigureBillProductDataGridView();
            ConfigureRefItemDataGridView();
            billProductDataGrid.SelectionChanged += billProductDataGrid_SelectionChanged;
            refQTYText.KeyPress += refQTYText_KeyPress;

            // Set text boxes to read-only
            proIDText.ReadOnly = true;
            refProNameText.ReadOnly = true;
            refVarTypeText.ReadOnly = true;
            refUnitText.ReadOnly = true;

            // Initialize DataTable
            billProductsTable = new DataTable();
            ClearBillDetails();

            // Initialize scanners
            InitializeBluetoothScanner();
            InitializeUsbScanTimer();

            // Subscribe to form key press event for USB scanner input
            this.KeyPreview = true;
            this.KeyPress += Refund_KeyPress;

            // Subscribe to FormClosing event for cleanup
            this.FormClosing += Refund_FormClosing;
        }

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

        private void Refund_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isUsbScannerEnabled)
            {
                scannedBarcodeBuffer += e.KeyChar;
                usbScanTimer.Stop();
                usbScanTimer.Start(); // Restart timer to detect end of scan
                e.Handled = true; // Prevent character from being entered into focused control
            }
        }

        private void ProcessScannedBarcode(string billNo)
        {
            if (!string.IsNullOrEmpty(billNo))
            {
                billSearchTextBox.Text = billNo;
                LoadBillDetails(billNo);
                Debug.WriteLine($"Processed scanned bill number: {billNo}");
            }
        }

        private void refuntWebcamScanBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (CodeReaderForm codeReader = new CodeReaderForm())
                {
                    if (codeReader.ShowDialog() == DialogResult.OK)
                    {
                        string scannedBillNo = codeReader.ScannedCode;
                        ProcessScannedBarcode(scannedBillNo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error scanning barcode with webcam: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine($"Webcam scan error: {ex.Message}");
            }
        }

        private void refundUSBScanToggleBtn_CheckedChanged(object sender, EventArgs e)
        {
            isUsbScannerEnabled = refundUSBScanToggleBtn.Checked;
            if (isUsbScannerEnabled)
            {
                MessageBox.Show("USB Scanner enabled. Scan a bill barcode to auto-fill bill details.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActiveControl = null;
            }
            else
            {
                MessageBox.Show("USB Scanner disabled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scannedBarcodeBuffer = "";
                usbScanTimer.Stop();
            }
            Debug.WriteLine($"USB Scanner {(isUsbScannerEnabled ? "enabled" : "disabled")}");
        }

        private void refundBluToggleBtn_CheckedChanged(object sender, EventArgs e)
        {
            isBluetoothScannerEnabled = refundBluToggleBtn.Checked;
            try
            {
                if (isBluetoothScannerEnabled)
                {
                    if (bluetoothSerialPort != null && !bluetoothSerialPort.IsOpen)
                    {
                        bluetoothSerialPort.Open();
                        MessageBox.Show("Bluetooth Scanner enabled. Scan a bill barcode to auto-fill bill details.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ActiveControl = null;
                    }
                    else if (bluetoothSerialPort == null)
                    {
                        MessageBox.Show("No COM ports found for Bluetooth scanner. Please configure manually.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        refundBluToggleBtn.Checked = false;
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
                refundBluToggleBtn.Checked = false;
                Debug.WriteLine($"Bluetooth scanner toggle error: {ex.Message}");
            }
            Debug.WriteLine($"Bluetooth Scanner {(isBluetoothScannerEnabled ? "enabled" : "disabled")}");
        }
        #endregion

        #region Cleanup
        private void Refund_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Clean up scanner resources
            if (bluetoothSerialPort != null)
            {
                if (bluetoothSerialPort.IsOpen)
                {
                    bluetoothSerialPort.Close();
                }
                bluetoothSerialPort.Dispose();
                bluetoothSerialPort = null;
            }
            if (usbScanTimer != null)
            {
                usbScanTimer.Dispose();
                usbScanTimer = null;
            }
            Debug.WriteLine("Scanner resources cleaned up in Refund_FormClosing.");
        }
        #endregion

        #region DataGridView Configuration
        private void ConfigureBillProductDataGridView()
        {
            billProductDataGrid.AutoGenerateColumns = false;
            billProductDataGrid.Columns.Clear();

            billProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "product_id",
                HeaderText = "Product ID",
                DataPropertyName = "product_id",
                Visible = false
            });

            billProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "product_name",
                HeaderText = "Product Name",
                DataPropertyName = "product_name",
                Width = 150
            });

            billProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "variation_type",
                HeaderText = "Variation Type",
                DataPropertyName = "variation_type",
                Width = 100
            });

            billProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "unit",
                HeaderText = "Unit",
                DataPropertyName = "unit",
                Width = 80
            });

            billProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "quantity",
                HeaderText = "Quantity",
                DataPropertyName = "quantity",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            billProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "price",
                HeaderText = "Price",
                DataPropertyName = "price",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            billProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "total_price",
                HeaderText = "Total Price",
                DataPropertyName = "total_price",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            billProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "sale_date",
                HeaderText = "Sale Date",
                DataPropertyName = "sale_date",
                Width = 120
            });

            billProductDataGrid.AllowUserToAddRows = false;
            billProductDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            billProductDataGrid.MultiSelect = false;

            // Set text color to black for all cells
            billProductDataGrid.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void ConfigureRefItemDataGridView()
        {
            refItemDataGridView.AutoGenerateColumns = false;
            refItemDataGridView.Columns.Clear();

            refItemDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "product_id",
                HeaderText = "Product ID",
                Visible = false
            });

            refItemDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "product_name",
                HeaderText = "Product Name",
                Width = 150
            });

            refItemDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "variation_type",
                HeaderText = "Variation Type",
                Width = 100
            });

            refItemDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "unit",
                HeaderText = "Unit",
                Width = 80
            });

            refItemDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "quantity",
                HeaderText = "Quantity",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            refItemDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "price",
                HeaderText = "Price",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            refItemDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "total_price",
                HeaderText = "Total Price",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
            {
                Name = "delete",
                HeaderText = "Delete",
                Text = "",
                UseColumnTextForButtonValue = false,
                Width = 80
            };
            refItemDataGridView.Columns.Add(deleteColumn);

            refItemDataGridView.AllowUserToAddRows = false;
            refItemDataGridView.CellPainting += refItemDataGridView_CellPainting;
        }
        #endregion

        private void billSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string billNo = billSearchTextBox.Text.Trim();
            if (string.IsNullOrEmpty(billNo))
            {
                ClearBillDetails();
                return;
            }

            LoadBillDetails(billNo);
        }

        private void LoadBillDetails(string billNo)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch sales information
                    string salesQuery = "SELECT customer FROM sales WHERE bill_no = @billNo";
                    using (MySqlCommand salesCommand = new MySqlCommand(salesQuery, connection))
                    {
                        salesCommand.Parameters.AddWithValue("@billNo", billNo);
                        using (MySqlDataReader reader = salesCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                refClientNameLabel.Text = reader["customer"].ToString();
                                refClientNumLabel.Text = "N/A";
                                Debug.WriteLine($"Found bill {billNo} with customer: {refClientNameLabel.Text}");
                            }
                            else
                            {
                                Debug.WriteLine($"Bill {billNo} not found in sales table.");
                                MessageBox.Show("Bill not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ClearBillDetails();
                                return;
                            }
                        }
                    }

                    // Fetch product details using product_id directly
                    billProductsTable = new DataTable();
                    string detailsQuery = @"
                        SELECT 
                            sd.id AS sales_detail_id,
                            sd.product_id,
                            sd.product_name,
                            COALESCE(sd.variation_type, 'N/A') AS variation_type,
                            sd.unit,
                            sd.quantity,
                            sd.price,
                            sd.total_price,
                            s.sale_date
                        FROM sales_details sd
                        JOIN sales s ON sd.bill_no = s.bill_no
                        WHERE sd.bill_no = @billNo";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(detailsQuery, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@billNo", billNo);
                        adapter.Fill(billProductsTable);
                        Debug.WriteLine($"Retrieved {billProductsTable.Rows.Count} rows for bill {billNo}.");
                    }

                    if (billProductsTable.Rows.Count == 0)
                    {
                        Debug.WriteLine($"No products found for bill {billNo} in sales_details.");
                        MessageBox.Show("No products found for this bill.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearProductDetails();
                    }
                    else
                    {
                        billProductDataGrid.DataSource = null;
                        billProductDataGrid.DataSource = billProductsTable;
                        billProductDataGrid.Refresh();
                        Debug.WriteLine("billProductDataGrid bound to billProductsTable.");

                        if (billProductDataGrid.Rows.Count > 0)
                        {
                            billProductDataGrid.Rows[0].Selected = true;
                            Debug.WriteLine("First row selected in billProductDataGrid.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading bill details: {ex.Message}");
                MessageBox.Show($"Error loading bill details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearBillDetails();
            }
        }

        private void ClearBillDetails()
        {
            refClientNameLabel.Text = "N/A";
            refClientNumLabel.Text = "N/A";
            billProductsTable.Clear();
            billProductDataGrid.DataSource = null;
            billProductDataGrid.Refresh();
            ClearProductDetails();
            refItemDataGridView.Rows.Clear();
            UpdateRefundTotals(); // Reset totals and totalRefundAmount
            Debug.WriteLine("Bill details cleared.");
        }

        private void ClearProductDetails()
        {
            proIDText.Text = "";
            refProNameText.Text = "";
            refVarTypeText.Text = "";
            refUnitText.Text = "";
            refQTYText.Text = "";
            selectedProductId = 0;
            Debug.WriteLine("Product details cleared.");
        }

        private void billProductDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (billProductDataGrid.SelectedRows.Count > 0)
            {
                UpdateSelectedProductDetails(billProductDataGrid.SelectedRows[0]);
            }
            else
            {
                ClearProductDetails();
            }
        }

        private void UpdateSelectedProductDetails(DataGridViewRow selectedRow)
        {
            if (selectedRow.DataBoundItem is DataRowView rowView)
            {
                DataRow row = rowView.Row;
                selectedProductId = Convert.ToInt32(row["product_id"]);
                proIDText.Text = selectedProductId > 0 ? $"pro{selectedProductId:D3}" : "N/A";
                refProNameText.Text = row["product_name"].ToString();
                refVarTypeText.Text = row["variation_type"].ToString();
                refUnitText.Text = row["unit"].ToString();
                refQTYText.Text = "";
                Debug.WriteLine($"Selected product: ID={proIDText.Text}, Name={refProNameText.Text}, Variation={refVarTypeText.Text}, Unit={refUnitText.Text}");
            }
        }

        private void proIDText_TextChanged(object sender, EventArgs e)
        {
            // Auto-filled product ID, read-only
        }

        private void refProNameText_TextChanged(object sender, EventArgs e)
        {
            // Auto-filled product name, read-only
        }

        private void refVarTypeText_TextChanged(object sender, EventArgs e)
        {
            // Auto-filled variation type, read-only
        }

        private void refUnitText_TextChanged(object sender, EventArgs e)
        {
            // Auto-filled unit, read-only
        }

        private void refQTYText_TextChanged(object sender, EventArgs e)
        {
            // User enters refund quantity here
        }

        private void refQTYText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && refQTYText.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void addtoListBtn_Click(object sender, EventArgs e)
        {
            if (billProductDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to refund.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = billProductDataGrid.SelectedRows[0];
            if (!(selectedRow.DataBoundItem is DataRowView rowView)) return;

            DataRow row = rowView.Row;
            decimal originalQuantity = Convert.ToDecimal(row["quantity"]);
            string unit = row["unit"].ToString();

            if (!decimal.TryParse(refQTYText.Text, out decimal refundQuantity) || refundQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid refund quantity greater than 0.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (refundQuantity > originalQuantity)
            {
                MessageBox.Show($"Cannot refund more than the original quantity of {originalQuantity} {unit}.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (unit == "Pieces" && refundQuantity % 1 != 0)
            {
                MessageBox.Show("Quantity for items in Pieces must be a whole number.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productId = Convert.ToInt32(row["product_id"]);
            string productName = row["product_name"].ToString();
            string variationType = row["variation_type"].ToString();
            decimal price = Convert.ToDecimal(row["price"]);
            decimal totalPrice = refundQuantity * price;

            // Check if item already exists in refItemDataGridView
            foreach (DataGridViewRow refRow in refItemDataGridView.Rows)
            {
                if (Convert.ToInt32(refRow.Cells["product_id"].Value) == productId &&
                    refRow.Cells["variation_type"].Value.ToString() == variationType)
                {
                    MessageBox.Show("This product is already in the refund list.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            refItemDataGridView.Rows.Add(productId, productName, variationType, unit, refundQuantity, price, totalPrice);
            UpdateRefundTotals();
            refQTYText.Text = "";
            Debug.WriteLine($"Added to refund list: Product={productName}, Quantity={refundQuantity}, TotalPrice={totalPrice}");
        }

        private void UpdateRefundTotals()
        {
            decimal totalQuantity = 0m;
            decimal totalPrice = 0m;
            foreach (DataGridViewRow row in refItemDataGridView.Rows)
            {
                totalQuantity += Convert.ToDecimal(row.Cells["quantity"].Value);
                totalPrice += Convert.ToDecimal(row.Cells["total_price"].Value);
            }
            refTotQtyCountLabel.Text = totalQuantity.ToString("N2");
            refPriceCountLabel.Text = totalPrice.ToString("N2");
            totalRefundAmount = totalPrice; // Store the total refund amount
            Debug.WriteLine($"Refund totals updated: TotalQuantity={totalQuantity}, TotalPrice={totalPrice}");
        }

        private void refItemDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && refItemDataGridView.Columns[e.ColumnIndex].Name == "delete")
            {
                e.PaintBackground(e.CellBounds, true);
                try
                {
                    Image deleteIcon = Properties.Resources.delete;
                    int iconSize = 24;
                    int x = e.CellBounds.Left + (e.CellBounds.Width - iconSize) / 2;
                    int y = e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2;
                    e.Graphics.DrawImage(deleteIcon, x, y, iconSize, iconSize);
                }
                catch
                {
                    string text = "X";
                    using (Font font = new Font("Arial", 8))
                    {
                        SizeF size = e.Graphics.MeasureString(text, font);
                        PointF location = new PointF(
                            e.CellBounds.Left + (e.CellBounds.Width - size.Width) / 2,
                            e.CellBounds.Top + (e.CellBounds.Height - size.Height) / 2
                        );
                        e.Graphics.DrawString(text, font, Brushes.Black, location);
                    }
                }
                e.Handled = true;
            }
        }

        private void refItemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && refItemDataGridView.Columns[e.ColumnIndex].Name == "delete")
            {
                refItemDataGridView.Rows.RemoveAt(e.RowIndex);
                UpdateRefundTotals();
                Debug.WriteLine($"Removed item from refund list at index {e.RowIndex}.");
            }
        }

        private void refTotQtyCountLabel_Click(object sender, EventArgs e)
        {
            // Displays total quantity of products to be refunded
        }

        private void refPriceCountLabel_Click(object sender, EventArgs e)
        {
            // Displays total price of products to be refunded
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            if (refItemDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No items to refund.", "Empty Refund List", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string billNo = billSearchTextBox.Text.Trim();
            if (string.IsNullOrEmpty(billNo))
            {
                MessageBox.Show("Please enter a bill number.", "Missing Bill Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to process this refund?", "Confirm Refund", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        foreach (DataGridViewRow row in refItemDataGridView.Rows)
                        {
                            int productId = Convert.ToInt32(row.Cells["product_id"].Value);
                            string variationType = row.Cells["variation_type"].Value.ToString();
                            if (variationType == "N/A") variationType = null;
                            decimal quantity = Convert.ToDecimal(row.Cells["quantity"].Value);
                            decimal price = Convert.ToDecimal(row.Cells["price"].Value);
                            decimal totalPrice = Convert.ToDecimal(row.Cells["total_price"].Value);

                            // Insert into refunds table
                            string refundQuery = @"
                                INSERT INTO refunds (bill_no, product_id, product_name, variation_type, unit, quantity, price, total_price, refund_date)
                                VALUES (@billNo, @productId, @productName, @variationType, @unit, @quantity, @price, @totalPrice, NOW())";
                            using (MySqlCommand refundCommand = new MySqlCommand(refundQuery, connection, transaction))
                            {
                                refundCommand.Parameters.AddWithValue("@billNo", billNo);
                                refundCommand.Parameters.AddWithValue("@productId", productId);
                                refundCommand.Parameters.AddWithValue("@productName", row.Cells["product_name"].Value.ToString());
                                refundCommand.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                refundCommand.Parameters.AddWithValue("@unit", row.Cells["unit"].Value.ToString());
                                refundCommand.Parameters.AddWithValue("@quantity", quantity);
                                refundCommand.Parameters.AddWithValue("@price", price);
                                refundCommand.Parameters.AddWithValue("@totalPrice", totalPrice);
                                refundCommand.ExecuteNonQuery();
                            }

                            // Update stock
                            string updateStockQuery = @"
                                UPDATE stock 
                                SET stock = stock + @quantity 
                                WHERE product_id = @productId 
                                AND (variation_type = @variationType OR (variation_type IS NULL AND @variationType IS NULL))
                                LIMIT 1";
                            using (MySqlCommand stockCommand = new MySqlCommand(updateStockQuery, connection, transaction))
                            {
                                stockCommand.Parameters.AddWithValue("@quantity", quantity);
                                stockCommand.Parameters.AddWithValue("@productId", productId);
                                stockCommand.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                int rowsAffected = stockCommand.ExecuteNonQuery();
                                Debug.WriteLine($"Stock update for Product ID {productId}, Variation: {variationType ?? "NULL"}, Quantity: {quantity}, Rows Affected: {rowsAffected}");
                                if (rowsAffected == 0)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show($"Error: Stock not found for Product ID {productId}, Variation: {variationType ?? "NULL"}. Transaction rolled back.", "Stock Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        transaction.Commit();

                        SessionManager.TotalRefund += totalRefundAmount;

                        MessageBox.Show("Refund processed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearBillDetails();
                        billSearchTextBox.Text = "";
                        Debug.WriteLine($"Refund processed for bill {billNo}.");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error processing refund: {ex.Message}");
                MessageBox.Show($"Error processing refund: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refClientNameLabel_Click(object sender, EventArgs e)
        {
            // Displays customer name of the bill
        }

        private void refClientNumLabel_Click(object sender, EventArgs e)
        {
            // Displays customer phone number of the bill (not available in sales table)
        }

        private void billProductDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Columns: product id, product name, variant type, unit, quantity, price, total price, bill issue date
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Refund_Load(object sender, EventArgs e)
        {
            ClearBillDetails();
        }
    }
}