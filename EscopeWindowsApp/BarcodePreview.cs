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
            this.AutoScroll = true; // Enable scrolling for the form
        }

        private void BarcodePreview_Load(object sender, EventArgs e)
        {
            // Any additional initialization if needed
        }

        private void barcodePreviewPicBox_Click(object sender, EventArgs e)
        {
            // Handle click if necessary
        }
    }
}