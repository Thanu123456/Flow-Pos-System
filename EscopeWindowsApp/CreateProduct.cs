using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace EscopeWindowsApp
{
    public partial class CreateProduct : Form
    {
        // Dictionary to store the original Top positions of controls
        private Dictionary<Control, int> originalPositions = new Dictionary<Control, int>();

        public CreateProduct()
        {
            InitializeComponent();

            // Set up the scrollbar
            creProVScrollBar1.Minimum = 0;
            creProVScrollBar1.LargeChange = 50; // Scroll amount when clicking in the scrollbar track
            creProVScrollBar1.SmallChange = 10; // Scroll amount when clicking the arrows
            creProVScrollBar1.Scroll += new ScrollEventHandler(creProVScrollBar1_Scroll); // Handle the Scroll event

            // Store the original Top positions of controls
            StoreOriginalPositions();

            // Calculate the Maximum value for the scrollbar
            CalculateScrollBarMaximum();

            // Handle form resize events
            this.Resize += new EventHandler(Form1_Resize);

            // Handle mouse wheel events
            this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);

            // Add items to the ComboBox
            creProTypeComboBox.Items.Add("Single");
            creProTypeComboBox.Items.Add("Variation");

            // Set the default selected item
            creProTypeComboBox.SelectedIndex = 0;

            // Attach the SelectedIndexChanged event handler
            creProTypeComboBox.SelectedIndexChanged += new EventHandler(creProTypeComboBox_SelectedIndexChanged);
        }

        // Store the original Top positions of controls
        private void StoreOriginalPositions()
        {
            foreach (Control control in this.Controls)
            {
                if (control != headerPanel && control != creProVScrollBar1) // Exclude the header panel and scrollbar
                {
                    originalPositions[control] = control.Top;
                }
            }
        }

        // Calculate the Maximum value for the scrollbar
        private void CalculateScrollBarMaximum()
        {
            // Get the total height of the content (e.g., the height of the form)
            int contentHeight = this.ClientSize.Height;

            // Get the height of the visible area (viewport), excluding the header panel
            int viewportHeight = this.ClientSize.Height - headerPanel.Height;

            // Calculate the Maximum value for the scrollbar
            creProVScrollBar1.Maximum = Math.Max(0, contentHeight - viewportHeight);
        }

        // Handle the Scroll event of the VScrollBar
        private void creProVScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // Get the current scroll value
            int scrollValue = creProVScrollBar1.Value;

            // Move all controls (except the header panel) based on the scroll value
            foreach (Control control in this.Controls)
            {
                if (control != headerPanel && control != creProVScrollBar1) // Exclude the header panel and scrollbar
                {
                    // Calculate the new Top position based on the original position and scroll value
                    control.Top = originalPositions[control] - scrollValue;
                }
            }

            // Ensure the scrollbar stops at the top and bottom
            if (scrollValue <= creProVScrollBar1.Minimum)
            {
                creProVScrollBar1.Value = creProVScrollBar1.Minimum;
            }
            else if (scrollValue >= creProVScrollBar1.Maximum)
            {
                creProVScrollBar1.Value = creProVScrollBar1.Maximum;
            }
        }

        // Handle form resize events
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Recalculate the scrollbar's Maximum value when the form is resized
            CalculateScrollBarMaximum();
        }

        // Handle mouse wheel events
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            // Adjust the scrollbar's Value based on the mouse wheel delta
            int newScrollValue = creProVScrollBar1.Value - (e.Delta / 120 * creProVScrollBar1.SmallChange);

            // Constrain the new scroll value to the scrollbar's Minimum and Maximum
            newScrollValue = Math.Max(creProVScrollBar1.Minimum, Math.Min(creProVScrollBar1.Maximum, newScrollValue));

            // Set the scrollbar's Value
            creProVScrollBar1.Value = newScrollValue;

            // Trigger the Scroll event to update the control positions
            creProVScrollBar1_Scroll(null, null);
        }

        private void ProCatComboox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void creProBarcodeSymComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void creProSaleUnitLabel_Click(object sender, EventArgs e)
        {

        }

        private void creProCreUnitBtn_Click(object sender, EventArgs e)
        {

        }

        private void creProAddStocklabel_Click(object sender, EventArgs e)
        {

        }

        private void createProductMultipleImgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;)|*.jpg;*.jpeg;*.png;*.bmp;|All Files (*.*)|*.*";
                    dialog.FilterIndex = 1;
                    dialog.RestoreDirectory = true;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = dialog.FileName;

                        string fileName = System.IO.Path.GetFileName(filePath);

                        createProductMultipleImgText.Text = fileName;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {

        }

        // Handle the SelectedIndexChanged event of the creProTypeComboBox
        private void creProTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // Method to open the AddVariationItem form
        private void OpenAddVariationForm()
        {
            try
            {
                // Create an instance of the AddVariationItem form
                AddVariationItem addVariationForm = new AddVariationItem();

                // Show the form as a modal dialog
                addVariationForm.ShowDialog();
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show("Error opening AddVariationItem form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}