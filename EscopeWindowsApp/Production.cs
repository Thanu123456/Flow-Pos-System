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
        public Production()
        {
            InitializeComponent();
        }

        private void adjPageCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createProductBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is CreateProduct)
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
            CreateProduct createProduct = new CreateProduct();
            createProduct.Show();
        }
    }
}
