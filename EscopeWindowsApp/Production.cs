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
    public partial class Production : Form
    {
        private DataTable productionTable; // Data source for production data
        private int currentIndex = 0; // Current index for navigation

        public Production()
        {
            InitializeComponent();
            LoadProductionData();
        }

        private void Production_Load(object sender, EventArgs e)
        {
            // Initialize production data on form load
            ProductDataGridView.DataSource = productionTable;
        }

        private void LoadProductionData()
        {
            // Load production data into productionTable
            productionTable = new DataTable();
            productionTable.Columns.Add("ProductId", typeof(int));
            productionTable.Columns.Add("ProductName", typeof(string));
            productionTable.Columns.Add("QuantityProduced", typeof(int));
            productionTable.Columns.Add("ProductionDate", typeof(DateTime));
            productionTable.Columns.Add("Status", typeof(string));

            // Sample data - replace with actual data retrieval logic
            productionTable.Rows.Add(1, "Widget A", 100, DateTime.Now.AddDays(-5), "Completed");
            productionTable.Rows.Add(2, "Widget B", 200, DateTime.Now.AddDays(-3), "In Progress");
            productionTable.Rows.Add(3, "Widget C", 150, DateTime.Now.AddDays(-2), "Pending");
            productionTable.Rows.Add(4, "Widget D", 300, DateTime.Now, "Completed");
        }

        private void adjPageCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle selection change if needed
            // For example, update the data view based on the selected page or criteria
        }

        private void productionSearchText_TextChanged(object sender, EventArgs e)
        {
            // Filter production data based on search text
            string searchText = productionSearchText.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchText))
            {
                var filteredRows = productionTable.AsEnumerable()
                    .Where(row => row.Field<string>("ProductName").ToLower().Contains(searchText)
                               || row.Field<string>("Status").ToLower().Contains(searchText));

                if (filteredRows.Any())
                {
                    ProductDataGridView.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    ProductDataGridView.DataSource = null;
                }
            }
            else
            {
                ProductDataGridView.DataSource = productionTable;
            }
        }

        private void productFilterBtn_Click(object sender, EventArgs e)
        {
            // Filter products where ProductId is greater than 2
            var filteredRows = productionTable.AsEnumerable()
                .Where(row => row.Field<int>("ProductId") > 2);

            if (filteredRows.Any())
            {
                ProductDataGridView.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                ProductDataGridView.DataSource = null;
            }
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProductDataGridView.Rows[e.RowIndex];
                int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
                string productName = row.Cells["ProductName"].Value.ToString();
                int quantityProduced = Convert.ToInt32(row.Cells["QuantityProduced"].Value);
                DateTime productionDate = Convert.ToDateTime(row.Cells["ProductionDate"].Value);
                string status = row.Cells["Status"].Value.ToString();

                // Implement logic to handle the cell content click event
                // For example, open a detailed view or edit the production record
            }
        }

        private void productFirstBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the first record
            if (ProductDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                ProductDataGridView.CurrentCell = ProductDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void productPrevBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the previous record
            if (currentIndex > 0)
            {
                currentIndex--;
                ProductDataGridView.CurrentCell = ProductDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void productNextBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the next record
            if (currentIndex < ProductDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                ProductDataGridView.CurrentCell = ProductDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void productLastBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the last record
            if (ProductDataGridView.Rows.Count > 0)
            {
                currentIndex = ProductDataGridView.Rows.Count - 1;
                ProductDataGridView.CurrentCell = ProductDataGridView.Rows[currentIndex].Cells[0];
            }
        }
    }
}
