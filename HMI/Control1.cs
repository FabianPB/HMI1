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
    public partial class Control1 : Form
    {
        public Control1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BotonEncender_Click(object sender, EventArgs e)
        {
            try
            {
                //Enviar codigo al arduino
                //serial.println("$On");
                serialPort1.WriteLine("$On");
                Apagado.BackColor = Color.LimeGreen;
                Apagado.Text = "ON";
                BotonApagar.Enabled = true;
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }
        }

        private void Control1_Load(object sender, EventArgs e)
        {
            try
            {
                BotonApagar.Enabled = false;
                serialPort1.PortName = ("COM1"); //puerto donde se conecto el arduino
                serialPort1.Open();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
          
        }

        private void Control1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }
        }

        private void BotonApagar_Click(object sender, EventArgs e)
        {
            try
            {
                //Enviar codigo al arduino
                //serial.println("$On");
                serialPort1.WriteLine("$Off");
                Apagado.BackColor = Color.Red;
                Apagado.Text = "OFF";
                BotonApagar.Enabled = false;
                BotonEncender.Enabled = true;
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }
    }
}
