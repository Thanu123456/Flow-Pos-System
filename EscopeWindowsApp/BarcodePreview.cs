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
    public partial class BarcodePreview : Form
    {
        public BarcodePreview(Bitmap previewBitmap)
        {
            InitializeComponent();
            barcodePreviewPicBox.Image = previewBitmap;
            barcodePreviewPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            barcodePreviewPicBox.Size = new Size(595, 842); // A4 size in pixels at 72 DPI

            // Fix headerPanel to prevent scrolling
            headerPanel.Parent = this; // Make headerPanel a direct child of the form
            headerPanel.Dock = DockStyle.Top;
            headerPanel.AutoScroll = false;
            headerPanel.BringToFront();

            // Create a scrollable panel for other controls
            Panel scrollablePanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Top = headerPanel.Height, // Position below headerPanel
                Height = this.ClientSize.Height - headerPanel.Height
            };
            this.Controls.Add(scrollablePanel);

            // Move scrollable controls to scrollablePanel
            foreach (Control control in this.Controls.Cast<Control>().ToList())
            {
                if (control != headerPanel && control != scrollablePanel)
                {
                    this.Controls.Remove(control);
                    scrollablePanel.Controls.Add(control);
                }
            }

            // Handle form scrolling to keep headerPanel fixed
            this.Scroll += (s, e) => headerPanel.Location = new Point(0, 0);
        }

        private void BarcodePreview_Load(object sender, EventArgs e)
        {
            // Any additional initialization if needed
        }

        private void barcodePreviewPicBox_Click(object sender, EventArgs e)
        {
            // Handle click if necessary
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }
       
    }
}