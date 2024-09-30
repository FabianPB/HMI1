namespace HMI
{
    partial class Control2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control2));
            this.groupBoxLED = new System.Windows.Forms.GroupBox();
            this.groupBoxPort = new System.Windows.Forms.GroupBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelBaud = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLedOn = new System.Windows.Forms.Button();
            this.buttonLedOff = new System.Windows.Forms.Button();
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxLED.SuspendLayout();
            this.groupBoxPort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLED
            // 
            this.groupBoxLED.Controls.Add(this.buttonLedOff);
            this.groupBoxLED.Controls.Add(this.buttonLedOn);
            this.groupBoxLED.Controls.Add(this.pictureBox1);
            this.groupBoxLED.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLED.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxLED.Location = new System.Drawing.Point(395, 15);
            this.groupBoxLED.Name = "groupBoxLED";
            this.groupBoxLED.Size = new System.Drawing.Size(505, 300);
            this.groupBoxLED.TabIndex = 0;
            this.groupBoxLED.TabStop = false;
            this.groupBoxLED.Text = "LED CONTROL";
            // 
            // groupBoxPort
            // 
            this.groupBoxPort.Controls.Add(this.buttonClose);
            this.groupBoxPort.Controls.Add(this.buttonOpen);
            this.groupBoxPort.Controls.Add(this.comboBoxPort);
            this.groupBoxPort.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxPort.Controls.Add(this.labelBaud);
            this.groupBoxPort.Controls.Add(this.labelPort);
            this.groupBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPort.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxPort.Location = new System.Drawing.Point(12, 15);
            this.groupBoxPort.Name = "groupBoxPort";
            this.groupBoxPort.Size = new System.Drawing.Size(372, 248);
            this.groupBoxPort.TabIndex = 1;
            this.groupBoxPort.TabStop = false;
            this.groupBoxPort.Text = "COM PORT SETTINGS";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(43, 43);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(83, 15);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "COM PORT:";
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Location = new System.Drawing.Point(43, 98);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(87, 15);
            this.labelBaud.TabIndex = 1;
            this.labelBaud.Text = "BAUD RATE:";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(185, 95);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 23);
            this.comboBoxBaudRate.TabIndex = 2;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(185, 43);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPort.TabIndex = 3;
            // 
            // buttonOpen
            // 
            this.buttonOpen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonOpen.Location = new System.Drawing.Point(57, 158);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(109, 55);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "OPEN";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonClose.Location = new System.Drawing.Point(185, 158);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(109, 55);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(172, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLedOn
            // 
            this.buttonLedOn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOn.Location = new System.Drawing.Point(86, 214);
            this.buttonLedOn.Name = "buttonLedOn";
            this.buttonLedOn.Size = new System.Drawing.Size(113, 60);
            this.buttonLedOn.TabIndex = 1;
            this.buttonLedOn.Text = "LED ON";
            this.buttonLedOn.UseVisualStyleBackColor = true;
            // 
            // buttonLedOff
            // 
            this.buttonLedOff.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOff.Location = new System.Drawing.Point(289, 214);
            this.buttonLedOff.Name = "buttonLedOff";
            this.buttonLedOff.Size = new System.Drawing.Size(113, 60);
            this.buttonLedOff.TabIndex = 2;
            this.buttonLedOff.Text = "LED OFF";
            this.buttonLedOff.UseVisualStyleBackColor = true;
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Location = new System.Drawing.Point(12, 278);
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(376, 32);
            this.progressBarStatus.TabIndex = 2;
            // 
            // Control2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(914, 336);
            this.Controls.Add(this.progressBarStatus);
            this.Controls.Add(this.groupBoxPort);
            this.Controls.Add(this.groupBoxLED);
            this.Name = "Control2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control LED APPLICATION";
            this.groupBoxLED.ResumeLayout(false);
            this.groupBoxPort.ResumeLayout(false);
            this.groupBoxPort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLED;
        private System.Windows.Forms.GroupBox groupBoxPort;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonLedOff;
        private System.Windows.Forms.Button buttonLedOn;
        private System.Windows.Forms.ProgressBar progressBarStatus;
        private System.IO.Ports.SerialPort serialPort1;
    }
}