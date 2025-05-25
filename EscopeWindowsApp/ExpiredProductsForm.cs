using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace EscopeWindowsApp
{
    public partial class ExpiredProductsForm : Form
    {
        private readonly StockManager _stockManager;
        private readonly string _connectionString;
        private int currentPage = 1;
        private const int PageSize = 10;
        private int totalRecords = 0;

        public ExpiredProductsForm()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
            _stockManager = new StockManager(_connectionString);
        }

        private void ExpiredProductsForm_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadExpiredProducts();
        }

        private void supplierSearchText_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadExpiredProducts(supplierSearchText.Text);
        }

        private void expiredRefreshBtn_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadExpiredProducts(supplierSearchText.Text);
        }

        private void expiredProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == expiredProductsDataGridView.Columns["addButtonColumn"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = expiredProductsDataGridView.Rows[e.RowIndex];
                string grnNo = row.Cells["grn_no"].Value.ToString();
                int productId = Convert.ToInt32(row.Cells["product_id_raw"].Value);
                decimal expiredQuantity = Convert.ToDecimal(row.Cells["expired_quantity"].Value);
                string variationType = row.Cells["variation_type"].Value?.ToString() ?? "N/A";
                string unit = row.Cells["unit"].Value?.ToString() ?? "N/A";

                try
                {
                    _stockManager.UpdateStock(productId, variationType, expiredQuantity, unit, false);
                    LoadExpiredProducts(supplierSearchText.Text);
                    MessageBox.Show($"Removed {expiredQuantity} expired units from stock for GRN: {grnNo}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadExpiredProducts(string searchText = "")
        {
            string query = @"
                SELECT 
                    grn.grn_no,
                    grn_items.product_id AS product_id_raw,
                    CONCAT('PRO', LPAD(grn_items.product_id, 3, '0')) AS product_id,
                    products.name AS product_name,
                    suppliers.name AS supplier_name,
                    grn_items.quantity AS expired_quantity,
                    DATE(grn.date) AS grn_created_date,
                    grn_items.expiry_date,
                    grn_items.variation_type,
                    grn_items.unit
                FROM 
                    grn_items
                JOIN 
                    grn ON grn_items.grn_id = grn.id
                JOIN 
                    products ON grn_items.product_id = products.id
                JOIN 
                    suppliers ON products.supplier_id = suppliers.id
                LEFT JOIN 
                    stock s ON grn_items.product_id = s.product_id 
                    AND (grn_items.variation_type = s.variation_type OR (grn_items.variation_type IS NULL AND s.variation_type IS NULL))
                    AND (grn_items.unit = s.unit OR (grn_items.unit IS NULL AND s.unit IS NULL))
                WHERE 
                    grn_items.expiry_date <= CURDATE()
                    AND grn_items.expiry_date IS NOT NULL";

            if (!string.IsNullOrEmpty(searchText))
            {
                query += " AND (suppliers.name LIKE @searchText OR grn.grn_no LIKE @searchText)";
            }

            // Add pagination
            query += " ORDER BY grn_items.expiry_date ASC LIMIT @Offset, @PageSize";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    // Count total records for pagination
                    string countQuery = @"
                        SELECT COUNT(*) 
                        FROM grn_items
                        JOIN grn ON grn_items.grn_id = grn.id
                        JOIN products ON grn_items.product_id = products.id
                        JOIN suppliers ON products.supplier_id = suppliers.id
                        WHERE grn_items.expiry_date <= CURDATE()
                        AND grn_items.expiry_date IS NOT NULL";
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        countQuery += " AND (suppliers.name LIKE @searchText OR grn.grn_no LIKE @searchText)";
                    }
                    using (MySqlCommand countCmd = new MySqlCommand(countQuery, conn))
                    {
                        if (!string.IsNullOrEmpty(searchText))
                        {
                            countCmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        }
                        totalRecords = Convert.ToInt32(countCmd.ExecuteScalar());
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchText))
                        {
                            cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        }
                        cmd.Parameters.AddWithValue("@Offset", (currentPage - 1) * PageSize);
                        cmd.Parameters.AddWithValue("@PageSize", PageSize);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            expiredProductsDataGridView.DataSource = dt;
                        }
                    }
                }
                UpdatePaginationUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading expired products: {ex.Message}");
            }
        }

        private void ConfigureDataGridView()
        {
            expiredProductsDataGridView.AutoGenerateColumns = false;
            expiredProductsDataGridView.Columns.Clear();

            expiredProductsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "grn_no",
                Name = "grn_no",
                HeaderText = "GRN No",
                ReadOnly = true
            });
            expiredProductsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "product_id",
                Name = "product_id",
                HeaderText = "Product ID",
                ReadOnly = true
            });
            expiredProductsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "product_id_raw",
                Name = "product_id_raw",
                HeaderText = "Raw Product ID",
                ReadOnly = true,
                Visible = false
            });
            expiredProductsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "product_name",
                Name = "product_name",
                HeaderText = "Product Name",
                ReadOnly = true
            });
            expiredProductsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "supplier_name",
                Name = "supplier_name",
                HeaderText = "Supplier Name",
                ReadOnly = true
            });
            expiredProductsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "expired_quantity",
                Name = "expired_quantity",
                HeaderText = "Expired Quantity",
                ReadOnly = true
            });
            expiredProductsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "grn_created_date",
                Name = "grn_created_date",
                HeaderText = "GRN Created Date",
                ReadOnly = true
            });
            expiredProductsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "expiry_date",
                Name = "expiry_date",
                HeaderText = "Expiry Date",
                ReadOnly = true
            });
            expiredProductsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "variation_type",
                Name = "variation_type",
                HeaderText = "Variation Type",
                ReadOnly = true,
                Visible = false
            });
            expiredProductsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "unit",
                Name = "unit",
                HeaderText = "Unit",
                ReadOnly = true,
                Visible = false
            });

            if (expiredProductsDataGridView.Columns["addButtonColumn"] == null)
            {
                DataGridViewButtonColumn addButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "addButtonColumn",
                    HeaderText = "Action",
                    Text = "Add",
                    UseColumnTextForButtonValue = true,
                    Width = 50
                };
                expiredProductsDataGridView.Columns.Add(addButtonColumn);
            }
        }

        private void UpdatePaginationUI()
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / PageSize);
            exFirstBtn.Enabled = currentPage > 1;
            exPrevBtn.Enabled = currentPage > 1;
            exNextBtn.Enabled = currentPage < totalPages;
            exLastBtn.Enabled = currentPage < totalPages;
            // Optionally update a label or status bar with page info if available
        }

        private void exFirstBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage = 1;
                LoadExpiredProducts(supplierSearchText.Text);
            }
        }

        private void exPrevBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadExpiredProducts(supplierSearchText.Text);
            }
        }

        private void exNextBtn_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / PageSize);
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadExpiredProducts(supplierSearchText.Text);
            }
        }

        private void exLastBtn_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / PageSize);
            if (currentPage < totalPages)
            {
                currentPage = totalPages;
                LoadExpiredProducts(supplierSearchText.Text);
            }
        }
    }
}