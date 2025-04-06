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
    public partial class POS : Form
    {
       
        private Timer timeTimer;       // Timer for time updates
        private Timer dateTimer;       // Timer for date updates

        public POS()
        {
            InitializeComponent();

           

            // Initialize and start the time timer
            timeTimer = new Timer();
            timeTimer.Interval = 1000; // Update every 1 second
            timeTimer.Tick += TimeTimer_Tick;
            timeTimer.Start();

            // Initialize and start the date timer
            dateTimer = new Timer();
            dateTimer.Interval = 1000; // Update every 1 second
            dateTimer.Tick += DateTimer_Tick;
            dateTimer.Start();

            // Ensure labels can display their content
            posTimeLabel.AutoSize = false; // Fixed from timeLabel
            posDateLabel.AutoSize = false; // Fixed from dateLabel
        }

        private void POS_Load(object sender, EventArgs e)
        {
            
        }

        private void cashBookBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void CashBookTimer_Tick(object sender, EventArgs e)
        {
           
        }

        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            posTimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt") + "\n" + DateTime.Now.ToString("yyyy-MM-dd");
            // Example: "02:35:42 PM\n2025-04-06"
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            posDateLabel.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy");
            // Example: "Sun, Apr 06, 2025"
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Empty handler preserved
        }

        private void posTimeLabel_Click(object sender, EventArgs e)
        {
            // Empty handler preserved
        }

        private void posDateLabel_Click(object sender, EventArgs e)
        {
            // Optional: Keeping this as a manual update on click
            // but the timer will handle continuous updates anyway
            posDateLabel.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy");
        }
    }
}
