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
    public partial class SaleReturnForm : Form
    {
        private DataTable saleReturnsTable; // Data source for sale returns
        private int currentIndex = 0; // Current index for navigation

        public SaleReturnForm()
        {
            InitializeComponent();
            LoadSaleReturnsData();
        }

        private void SaleReturnForm_Load(object sender, EventArgs e)
        {
            // Initialize sale returns data on form load
            saleReDataGridView.DataSource = saleReturnsTable;
        }

        private void LoadSaleReturnsData()
        {
            // Load sale returns data into saleReturnsTable
            saleReturnsTable = new DataTable();
            saleReturnsTable.Columns.Add("SaleReturnId", typeof(int));
            saleReturnsTable.Columns.Add("ProductName", typeof(string));
            saleReturnsTable.Columns.Add("Quantity", typeof(int));
            saleReturnsTable.Columns.Add("ReturnDate", typeof(DateTime));
            saleReturnsTable.Columns.Add("Reason", typeof(string));

            // Sample data - replace with actual data retrieval logic
            saleReturnsTable.Rows.Add(1, "Laptop", 1, DateTime.Now.AddDays(-10), "Defective");
            saleReturnsTable.Rows.Add(2, "Smartphone", 2, DateTime.Now.AddDays(-7), "Damaged");
            saleReturnsTable.Rows.Add(3, "Tablet", 1, DateTime.Now.AddDays(-5), "Incorrect Model");
            saleReturnsTable.Rows.Add(4, "Headphones", 3, DateTime.Now.AddDays(-2), "Changed Mind");
        }

        private void saleReSearchText_TextChanged(object sender, EventArgs e)
        {
            // Search sales returns as text changes
            string searchText = saleReSearchText.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchText))
            {
                var filteredRows = saleReturnsTable.AsEnumerable()
                    .Where(row => row.Field<string>("ProductName").ToLower().Contains(searchText)
                               || row.Field<string>("Reason").ToLower().Contains(searchText));

                if (filteredRows.Any())
                {
                    saleReDataGridView.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    saleReDataGridView.DataSource = null;
                }
            }
            else
            {
                saleReDataGridView.DataSource = saleReturnsTable;
            }
        }

        private void saleReFilterBtn_Click(object sender, EventArgs e)
        {
            // Filter sale returns where SaleReturnId is greater than 2
            var filteredRows = saleReturnsTable.AsEnumerable()
                .Where(row => row.Field<int>("SaleReturnId") > 2);

            if (filteredRows.Any())
            {
                saleReDataGridView.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                saleReDataGridView.DataSource = null;
            }
        }

        private void saleReDataComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle selection change in ComboBox if needed
            // For example, filter sale returns based on selected criteria
        }

        private void saleReDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = saleReDataGridView.Rows[e.RowIndex];
                int saleReturnId = Convert.ToInt32(row.Cells["SaleReturnId"].Value);
                string productName = row.Cells["ProductName"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                DateTime returnDate = Convert.ToDateTime(row.Cells["ReturnDate"].Value);
                string reason = row.Cells["Reason"].Value.ToString();

                // Implement logic to handle the cell content click event
            }
        }

        private void saleReFirstBtn_Click(object sender, EventArgs e)
        {
            // Navigate to first record
            if (saleReDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                saleReDataGridView.CurrentCell = saleReDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void saleRePrevBtn_Click(object sender, EventArgs e)
        {
            // Navigate to previous record
            if (currentIndex > 0)
            {
                currentIndex--;
                saleReDataGridView.CurrentCell = saleReDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void saleReNextBtn_Click(object sender, EventArgs e)
        {
            // Navigate to next record
            if (currentIndex < saleReDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                saleReDataGridView.CurrentCell = saleReDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void saleReLastBtn_Click(object sender, EventArgs e)
        {
            // Navigate to last record
            if (saleReDataGridView.Rows.Count > 0)
            {
                currentIndex = saleReDataGridView.Rows.Count - 1;
                saleReDataGridView.CurrentCell = saleReDataGridView.Rows[currentIndex].Cells[0];
            }
        }
    }
}
