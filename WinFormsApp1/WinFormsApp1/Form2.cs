using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k1 = Convert.ToInt32(textBox1.Text);
            int k2 = Convert.ToInt32(textBox2.Text);

            int gip = k1 * k1 + (k2 * k2);
            float result = (float)Math.Sqrt(gip);
            textBox3.Text = "1й катет = " + k1 + ",  2й катет = " + k2 + ",  Гипотенуза = " + result.ToString();


        }
    }
}
