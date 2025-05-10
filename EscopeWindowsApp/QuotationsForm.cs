using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class Quotations : Form
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private DataTable _quotationsTable = new DataTable(); // Table to hold quotation data
        private int currentIndex = 0; // Current index for navigation

        public Quotations()
        {
            InitializeComponent();

            // Wire up events with the correct method names
            this.Load += Quotations_Load;
            quotaSearchText.TextChanged += quotaSearchText_TextChanged;
            createQuotaBtn.Click += createQuotaBtn_Click;
            quotaFirstBtn.Click += quotaFirstBtn_Click;
            quotaPrevBtn.Click += quotaPrevBtn_Click;
            quotaNextBtn.Click += quotaNextBtn_Click;
            quotaLastBtn.Click += quotaLastBtn_Click;
            quotaDataGridView.CellContentClick += quotaDataGridView_CellContentClick;
            quotaDataGridView.CellFormatting += quotaDataGridView_CellFormatting; // Add CellFormatting event
        }

        private void Quotations_Load(object sender, EventArgs e)
        {
            // Configure the DataGridView columns
            quotaDataGridView.AutoGenerateColumns = false;
            quotaDataGridView.ReadOnly = true;
            quotaDataGridView.AllowUserToAddRows = false;
            quotaDataGridView.Columns.Clear();

            quotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "quotation_no",
                DataPropertyName = "quotation_no",
                HeaderText = "QUATATION NO",
                Width = 150
            });
            quotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "customer_name",
                DataPropertyName = "customer_name",
                HeaderText = "CUSTOMER",
                Width = 150
            });
            quotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "quotation_date",
                DataPropertyName = "quotation_date",
                HeaderText = "DATE",
                DefaultCellStyle = { Format = "yyyy-MM-dd" },
                Width = 100
            });
            quotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "quantity_of_items",
                DataPropertyName = "quantity_of_items",
                HeaderText = "QUANTITY",
                Width = 80
            });
            quotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "subtotal",
                DataPropertyName = "subtotal",
                HeaderText = "SUB TOTAL",
                DefaultCellStyle = { Format = "N2" },
                Width = 100
            });
            quotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "discount_amount",
                DataPropertyName = "discount_amount",
                HeaderText = "DISCOUNT",
                DefaultCellStyle = { Format = "N2" },
                Width = 120
            });
            quotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "shipping_charge",
                DataPropertyName = "shipping_charge",
                HeaderText = "SHIPPING COST",
                DefaultCellStyle = { Format = "N2" },
                Width = 120
            });
            quotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "total_amount",
                DataPropertyName = "total_amount",
                HeaderText = "TOTAL",
                DefaultCellStyle = { Format = "N2" },
                Width = 100
            });
            quotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "shipping_address",
                DataPropertyName = "shipping_address",
                HeaderText = "ADDRESS",
                Width = 150
            });
            quotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "notes",
                DataPropertyName = "notes",
                HeaderText = "NOTE",
                Width = 200
            });

            // Load all quotations initially
            LoadQuotationsData();
        }

        private void LoadQuotationsData()
        {
            try
            {
                // Validate controls
                if (quotaDataGridView == null || quotaSearchText == null)
                {
                    MessageBox.Show(
                        "One or more controls are not properly initialized. Check your designer names.",
                        "Initialization Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                // Build the query to fetch quotations
                string query = @"
                    SELECT 
                        quotation_no,
                        customer_name,
                        quotation_date,
                        quantity_of_items,
                        subtotal,
                        discount_amount,
                        shipping_charge,
                        total_amount,
                        shipping_address,
                        notes
                    FROM quotations
                    WHERE 1=1
                ";

                string searchText = quotaSearchText.Text.Trim();
                if (!string.IsNullOrEmpty(searchText))
                {
                    // Search by both quotation_no and customer_name
                    query += " AND (quotation_no LIKE @searchText OR customer_name LIKE @searchText)";
                }

                using (var conn = new MySqlConnection(_connectionString))
                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        cmd.Parameters.AddWithValue("@searchText", $"%{searchText}%");
                    }

                    var adapter = new MySqlDataAdapter(cmd);
                    _quotationsTable.Clear();
                    adapter.Fill(_quotationsTable);
                    quotaDataGridView.DataSource = _quotationsTable;

                    // Reset the current index after loading data
                    if (_quotationsTable.Rows.Count > 0)
                    {
                        currentIndex = 0;
                        quotaDataGridView.CurrentCell = quotaDataGridView.Rows[currentIndex].Cells[0];
                    }
                    else
                    {
                        currentIndex = -1; // No rows available
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading quotations: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quotaDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Handle shipping_address column
            if (quotaDataGridView.Columns[e.ColumnIndex].Name == "shipping_address")
            {
                if (e.Value == null || e.Value == DBNull.Value || string.IsNullOrWhiteSpace(e.Value.ToString()))
                {
                    e.Value = "N/A";
                    e.FormattingApplied = true;
                }
            }

            // Handle notes column
            if (quotaDataGridView.Columns[e.ColumnIndex].Name == "notes")
            {
                if (e.Value == null || e.Value == DBNull.Value || string.IsNullOrWhiteSpace(e.Value.ToString()))
                {
                    e.Value = "N/A";
                    e.FormattingApplied = true;
                }
            }
        }

        private void createQuotaBtn_Click(object sender, EventArgs e)
        {
            // Open the AddQuotationForm if not already open
            foreach (Form form in Application.OpenForms)
            {
                if (form is AddQuotationForm)
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
            AddQuotationForm addQuotation = new AddQuotationForm();
            addQuotation.FormClosed += (s, args) => LoadQuotationsData(); // Refresh data after adding a new quotation
            addQuotation.Show();
        }

        private void quotaSearchText_TextChanged(object sender, EventArgs e)
        {
            // Refresh the DataGridView when the search text changes
            LoadQuotationsData();
        }

        private void quotaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This is the datagridview for the quotations
            // columns are: quotation number, customer name, date, quantity, sub total, discount amount, shipping charge, total amount, shipping address, note
        }

        private void quotaBtnPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quotaFirstBtn_Click(object sender, EventArgs e)
        {
            // Navigate to first quota
            if (quotaDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                quotaDataGridView.CurrentCell = quotaDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void quotaPrevBtn_Click(object sender, EventArgs e)
        {
            // Navigate to previous quota
            if (currentIndex > 0)
            {
                currentIndex--;
                quotaDataGridView.CurrentCell = quotaDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void quotaNextBtn_Click(object sender, EventArgs e)
        {
            // Navigate to next quota
            if (currentIndex < quotaDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                quotaDataGridView.CurrentCell = quotaDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void quotaLastBtn_Click(object sender, EventArgs e)
        {
            // Navigate to last quota
            if (quotaDataGridView.Rows.Count > 0)
            {
                currentIndex = quotaDataGridView.Rows.Count - 1;
                quotaDataGridView.CurrentCell = quotaDataGridView.Rows[currentIndex].Cells[0];
            }
        }
    }
}