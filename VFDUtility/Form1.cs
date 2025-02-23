using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing.Text;
using System.IO;

namespace VFDUtility
{
    public partial class Form1 : Form
    {
        VFDConnection vfdConnection;
        PrivateFontCollection fonts = new PrivateFontCollection();

        private delegate void SerialEvent();

        private event SerialEvent OnSerialOpened;
        private event SerialEvent OnSerialClosed;
        private event SerialEvent OnClearDisplay;

        public Form1()
        {
            InitializeComponent();

            this.vfdConnection = new VFDConnection(serialPort1);

            Stream fontStream = this.GetType().Assembly.GetManifestResourceStream("VFDUtility.Resources.vfd_display.ttf");
            byte[] fontData = new byte[fontStream.Length];
            fontStream.Read(fontData, 0, (int)fontStream.Length);
            fontStream.Close();

            unsafe
            {
                fixed (byte* pFontData = fontData)
                {
                    fonts.AddMemoryFont((System.IntPtr)pFontData, fontData.Length);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generateArrowCheckboxes();

            txtLine1.Font = new Font(fonts.Families[0], 14, FontStyle.Regular);
            txtLine2.Font = new Font(fonts.Families[0], 14, FontStyle.Regular);

            string[] portNames = SerialPort.GetPortNames();

            if (portNames.Length > 0)
            {
                cmbPorts.Items.AddRange(portNames);
                cmbPorts.Text = portNames[0];
            }
            else
            {
                cmbPorts.Text = "No ports";
                cmbPorts.Enabled = false;
            }

            this.OnSerialOpened += delegate
            {
                btnSend.Enabled = true;
                btnSelfTestDisplay.Enabled = true;
                btnClearDisplay.Enabled = true;
                cmbPorts.Enabled = false;
                trkBrightness.Enabled = true;
                btnTglConnection.Text = "Disconnect";
            };

            this.OnSerialClosed += delegate
            {
                btnSend.Enabled = false;
                btnSelfTestDisplay.Enabled = false;
                btnClearDisplay.Enabled = false;
                cmbPorts.Enabled = true;
                trkBrightness.Enabled = false;
                btnTglConnection.Text = "Connect";
            };

            this.OnSerialClosed.Invoke();
        }

        private void btnClearDisplay_Click(object sender, EventArgs e)
        {
            vfdConnection.clearDisplay();
        }

        private void btnSelfTest_Click(object sender, EventArgs e)
        {
            this.vfdConnection.selfTest();
        }

        private void btnTglConnection_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    this.vfdConnection.clearDisplay();

                    OnSerialOpened.Invoke();
                }
                catch (System.Exception exception)
                {
                    MessageBox.Show(
                        "Cannot open COM port: " + exception.Message,
                        "VFD Utility",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
            }
            else
            {
                serialPort1.Close();
                this.OnSerialClosed.Invoke();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            vfdConnection.clearDisplay();

            vfdConnection.setPosition(1, 1);
            vfdConnection.writeString(txtLine1.Text);
            vfdConnection.setPosition(2, 1);
            vfdConnection.writeString(txtLine2.Text);
        }

        private void trkBrightness_Scroll(object sender, EventArgs e)
        {
            vfdConnection.setBrightness(trkBrightness.Value);
        }

        private void onArrowCheckerClick(object sender, EventArgs e)
        {
            if (!(sender is AnnunciatorCheckBox))
            {
                return;
            }

            AnnunciatorCheckBox senderObj = (AnnunciatorCheckBox)sender;

            this.vfdConnection.setAnnunciator(
                senderObj.getIndex(),
                senderObj.CheckState == CheckState.Checked ? 1 : 0
            );
        }

        private void generateArrowCheckboxes()
        {
            AnnunciatorCheckBox[] items = new AnnunciatorCheckBox[10];

            for (int i = 0; i < 20; i++)
            {
                AnnunciatorCheckBox item = new AnnunciatorCheckBox(i + 1);
                item.Location = new Point(16 * i, 0);
                item.CheckStateChanged += new EventHandler(onArrowCheckerClick);

                pnlAnnuciatorContainer.Controls.Add(item);

                item.BringToFront();

                this.OnSerialOpened += delegate
                {
                    item.Enabled = true;
                    item.Checked = false;
                };

                this.OnSerialClosed += delegate
                {
                    item.Enabled = false;
                };

                this.vfdConnection.OnDisplayClear += delegate
                {
                    item.Checked = false;
                };
            }
        }
    }
}