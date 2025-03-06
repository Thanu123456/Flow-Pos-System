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
    public partial class Brands : Form
    {
        private DataTable brandsTable; // Data source for the brands list

        public Brands()
        {
            InitializeComponent();
            LoadBrandsData();
        }

        private void LoadBrandsData()
        {
            // Load the brands data into the brandsTable
            // Replace this with actual data retrieval logic
            brandsTable = new DataTable();
            brandsTable.Columns.Add("BrandId", typeof(int));
            brandsTable.Columns.Add("BrandName", typeof(string));

            // Sample data
            brandsTable.Rows.Add(1, "Brand A");
            brandsTable.Rows.Add(2, "Brand B");
            brandsTable.Rows.Add(3, "Brand C");

            // Bind the data to a DataGridView or other control
            // brandsDataGridView.DataSource = brandsTable;
        }

        private void createBrandsBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is CreateBrand)
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
            CreateBrand createBrand = new CreateBrand();
            createBrand.Show();
        }

        private void brandsSearchText_TextChanged(object sender, EventArgs e)
        {
            // This is the search brands text box
            string searchText = brandsSearchText.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchText))
            {
                // Filter the brandsTable based on the search text
                var filteredRows = brandsTable.AsEnumerable()
                    .Where(row => row.Field<string>("BrandName").ToLower().Contains(searchText));

                if (filteredRows.Any())
                {
                    // Bind the filtered data to the DataGridView
                    // brandsDataGridView.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    // No matches found, clear the DataGridView
                    // brandsDataGridView.DataSource = null;
                }
            }
            else
            {
                // If search text is empty, show all data
                // brandsDataGridView.DataSource = brandsTable;
            }
        }

        private void brandsFilterBtn_Click(object sender, EventArgs e)
        {
            // This is the filter button
            // Implement filter logic here
            // For example, open a filter dialog and apply selected filters to brandsTable
        }

        private void brandsFirstBtn_Click(object sender, EventArgs e)
        {
            // This is the first button
            // Navigate to the first record
            // brandsDataGridView.CurrentCell = brandsDataGridView.Rows[0].Cells[0];
        }

        private void brandsPrevBtn_Click(object sender, EventArgs e)
        {
            // This is the previous button
            // Navigate to the previous record
            // int currentIndex = brandsDataGridView.CurrentRow.Index;
            // if (currentIndex > 0)
            // {
            //     brandsDataGridView.CurrentCell = brandsDataGridView.Rows[currentIndex - 1].Cells[0];
            // }
        }

        private void brandsNextBtn_Click(object sender, EventArgs e)
        {
            // This is the next button
            // Navigate to the next record
            // int currentIndex = brandsDataGridView.CurrentRow.Index;
            // if (currentIndex < brandsDataGridView.Rows.Count - 1)
            // {
            //     brandsDataGridView.CurrentCell = brandsDataGridView.Rows[currentIndex + 1].Cells[0];
            // }
        }

        private void brandsLastBtn_Click(object sender, EventArgs e)
        {
            // This is the last button
            // Navigate to the last record
            // int lastIndex = brandsDataGridView.Rows.Count - 1;
            // brandsDataGridView.CurrentCell = brandsDataGridView.Rows[lastIndex].Cells[0];
        }

        private void brandsRecordsPerLabel_Click(object sender, EventArgs e)
        {

        }
    }

}
