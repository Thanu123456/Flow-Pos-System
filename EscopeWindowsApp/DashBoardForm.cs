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
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            
            InitializeComponent();
            // Disable horizontal scrollbar
            this.AutoScroll = true; // Enable scrolling (optional, for vertical scroll)
            this.HorizontalScroll.Enabled = false; // Disable horizontal scrollbar
            this.HorizontalScroll.Visible = false; // Hide horizontal scrollbar
        }

        private void numberOrderLabel_Click(object sender, EventArgs e)
        {

        }

        private void grossRevenueChart_Click(object sender, EventArgs e)
        {

        }

        private void topProductsPieChart_Click(object sender, EventArgs e)
        {

        }

        private void numberTrevenueLabel_Click(object sender, EventArgs e)
        {

        }

        private void last7DaysBtn_Click(object sender, EventArgs e)
        {

        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tNOCLabel_Click(object sender, EventArgs e)
        {

        }

        private void tNOPLabel_Click(object sender, EventArgs e)
        {

        }

        private void dashTotPurPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashTotSalePriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void thisYearBtn_Click(object sender, EventArgs e)
        {

        }
    }
}