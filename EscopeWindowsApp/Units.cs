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
        public Units()
        {
            InitializeComponent();
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
    }
}
