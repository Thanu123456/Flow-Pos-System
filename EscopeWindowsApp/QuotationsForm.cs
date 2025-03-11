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
    public partial class Quotations : Form
    {
        private DataTable quotationsTable; // Data source for quotations
        private int currentIndex = 0; // Current index for navigation

        public Quotations()
        {
            InitializeComponent();
            LoadQuotationsData();
        }

        private void Quotations_Load(object sender, EventArgs e)
        {
            // Initialize quotations data on form load
            quotaDataGridView.DataSource = quotationsTable;
        }

        private void LoadQuotationsData()
        {
            // Load quotations data into quotationsTable
            quotationsTable = new DataTable();
            quotationsTable.Columns.Add("QuotationId", typeof(int));
            quotationsTable.Columns.Add("CustomerName", typeof(string));
            quotationsTable.Columns.Add("Product", typeof(string));
            quotationsTable.Columns.Add("Quantity", typeof(int));
            quotationsTable.Columns.Add("Price", typeof(decimal));
            quotationsTable.Columns.Add("Date", typeof(DateTime));

            // Sample data - replace with actual data retrieval logic
            quotationsTable.Rows.Add(1, "Alice", "Laptop", 2, 1200.00m, DateTime.Now.AddDays(-5));
            quotationsTable.Rows.Add(2, "Bob", "Smartphone", 5, 800.00m, DateTime.Now.AddDays(-3));
            quotationsTable.Rows.Add(3, "Charlie", "Tablet", 3, 500.00m, DateTime.Now.AddDays(-1));
            quotationsTable.Rows.Add(4, "Diana", "Headphones", 10, 150.00m, DateTime.Now);
        }

        private void createQuotaBtn_Click(object sender, EventArgs e)
        {
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
            addQuotation.Show();
        }

        private void quotaFilterBtn_Click(object sender, EventArgs e)
        {
            // Filter quotations where QuotationId is greater than 2
            var filteredRows = quotationsTable.AsEnumerable()
                .Where(row => row.Field<int>("QuotationId") > 2);

            if (filteredRows.Any())
            {
                quotaDataGridView.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                quotaDataGridView.DataSource = null;
            }
        }

        private void quotaSearchText_TextChanged(object sender, EventArgs e)
        {
            // Search quotations as text changes
            string searchText = quotaSearchText.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchText))
            {
                var filteredRows = quotationsTable.AsEnumerable()
                    .Where(row => row.Field<string>("CustomerName").ToLower().Contains(searchText)
                               || row.Field<string>("Product").ToLower().Contains(searchText));

                if (filteredRows.Any())
                {
                    quotaDataGridView.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    quotaDataGridView.DataSource = null;
                }
            }
            else
            {
                quotaDataGridView.DataSource = quotationsTable;
            }
        }

        private void quotaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = quotaDataGridView.Rows[e.RowIndex];
                int quotationId = Convert.ToInt32(row.Cells["QuotationId"].Value);
                string customerName = row.Cells["CustomerName"].Value.ToString();
                string product = row.Cells["Product"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                DateTime date = Convert.ToDateTime(row.Cells["Date"].Value);

                // Implement logic to handle the cell content click event
            }
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
