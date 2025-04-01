using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace EscopeWindowsApp
{
    public partial class Production : Form
    {
        private DataTable productsTable;
        private BindingSource bindingSource;
        private int currentIndex = 0;
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";

        public Production()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            LoadProductsData();
            // Wire up events
            ProductDataGridView.CellPainting += ProductDataGridView_CellPainting;
            ProductDataGridView.CellFormatting += ProductDataGridView_CellFormatting;
            ProductDataGridView.CellContentClick += ProductDataGridView_CellContentClick;
        }

        //private void Production_Load(object sender, EventArgs e)
        //{
            
        //}

        private void ConfigureDataGridView()
        {
            ProductDataGridView.AutoGenerateColumns = false;
            ProductDataGridView.Columns.Clear();

            // Add columns as specified
            ProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                Name = "id",
                HeaderText = "PRODUCT ID"
            });
            ProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "product_name",
                Name = "product_name",
                HeaderText = "PRODUCT NAME"
            });
            ProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "category_name",
                Name = "category_name",
                HeaderText = "CATEGORY"
            });
            ProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "unit_name",
                Name = "unit_name",
                HeaderText = "UNIT"
            });
            ProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "brand_name",
                Name = "brand_name",
                HeaderText = "BRAND"
            });
            ProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "variation_name",
                Name = "variation_name",
                HeaderText = "VARIATION"
            });
            ProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "variation_type",
                Name = "variation_type",
                HeaderText = "VARIATION TYPE"
            });
            ProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "retail_price",
                Name = "retail_price",
                HeaderText = "RETAIL PRICE",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });
            ProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "wholesale_price",
                Name = "wholesale_price",
                HeaderText = "WHOLESALE PRICE",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });
            ProductDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "stock",
                Name = "stock",
                HeaderText = "STOCK"
            });

            // Add action buttons
            ProductDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "EditColumn",
                HeaderText = "EDIT",
                Width = 50,
                ToolTipText = "Edit this product"
            });

            ProductDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "DELETE",
                Width = 50,
                ToolTipText = "Delete this product"
            });

            // Prevent the empty row at the end
            ProductDataGridView.AllowUserToAddRows = false;
        }

        private void ProductDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Format product ID
            if (ProductDataGridView.Columns[e.ColumnIndex].Name == "id")
            {
                if (e.Value != null)
                {
                    int productId = Convert.ToInt32(e.Value);
                    e.Value = $"pro{productId:D3}";
                    e.FormattingApplied = true;
                }
            }

            // Handle null values
            if (e.Value == DBNull.Value || e.Value == null)
            {
                e.Value = "N/A";
                e.FormattingApplied = true;
            }
        }

        private void ProductDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    if (ProductDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
                    {
                        e.PaintBackground(e.CellBounds, true);
                        Image editIcon = Properties.Resources.edit ?? SystemIcons.Question.ToBitmap();
                        int iconSize = (int)(Math.Min(e.CellBounds.Width, e.CellBounds.Height) * 0.7);
                        if (iconSize <= 0) iconSize = 16;
                        int x = e.CellBounds.X + (e.CellBounds.Width - iconSize) / 2;
                        int y = e.CellBounds.Y + (e.CellBounds.Height - iconSize) / 2;
                        e.Graphics.DrawImage(editIcon, x, y, iconSize, iconSize);
                        e.Handled = true;
                    }

                    if (ProductDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
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
                catch (Exception ex)
                {
                    MessageBox.Show($"Error rendering icons: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadProductsData()
        {
            try
            {
                productsTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            p.id,
                            p.name AS product_name,
                            c.name AS category_name,
                            u.unit_name,
                            b.name AS brand_name,
                            v.name AS variation_name,
                            pr.variation_type,
                            pr.retail_price,
                            pr.wholesale_price,
                            COALESCE(s.stock, 0) AS stock
                        FROM products p
                        LEFT JOIN categories c ON p.category_id = c.id
                        LEFT JOIN units u ON p.unit_id = u.id
                        LEFT JOIN brands b ON p.brand_id = b.id
                        LEFT JOIN variations v ON p.variation_type_id = v.id
                        LEFT JOIN pricing pr ON p.id = pr.product_id
                        LEFT JOIN stock s ON p.id = s.product_id AND 
                            (pr.variation_type IS NULL OR pr.variation_type = s.variation_type)
                        ORDER BY p.id, pr.variation_type";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(productsTable);
                    }
                }

                // Replace DBNull with default values
                foreach (DataRow row in productsTable.Rows)
                {
                    for (int i = 0; i < productsTable.Columns.Count; i++)
                    {
                        if (row.IsNull(i))
                        {
                            if (productsTable.Columns[i].DataType == typeof(string))
                            {
                                row[i] = "N/A";
                            }
                            else if (productsTable.Columns[i].DataType == typeof(decimal))
                            {
                                row[i] = 0.00m;
                            }
                            else if (productsTable.Columns[i].DataType == typeof(int))
                            {
                                row[i] = 0;
                            }
                        }
                    }
                }

                bindingSource.DataSource = productsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Create empty table structure
                productsTable = new DataTable();
                productsTable.Columns.Add("id", typeof(int));
                productsTable.Columns.Add("product_name", typeof(string));
                productsTable.Columns.Add("category_name", typeof(string));
                productsTable.Columns.Add("unit_name", typeof(string));
                productsTable.Columns.Add("brand_name", typeof(string));
                productsTable.Columns.Add("variation_name", typeof(string));
                productsTable.Columns.Add("variation_type", typeof(string));
                productsTable.Columns.Add("retail_price", typeof(decimal));
                productsTable.Columns.Add("wholesale_price", typeof(decimal));
                productsTable.Columns.Add("stock", typeof(int));
                bindingSource.DataSource = productsTable;
            }
        }

        private void productionSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = productionSearchText.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(searchText))
                {
                    bindingSource.Filter = $"product_name LIKE '%{searchText}%' OR " +
                                           $"category_name LIKE '%{searchText}%' OR " +
                                           $"brand_name LIKE '%{searchText}%' OR " +
                                           $"variation_name LIKE '%{searchText}%' OR " +
                                           $"variation_type LIKE '%{searchText}%'";
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

        private void proRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadProductsData();
            productionSearchText.Text = string.Empty;
            bindingSource.Filter = null;
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProductDataGridView.Rows[e.RowIndex];
                string columnName = ProductDataGridView.Columns[e.ColumnIndex].Name;

                if (columnName == "EditColumn")
                {
                    try
                    {
                        int productId = Convert.ToInt32(row.Cells["id"].Value);
                        string productName = row.Cells["product_name"].Value.ToString();
                        string category = row.Cells["category_name"].Value.ToString();

                        // Open edit form
                        CreateProduct editForm = new CreateProduct(
                            productId: productId,
                            name: productName,
                            category: category
                        // Add other parameters as needed from your CreateProduct form
                        );
                        editForm.FormClosed += (s, args) => LoadProductsData();
                        editForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening edit form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (columnName == "DeleteColumn")
                {
                    int productId = Convert.ToInt32(row.Cells["id"].Value);
                    string formattedId = $"pro{productId:D3}";

                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete product {formattedId}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                connection.Open();
                                // First delete related records in pricing and stock
                                string deletePricingQuery = "DELETE FROM pricing WHERE product_id = @productId";
                                string deleteStockQuery = "DELETE FROM stock WHERE product_id = @productId";
                                string deleteProductQuery = "DELETE FROM products WHERE id = @productId";

                                using (MySqlTransaction transaction = connection.BeginTransaction())
                                {
                                    try
                                    {
                                        // Delete pricing
                                        using (MySqlCommand cmd = new MySqlCommand(deletePricingQuery, connection, transaction))
                                        {
                                            cmd.Parameters.AddWithValue("@productId", productId);
                                            cmd.ExecuteNonQuery();
                                        }

                                        // Delete stock
                                        using (MySqlCommand cmd = new MySqlCommand(deleteStockQuery, connection, transaction))
                                        {
                                            cmd.Parameters.AddWithValue("@productId", productId);
                                            cmd.ExecuteNonQuery();
                                        }

                                        // Delete product
                                        using (MySqlCommand cmd = new MySqlCommand(deleteProductQuery, connection, transaction))
                                        {
                                            cmd.Parameters.AddWithValue("@productId", productId);
                                            cmd.ExecuteNonQuery();
                                        }

                                        transaction.Commit();
                                        LoadProductsData();
                                        MessageBox.Show($"Product {formattedId} deleted successfully.", "Success",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    catch
                                    {
                                        transaction.Rollback();
                                        throw;
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting product: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void productFirstBtn_Click(object sender, EventArgs e)
        {
            if (ProductDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                ProductDataGridView.CurrentCell = ProductDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void productPrevBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                ProductDataGridView.CurrentCell = ProductDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void productNextBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex < ProductDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                ProductDataGridView.CurrentCell = ProductDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void productLastBtn_Click(object sender, EventArgs e)
        {
            if (ProductDataGridView.Rows.Count > 0)
            {
                currentIndex = ProductDataGridView.Rows.Count - 1;
                ProductDataGridView.CurrentCell = ProductDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void createProductBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is CreateProduct)
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
            CreateProduct createProduct = new CreateProduct();
            createProduct.FormClosed += (s, args) => LoadProductsData();
            createProduct.Show();
        }

        private void grn_Btn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is GRNForm)
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
            GRNForm gRNForm = new GRNForm();
            gRNForm.Show();
        }

        private void adjPageCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Pagination logic can be implemented here if needed
        }
        private void Production_Load_1(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            ProductDataGridView.DataSource = bindingSource;
        }
    }
}