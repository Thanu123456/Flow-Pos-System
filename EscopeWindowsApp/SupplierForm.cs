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
    public partial class SupplierForm : Form
    {
        private DataTable suppliersTable; // Data source for suppliers
        private int currentIndex = 0; // Current index for navigation

        public SupplierForm()
        {
            InitializeComponent();
            LoadSuppliersData();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            // Initialize suppliers data on form load
            supDataGridView.DataSource = suppliersTable;
        }

        private void LoadSuppliersData()
        {
            // Load suppliers data into suppliersTable
            suppliersTable = new DataTable();
            suppliersTable.Columns.Add("SupplierId", typeof(int));
            suppliersTable.Columns.Add("SupplierName", typeof(string));

            // Sample data - replace with actual data retrieval logic
            suppliersTable.Rows.Add(1, "Supplier A");
            suppliersTable.Rows.Add(2, "Supplier B");
            suppliersTable.Rows.Add(3, "Supplier C");
            suppliersTable.Rows.Add(4, "Supplier D");
        }

        private void createSupBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is AddSupplierForm)
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
            AddSupplierForm addSupplierForm = new AddSupplierForm();
            addSupplierForm.Show();
        }

        private void supSearchText_TextChanged(object sender, EventArgs e)
        {
            // Search suppliers as text changes
            string searchText = supSearchText.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchText))
            {
                var filteredRows = suppliersTable.AsEnumerable()
                    .Where(row => row.Field<string>("SupplierName").ToLower().Contains(searchText));

                if (filteredRows.Any())
                {
                    supDataGridView.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    supDataGridView.DataSource = null;
                }
            }
            else
            {
                supDataGridView.DataSource = suppliersTable;
            }
        }

        private void supFilterBtn_Click(object sender, EventArgs e)
        {
            // Filter suppliers where SupplierId is greater than 2
            var filteredRows = suppliersTable.AsEnumerable()
                .Where(row => row.Field<int>("SupplierId") > 2);

            if (filteredRows.Any())
            {
                supDataGridView.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                supDataGridView.DataSource = null;
            }
        }

        private void supDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell clicks, for example to edit or delete suppliers
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = supDataGridView.Rows[e.RowIndex];
                int supplierId = Convert.ToInt32(row.Cells["SupplierId"].Value);
                string supplierName = row.Cells["SupplierName"].Value.ToString();

                // Implement logic to handle the cell content click event
            }
        }

        private void supFirstBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the first supplier
            if (supDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                supDataGridView.CurrentCell = supDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void supPrevBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the previous supplier
            if (currentIndex > 0)
            {
                currentIndex--;
                supDataGridView.CurrentCell = supDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void supNextBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the next supplier
            if (currentIndex < supDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                supDataGridView.CurrentCell = supDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void supLastBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the last supplier
            if (supDataGridView.Rows.Count > 0)
            {
                currentIndex = supDataGridView.Rows.Count - 1;
                supDataGridView.CurrentCell = supDataGridView.Rows[currentIndex].Cells[0];
            }
        }
    }
}
