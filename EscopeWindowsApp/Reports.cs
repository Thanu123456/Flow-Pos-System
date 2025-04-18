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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void expReportBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is ExpencesReport)
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

            // Create and show a new instance of ExpencesReport
            ExpencesReport expencesReport = new ExpencesReport();
            expencesReport.Show();
        }

        private void saleReportBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is SalesReport)
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

            // Create and show a new instance of ExpencesReport
            SalesReport salesReport = new SalesReport();
            salesReport.Show();
        }

        private void stockReportBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is StockReport)
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

            // Create and show a new instance of ExpencesReport
            StockReport stockReport = new StockReport();
            stockReport.Show();
        }
    }
}
