using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class InventoryForm : Form
    {
        private DataGridView inventoryDataGridView;

        public InventoryForm()
        {
            InitializeComponent();
            SetupSaleDataGridView();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadSampleData();
        }

        private void saleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can handle cell click events here if needed
        }

        private void SetupSaleDataGridView()
        {
            // Create the DataGridView if it doesn't exist in the designer
            invDataGridView.Name = "saleDataGridView";
            invDataGridView.Dock = DockStyle.Fill;
            invDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            invDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            invDataGridView.AllowUserToAddRows = false;
            invDataGridView.AllowUserToDeleteRows = false;
            invDataGridView.ReadOnly = true;
            invDataGridView.RowHeadersVisible = false;
            invDataGridView.BackgroundColor = Color.White;
            invDataGridView.BorderStyle = BorderStyle.None;
            invDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            invDataGridView.RowTemplate.Height = 40;
            invDataGridView.GridColor = Color.LightGray;
            invDataGridView.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

            // Add the CellContentClick event handler
            invDataGridView.CellContentClick += new DataGridViewCellEventHandler(saleDataGridView_CellContentClick);

            // Define columns
            invDataGridView.Columns.Add(CreateColumn("Reference", "REFERENCE"));
            invDataGridView.Columns.Add(CreateColumn("Customer", "CUSTOMER"));
            invDataGridView.Columns.Add(CreateColumn("Warehouse", "WAREHOUSE"));
            invDataGridView.Columns.Add(CreateColumn("Status", "STATUS"));
            invDataGridView.Columns.Add(CreateColumn("GrandTotal", "GRAND TOTAL"));
            invDataGridView.Columns.Add(CreateColumn("Paid", "PAID"));
            invDataGridView.Columns.Add(CreateColumn("PaymentStatus", "PAYMENT STATUS"));

            // Style the header
            invDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            invDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkGray;
            invDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            invDataGridView.ColumnHeadersHeight = 40;
            invDataGridView.EnableHeadersVisualStyles = false;

            // Add the DataGridView to the form if it's not already added in the designer
            this.Controls.Add(invDataGridView);

            // Set up custom cell formatting
            invDataGridView.CellFormatting += SaleDataGridView_CellFormatting;
        }

        private DataGridViewTextBoxColumn CreateColumn(string name, string headerText)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = name;
            column.HeaderText = headerText;
            column.DataPropertyName = name;
            return column;
        }

        private void SaleDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Style all rows with alternating background
            if (e.RowIndex % 2 == 0)
            {
                invDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }

            // Style the reference cells (pink background)
            if (e.ColumnIndex == 0)
            {
                e.CellStyle.BackColor = Color.FromArgb(255, 228, 225); // Light pink
                e.CellStyle.ForeColor = Color.DeepPink;
                e.CellStyle.SelectionBackColor = Color.FromArgb(255, 228, 225);
                e.CellStyle.SelectionForeColor = Color.DeepPink;
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                e.CellStyle.Padding = new Padding(5);
            }

            // Style the status cells (green background)
            if (e.ColumnIndex == 3 && e.Value?.ToString() == "Completed")
            {
                e.CellStyle.BackColor = Color.FromArgb(200, 255, 220); // Light green
                e.CellStyle.ForeColor = Color.Green;
                e.CellStyle.SelectionBackColor = Color.FromArgb(200, 255, 220);
                e.CellStyle.SelectionForeColor = Color.Green;
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                e.CellStyle.Padding = new Padding(5);
            }

            // Style the payment status cells (green background)
            if (e.ColumnIndex == 6 && e.Value?.ToString() == "Paid")
            {
                e.CellStyle.BackColor = Color.FromArgb(200, 255, 220); // Light green
                e.CellStyle.ForeColor = Color.Green;
                e.CellStyle.SelectionBackColor = Color.FromArgb(200, 255, 220);
                e.CellStyle.SelectionForeColor = Color.Green;
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                e.CellStyle.Padding = new Padding(5);
            }

            // Format money values
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal amount))
                {
                    e.Value = "$ " + amount.ToString("0.00");
                    e.FormattingApplied = true;
                }
            }
        }

        private void LoadSampleData()
        {
            // Create a data source
            var data = new DataTable();
            data.Columns.Add("Reference", typeof(string));
            data.Columns.Add("Customer", typeof(string));
            data.Columns.Add("Warehouse", typeof(string));
            data.Columns.Add("Status", typeof(string));
            data.Columns.Add("GrandTotal", typeof(decimal));
            data.Columns.Add("Paid", typeof(decimal));
            data.Columns.Add("PaymentStatus", typeof(string));

            // Add sample rows
            data.Rows.Add("SA_11151174", "Click để tốn tiền của bạn", "ABC", "Completed", 300.00m, 300.00m, "Paid");
            data.Rows.Add("SA_11151173", "Kim Do Won", "warehouse", "Completed", 1.00m, 1.00m, "Paid");
            data.Rows.Add("SA_11151172", "Kim Do Won", "warehouse", "Completed", 100.00m, 100.00m, "Paid");
            data.Rows.Add("SA_11151171", "Kim Do Won", "warehouse", "Completed", 24.00m, 24.00m, "Paid");
            data.Rows.Add("SA_11151170", "Kim Do Won", "warehouse", "Completed", 40.00m, 40.00m, "Paid");
            data.Rows.Add("SA_11151169", "Kim Do Won", "warehouse", "Completed", 1200.00m, 1200.00m, "Paid");

            // Bind data to the grid
            invDataGridView.DataSource = data;
        }
    }
}