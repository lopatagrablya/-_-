namespace WinFormsApp1
{
    partial class Form5
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
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label5 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 9;
            label4.Text = "Данные для расчета";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(48, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 84);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 14;
            label2.Text = "В = ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 49);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 13;
            label1.Text = "А = ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 129);
            label3.Name = "label3";
            label3.Size = new Size(170, 15);
            label3.TabIndex = 17;
            label3.Text = "Выберите варииаты расчетов";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(17, 165);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Y = A + B";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(17, 205);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(73, 19);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "Y = A / B";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(17, 244);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(70, 19);
            checkBox3.TabIndex = 20;
            checkBox3.Text = "Y = A *B";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 294);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 21;
            label5.Text = "Результат";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(17, 326);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(241, 105);
            textBox3.TabIndex = 22;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 443);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label5;
        private TextBox textBox3;
    }
}