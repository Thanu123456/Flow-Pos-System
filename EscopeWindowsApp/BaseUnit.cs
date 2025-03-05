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

        private void baseUnitSearchText_TextChanged(object sender, EventArgs e)
        {
            // Search for base units text box
        }

        private void baseUnitFilterBtn_Click(object sender, EventArgs e)
        {
            // Filter base units button click
        }

        private void baseUnitsFirstBtn_Click(object sender, EventArgs e)
        {
            // First page button click
        }

        private void baseUnitsPrevBtn_Click(object sender, EventArgs e)
        {
            // Previous page button click
        }

        private void baseUnitsNextBtn_Click(object sender, EventArgs e)
        {
            // Next page button click
        }

        private void baseUnitsLastBtn_Click(object sender, EventArgs e)
        {
            // Last page button click
        }
    }
}
