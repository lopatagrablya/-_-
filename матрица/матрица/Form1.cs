using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace матрица
{
    public partial class Form1 : Form

    {
        private int rowCount;
        private int colCount;
        private int[,] matrix1;
        private int[,] matrix2;
        private int[,] sumMatrix;
        int counter1 = 0;
        int counter2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //rowCount = (int)numericUpDown1.Value;
            //colCount = (int)numericUpDown2.Value;

            //dataGridView1.RowCount = rowCount;
            //dataGridView1.ColumnCount = colCount;

            //dataGridView2.RowCount = rowCount;
            //dataGridView2.ColumnCount = colCount;

            //sumMatrix = new int[rowCount, colCount];
            //dataGridView3.RowCount = rowCount;
            //dataGridView3.ColumnCount = colCount;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            matrix1 = ReadMatrixFromDataGridView(dataGridView1);
            matrix2 = ReadMatrixFromDataGridView(dataGridView2);

            
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            
            DisplayMatrixInDataGridView(sumMatrix, dataGridView3);
        }
        private int[,] ReadMatrixFromDataGridView(DataGridView dataGridView)
        {
            int[,] matrix = new int[rowCount, colCount];
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    matrix[i, j] = int.Parse(dataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            return matrix;
        }
        private void DisplayMatrixInDataGridView(int[,] matrix, DataGridView dataGridView)
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            buttonnnn();
        }

        private void buttonnnn()
        {
            rowCount = (int)numericUpDown1.Value;
            colCount = (int)numericUpDown2.Value;

            dataGridView1.RowCount = rowCount;
            dataGridView1.ColumnCount = colCount;

            dataGridView2.RowCount = rowCount;
            dataGridView2.ColumnCount = colCount;

            sumMatrix = new int[rowCount, colCount];
            dataGridView3.RowCount = rowCount;
            dataGridView3.ColumnCount = colCount;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            buttonnnn();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //    
            //    counter1++;
            //    
            //    if (counter1 == rowCount * colCount)
            //    {
            //        
            //        button2_Click(sender, e);
            //    }
            //}
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //    
            //    counter2++;
            //    
            //    if (counter2 == rowCount * colCount)
            //    {
            //        
            //        button2_Click(sender, e);
            //    }
            //}
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
