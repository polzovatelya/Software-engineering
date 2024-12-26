namespace LAB4
{
    partial class SDI_Proc
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
            this.Cuntstr = new System.Windows.Forms.CheckBox();
            this.q = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Cuntstr
            // 
            this.Cuntstr.AutoSize = true;
            this.Cuntstr.Checked = true;
            this.Cuntstr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cuntstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cuntstr.Location = new System.Drawing.Point(30, 34);
            this.Cuntstr.Name = "Cuntstr";
            this.Cuntstr.Size = new System.Drawing.Size(722, 20);
            this.Cuntstr.TabIndex = 0;
            this.Cuntstr.Text = "Определить номера столбцов, сумма элементов в которых находится в заданном интерв" +
    "але";
            this.Cuntstr.UseVisualStyleBackColor = true;
            this.Cuntstr.CheckedChanged += new System.EventHandler(this.Cuntstr_CheckedChanged);
            // 
            // q
            // 
            this.q.AutoSize = true;
            this.q.Checked = true;
            this.q.CheckState = System.Windows.Forms.CheckState.Checked;
            this.q.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q.Location = new System.Drawing.Point(30, 249);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(687, 20);
            this.q.TabIndex = 1;
            this.q.Text = "Выяснить, имеются ли в заданном массиве больше половины положительных элементов";
            this.q.UseVisualStyleBackColor = true;
            this.q.CheckedChanged += new System.EventHandler(this.q_CheckedChanged);
            // 
            // SDI_Proc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.q);
            this.Controls.Add(this.Cuntstr);
            this.Name = "SDI_Proc";
            this.Text = "SDI_Proc";
            this.Controls.SetChildIndex(this.Cuntstr, 0);
            this.Controls.SetChildIndex(this.q, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Cuntstr;
        private System.Windows.Forms.CheckBox q;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}