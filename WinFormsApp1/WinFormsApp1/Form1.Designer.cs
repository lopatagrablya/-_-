namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            линейныйАлгоритмыToolStripMenuItem = new ToolStripMenuItem();
            задача1ToolStripMenuItem = new ToolStripMenuItem();
            задача2ToolStripMenuItem = new ToolStripMenuItem();
            ветвлениеToolStripMenuItem = new ToolStripMenuItem();
            задача3ToolStripMenuItem = new ToolStripMenuItem();
            задача4ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { линейныйАлгоритмыToolStripMenuItem, ветвлениеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // линейныйАлгоритмыToolStripMenuItem
            // 
            линейныйАлгоритмыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { задача1ToolStripMenuItem, задача2ToolStripMenuItem });
            линейныйАлгоритмыToolStripMenuItem.Name = "линейныйАлгоритмыToolStripMenuItem";
            линейныйАлгоритмыToolStripMenuItem.Size = new Size(142, 20);
            линейныйАлгоритмыToolStripMenuItem.Text = "Линейный алгоритмы";
            // 
            // задача1ToolStripMenuItem
            // 
            задача1ToolStripMenuItem.Name = "задача1ToolStripMenuItem";
            задача1ToolStripMenuItem.Size = new Size(121, 22);
            задача1ToolStripMenuItem.Text = "Задача 1";
            задача1ToolStripMenuItem.Click += задача1ToolStripMenuItem_Click;
            // 
            // задача2ToolStripMenuItem
            // 
            задача2ToolStripMenuItem.Name = "задача2ToolStripMenuItem";
            задача2ToolStripMenuItem.Size = new Size(121, 22);
            задача2ToolStripMenuItem.Text = "Задача 2";
            задача2ToolStripMenuItem.Click += задача2ToolStripMenuItem_Click;
            // 
            // ветвлениеToolStripMenuItem
            // 
            ветвлениеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { задача3ToolStripMenuItem, задача4ToolStripMenuItem });
            ветвлениеToolStripMenuItem.Name = "ветвлениеToolStripMenuItem";
            ветвлениеToolStripMenuItem.Size = new Size(76, 20);
            ветвлениеToolStripMenuItem.Text = "Ветвление";
            // 
            // задача3ToolStripMenuItem
            // 
            задача3ToolStripMenuItem.Name = "задача3ToolStripMenuItem";
            задача3ToolStripMenuItem.Size = new Size(180, 22);
            задача3ToolStripMenuItem.Text = "Задача 3";
            задача3ToolStripMenuItem.Click += задача3ToolStripMenuItem_Click;
            // 
            // задача4ToolStripMenuItem
            // 
            задача4ToolStripMenuItem.Name = "задача4ToolStripMenuItem";
            задача4ToolStripMenuItem.Size = new Size(180, 22);
            задача4ToolStripMenuItem.Text = "Задача 4";
            задача4ToolStripMenuItem.Click += задача4ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem линейныйАлгоритмыToolStripMenuItem;
        private ToolStripMenuItem задача1ToolStripMenuItem;
        private ToolStripMenuItem задача2ToolStripMenuItem;
        private ToolStripMenuItem ветвлениеToolStripMenuItem;
        private ToolStripMenuItem задача3ToolStripMenuItem;
        private ToolStripMenuItem задача4ToolStripMenuItem;
    }
}