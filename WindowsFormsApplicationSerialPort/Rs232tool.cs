using System;
using System.IO.Ports;
using System.Windows.Forms;

// Author: Stefan Seeland stefan.seeland@gmx.at

namespace WindowsFormsApplicationSerialPort
{
    public partial class Rs232tool : Form
    {
        public Rs232tool()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void serialPort1_PinChanged(object sender, System.IO.Ports.SerialPinChangedEventArgs e)
        {
            logEvent("Pin Changed! " + e.EventType.ToString());
        }

        /// <summary>
        /// Reads everything incomming
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            logEvent("Data Received! " + e.EventType.ToString());
            //http://msdn.microsoft.com/en-us/library/system.io.ports.serialport.datareceived.aspx
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            outputRaw(indata);
        }

        private void serialPort1_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            logEvent("Error Received! " + e.EventType.ToString());
        }

        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        private delegate void SetTextCallback(string text);

        private void logEvent(string e)
        {
            // http://msdn.microsoft.com/query/dev10.query?appId=Dev10IDEF1&l=EN-US&k=k(EHINVALIDOPERATION.WINFORMS.ILLEGALCROSSTHREADCALL);k(TargetFrameworkMoniker-%22.NETFRAMEWORK%2cVERSION%3dV4.0%22);k(DevLang-CSHARP)&rd=true
            if (this.richTextBoxEventlog.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(logEvent);
                this.Invoke(d, new object[] { e });
            }
            else
            {
                this.richTextBoxEventlog.Text += "\n" + DateTime.Now.ToString("h:m:s.ffff") + " - " + e;
            }
        }

        private void outputRaw(string e)
        {
            // http://msdn.microsoft.com/query/dev10.query?appId=Dev10IDEF1&l=EN-US&k=k(EHINVALIDOPERATION.WINFORMS.ILLEGALCROSSTHREADCALL);k(TargetFrameworkMoniker-%22.NETFRAMEWORK%2cVERSION%3dV4.0%22);k(DevLang-CSHARP)&rd=true
            if (this.richTextBoxEventlog.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(outputRaw);
                this.Invoke(d, new object[] { e });
            }
            else
            {
                this.richTextBoxRawOutput.Text += e;
            }
        }

        /// <summary>
        /// Save configuration on close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.BaudRate = serialPort1.BaudRate;
            Properties.Settings.Default.DataBits = serialPort1.DataBits;

            Properties.Settings.Default.Handshake = serialPort1.Handshake;
            Properties.Settings.Default.Parity = serialPort1.Parity;
            Properties.Settings.Default.StopBits = serialPort1.StopBits;
            Properties.Settings.Default.WriteTimeout = serialPort1.WriteTimeout;
            Properties.Settings.Default.PortName = serialPort1.PortName;
            Properties.Settings.Default.Save();
        }

        private void buttonStartReading_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                logEvent(ex.Message);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void buttonSenden_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(richTextBox1.Text);
        }
    }
}