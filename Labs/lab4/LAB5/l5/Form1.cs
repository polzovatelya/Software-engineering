using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l5
{
    public partial class Form1 : Form
    {
        public struct elem
        {
            public String name_k;
            public String name_t;
            public int win;
        }
        public static int count = 1;
        public static List<elem> lst1;
        public static String team= "";
        public static String nwin = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();                  
            aboutBox1.ShowDialog();
        }

        private void elem_count_Scroll(object sender, EventArgs e)
        {
          
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            result.ShowDialog();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
