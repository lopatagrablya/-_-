using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double a) &&
                double.TryParse(textBox2.Text, out double b))
            {
                double y = a + b;

                textBox3.Text = y.ToString();

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double a) &&
                double.TryParse(textBox2.Text, out double b))
            {
                double y = a / b;

                textBox3.Text = y.ToString();

            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double a) &&
                double.TryParse(textBox2.Text, out double b))
            {
                double y = a * b;

                textBox3.Text = y.ToString();

            }
        }
    }
}
