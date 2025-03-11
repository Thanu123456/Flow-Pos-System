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
    public partial class SalesForm : Form
    {
        private DataTable salesTable; // Data source for sales
        private int currentIndex = 0; // Current index for navigation

        public SalesForm()
        {
            InitializeComponent();
            LoadSalesData();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            // Initialize sales data on form load
            saleDataGridView.DataSource = salesTable;
        }

        private void LoadSalesData()
        {
            // Load sales data into salesTable
            salesTable = new DataTable();
            salesTable.Columns.Add("SaleId", typeof(int));
            salesTable.Columns.Add("ProductName", typeof(string));
            salesTable.Columns.Add("Quantity", typeof(int));
            salesTable.Columns.Add("Price", typeof(decimal));
            salesTable.Columns.Add("Date", typeof(DateTime));

            // Sample data - replace with actual data retrieval logic
            salesTable.Rows.Add(1, "Laptop", 2, 1200.00m, DateTime.Now.AddDays(-5));
            salesTable.Rows.Add(2, "Smartphone", 5, 800.00m, DateTime.Now.AddDays(-3));
            salesTable.Rows.Add(3, "Tablet", 3, 500.00m, DateTime.Now.AddDays(-1));
            salesTable.Rows.Add(4, "Headphones", 10, 150.00m, DateTime.Now);
        }

        private void createSaleBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is AddSaleForm)
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
            AddSaleForm addSaleForm = new AddSaleForm();
            addSaleForm.Show();
        }

        private void saleDataComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // select sales data based on the selected data
        }

        private void saleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell clicks, for example to edit or delete sales
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = saleDataGridView.Rows[e.RowIndex];
                int saleId = Convert.ToInt32(row.Cells["SaleId"].Value);
                string productName = row.Cells["ProductName"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                DateTime date = Convert.ToDateTime(row.Cells["Date"].Value);

                // Implement logic to handle the cell content click event
            }
        }

        private void saleSearchText_TextChanged(object sender, EventArgs e)
        {
            // Search sales as text changes
            string searchText = saleSearchText.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchText))
            {
                var filteredRows = salesTable.AsEnumerable()
                    .Where(row => row.Field<string>("ProductName").ToLower().Contains(searchText));

                if (filteredRows.Any())
                {
                    saleDataGridView.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    saleDataGridView.DataSource = null;
                }
            }
            else
            {
                saleDataGridView.DataSource = salesTable;
            }
        }

        private void saleFilterBtn_Click(object sender, EventArgs e)
        {
            // Filter sales where SaleId is greater than 2
            var filteredRows = salesTable.AsEnumerable()
                .Where(row => row.Field<int>("SaleId") > 2);

            if (filteredRows.Any())
            {
                saleDataGridView.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                saleDataGridView.DataSource = null;
            }
        }

        private void saleFirstBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the first sale
            if (saleDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                saleDataGridView.CurrentCell = saleDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void salePrevBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the previous sale
            if (currentIndex > 0)
            {
                currentIndex--;
                saleDataGridView.CurrentCell = saleDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void saleNextBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the next sale
            if (currentIndex < saleDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                saleDataGridView.CurrentCell = saleDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void saleLastBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the last sale
            if (saleDataGridView.Rows.Count > 0)
            {
                currentIndex = saleDataGridView.Rows.Count - 1;
                saleDataGridView.CurrentCell = saleDataGridView.Rows[currentIndex].Cells[0];
            }
        }
    }
}
