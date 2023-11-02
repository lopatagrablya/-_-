namespace WinFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 24);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 7;
            label3.Text = "Исходные данные";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 52);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 8;
            label1.Text = "Начальная скорость";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 85);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 9;
            label2.Text = "Ускорение";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 116);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 10;
            label4.Text = "Время";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(165, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 13;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyUp += textBox3_KeyUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 220);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 14;
            label5.Text = "Конечная скорость";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 262);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 15;
            label6.Text = "Расстояние";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(165, 212);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(165, 259);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 192);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 18;
            label7.Text = "Результат";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 332);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
    }
}