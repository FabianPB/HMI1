﻿namespace HMI
{
    partial class Control3
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
            this.SuspendLayout();
            // 
            // Control3
            // 
            this.ClientSize = new System.Drawing.Size(526, 402);
            this.Name = "Control3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
<<<<<<< HEAD
        private CircularProgressBar.CircularProgressBar CircularProgressBar1;
=======
>>>>>>> 9ae13d9be6a0754d4c551fd60a569ffe02183b1a
        private System.IO.Ports.SerialPort serialPort1;
    }
}