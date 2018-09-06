namespace WindowsFormsApplicationSerialPort
{
    partial class Rs232tool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.richTextBoxEventlog = new System.Windows.Forms.RichTextBox();
            this.richTextBoxRawOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStartReading = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonSenden = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Top;
            this.propertyGrid1.Location = new System.Drawing.Point(2, 2);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.serialPort1;
            this.propertyGrid1.Size = new System.Drawing.Size(686, 406);
            this.propertyGrid1.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = global::WindowsFormsApplicationSerialPort.Properties.Settings.Default.BaudRate;
            this.serialPort1.DataBits = global::WindowsFormsApplicationSerialPort.Properties.Settings.Default.DataBits;
            this.serialPort1.Handshake = global::WindowsFormsApplicationSerialPort.Properties.Settings.Default.Handshake;
            this.serialPort1.Parity = global::WindowsFormsApplicationSerialPort.Properties.Settings.Default.Parity;
            this.serialPort1.PortName = global::WindowsFormsApplicationSerialPort.Properties.Settings.Default.PortName;
            this.serialPort1.StopBits = global::WindowsFormsApplicationSerialPort.Properties.Settings.Default.StopBits;
            this.serialPort1.WriteTimeout = global::WindowsFormsApplicationSerialPort.Properties.Settings.Default.WriteTimeout;
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.serialPort1_PinChanged);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // richTextBoxEventlog
            // 
            this.richTextBoxEventlog.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBoxEventlog.Location = new System.Drawing.Point(2, 15);
            this.richTextBoxEventlog.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxEventlog.Name = "richTextBoxEventlog";
            this.richTextBoxEventlog.Size = new System.Drawing.Size(686, 234);
            this.richTextBoxEventlog.TabIndex = 1;
            this.richTextBoxEventlog.Text = "";
            // 
            // richTextBoxRawOutput
            // 
            this.richTextBoxRawOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxRawOutput.Location = new System.Drawing.Point(2, 274);
            this.richTextBoxRawOutput.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxRawOutput.Name = "richTextBoxRawOutput";
            this.richTextBoxRawOutput.Size = new System.Drawing.Size(686, 218);
            this.richTextBoxRawOutput.TabIndex = 2;
            this.richTextBoxRawOutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eventlog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RawOutput";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(698, 520);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.propertyGrid1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(690, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonStop);
            this.tabPage2.Controls.Add(this.buttonStartReading);
            this.tabPage2.Controls.Add(this.richTextBoxEventlog);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.richTextBoxRawOutput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(690, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Empfangen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(448, 2);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(56, 19);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStartReading
            // 
            this.buttonStartReading.Location = new System.Drawing.Point(519, 0);
            this.buttonStartReading.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartReading.Name = "buttonStartReading";
            this.buttonStartReading.Size = new System.Drawing.Size(56, 19);
            this.buttonStartReading.TabIndex = 5;
            this.buttonStartReading.Text = "Start Reading";
            this.buttonStartReading.UseVisualStyleBackColor = true;
            this.buttonStartReading.Click += new System.EventHandler(this.buttonStartReading_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonSenden);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(690, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Senden";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonSenden
            // 
            this.buttonSenden.Location = new System.Drawing.Point(518, 471);
            this.buttonSenden.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSenden.Name = "buttonSenden";
            this.buttonSenden.Size = new System.Drawing.Size(56, 19);
            this.buttonSenden.TabIndex = 1;
            this.buttonSenden.Text = "send";
            this.buttonSenden.UseVisualStyleBackColor = true;
            this.buttonSenden.Click += new System.EventHandler(this.buttonSenden_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 2);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(569, 465);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 520);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Rs232tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.RichTextBox richTextBoxEventlog;
        private System.Windows.Forms.RichTextBox richTextBoxRawOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonStartReading;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonSenden;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

