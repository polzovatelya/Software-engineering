using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private static int window1 = 0;
        
        public static String result = " ";
        public static bool flag1 = true;
        public static bool flag2 =true;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SDI_Input input = new SDI_Input();
            input.Show();
        }

        private void outputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SDI_Output output = new SDI_Output();
            output.Show();
        }

        private void procToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SDI_Proc proc = new SDI_Proc();
            proc.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show(this);
        }
    }
}
