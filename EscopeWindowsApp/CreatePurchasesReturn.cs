using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class CreatePurchasesReturn : Form
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private DataTable _grnTable = new DataTable();
        private DataTable _grnItemsTable = new DataTable();
        private string _returnNote = string.Empty;
        private string selectedReason;
        private int? _returnId;

        public CreatePurchasesReturn(int? returnId = null)
        {
            InitializeComponent();
            _returnId = returnId;

            this.Load -= CreatePurchasesReturn_Load;
            grnProSearchText.TextChanged -= grnProSearchText_TextChanged;
            preReGRNDataGridView.CellContentClick -= preReGRNDataGridView_CellContentClick;
            preReGRNDataGridView.CellPainting -= preReGRNDataGridView_CellPainting;
            grnProductDataGridView.CellContentClick -= grnProductDataGridView_CellContentClick;
            grnProductDataGridView.CellPainting -= grnProductDataGridView_CellPainting;
            grnSaveBtn.Click -= grnSaveBtn_Click;
            grnCancelBtn.Click -= grnCancelBtn_Click;
            purReNoteText.TextChanged -= purReNoteText_TextChanged;
            StatusComboBox.SelectedIndexChanged -= StatusComboBox_SelectedIndexChanged;

            this.Load += CreatePurchasesReturn_Load;
            grnProSearchText.TextChanged += grnProSearchText_TextChanged;
            preReGRNDataGridView.CellContentClick += preReGRNDataGridView_CellContentClick;
            preReGRNDataGridView.CellPainting += preReGRNDataGridView_CellPainting;
            grnProductDataGridView.CellContentClick += grnProductDataGridView_CellContentClick;
            grnProductDataGridView.CellPainting += grnProductDataGridView_CellPainting;
            grnSaveBtn.Click += grnSaveBtn_Click;
            grnCancelBtn.Click += grnCancelBtn_Click;
            purReNoteText.TextChanged += purReNoteText_TextChanged;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;

            this.KeyPreview = true;
            this.KeyDown += CreatePurchasesReturn_KeyDown;

            ResonsPurchasReturnCombo.Items.AddRange(new string[] { "Product Damaged or Defective", "Product Not as Described or Expected", "Expired Products", "Other" });
            ResonsPurchasReturnCombo.SelectedIndex = 0;

            StatusComboBox.Items.AddRange(new string[] { "Complete", "Pending" });
            StatusComboBox.SelectedIndex = 0; // Default to "Complete"

            if (_returnId.HasValue)
            {
                this.Text = "Edit Purchase Return";
            }
            else
            {
                this.Text = "Create Purchase Return";
            }
        }

        private void CreatePurchasesReturn_Load(object sender, EventArgs e)
        {
            ConfigurePreReGRNDataGridView();
            ConfigureGrnProductDataGridView();
            if (_returnId.HasValue)
            {
                grnProSearchText.Enabled = false; // Disable search bar in update mode
                LoadExistingReturn(_returnId.Value);
                if (preReGRNDataGridView.Columns.Contains("AddColumn"))
                {
                    preReGRNDataGridView.Columns["AddColumn"].Visible = false; // Hide "Add" button when editing
                }
            }
            else
            {
                grnProSearchText.Enabled = true; // Enable search bar in create mode
                LoadGRNData();
                if (preReGRNDataGridView.Columns.Contains("AddColumn"))
                {
                    preReGRNDataGridView.Columns["AddColumn"].Visible = true; // Show "Add" button when creating
                }
            }
        }

        private void CreatePurchasesReturn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                grnSaveBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                grnCancelBtn.PerformClick();
            }
        }

        private void LoadExistingReturn(int returnId)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string returnQuery = @"
                        SELECT grn_no, note, reason, status
                        FROM purchase_returns
                        WHERE id = @returnId";
                    using (var cmd = new MySqlCommand(returnQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@returnId", returnId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string grnNo = reader["grn_no"].ToString();
                                _returnNote = reader["note"]?.ToString();
                                selectedReason = reader["reason"].ToString();
                                string status = reader["status"].ToString();

                                purReNoteText.Text = _returnNote;
                                ResonsPurchasReturnCombo.SelectedItem = selectedReason;
                                StatusComboBox.SelectedItem = status;

                                LoadGRNItems(grnNo);
                                LoadSpecificGRN(grnNo); // Load the specific GRN
                            }
                            else
                            {
                                MessageBox.Show("Return not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    string detailsQuery = @"
                        SELECT product_id, variation_type, unit, quantity
                        FROM purchase_return_details
                        WHERE return_id = @returnId";
                    using (var cmd = new MySqlCommand(detailsQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@returnId", returnId);
                        var detailsTable = new DataTable();
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(detailsTable);
                        }

                        foreach (DataRow detailRow in detailsTable.Rows)
                        {
                            int productId = Convert.ToInt32(detailRow["product_id"]);
                            string variationType = detailRow["variation_type"]?.ToString();
                            string unit = detailRow["unit"]?.ToString();
                            decimal returnQuantity = Convert.ToDecimal(detailRow["quantity"]);

                            foreach (DataGridViewRow gridRow in grnProductDataGridView.Rows)
                            {
                                if (Convert.ToInt32(gridRow.Cells["product_id"].Value) == productId &&
                                    (gridRow.Cells["variation_type"].Value?.ToString() ?? "") == (variationType ?? "") &&
                                    (gridRow.Cells["unit"].Value?.ToString() ?? "") == (unit ?? ""))
                                {
                                    gridRow.Cells["return_quantity"].Value = returnQuantity;
                                    decimal costPrice = Convert.ToDecimal(gridRow.Cells["cost_price"].Value);
                                    gridRow.Cells["net_price"].Value = costPrice * returnQuantity;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading return data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSpecificGRN(string grnNo)
        {
            try
            {
                string query = @"
                    SELECT 
                        grn_no,
                        payment_method,
                        total_amount,
                        date
                    FROM grn
                    WHERE grn_no = @grnNo
                ";

                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@grnNo", grnNo);
                        var adapter = new MySqlDataAdapter(cmd);
                        _grnTable.Clear();
                        adapter.Fill(_grnTable);
                        preReGRNDataGridView.DataSource = _grnTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading specific GRN data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region preReGRNDataGridView Configuration and Loading

        private void ConfigurePreReGRNDataGridView()
        {
            preReGRNDataGridView.AutoGenerateColumns = false;
            preReGRNDataGridView.ReadOnly = true;
            preReGRNDataGridView.AllowUserToAddRows = false;
            preReGRNDataGridView.Columns.Clear();

            preReGRNDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "grn_no",
                DataPropertyName = "grn_no",
                HeaderText = "GRN No",
                Width = 150
            });
            preReGRNDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "payment_method",
                DataPropertyName = "payment_method",
                HeaderText = "Payment Method",
                Width = 120
            });
            preReGRNDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "total_amount",
                DataPropertyName = "total_amount",
                HeaderText = "Total Amount",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" },
                Width = 100
            });
            preReGRNDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "date",
                DataPropertyName = "date",
                HeaderText = "Date",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" },
                Width = 100
            });
            DataGridViewButtonColumn addColumn = new DataGridViewButtonColumn
            {
                Name = "AddColumn",
                HeaderText = "Add",
                Text = "",
                UseColumnTextForButtonValue = false,
                Width = 50
            };
            preReGRNDataGridView.Columns.Add(addColumn);
        }

        private void LoadGRNData()
        {
            try
            {
                if (preReGRNDataGridView == null || grnProSearchText == null)
                {
                    MessageBox.Show(
                        "One or more controls are not properly initialized. Check your designer names.",
                        "Initialization Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                string query = @"
                    SELECT 
                        grn_no,
                        payment_method,
                        total_amount,
                        date
                    FROM grn
                    WHERE 1=1
                ";

                string searchText = grnProSearchText.Text.Trim();
                if (!string.IsNullOrEmpty(searchText))
                {
                    query += " AND grn_no LIKE @searchText";
                }

                query += " ORDER BY date DESC";

                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchText))
                        {
                            cmd.Parameters.AddWithValue("@searchText", $"%{searchText}%");
                        }

                        var adapter = new MySqlDataAdapter(cmd);
                        _grnTable.Clear();
                        adapter.Fill(_grnTable);
                        preReGRNDataGridView.DataSource = _grnTable;

                        if (_grnTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No GRN records found in the database.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading GRN data: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grnProSearchText_TextChanged(object sender, EventArgs e)
        {
            LoadGRNData();
        }

        private void preReGRNDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (preReGRNDataGridView.Columns[e.ColumnIndex].Name == "AddColumn")
                {
                    e.PaintBackground(e.CellBounds, true);

                    try
                    {
                        Image addIcon = Properties.Resources.posadd_;
                        int iconSize = 24;
                        int x = e.CellBounds.Left + (e.CellBounds.Width - iconSize) / 2;
                        int y = e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2;
                        e.Graphics.DrawImage(addIcon, x, y, iconSize, iconSize);
                    }
                    catch (Exception ex)
                    {
                        string text = "Add";
                        using (Font font = new Font("Arial", 8))
                        {
                            SizeF size = e.Graphics.MeasureString(text, font);
                            PointF location = new PointF(
                                e.CellBounds.Left + (e.CellBounds.Width - size.Width) / 2,
                                e.CellBounds.Top + (e.CellBounds.Height - size.Height) / 2
                            );
                            e.Graphics.DrawString(text, font, Brushes.Black, location);
                        }
                        System.Diagnostics.Debug.WriteLine($"Error loading Add icon: {ex.Message}");
                    }

                    e.Handled = true;
                }
            }
        }

        private void preReGRNDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && preReGRNDataGridView.Columns[e.ColumnIndex].Name == "AddColumn")
            {
                string selectedGRNNo = preReGRNDataGridView.Rows[e.RowIndex].Cells["grn_no"].Value?.ToString();
                if (string.IsNullOrEmpty(selectedGRNNo))
                {
                    MessageBox.Show("Selected GRN number is empty or null.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoadGRNItems(selectedGRNNo);
            }
        }

        #endregion

        #region grnProductDataGridView Configuration and Loading

        private void ConfigureGrnProductDataGridView()
        {
            grnProductDataGridView.AutoGenerateColumns = false;
            grnProductDataGridView.AllowUserToAddRows = false;
            grnProductDataGridView.Columns.Clear();

            grnProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "grn_no",
                DataPropertyName = "grn_no",
                HeaderText = "GRN No",
                Width = 100
            });
            grnProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "product_id",
                DataPropertyName = "product_id",
                HeaderText = "Product ID",
                Width = 80
            });
            grnProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "product_name",
                DataPropertyName = "product_name",
                HeaderText = "Product Name",
                Width = 150
            });
            grnProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "supplier_name",
                DataPropertyName = "supplier_name",
                HeaderText = "Supplier Name",
                Width = 120
            });
            grnProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "brand",
                DataPropertyName = "brand",
                HeaderText = "Brand",
                Width = 100
            });
            grnProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "variation_type",
                DataPropertyName = "variation_type",
                HeaderText = "Variation Type",
                Width = 100
            });
            grnProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "unit",
                DataPropertyName = "unit",
                HeaderText = "Unit Type",
                Width = 80
            });
            grnProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "quantity",
                DataPropertyName = "quantity",
                HeaderText = "Quantity",
                Width = 80
            });
            DataGridViewButtonColumn decreaseColumn = new DataGridViewButtonColumn
            {
                Name = "decrease",
                HeaderText = "",
                Text = "",
                UseColumnTextForButtonValue = false,
                Width = 30
            };
            grnProductDataGridView.Columns.Add(decreaseColumn);
            grnProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "cost_price",
                DataPropertyName = "cost_price",
                HeaderText = "Cost Price",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" },
                Width = 100
            });
            grnProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "net_price",
                DataPropertyName = "net_price",
                HeaderText = "Net Price",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" },
                Width = 100
            });
            grnProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "return_quantity",
                DataPropertyName = "return_quantity",
                HeaderText = "Return Quantity",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "F2" }
            });
        }

        private void LoadGRNItems(string grnNo)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    string grnCheckQuery = "SELECT COUNT(*) FROM grn WHERE grn_no = @grnNo";
                    using (var grnCheckCmd = new MySqlCommand(grnCheckQuery, conn))
                    {
                        grnCheckCmd.Parameters.AddWithValue("@grnNo", grnNo);
                        int grnCount = Convert.ToInt32(grnCheckCmd.ExecuteScalar());

                        if (grnCount == 0)
                        {
                            MessageBox.Show($"GRN No {grnNo} does not exist.", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string itemsCheckQuery = @"SELECT COUNT(*) FROM grn_items gi 
                                    JOIN grn g ON gi.grn_id = g.id 
                                    WHERE g.grn_no = @grnNo";
                    using (var itemsCheckCmd = new MySqlCommand(itemsCheckQuery, conn))
                    {
                        itemsCheckCmd.Parameters.AddWithValue("@grnNo", grnNo);
                        int itemsCount = Convert.ToInt32(itemsCheckCmd.ExecuteScalar());

                        if (itemsCount == 0)
                        {
                            MessageBox.Show($"GRN No {grnNo} exists but has no items.", "Information",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            grnProductDataGridView.DataSource = null;
                            return;
                        }
                    }

                    string query = @"
                SELECT 
                    g.grn_no,
                    gi.product_id,
                    COALESCE(p.name, 'N/A') AS product_name,
                    COALESCE(s.name, 'N/A') AS supplier_name,
                    COALESCE(b.name, 'N/A') AS brand,
                    COALESCE(gi.variation_type, 'N/A') AS variation_type,
                    COALESCE(gi.unit, 'N/A') AS unit,
                    gi.quantity,
                    gi.cost_price,
                    gi.net_price
                FROM grn g
                JOIN grn_items gi ON g.id = gi.grn_id
                LEFT JOIN products p ON gi.product_id = p.id
                LEFT JOIN suppliers s ON p.supplier_id = s.id
                LEFT JOIN brands b ON p.brand_id = b.id
                WHERE g.grn_no = @grnNo
            ";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@grnNo", grnNo);
                        var adapter = new MySqlDataAdapter(cmd);
                        _grnItemsTable.Clear();
                        adapter.Fill(_grnItemsTable);

                        if (_grnItemsTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No items found for this GRN.", "Information",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        DataTable returnItemsTable = _grnItemsTable.Clone();
                        returnItemsTable.Columns.Add("return_quantity", typeof(decimal));

                        foreach (DataRow row in _grnItemsTable.Rows)
                        {
                            DataRow newRow = returnItemsTable.NewRow();
                            foreach (DataColumn col in _grnItemsTable.Columns)
                            {
                                newRow[col.ColumnName] = row[col.ColumnName];
                            }
                            newRow["return_quantity"] = 0m;
                            returnItemsTable.Rows.Add(newRow);
                        }

                        grnProductDataGridView.DataSource = returnItemsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading GRN items: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                grnProductDataGridView.DataSource = null;
            }
        }

        private void grnProductDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (grnProductDataGridView.Columns[e.ColumnIndex].Name == "decrease")
                {
                    e.PaintBackground(e.CellBounds, true);
                    try
                    {
                        Image minusIcon = Properties.Resources.posminus1;
                        int iconSize = 24;
                        int x = e.CellBounds.Left + (e.CellBounds.Width - iconSize) / 2;
                        int y = e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2;
                        e.Graphics.DrawImage(minusIcon, x, y, iconSize, iconSize);
                    }
                    catch (Exception ex)
                    {
                        string text = "-";
                        using (Font font = new Font("Arial", 8))
                        {
                            SizeF size = e.Graphics.MeasureString(text, font);
                            PointF location = new PointF(
                                e.CellBounds.Left + (e.CellBounds.Width - size.Width) / 2,
                                e.CellBounds.Top + (e.CellBounds.Height - size.Height) / 2
                            );
                            e.Graphics.DrawString(text, font, Brushes.Black, location);
                        }
                        System.Diagnostics.Debug.WriteLine($"Error loading minus icon: {ex.Message}");
                    }
                    e.Handled = true;
                }
            }
        }

        private void grnProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && grnProductDataGridView.Columns[e.ColumnIndex].Name == "decrease")
            {
                DataGridViewRow row = grnProductDataGridView.Rows[e.RowIndex];
                decimal returnQuantity = Convert.ToDecimal(row.Cells["return_quantity"].Value);
                decimal originalQuantity = Convert.ToDecimal(row.Cells["quantity"].Value);

                if (returnQuantity < originalQuantity)
                {
                    row.Cells["return_quantity"].Value = returnQuantity + 1;
                    decimal costPrice = Convert.ToDecimal(row.Cells["cost_price"].Value);
                    decimal newNetPrice = costPrice * (returnQuantity + 1);
                    row.Cells["net_price"].Value = newNetPrice;
                }
                else
                {
                    MessageBox.Show("Cannot return more than the original quantity.",
                        "Maximum Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #endregion

        private void grnSaveBtn_Click(object sender, EventArgs e)
        {
            if (grnProductDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No items to return.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(selectedReason))
            {
                MessageBox.Show("Please select a reason for the return.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResonsPurchasReturnCombo.Focus();
                return;
            }

            string status = StatusComboBox.SelectedItem.ToString();
            decimal totalAmount = 0m;
            if (status == "Complete")
            {
                totalAmount = CalculateTotalAmount();
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            if (_returnId.HasValue)
                            {
                                // Update existing return
                                string updateReturnQuery = @"
                                    UPDATE purchase_returns
                                    SET note = @note, reason = @reason, status = @status, total_amount = @totalAmount
                                    WHERE id = @returnId";
                                using (MySqlCommand cmd = new MySqlCommand(updateReturnQuery, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@note", _returnNote ?? (object)DBNull.Value);
                                    cmd.Parameters.AddWithValue("@reason", selectedReason);
                                    cmd.Parameters.AddWithValue("@status", status);
                                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                                    cmd.Parameters.AddWithValue("@returnId", _returnId.Value);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Insert new return
                                string returnNo = "PR_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                                string grnNo = grnProductDataGridView.Rows[0].Cells["grn_no"].Value?.ToString();

                                if (string.IsNullOrEmpty(grnNo))
                                {
                                    MessageBox.Show("Invalid GRN number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                string note = _returnNote;
                                if (string.IsNullOrEmpty(note)) note = null;

                                string insertReturnQuery = @"
                                    INSERT INTO purchase_returns (grn_no, return_no, note, total_amount, reason, status, created_at)
                                    VALUES (@grnNo, @returnNo, @note, @totalAmount, @reason, @status, NOW());
                                    SELECT LAST_INSERT_ID();";
                                using (MySqlCommand cmd = new MySqlCommand(insertReturnQuery, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@grnNo", grnNo);
                                    cmd.Parameters.AddWithValue("@returnNo", returnNo);
                                    cmd.Parameters.AddWithValue("@note", note ?? (object)DBNull.Value);
                                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                                    cmd.Parameters.AddWithValue("@reason", selectedReason);
                                    cmd.Parameters.AddWithValue("@status", status);
                                    _returnId = Convert.ToInt32(cmd.ExecuteScalar());
                                }

                                // Insert details for both Pending and Complete
                                string insertDetailsQuery = @"
                                    INSERT INTO purchase_return_details 
                                    (return_id, product_id, variation_type, unit, quantity, cost_price, net_price)
                                    VALUES (@returnId, @productId, @variationType, @unit, @quantity, @costPrice, @netPrice)";
                                HashSet<string> processedProducts = new HashSet<string>();

                                foreach (DataGridViewRow row in grnProductDataGridView.Rows)
                                {
                                    if (row.Cells["return_quantity"].Value == null || Convert.ToDecimal(row.Cells["return_quantity"].Value) <= 0)
                                        continue;

                                    int productId = Convert.ToInt32(row.Cells["product_id"].Value);
                                    string variationType = row.Cells["variation_type"].Value?.ToString();
                                    if (string.IsNullOrEmpty(variationType) || variationType == "N/A") variationType = null;
                                    string unit = row.Cells["unit"].Value?.ToString();
                                    if (string.IsNullOrEmpty(unit) || unit == "N/A") unit = null;
                                    decimal returnQuantity = Convert.ToDecimal(row.Cells["return_quantity"].Value);
                                    decimal costPrice = Convert.ToDecimal(row.Cells["cost_price"].Value);
                                    decimal netPrice = Convert.ToDecimal(row.Cells["net_price"].Value);

                                    string productKey = $"{productId}{variationType ?? "null"}{unit ?? "null"}";
                                    if (processedProducts.Contains(productKey))
                                        continue;
                                    processedProducts.Add(productKey);

                                    string checkStockQuery = @"
                                        SELECT stock 
                                        FROM stock 
                                        WHERE product_id = @productId 
                                        AND (variation_type = @variationType OR (variation_type IS NULL AND @variationType IS NULL))
                                        AND (unit = @unit OR (unit IS NULL AND @unit IS NULL))
                                        LIMIT 1";
                                    using (MySqlCommand checkCmd = new MySqlCommand(checkStockQuery, connection, transaction))
                                    {
                                        checkCmd.Parameters.AddWithValue("@productId", productId);
                                        checkCmd.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                        checkCmd.Parameters.AddWithValue("@unit", unit ?? (object)DBNull.Value);
                                        var result = checkCmd.ExecuteScalar();
                                        decimal currentStock = result != null ? Convert.ToDecimal(result) : 0m;

                                        if (currentStock < returnQuantity)
                                        {
                                            transaction.Rollback();
                                            MessageBox.Show($"Cannot return {returnQuantity} units of Product ID {productId}. Only {currentStock} units available.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }

                                    using (MySqlCommand cmd = new MySqlCommand(insertDetailsQuery, connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@returnId", _returnId.Value);
                                        cmd.Parameters.AddWithValue("@productId", productId);
                                        cmd.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                        cmd.Parameters.AddWithValue("@unit", unit ?? (object)DBNull.Value);
                                        cmd.Parameters.AddWithValue("@quantity", returnQuantity);
                                        cmd.Parameters.AddWithValue("@costPrice", costPrice);
                                        cmd.Parameters.AddWithValue("@netPrice", netPrice);
                                        cmd.ExecuteNonQuery();
                                    }

                                    string updateStockQuery = @"
                                        UPDATE stock 
                                        SET stock = stock - @quantity 
                                        WHERE product_id = @productId 
                                        AND (variation_type = @variationType OR (variation_type IS NULL AND @variationType IS NULL))
                                        AND (unit = @unit OR (unit IS NULL AND @unit IS NULL))";
                                    using (MySqlCommand cmd = new MySqlCommand(updateStockQuery, connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@quantity", returnQuantity);
                                        cmd.Parameters.AddWithValue("@productId", productId);
                                        cmd.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                        cmd.Parameters.AddWithValue("@unit", unit ?? (object)DBNull.Value);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("Purchase return processed successfully.", "Success",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error processing return: {ex.Message}", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal CalculateTotalAmount()
        {
            decimal total = 0m;
            foreach (DataGridViewRow row in grnProductDataGridView.Rows)
            {
                if (row.Cells["return_quantity"].Value != null &&
                    Convert.ToDecimal(row.Cells["return_quantity"].Value) > 0)
                {
                    if (row.Cells["net_price"].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells["net_price"].Value);
                    }
                }
            }
            return total;
        }

        private void grnCancelBtn_Click(object sender, EventArgs e)
        {
            grnProSearchText.Text = "";
            purReNoteText.Text = "";
            _returnNote = string.Empty;
            ResonsPurchasReturnCombo.SelectedIndex = 0;
            StatusComboBox.SelectedIndex = 0;
            _grnItemsTable.Clear();
            grnProductDataGridView.DataSource = null;
            LoadGRNData();
            this.Close();
        }

        private void purReNoteText_TextChanged(object sender, EventArgs e)
        {
            _returnNote = purReNoteText.Text.Trim();
        }

        private void ResonsPurchasReturnCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedReason = ResonsPurchasReturnCombo.SelectedItem?.ToString();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedItem.ToString() == "Pending")
            {
                grnSaveBtn.Text = "Process";
            }
            else
            {
                grnSaveBtn.Text = "Save";
            }
        }
    }
}