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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // Привязываем обработчик события TextChanged для textBox1

        }

        private void result()
        {


            if (double.TryParse(textBox1.Text, out double v0) &&
                double.TryParse(textBox2.Text, out double a) &&
                double.TryParse(textBox3.Text, out double t))
            {
                double v = v0 + a * t;
                // Рассчитать пройденное расстояние (S)
                double s = v0 * t + 0.5 * a * t * t;

                // Отобразить результаты в соответствующих TextBox
                textBox4.Text = v.ToString();
                textBox5.Text = s.ToString();

            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            result();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            result();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            result();
        }
    }
}
