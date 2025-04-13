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
        private Timer initTimer; // One-shot timer for delayed update

        public CashBookDetails()
        {
            InitializeComponent();
            // Debug
            System.Diagnostics.Debug.WriteLine("Constructor started");
            // Try updating after init
            UpdateSessionDetails();
            // Setup timer
            initTimer = new Timer { Interval = 500 }; // 500ms
            initTimer.Tick += (s, e) =>
            {
                System.Diagnostics.Debug.WriteLine("Timer triggered");
                UpdateSessionDetails();
                initTimer.Stop();
                initTimer.Dispose();
            };
            initTimer.Start();
        }

        private void CashBookDetails_Load(object sender, EventArgs e)
        {
            // Debug
            System.Diagnostics.Debug.WriteLine("CashBookDetails_Load triggered");
            // Update labels
            UpdateSessionDetails();
        }

        private void CashBookDetails_Shown(object sender, EventArgs e)
        {
            // Debug
            System.Diagnostics.Debug.WriteLine("CashBookDetails_Shown triggered");
            // Update labels
            UpdateSessionDetails();
        }

        private void UpdateSessionDetails()
        {
            try
            {
                // Debug
                System.Diagnostics.Debug.WriteLine("UpdateSessionDetails started");

                // Check labels
                if (cashRegDateLable == null || cashInHandAmount == null || cashAmount == null ||
                    cardAmount == null || totSaleAmount == null || totRefAmount == null || subTotAmount == null)
                {
                    System.Diagnostics.Debug.WriteLine("One or more labels are null");
                    return;
                }

                // Update date
                cashRegDateLable.Text = DateTime.Now.ToString("yyyy-MM-dd");
                cashRegDateLable.Refresh();

                // Get SessionManager values
                decimal cashInHand = SessionManager.CashInHand;
                decimal cash = SessionManager.Cash;
                decimal card = SessionManager.Card;
                decimal totalSales = SessionManager.TotalSales;
                decimal totalRefund = SessionManager.TotalRefund;

                // Update labels
                cashInHandAmount.Text = cashInHand.ToString("F2");
                cashAmount.Text = cash.ToString("F2");
                cardAmount.Text = card.ToString("F2");
                totSaleAmount.Text = totalSales.ToString("F2");
                totRefAmount.Text = totalRefund.ToString("F2");
                subTotAmount.Text = (totalSales - totalRefund).ToString("F2");

                // Force UI update
                cashInHandAmount.Refresh();
                cashAmount.Refresh();
                cardAmount.Refresh();
                totSaleAmount.Refresh();
                totRefAmount.Refresh();
                subTotAmount.Refresh();
                this.Refresh();

                // Debug
                System.Diagnostics.Debug.WriteLine($"Updated: Date={cashRegDateLable.Text}, CashInHand={cashInHandAmount.Text}, Cash={cashAmount.Text}, Card={cardAmount.Text}, Sales={totSaleAmount.Text}, Refund={totRefAmount.Text}, SubTotal={subTotAmount.Text}");
            }
            catch (Exception ex)
            {
                // Debug
                System.Diagnostics.Debug.WriteLine($"UpdateSessionDetails error: {ex.Message}");
                // Fallbacks
                if (cashRegDateLable != null)
                {
                    cashRegDateLable.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    cashRegDateLable.Refresh();
                }
                if (cashInHandAmount != null)
                {
                    cashInHandAmount.Text = "0.00";
                    cashInHandAmount.Refresh();
                }
                if (cashAmount != null)
                {
                    cashAmount.Text = "0.00";
                    cashAmount.Refresh();
                }
                if (cardAmount != null)
                {
                    cardAmount.Text = "0.00";
                    cardAmount.Refresh();
                }
                if (totSaleAmount != null)
                {
                    totSaleAmount.Text = "0.00";
                    totSaleAmount.Refresh();
                }
                if (totRefAmount != null)
                {
                    totRefAmount.Text = "0.00";
                    totRefAmount.Refresh();
                }
                if (subTotAmount != null)
                {
                    subTotAmount.Text = "0.00";
                    subTotAmount.Refresh();
                }
                this.Refresh();
            }
        }

        private void cashRegDateLable_Click(object sender, EventArgs e)
        {
            cashRegDateLable.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void cashInHandAmount_Click(object sender, EventArgs e)
        {
            cashInHandAmount.Text = SessionManager.CashInHand.ToString("F2");
        }

        private void cashAmount_Click(object sender, EventArgs e)
        {
            cashAmount.Text = SessionManager.Cash.ToString("F2");
        }

        private void cardAmount_Click(object sender, EventArgs e)
        {
            cardAmount.Text = SessionManager.Card.ToString("F2");
        }

        private void totSaleAmount_Click(object sender, EventArgs e)
        {
            totSaleAmount.Text = SessionManager.TotalSales.ToString("F2");
        }

        private void totRefAmount_Click(object sender, EventArgs e)
        {
            totRefAmount.Text = SessionManager.TotalRefund.ToString("F2");
        }

        private void subTotAmount_Click(object sender, EventArgs e)
        {
            subTotAmount.Text = (SessionManager.TotalSales - SessionManager.TotalRefund).ToString("F2");
        }

        private void cashBookPrintBtn_Click(object sender, EventArgs e)
        {
            // Placeholder for printing cash book details
            MessageBox.Show("Printing Cash Book Details...\n" +
                            $"Date: {cashRegDateLable.Text}\n" +
                            $"Cash in Hand: {cashInHandAmount.Text}\n" +
                            $"Cash: {cashAmount.Text}\n" +
                            $"Card: {cardAmount.Text}\n" +
                            $"Total Sales: {totSaleAmount.Text}\n" +
                            $"Total Refund: {totRefAmount.Text}\n" +
                            $"Sub Total: {subTotAmount.Text}",
                            "Print Preview", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cashbookDetailsCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateRegisterDetailsLabels()
        {
            // Update labels that use SessionManager values
            cashInHandLabel.Text = SessionManager.CashInHand.ToString("F2");
            cashLabel.Text = SessionManager.Cash.ToString("F2");
            cardLabel.Text = SessionManager.Card.ToString("F2");

            // For the current transaction (not session-wide)
            //totalSalesLabel.Text = subTotPriLabel.Text; // Sub Total before discount
            //totalRefundLabel.Text = "0.00"; // No refunds in POS form, so 0
            //subTotalLabel.Text = totPriceCountLabel.Text; // Total after discount
        }
    }
}