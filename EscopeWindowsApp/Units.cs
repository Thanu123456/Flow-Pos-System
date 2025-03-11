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
    public partial class Units : Form
    {
        private DataTable unitsTable; // Data source for units
        private int currentIndex = 0; // Current index for navigation

        public Units()
        {
            InitializeComponent();
            LoadUnitsData();
        }

        private void Units_Load(object sender, EventArgs e)
        {
            // Initialize units data on form load
            unitsDataGridView.DataSource = unitsTable;
        }

        private void LoadUnitsData()
        {
            // Load units data into unitsTable
            unitsTable = new DataTable();
            unitsTable.Columns.Add("UnitId", typeof(int));
            unitsTable.Columns.Add("UnitName", typeof(string));

            // Sample data - replace with actual data retrieval logic
            unitsTable.Rows.Add(1, "Piece");
            unitsTable.Rows.Add(2, "Kilogram");
            unitsTable.Rows.Add(3, "Liter");
            unitsTable.Rows.Add(4, "Box");
        }

        private void createUnitsBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is CreateUnits)
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
            CreateUnits createUnits = new CreateUnits();
            createUnits.Show();
        }

        private void unitsSearchText_TextChanged(object sender, EventArgs e)
        {
            // Search units as text changes
            string searchText = unitsSearchText.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchText))
            {
                var filteredRows = unitsTable.AsEnumerable()
                    .Where(row => row.Field<string>("UnitName").ToLower().Contains(searchText));

                if (filteredRows.Any())
                {
                    unitsDataGridView.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    unitsDataGridView.DataSource = null;
                }
            }
            else
            {
                unitsDataGridView.DataSource = unitsTable;
            }
        }

        private void unitsFilterBtn_Click(object sender, EventArgs e)
        {
            // Filter units where UnitId is greater than 2
            var filteredRows = unitsTable.AsEnumerable()
                .Where(row => row.Field<int>("UnitId") > 2);

            if (filteredRows.Any())
            {
                unitsDataGridView.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                unitsDataGridView.DataSource = null;
            }
        }

        private void unitsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell clicks, for example to edit or delete units
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = unitsDataGridView.Rows[e.RowIndex];
                int unitId = Convert.ToInt32(row.Cells["UnitId"].Value);
                string unitName = row.Cells["UnitName"].Value.ToString();

                // Implement logic to handle the cell content click event
            }
        }

        private void unitsFirstBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the first unit
            if (unitsDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                unitsDataGridView.CurrentCell = unitsDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void unitsPrevBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the previous unit
            if (currentIndex > 0)
            {
                currentIndex--;
                unitsDataGridView.CurrentCell = unitsDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void unitsNextBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the next unit
            if (currentIndex < unitsDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                unitsDataGridView.CurrentCell = unitsDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void unitsLastBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the last unit
            if (unitsDataGridView.Rows.Count > 0)
            {
                currentIndex = unitsDataGridView.Rows.Count - 1;
                unitsDataGridView.CurrentCell = unitsDataGridView.Rows[currentIndex].Cells[0];
            }
        }
    }
}
