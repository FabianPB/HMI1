using CircularProgressBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMI
{
    public partial class Control3 : Form
    {
        public Control3()
        {
            InitializeComponent();
        }

      

        private void Control3_Load(object sender, EventArgs e)
        {

        }
        private void Control3_FormClosing(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnConectar_Enter(object sender, EventArgs e)
        {
            BtnConectar.BackColor = Color.Gray;
        }

        private void BtnConectar_Leave(object sender, EventArgs e)
        {
            BtnConectar.BackColor = Color.DodgerBlue;
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
            {
                string serialData = serialPort1.ReadLine();

                int value = Convert.ToInt32(serialData);

                //if (value >= CircularProgressBar1.Minimum &&
                //    value <= CircularProgressBar1.Maximum)
                //{
                //    CircularProgressBar.invoke((MethodInvoker)(() =>
                //    {
                //        CircularProgressBar1.Text = serialData;
                //        CircularProgressBar1.Value = value;
                //    }));
                //}
                chart1.Invoke((MethodInvoker)(() => chart1.Series
                ["Analog"].Points.Add(value)));
            }
        }
    }
}
