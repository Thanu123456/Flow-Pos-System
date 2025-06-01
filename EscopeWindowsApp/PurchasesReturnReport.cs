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
    public partial class PurchasesReturnReport : Form
    {
        public PurchasesReturnReport()
        {
            InitializeComponent();
        }

        private void PurchasesReturnReport_Load(object sender, EventArgs e)
        {

        }

        private void retNoSearchText_TextChanged(object sender, EventArgs e)
        {
            // This method is called when the text in the return number or GRN number search box changes.
        }

        private void resonsFilterPurRetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This method is called when the selected item in the reasons filter combo box changes.
            // reasons are: "Product Damaged or Defective", "Product Not as Described or Expected", "Expired Products", "Other"
        }

        private void dateFilterPurRetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This method is called when the selected item in the date filter combo box changes.
            // "Daily", "Weekly", "Monthly", "Yearly"
        }

        private void purRetReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This method is called when a cell in the purchases return report data grid.
        }

        private void purRetTotAmontLabel_Click(object sender, EventArgs e)
        {
            // This method is called when the total amount label in the purchases return report.
        }

        private void generatePurRetPdfBtn_Click(object sender, EventArgs e)
        {
            // This method is called when the "Generate PDF" button is clicked in the purchases return report.
        }

        private void generatePurRetExcelBtn_Click(object sender, EventArgs e)
        {
            // This method is called when the "Generate Excel" button is clicked in the purchases return report.
        }
    }
}
