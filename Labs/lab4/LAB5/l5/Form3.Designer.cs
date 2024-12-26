namespace l5
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
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.komanda = new System.Windows.Forms.TextBox();
            this.trener = new System.Windows.Forms.TextBox();
            this.win = new System.Windows.Forms.TextBox();
            this.ind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(34, 287);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(149, 41);
            this.add.TabIndex = 0;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(223, 287);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(173, 40);
            this.edit.TabIndex = 1;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(430, 287);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(163, 39);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // komanda
            // 
            this.komanda.Location = new System.Drawing.Point(40, 161);
            this.komanda.Multiline = true;
            this.komanda.Name = "komanda";
            this.komanda.Size = new System.Drawing.Size(142, 41);
            this.komanda.TabIndex = 3;
            // 
            // trener
            // 
            this.trener.Location = new System.Drawing.Point(230, 164);
            this.trener.Multiline = true;
            this.trener.Name = "trener";
            this.trener.Size = new System.Drawing.Size(165, 37);
            this.trener.TabIndex = 4;
            // 
            // win
            // 
            this.win.Location = new System.Drawing.Point(428, 165);
            this.win.Multiline = true;
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(164, 36);
            this.win.TabIndex = 5;
            // 
            // ind
            // 
            this.ind.Location = new System.Drawing.Point(636, 165);
            this.ind.Multiline = true;
            this.ind.Name = "ind";
            this.ind.Size = new System.Drawing.Size(66, 36);
            this.ind.TabIndex = 6;
            this.ind.TextChanged += new System.EventHandler(this.ind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Команда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(231, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Тренер";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(426, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Победы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(636, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "№ елемента";
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.DarkSalmon;
            this.left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.left.Cursor = System.Windows.Forms.Cursors.Default;
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.left.Location = new System.Drawing.Point(523, 220);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(95, 38);
            this.left.TabIndex = 11;
            this.left.Text = "left";
            this.left.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.left.UseMnemonic = false;
            this.left.UseVisualStyleBackColor = false;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.Coral;
            this.right.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.right.Location = new System.Drawing.Point(635, 220);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(93, 37);
            this.right.TabIndex = 12;
            this.right.Text = "right";
            this.right.UseVisualStyleBackColor = false;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(45, 36);
            this.trackBar1.Maximum = 15;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(263, 56);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ind);
            this.Controls.Add(this.win);
            this.Controls.Add(this.trener);
            this.Controls.Add(this.komanda);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form3";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Controls.SetChildIndex(this.add, 0);
            this.Controls.SetChildIndex(this.edit, 0);
            this.Controls.SetChildIndex(this.delete, 0);
            this.Controls.SetChildIndex(this.komanda, 0);
            this.Controls.SetChildIndex(this.trener, 0);
            this.Controls.SetChildIndex(this.win, 0);
            this.Controls.SetChildIndex(this.ind, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.left, 0);
            this.Controls.SetChildIndex(this.right, 0);
            this.Controls.SetChildIndex(this.trackBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox komanda;
        private System.Windows.Forms.TextBox trener;
        private System.Windows.Forms.TextBox win;
        private System.Windows.Forms.TextBox ind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}