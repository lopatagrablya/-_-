namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ������1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
        }

        private void ������2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 secondForm = new Form3();
            secondForm.Show();
        }

        private void ������3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 secondForm = new Form4();
            secondForm.Show();
        }

        private void ������4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 secondForm = new Form5();
            secondForm.Show();
        }
    }
}