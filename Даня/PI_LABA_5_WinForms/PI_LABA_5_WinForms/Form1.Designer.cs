namespace PI_LABA_5_WinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            окнаToolStripMenuItem = new ToolStripMenuItem();
            вводДанныхToolStripMenuItem = new ToolStripMenuItem();
            просмотрИРедToolStripMenuItem = new ToolStripMenuItem();
            выводДанныхToolStripMenuItem = new ToolStripMenuItem();
            оНашемСообществеToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, окнаToolStripMenuItem, оНашемСообществеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(109, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // окнаToolStripMenuItem
            // 
            окнаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вводДанныхToolStripMenuItem, просмотрИРедToolStripMenuItem, выводДанныхToolStripMenuItem });
            окнаToolStripMenuItem.Name = "окнаToolStripMenuItem";
            окнаToolStripMenuItem.Size = new Size(47, 20);
            окнаToolStripMenuItem.Text = "Окна";
            // 
            // вводДанныхToolStripMenuItem
            // 
            вводДанныхToolStripMenuItem.Name = "вводДанныхToolStripMenuItem";
            вводДанныхToolStripMenuItem.Size = new Size(180, 22);
            вводДанныхToolStripMenuItem.Text = "Ввод данных";
            вводДанныхToolStripMenuItem.Click += вводДанныхToolStripMenuItem_Click;
            // 
            // просмотрИРедToolStripMenuItem
            // 
            просмотрИРедToolStripMenuItem.Name = "просмотрИРедToolStripMenuItem";
            просмотрИРедToolStripMenuItem.Size = new Size(180, 22);
            просмотрИРедToolStripMenuItem.Text = "Просмотр и ред";
            // 
            // выводДанныхToolStripMenuItem
            // 
            выводДанныхToolStripMenuItem.Name = "выводДанныхToolStripMenuItem";
            выводДанныхToolStripMenuItem.Size = new Size(180, 22);
            выводДанныхToolStripMenuItem.Text = "Вывод данных";
            выводДанныхToolStripMenuItem.Click += выводДанныхToolStripMenuItem_Click;
            // 
            // оНашемСообществеToolStripMenuItem
            // 
            оНашемСообществеToolStripMenuItem.Name = "оНашемСообществеToolStripMenuItem";
            оНашемСообществеToolStripMenuItem.Size = new Size(140, 20);
            оНашемСообществеToolStripMenuItem.Text = "О нашем сообществе";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "ЛР5 Ершов";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem окнаToolStripMenuItem;
        private ToolStripMenuItem вводДанныхToolStripMenuItem;
        private ToolStripMenuItem просмотрИРедToolStripMenuItem;
        private ToolStripMenuItem выводДанныхToolStripMenuItem;
        private ToolStripMenuItem оНашемСообществеToolStripMenuItem;
    }
}
