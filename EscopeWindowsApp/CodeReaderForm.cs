using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Common;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EscopeWindowsApp
{
    public partial class CodeReaderForm : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private bool isDecoding = false;
        private BarcodeReader barcodeReader;
        public string ScannedCode { get; private set; }

        public CodeReaderForm()
        {
            InitializeComponent();
            InitializeWebcam();
            InitializeBarcodeReader();
        }

        private void InitializeWebcam()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No webcam devices found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing webcam: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void InitializeBarcodeReader()
        {
            barcodeReader = new BarcodeReader
            {
                AutoRotate = true,
                Options = new DecodingOptions
                {
                    TryHarder = true
                    // Removed PossibleFormats to allow detection of all barcode types
                }
            };
        }

        private void CodeReaderForm_Load(object sender, EventArgs e)
        {
            StartWebcam();
        }

        private void StartWebcam()
        {
            if (videoSource != null && !videoSource.IsRunning)
            {
                try
                {
                    videoSource.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error starting webcam: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void StopWebcam()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                try
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error stopping webcam: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

            if (dispalyCodePictureBox.InvokeRequired)
            {
                dispalyCodePictureBox.Invoke(new Action(() =>
                {
                    dispalyCodePictureBox.Image = frame;
                }));
            }
            else
            {
                dispalyCodePictureBox.Image = frame;
            }

            if (!isDecoding)
            {
                isDecoding = true;
                Bitmap frameToDecode = (Bitmap)frame.Clone();
                Task.Run(() =>
                {
                    Debug.WriteLine("Attempting to decode frame");
                    try
                    {
                        // Save the frame for manual testing (remove this after debugging)
                        frameToDecode.Save("frame.png", System.Drawing.Imaging.ImageFormat.Png);

                        var result = barcodeReader.Decode(frameToDecode);
                        if (result != null)
                        {
                            Debug.WriteLine($"Barcode found: {result.Text}");
                            ScannedCode = result.Text.Trim();
                            this.Invoke(new Action(() =>
                            {
                                StopWebcam();
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }));
                        }
                        else
                        {
                            Debug.WriteLine("No barcode found in frame");
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Decoding error: {ex}");
                        MessageBox.Show($"Decoding error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        frameToDecode.Dispose();
                        isDecoding = false;
                    }
                });
            }
        }

        private void dispalyCodePictureBox_Click(object sender, EventArgs e)
        {
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopWebcam();
            if (videoSource != null)
            {
                videoSource.NewFrame -= VideoSource_NewFrame;
                videoSource = null;
            }
            base.OnFormClosing(e);
        }
    }
}