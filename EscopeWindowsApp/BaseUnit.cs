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
    public partial class BaseUnit : Form
    {
        public BaseUnit()
        {
            InitializeComponent();
        }

        private void baseUnitsBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is CreateBaseUnit)
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
            CreateBaseUnit createBaseUnit = new CreateBaseUnit();
            createBaseUnit.Show();
        }
    }
}
