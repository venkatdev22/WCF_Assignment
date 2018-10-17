using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculatorService.CalculatorServiceClient client = new CalculatorService.CalculatorServiceClient("BasicHttpBinding_ICalculatorService");
            label3.Text = "Result : " + client.Add(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculatorService.CalculatorServiceClient client = new CalculatorService.CalculatorServiceClient("BasicHttpBinding_ICalculatorService");
            label3.Text = "Result : " + client.Sub(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }
    }
}
