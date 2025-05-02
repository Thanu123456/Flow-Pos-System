using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace EscopeWindowsApp
{
    public partial class CreatePurchasesReturn : Form
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private DataTable _grnTable = new DataTable();
        private DataTable _grnItemsTable = new DataTable();
        private string _returnNote = string.Empty;

        public CreatePurchasesReturn()
        {
            InitializeComponent();

            // Clear any existing event handlers to prevent duplicates
            this.Load -= CreatePurchasesReturn_Load;
            grnProSearchText.TextChanged -= grnProSearchText_TextChanged;
            preReGRNDataGridView.CellContentClick -= preReGRNDataGridView_CellContentClick;
            preReGRNDataGridView.CellPainting -= preReGRNDataGridView_CellPainting;
            grnProductDataGridView.CellContentClick -= grnProductDataGridView_CellContentClick;
            grnProductDataGridView.CellPainting -= grnProductDataGridView_CellPainting;
            grnSaveBtn.Click -= grnSaveBtn_Click;
            grnCancelBtn.Click -= grnCancelBtn_Click;
            purReNoteText.TextChanged -= purReNoteText_TextChanged;

            // Subscribe to events
            this.Load += CreatePurchasesReturn_Load;
            grnProSearchText.TextChanged += grnProSearchText_TextChanged;
            preReGRNDataGridView.CellContentClick += preReGRNDataGridView_CellContentClick;
            preReGRNDataGridView.CellPainting += preReGRNDataGridView_CellPainting;
            grnProductDataGridView.CellContentClick += grnProductDataGridView_CellContentClick;
            grnProductDataGridView.CellPainting += grnProductDataGridView_CellPainting;
            grnSaveBtn.Click += grnSaveBtn_Click;
            grnCancelBtn.Click += grnCancelBtn_Click;
            purReNoteText.TextChanged += purReNoteText_TextChanged;
        }

        private void CreatePurchasesReturn_Load(object sender, EventArgs e)
        {
            ConfigurePreReGRNDataGridView();
            ConfigureGrnProductDataGridView();
            LoadGRNData();
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
                DefaultCellStyle = new DataGridViewCellStyle { Format = "D2" }
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
                        returnItemsTable.Columns.Add("return_quantity", typeof(int));

                        foreach (DataRow row in _grnItemsTable.Rows)
                        {
                            DataRow newRow = returnItemsTable.NewRow();
                            foreach (DataColumn col in _grnItemsTable.Columns)
                            {
                                newRow[col.ColumnName] = row[col.ColumnName];
                            }
                            newRow["return_quantity"] = 0;
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
                int returnQuantity = Convert.ToInt32(row.Cells["return_quantity"].Value);
                int originalQuantity = Convert.ToInt32(row.Cells["quantity"].Value);

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

            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string returnNo = "PR_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                            string grnNo = grnProductDataGridView.Rows[0].Cells["grn_no"].Value?.ToString();

                            if (string.IsNullOrEmpty(grnNo))
                            {
                                MessageBox.Show("Invalid GRN number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Use the stored note
                            string note = _returnNote;
                            if (string.IsNullOrEmpty(note)) note = null;

                            decimal totalAmount = 0m;
                            foreach (DataGridViewRow row in grnProductDataGridView.Rows)
                            {
                                if (row.Cells["net_price"].Value != null)
                                {
                                    totalAmount += Convert.ToDecimal(row.Cells["net_price"].Value);
                                }
                            }

                            string insertReturnQuery = @"
                                INSERT INTO purchase_returns (grn_no, return_no, note, total_amount, created_at)
                                VALUES (@grnNo, @returnNo, @note, @totalAmount, NOW());
                                SELECT LAST_INSERT_ID();
                            ";

                            long returnId;
                            using (MySqlCommand cmd = new MySqlCommand(insertReturnQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@grnNo", grnNo);
                                cmd.Parameters.AddWithValue("@returnNo", returnNo);
                                cmd.Parameters.AddWithValue("@note", note ?? (object)DBNull.Value);
                                cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                                returnId = Convert.ToInt64(cmd.ExecuteScalar());
                            }

                            string insertDetailsQuery = @"
                                INSERT INTO purchase_return_details 
                                (return_id, product_id, variation_type, unit, quantity, cost_price, net_price)
                                VALUES (@returnId, @productId, @variationType, @unit, @quantity, @costPrice, @netPrice)
                            ";

                            string checkStockQuery = @"
                            SELECT COALESCE(stock, 0) AS stockCoffee
                            FROM stock 
                            WHERE product_id = @productId 
                            AND (variation_type = @variationType OR (variation_type IS NULL AND @variationType IS NULL))
                            AND (unit = @unit OR (unit IS NULL AND @unit IS NULL))
                            LIMIT 1
                        ";

                            string updateStockQuery = @"
                        INSERT INTO stock (product_id, variation_type, stock, unit)
                        SELECT @productId, @variationType, -@quantity, @unit
                        WHERE NOT EXISTS (
                            SELECT 1 FROM stock 
                            WHERE product_id = @productId 
                            AND (variation_type = @variationType OR (variation_type IS NULL AND @variationType IS NULL))
                            AND (unit = @unit OR (unit IS NULL AND @unit IS NULL))
                        );
                        UPDATE stock 
                        SET stock = stock - @quantity 
                        WHERE product_id = @productId 
                        AND (variation_type = @variationType OR (variation_type IS NULL AND @variationType IS NULL))
                        AND (unit = @unit OR (unit IS NULL AND @unit IS NULL));
                    ";

                            // Track processed products to avoid duplicates
                            HashSet<string> processedProducts = new HashSet<string>();

                            foreach (DataGridViewRow row in grnProductDataGridView.Rows)
                            {
                                if (row.Cells["product_id"].Value == null ||
                                    row.Cells["return_quantity"].Value == null ||
                                    Convert.ToInt32(row.Cells["return_quantity"].Value) == 0)
                                {
                                    continue;
                                }

                                int productId = Convert.ToInt32(row.Cells["product_id"].Value);
                                string variationType = row.Cells["variation_type"].Value?.ToString();
                                if (string.IsNullOrEmpty(variationType) || variationType == "N/A")
                                    variationType = null;

                                string unit = row.Cells["unit"].Value?.ToString();
                                int returnQuantity = Convert.ToInt32(row.Cells["return_quantity"].Value);
                                decimal costPrice = Convert.ToDecimal(row.Cells["cost_price"].Value);
                                decimal netPrice = Convert.ToDecimal(row.Cells["net_price"].Value);

                                // Create a unique key for the product
                                string productKey = $"{productId}_{variationType ?? "null"}_{unit ?? "null"}";
                                if (processedProducts.Contains(productKey))
                                {
                                    System.Diagnostics.Debug.WriteLine($"Skipping duplicate product: {productKey}");
                                    continue;
                                }
                                processedProducts.Add(productKey);

                                // Check current stock
                                int currentStock = 0;
                                using (MySqlCommand cmd = new MySqlCommand(checkStockQuery, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@productId", productId);
                                    cmd.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                    cmd.Parameters.AddWithValue("@unit", unit ?? (object)DBNull.Value);
                                    var result = cmd.ExecuteScalar();
                                    currentStock = Convert.ToInt32(result);
                                }

                                // Validate stock
                                if (currentStock < returnQuantity)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show($"Cannot return {returnQuantity} units of Product ID {productId}. Only {currentStock} units available in stock.", "Insufficient Stock",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                // Insert purchase return details
                                using (MySqlCommand cmd = new MySqlCommand(insertDetailsQuery, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@returnId", returnId);
                                    cmd.Parameters.AddWithValue("@productId", productId);
                                    cmd.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                    cmd.Parameters.AddWithValue("@unit", unit ?? (object)DBNull.Value);
                                    cmd.Parameters.AddWithValue("@quantity", returnQuantity);
                                    cmd.Parameters.AddWithValue("@costPrice", costPrice);
                                    cmd.Parameters.AddWithValue("@netPrice", netPrice);
                                    cmd.ExecuteNonQuery();
                                }

                                // Update stock (reduce by return quantity)
                                using (MySqlCommand cmd = new MySqlCommand(updateStockQuery, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@productId", productId);
                                    cmd.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                    cmd.Parameters.AddWithValue("@quantity", returnQuantity);
                                    cmd.Parameters.AddWithValue("@unit", unit ?? (object)DBNull.Value);

                                    int rowsAffected = cmd.ExecuteNonQuery();
                                    System.Diagnostics.Debug.WriteLine($"Stock update for Product ID {productId}: Rows affected = {rowsAffected}, Reduced by {returnQuantity}");
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("Purchase return processed successfully.", "Success",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            grnCancelBtn_Click(sender, e);
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

        private void grnCancelBtn_Click(object sender, EventArgs e)
        {
            grnProSearchText.Text = "";
            purReNoteText.Text = "";
            _returnNote = string.Empty;
            _grnItemsTable.Clear();
            grnProductDataGridView.DataSource = null;
            LoadGRNData();
        }

        private void purReNoteText_TextChanged(object sender, EventArgs e)
        {
            _returnNote = purReNoteText.Text.Trim();
        }
    }
}