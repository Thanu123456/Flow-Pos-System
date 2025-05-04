using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Common;
using System.Threading.Tasks;

namespace EscopeWindowsApp
{
    public partial class CodeReaderForm : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private bool isScanning = false;
        private bool isProcessingScan = false;
        public string ScannedCode { get; private set; }

        public CodeReaderForm()
        {
            InitializeComponent();
            InitializeWebcam();
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
                    isScanning = true;
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
                    isScanning = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error stopping webcam: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (isProcessingScan) return;
            isProcessingScan = true;

            using (Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone())
            {
                try
                {
                    if (dispalyCodePictureBox.InvokeRequired)
                    {
                        dispalyCodePictureBox.Invoke(new Action(() =>
                        {
                            dispalyCodePictureBox.Image = (Bitmap)bitmap.Clone();
                        }));
                    }
                    else
                    {
                        dispalyCodePictureBox.Image = (Bitmap)bitmap.Clone();
                    }

                    BarcodeReader barcodeReader = new BarcodeReader
                    {
                        AutoRotate = true,
                        Options = new DecodingOptions
                        {
                            TryHarder = true,
                            PossibleFormats = new[]
                            {
                                BarcodeFormat.EAN_13,
                                BarcodeFormat.EAN_8,
                                BarcodeFormat.UPC_A,
                                BarcodeFormat.UPC_E,
                                BarcodeFormat.CODE_128,
                                BarcodeFormat.CODE_39,
                                BarcodeFormat.QR_CODE
                            }
                        }
                    };

                    var result = barcodeReader.Decode(bitmap);
                    if (result != null)
                    {
                        ScannedCode = result.Text.Trim();
                        await Task.Run(() => StopWebcam());
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Frame processing error: {ex}");
                }
                finally
                {
                    isProcessingScan = false;
                }
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