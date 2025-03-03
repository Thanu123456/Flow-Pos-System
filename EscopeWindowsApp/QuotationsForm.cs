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
    public partial class Quotations : Form
    {
        public Quotations()
        {
            InitializeComponent();
        }

        private void Quotations_Load(object sender, EventArgs e)
        {

        }

        private void createQuotaBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is AddQuotationForm)
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
            AddQuotationForm addQuotation = new AddQuotationForm();
            addQuotation.Show();
        }
    }
}
