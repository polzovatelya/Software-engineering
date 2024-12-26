namespace LAB4
{
    partial class SDI_Input
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.send = new System.Windows.Forms.Button();
            this.rows = new System.Windows.Forms.TextBox();
            this.cols = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(456, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.send.Location = new System.Drawing.Point(327, 334);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(153, 51);
            this.send.TabIndex = 1;
            this.send.Text = "Отправить";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // rows
            // 
            this.rows.Location = new System.Drawing.Point(651, 59);
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(137, 22);
            this.rows.TabIndex = 2;
            this.rows.Text = "0";
            this.rows.TextChanged += new System.EventHandler(this.rows_TextChanged);
            // 
            // cols
            // 
            this.cols.Location = new System.Drawing.Point(655, 96);
            this.cols.Name = "cols";
            this.cols.Size = new System.Drawing.Size(132, 22);
            this.cols.TabIndex = 3;
            this.cols.TabStop = false;
            this.cols.Text = "0";
            this.cols.TextChanged += new System.EventHandler(this.cols_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(507, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Строки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(507, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Столбцы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(516, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Интервал";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(512, 218);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(86, 22);
            this.start.TabIndex = 7;
            this.start.TextChanged += new System.EventHandler(this.start_TextChanged);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(623, 220);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(89, 22);
            this.stop.TabIndex = 8;
            this.stop.TextChanged += new System.EventHandler(this.stop_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "От";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "До";
            // 
            // SDI_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cols);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.send);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SDI_Input";
            this.Text = "SDI_Input";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.send, 0);
            this.Controls.SetChildIndex(this.rows, 0);
            this.Controls.SetChildIndex(this.cols, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.start, 0);
            this.Controls.SetChildIndex(this.stop, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox rows;
        private System.Windows.Forms.TextBox cols;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox start;
        private System.Windows.Forms.TextBox stop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}