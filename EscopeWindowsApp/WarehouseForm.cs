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
    public partial class WarehouseForm : Form
    {
        private DataTable warehousesTable; // Data source for warehouses
        private int currentIndex = 0; // Current index for navigation

        public WarehouseForm()
        {
            InitializeComponent();
            LoadWarehousesData();
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            // Initialize warehouses data on form load
            wareDataGridView.DataSource = warehousesTable;
        }

        private void LoadWarehousesData()
        {
            // Load warehouses data into warehousesTable
            warehousesTable = new DataTable();
            warehousesTable.Columns.Add("WarehouseId", typeof(int));
            warehousesTable.Columns.Add("WarehouseName", typeof(string));
            warehousesTable.Columns.Add("Location", typeof(string));

            // Sample data - replace with actual data retrieval logic
            warehousesTable.Rows.Add(1, "Main Warehouse", "New York");
            warehousesTable.Rows.Add(2, "Secondary Warehouse", "Los Angeles");
            warehousesTable.Rows.Add(3, "East Warehouse", "Chicago");
            warehousesTable.Rows.Add(4, "West Warehouse", "San Francisco");
        }

        private void createWareBtn_Click(object sender, EventArgs e)
        {
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form is AddWarehouseForm)
            //    {
            //        if (form.WindowState == FormWindowState.Minimized)
            //        {
            //            form.WindowState = FormWindowState.Normal;
            //        }
            //        form.BringToFront();
            //        form.Activate();
            //        return;
            //    }
            //}
            //AddWarehouseForm addWarehouseForm = new AddWarehouseForm();
            //addWarehouseForm.Show();
        }

        private void wareSearchText_TextChanged(object sender, EventArgs e)
        {
            // Search warehouses as text changes
            string searchText = wareSearchText.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchText))
            {
                var filteredRows = warehousesTable.AsEnumerable()
                    .Where(row => row.Field<string>("WarehouseName").ToLower().Contains(searchText)
                               || row.Field<string>("Location").ToLower().Contains(searchText));

                if (filteredRows.Any())
                {
                    wareDataGridView.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    wareDataGridView.DataSource = null;
                }
            }
            else
            {
                wareDataGridView.DataSource = warehousesTable;
            }
        }

        private void wareFilterBtn_Click(object sender, EventArgs e)
        {
            // Filter warehouses where WarehouseId is greater than 2
            var filteredRows = warehousesTable.AsEnumerable()
                .Where(row => row.Field<int>("WarehouseId") > 2);

            if (filteredRows.Any())
            {
                wareDataGridView.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                wareDataGridView.DataSource = null;
            }
        }

        private void wareDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click event
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = wareDataGridView.Rows[e.RowIndex];
                int warehouseId = Convert.ToInt32(row.Cells["WarehouseId"].Value);
                string warehouseName = row.Cells["WarehouseName"].Value.ToString();
                string location = row.Cells["Location"].Value.ToString();

                // Implement logic to handle the cell content click event
            }
        }

        private void wareFirstBtn_Click(object sender, EventArgs e)
        {
            // Move to the first record
            if (wareDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                wareDataGridView.CurrentCell = wareDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void warePrevBtn_Click(object sender, EventArgs e)
        {
            // Move to the previous record
            if (currentIndex > 0)
            {
                currentIndex--;
                wareDataGridView.CurrentCell = wareDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void wareNextBtn_Click(object sender, EventArgs e)
        {
            // Move to the next record
            if (currentIndex < wareDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                wareDataGridView.CurrentCell = wareDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void wareLastBtn_Click(object sender, EventArgs e)
        {
            // Move to the last record
            if (wareDataGridView.Rows.Count > 0)
            {
                currentIndex = wareDataGridView.Rows.Count - 1;
                wareDataGridView.CurrentCell = wareDataGridView.Rows[currentIndex].Cells[0];
            }
        }
    }
}
