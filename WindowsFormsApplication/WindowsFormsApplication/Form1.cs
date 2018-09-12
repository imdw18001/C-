using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname;
            string lname;
            string ename;

            fname = textBox1.Text;
            lname = textBox2.Text;
            ename = textBox3.Text;
            MessageBox.Show("Welcome "+fname+" "+lname);
            
        }
    }
}
