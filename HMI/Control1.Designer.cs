namespace HMI
{
    partial class Control1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BotonEncender = new System.Windows.Forms.Button();
            this.Apagado = new System.Windows.Forms.Label();
            this.BotonApagar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BotonApagar);
            this.groupBox1.Controls.Add(this.Apagado);
            this.groupBox1.Controls.Add(this.BotonEncender);
            this.groupBox1.Location = new System.Drawing.Point(58, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Led1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BotonEncender
            // 
            this.BotonEncender.Location = new System.Drawing.Point(39, 133);
            this.BotonEncender.Name = "BotonEncender";
            this.BotonEncender.Size = new System.Drawing.Size(75, 23);
            this.BotonEncender.TabIndex = 0;
            this.BotonEncender.Text = "Encender";
            this.BotonEncender.UseVisualStyleBackColor = true;
            this.BotonEncender.Click += new System.EventHandler(this.BotonEncender_Click);
            // 
            // Apagado
            // 
            this.Apagado.AutoSize = true;
            this.Apagado.BackColor = System.Drawing.Color.Red;
            this.Apagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apagado.Location = new System.Drawing.Point(91, 67);
            this.Apagado.Name = "Apagado";
            this.Apagado.Size = new System.Drawing.Size(52, 24);
            this.Apagado.TabIndex = 1;
            this.Apagado.Text = "OFF";
            this.Apagado.Click += new System.EventHandler(this.label1_Click);
            // 
            // BotonApagar
            // 
            this.BotonApagar.Location = new System.Drawing.Point(126, 133);
            this.BotonApagar.Name = "BotonApagar";
            this.BotonApagar.Size = new System.Drawing.Size(75, 23);
            this.BotonApagar.TabIndex = 2;
            this.BotonApagar.Text = "Apagar";
            this.BotonApagar.UseVisualStyleBackColor = true;
            this.BotonApagar.Click += new System.EventHandler(this.BotonApagar_Click);
            // 
            // Control1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 273);
            this.Controls.Add(this.groupBox1);
            this.Name = "Control1";
            this.Text = "Control1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Control1_FormClosing);
            this.Load += new System.EventHandler(this.Control1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Apagado;
        private System.Windows.Forms.Button BotonEncender;
        private System.Windows.Forms.Button BotonApagar;
        private System.IO.Ports.SerialPort serialPort1;
    }
}