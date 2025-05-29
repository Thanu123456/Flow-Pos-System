using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace EscopeWindowsApp
{
    public partial class ExpiredProductsForm : Form
    {
        private readonly string _connectionString;
        private int currentPage = 1;
        private const int PageSize = 10;
        private int totalRecords = 0;

        public ExpiredProductsForm()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
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
                int stockDetailsId = Convert.ToInt32(row.Cells["stock_details_id"].Value);
                int productId = Convert.ToInt32(row.Cells["product_id_raw"].Value);
                string variationType = row.Cells["variation_type"].Value?.ToString() ?? "N/A";
                if (variationType == "N/A") variationType = null;
                string unit = row.Cells["unit"].Value?.ToString() ?? "N/A";
                if (unit == "N/A") unit = null;
                decimal expiredQuantity = Convert.ToDecimal(row.Cells["expired_quantity"].Value);
                string grnNo = row.Cells["grn_no"].Value.ToString();
                string productName = row.Cells["product_name"].Value.ToString();
                string supplierName = row.Cells["supplier_name"].Value.ToString();

                try
                {
                    CreatePurchasesReturn returnForm = new CreatePurchasesReturn(_connectionString, stockDetailsId, productId, productName, supplierName, expiredQuantity, variationType, unit, grnNo);
                    returnForm.ShowDialog();
                    LoadExpiredProducts(supplierSearchText.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening return form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    sd.id AS stock_details_id,
                    gi.product_id AS product_id_raw,
                    CONCAT('PRO', LPAD(gi.product_id, 3, '0')) AS product_id,
                    products.name AS product_name,
                    suppliers.name AS supplier_name,
                    sd.remaining_qty AS expired_quantity,
                    DATE(grn.date) AS grn_created_date,
                    gi.expiry_date,
                    gi.variation_type,
                    gi.unit
                FROM 
                    stock_details sd
                JOIN 
                    grn_items gi ON sd.grn_items_id = gi.id
                JOIN 
                    grn ON gi.grn_id = grn.id
                JOIN 
                    products ON gi.product_id = products.id
                JOIN 
                    suppliers ON products.supplier_id = suppliers.id
                WHERE 
                    sd.is_expired = 1
                    AND sd.remaining_qty > 0";

            if (!string.IsNullOrEmpty(searchText))
            {
                query += " AND (suppliers.name LIKE @searchText OR grn.grn_no LIKE @searchText)";
            }

            query += " ORDER BY gi.expiry_date ASC LIMIT @Offset, @PageSize";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string countQuery = @"
                        SELECT COUNT(*) 
                        FROM stock_details sd
                        JOIN grn_items gi ON sd.grn_items_id = gi.id
                        JOIN grn ON gi.grn_id = grn.id
                        JOIN products ON gi.product_id = products.id
                        JOIN suppliers ON products.supplier_id = suppliers.id
                        WHERE sd.is_expired = 1
                        AND sd.remaining_qty > 0";
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
                MessageBox.Show($"Error loading expired products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DataPropertyName = "stock_details_id",
                Name = "stock_details_id",
                HeaderText = "Stock Details ID",
                ReadOnly = true,
                Visible = false
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
                    Text = "Return",
                    UseColumnTextForButtonValue = true,
                    Width = 50
                };
                expiredProductsDataGridView.Columns.Add(addButtonColumn);
            }
        }

        private void UpdatePaginationUI()
        {
            
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