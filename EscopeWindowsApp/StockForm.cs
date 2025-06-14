using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Configuration;

namespace EscopeWindowsApp
{
    public partial class StockForm : Form
    {
        private DataTable stockTable;
        private BindingSource bindingSource;
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;

        public StockForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            LoadStockData();
            ProStockDataGridView.CellFormatting += ProStockDataGridView_CellFormatting;
        }

        private void ConfigureDataGridView()
        {
            ProStockDataGridView.AutoGenerateColumns = false;
            ProStockDataGridView.Columns.Clear();

            ProStockDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "product_name",
                Name = "product_name",
                HeaderText = "PRODUCT NAME",
                Width = 200
            });

            ProStockDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "variation_type",
                Name = "variation_type",
                HeaderText = "VARIATION",
                Width = 100
            });

            ProStockDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "unit_name",
                Name = "unit_name",
                HeaderText = "UNIT",
                Width = 80
            });

            ProStockDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "available_stock",
                Name = "available_stock",
                HeaderText = "AVAILABLE STOCK",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            ProStockDataGridView.AllowUserToAddRows = false;
            ProStockDataGridView.ReadOnly = true;
            ProStockDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadStockData()
        {
            try
            {
                stockTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            p.name as product_name,
                            COALESCE(s.variation_type, 'N/A') as variation_type,
                            COALESCE(u.unit_name, s.unit, 'N/A') as unit_name,
                            COALESCE(s.stock, 0) as available_stock
                        FROM products p
                        LEFT JOIN stock s ON p.id = s.product_id
                        LEFT JOIN units u ON p.unit_id = u.id
                        WHERE s.stock IS NOT NULL AND s.stock > 0
                        ORDER BY p.name, s.variation_type";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(stockTable);
                    }
                }

                // Handle null values
                foreach (DataRow row in stockTable.Rows)
                {
                    for (int i = 0; i < stockTable.Columns.Count; i++)
                    {
                        if (row.IsNull(i))
                        {
                            if (stockTable.Columns[i].DataType == typeof(string))
                                row[i] = "N/A";
                            else if (stockTable.Columns[i].DataType == typeof(decimal))
                                row[i] = 0.00m;
                        }
                    }
                }

                bindingSource.DataSource = stockTable;
                ProStockDataGridView.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stock data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stockTable = new DataTable();
                stockTable.Columns.Add("product_name", typeof(string));
                stockTable.Columns.Add("variation_type", typeof(string));
                stockTable.Columns.Add("unit_name", typeof(string));
                stockTable.Columns.Add("available_stock", typeof(decimal));
                bindingSource.DataSource = stockTable;
            }
        }

        private void ProStockDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Handle null values
            if (e.Value == DBNull.Value || e.Value == null)
            {
                e.Value = "N/A";
                e.FormattingApplied = true;
            }

            // Highlight low stock
            if (ProStockDataGridView.Columns[e.ColumnIndex].Name == "available_stock")
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    decimal stockValue = Convert.ToDecimal(e.Value);
                    if (stockValue < 20) // Low stock threshold
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.Black;
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);

                    }
                    else if (stockValue < 50) // Medium stock
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                        e.CellStyle.ForeColor = Color.Black;
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);

                    }
                    else // Good stock
                    {
                        e.CellStyle.BackColor = Color.LimeGreen;
                        e.CellStyle.ForeColor = Color.Black;
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }
                }
            }
        }

        private void ProStockSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = ProStockSearchText.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(searchText))
                {
                    bindingSource.Filter = $"product_name LIKE '%{searchText}%' OR " +
                                           $"variation_type LIKE '%{searchText}%' OR " +
                                           $"unit_name LIKE '%{searchText}%'";
                }
                else
                {
                    bindingSource.Filter = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying search filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bindingSource.Filter = null;
            }
        }

        private void ProStockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // If you want to handle cell clicks for viewing stock details
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProStockDataGridView.Rows[e.RowIndex];
                // Note: product_id is not available in the current dataset
                // If needed, add product_id to the SQL query and access it here
                // Example: int productId = Convert.ToInt32(row.Cells["product_id"].Value);
                // string variationType = row.Cells["variation_type"].Value.ToString();
                // ShowStockDetails(productId, variationType);
            }
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadStockData();
            ProStockDataGridView.DataSource = bindingSource;

            // Add refresh button if you have one
            // refreshBtn.Click += (s, args) => LoadStockData();
        }
    }
}