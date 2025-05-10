using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class SaleReturnForm : Form
    {
        private DataTable refundsTable;
        private BindingSource bindingSource;
        private int currentIndex = 0;
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;

        public SaleReturnForm()
        {
            InitializeComponent();
            CustomizeDateTimePicker(); // Customize SiticoneDateTimePicker
            bindingSource = new BindingSource();
            LoadSaleReturnsData();
            // Explicitly wire all events
            saleReDataGridView.CellFormatting += SaleReDataGridView_CellFormatting;
            saleReDataGridView.CellContentClick += SaleReDataGridView_CellContentClick;
        }

        private void CustomizeDateTimePicker()
        {
            // Set fill color to White for SiticoneDateTimePicker using System.Drawing.Color
            selectSaleReDateTime.FillColor = System.Drawing.Color.White;
            selectSaleReDateTime.HoverState.FillColor = System.Drawing.Color.White; // Maintain white on hover
            selectSaleReDateTime.BorderColor = System.Drawing.Color.Gray; // Subtle border
        }

        private void SaleReturnForm_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            saleReDataGridView.DataSource = bindingSource;
        }

        private void ConfigureDataGridView()
        {
            saleReDataGridView.AutoGenerateColumns = false;
            saleReDataGridView.Columns.Clear();

            saleReDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "bill_no",
                Name = "bill_no",
                HeaderText = "BILL NO",
            });

            saleReDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "product_name",
                Name = "product_name",
                HeaderText = "PRODUCT NAME",
                Width = 150
            });

            saleReDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "variation_type",
                Name = "variation_type",
                HeaderText = "VARIATION TYPE",
                Width = 100
            });

            saleReDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "unit",
                Name = "unit",
                HeaderText = "UNIT",
                Width = 80
            });

            saleReDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "quantity",
                Name = "quantity",
                HeaderText = "QUANTITY",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            saleReDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "price",
                Name = "price",
                HeaderText = "PRICE",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            saleReDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "total_price",
                Name = "total_price",
                HeaderText = "TOTAL",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            saleReDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "refund_date",
                Name = "refund_date",
                HeaderText = "REFUND DATE",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" }
            });

            saleReDataGridView.AllowUserToAddRows = false;
            saleReDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            saleReDataGridView.MultiSelect = false;

            // Set text color to black for all cells
            saleReDataGridView.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void LoadSaleReturnsData()
        {
            try
            {
                refundsTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            bill_no,
                            product_name,
                            COALESCE(variation_type, 'N/A') AS variation_type,
                            unit,
                            quantity,
                            price,
                            total_price,
                            refund_date
                        FROM refunds
                        ORDER BY refund_date DESC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(refundsTable);
                    }
                }

                // Replace DBNull with default values
                foreach (DataRow row in refundsTable.Rows)
                {
                    for (int i = 0; i < refundsTable.Columns.Count; i++)
                    {
                        if (row.IsNull(i))
                        {
                            if (refundsTable.Columns[i].DataType == typeof(string))
                            {
                                row[i] = "N/A";
                            }
                            else if (refundsTable.Columns[i].DataType == typeof(decimal))
                            {
                                row[i] = 0m;
                            }
                            else if (refundsTable.Columns[i].DataType == typeof(DateTime))
                            {
                                row[i] = DateTime.MinValue;
                            }
                        }
                    }
                }

                bindingSource.DataSource = refundsTable;

                // Select the first row if available
                if (saleReDataGridView.Rows.Count > 0)
                {
                    currentIndex = 0;
                    saleReDataGridView.CurrentCell = saleReDataGridView.Rows[currentIndex].Cells[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales returns: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                refundsTable = new DataTable();
                refundsTable.Columns.Add("bill_no", typeof(string));
                refundsTable.Columns.Add("product_name", typeof(string));
                refundsTable.Columns.Add("variation_type", typeof(string));
                refundsTable.Columns.Add("unit", typeof(string));
                refundsTable.Columns.Add("quantity", typeof(decimal));
                refundsTable.Columns.Add("price", typeof(decimal));
                refundsTable.Columns.Add("total_price", typeof(decimal));
                refundsTable.Columns.Add("refund_date", typeof(DateTime));
                bindingSource.DataSource = refundsTable;
            }
        }

        private void saleReSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = saleReSearchText.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(searchText))
                {
                    bindingSource.Filter = $"bill_no LIKE '%{searchText}%'";
                }
                else
                {
                    bindingSource.Filter = null;
                }

                // Reset current index after filtering
                if (saleReDataGridView.Rows.Count > 0)
                {
                    currentIndex = 0;
                    saleReDataGridView.CurrentCell = saleReDataGridView.Rows[currentIndex].Cells[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying search filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bindingSource.Filter = null;
            }
        }

        private void saleReFilterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = selectSaleReDateTime.Value.Date;
                bindingSource.Filter = $"refund_date >= #{selectedDate:yyyy-MM-dd}# AND refund_date < #{selectedDate.AddDays(1):yyyy-MM-dd}#";

                // Reset current index after filtering
                if (saleReDataGridView.Rows.Count > 0)
                {
                    currentIndex = 0;
                    saleReDataGridView.CurrentCell = saleReDataGridView.Rows[currentIndex].Cells[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying date filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bindingSource.Filter = null;
            }
        }

        private void saleReturnRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadSaleReturnsData();
            saleReSearchText.Text = string.Empty;
            selectSaleReDateTime.Value = DateTime.Now;
            bindingSource.Filter = null; // Clear any existing filter

            // Reset current index after refreshing
            if (saleReDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                saleReDataGridView.CurrentCell = saleReDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void SaleReDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (saleReDataGridView.Columns[e.ColumnIndex].Name == "quantity")
            {
                if (e.Value != null)
                {
                    string unit = saleReDataGridView.Rows[e.RowIndex].Cells["unit"].Value?.ToString();
                    if (unit == "Pieces")
                    {
                        e.Value = Convert.ToDecimal(e.Value).ToString("F0");
                    }
                    else
                    {
                        e.Value = Convert.ToDecimal(e.Value).ToString("F2");
                    }
                    e.FormattingApplied = true;
                }
            }
            else if (saleReDataGridView.Columns[e.ColumnIndex].Name != "refund_date")
            {
                if (e.Value == DBNull.Value || e.Value == null)
                {
                    e.Value = "N/A";
                    e.FormattingApplied = true;
                }
            }
        }

        private void SaleReDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // No action required as per current requirements; columns are display-only
        }

        private void saleReFirstBtn_Click(object sender, EventArgs e)
        {
            if (saleReDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                saleReDataGridView.CurrentCell = saleReDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void saleRePrevBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                saleReDataGridView.CurrentCell = saleReDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void saleReNextBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex < saleReDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                saleReDataGridView.CurrentCell = saleReDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void saleReDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // this is the sales returns data from refunds table.
            // cloumns are : billno, product name, variation type, unit, quantity, price, total price, refund date(date only)
        }

        private void saleReLastBtn_Click(object sender, EventArgs e)
        {
            if (saleReDataGridView.Rows.Count > 0)
            {
                currentIndex = saleReDataGridView.Rows.Count - 1;
                saleReDataGridView.CurrentCell = saleReDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void saleReDataComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Placeholder for pagination logic if needed (e.g., items per page)
        }

        private void selectSaleReDateTime_ValueChanged(object sender, EventArgs e)
        {
            // No action needed; filtering is handled by saleReFilterBtn_Click
        }
    }
}