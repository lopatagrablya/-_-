using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (double.TryParse(textBox1.Text, out double a) &&
                double.TryParse(textBox2.Text, out double b))
                {
                    double y = a + b;

                    textBox3.Text += y.ToString() + "\r\n"; 

                }
            }
            else
            {
                textBox3.Text = textBox3.Text.Replace(textBox3.Text, "").Trim();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (double.TryParse(textBox1.Text, out double a) &&
                double.TryParse(textBox2.Text, out double b))
                {
                    double y = a / b;

                    textBox3.Text += y.ToString() +"\r\n"; 

                }
            }
            else
            {
                textBox3.Clear();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (double.TryParse(textBox1.Text, out double a) &&
                double.TryParse(textBox2.Text, out double b))
                {
                    double y = a * b;

                    textBox3.Text += y.ToString()  +"\r\n";

                }
            }
            else
            {
                textBox3.Text = textBox3.Text.Replace(textBox3.Text, "").Trim();
            }
        }
    }
}
