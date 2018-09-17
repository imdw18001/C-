using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationpraaaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, result;  //declared two double 
            string n1, n2;
            n1 = textBox1.Text;
            n2 = textBox2.Text;

            num1 = double.Parse(n1);
            num2 = double.Parse(n2);

            result = num1 - num2;

            MessageBox.Show("subtraction is" + result);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
