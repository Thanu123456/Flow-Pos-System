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
    public partial class CashBookDetails : Form
    {
        public CashBookDetails()
        {
            InitializeComponent();
        }

        private void cashRegDateLable_Click(object sender, EventArgs e)
        {
            // this label should show today date
        }

        private void cashInHandAmount_Click(object sender, EventArgs e)
        {
            // this label should show the cash in hand (cashier or owner included)
        }

        private void cashAmount_Click(object sender, EventArgs e)
        {
            // this label should show recent sales of payments methods = "Cash", recent meaning, Sales made in cash from the time of handing over cash until now 
        }

        private void cardAmount_Click(object sender, EventArgs e)
        {
            // this label should show recent sales of payments methods = "Card", recent meaning, Sales made in card from the time of handing over cash until now 
        }

        private void totSaleAmount_Click(object sender, EventArgs e)
        {
            // this label should show recent sales of payments methods = "Cash" and "Card", recent meaning, Sales made in cash and card from the time of handing over cash until now
        }

        private void totRefAmount_Click(object sender, EventArgs e)
        {
            // this label should show recent refunds of payments methods = "Cash" and "Card", if it have refunds, recent meaning, Refunds made in cash and card from the time of handing over cash until now
        }

        private void subTotAmount_Click(object sender, EventArgs e)
        {
            // this label should show the total amount of sales - refunds, recent meaning, Refunds made in cash and card from the time of handing over cash until now
        }

        private void cashBookPrintBtn_Click(object sender, EventArgs e)
        {
            // this button should print the cash book details
        }

        private void cashbookDetailsCancelBtn_Click(object sender, EventArgs e)
        {
            // this button should close the form
        }
    }
}
