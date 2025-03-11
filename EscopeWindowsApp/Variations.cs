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
    public partial class Variations : Form
    {
        private DataTable variationsTable; // Data source for variations
        private int currentIndex = 0; // Current index for navigation

        public Variations()
        {
            InitializeComponent();
            LoadVariationsData();
        }

        private void Variations_Load(object sender, EventArgs e)
        {
            // Initialize variations data on form load
            variationsDataGridView.DataSource = variationsTable;
        }

        private void LoadVariationsData()
        {
            // Load variations data into variationsTable
            variationsTable = new DataTable();
            variationsTable.Columns.Add("VariationId", typeof(int));
            variationsTable.Columns.Add("VariationName", typeof(string));
            variationsTable.Columns.Add("Description", typeof(string));

            // Sample data - replace with actual data retrieval logic
            variationsTable.Rows.Add(1, "Color", "Different colors available");
            variationsTable.Rows.Add(2, "Size", "Various sizes available");
            variationsTable.Rows.Add(3, "Material", "Different materials");
            variationsTable.Rows.Add(4, "Style", "Different styles");
        }

        private void createVariationsBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is CreateVariations)
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
            CreateVariations createVariations = new CreateVariations();
            createVariations.Show();
        }

        private void variationsSearchText_TextChanged(object sender, EventArgs e)
        {
            // Filter variations data based on search text
            string searchText = variationsSearchText.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchText))
            {
                var filteredRows = variationsTable.AsEnumerable()
                    .Where(row => row.Field<string>("VariationName").ToLower().Contains(searchText)
                               || row.Field<string>("Description").ToLower().Contains(searchText));

                if (filteredRows.Any())
                {
                    variationsDataGridView.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    variationsDataGridView.DataSource = null;
                }
            }
            else
            {
                variationsDataGridView.DataSource = variationsTable;
            }
        }

        private void variationsFilterBtn_Click(object sender, EventArgs e)
        {
            // Filter variations where VariationId is greater than 2
            var filteredRows = variationsTable.AsEnumerable()
                .Where(row => row.Field<int>("VariationId") > 2);

            if (filteredRows.Any())
            {
                variationsDataGridView.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                variationsDataGridView.DataSource = null;
            }
        }

        private void variationsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = variationsDataGridView.Rows[e.RowIndex];
                int variationId = Convert.ToInt32(row.Cells["VariationId"].Value);
                string variationName = row.Cells["VariationName"].Value.ToString();
                string description = row.Cells["Description"].Value.ToString();

                // Implement logic to handle the cell content click event
            }
        }

        private void variationsFirstBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the first record in the variations data
            if (variationsDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                variationsDataGridView.CurrentCell = variationsDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void variationsPrevBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the previous record in the variations data
            if (currentIndex > 0)
            {
                currentIndex--;
                variationsDataGridView.CurrentCell = variationsDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void variationsNextBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the next record in the variations data
            if (currentIndex < variationsDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                variationsDataGridView.CurrentCell = variationsDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void variationsLastBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the last record in the variations data
            if (variationsDataGridView.Rows.Count > 0)
            {
                currentIndex = variationsDataGridView.Rows.Count - 1;
                variationsDataGridView.CurrentCell = variationsDataGridView.Rows[currentIndex].Cells[0];
            }
        }
    }
    
}
