using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace LAB4
{
    public partial class SDI_Proc : Form1
    {
        public SDI_Proc()
        {
            InitializeComponent();
        }
        // public static bool 
        private void Cuntstr_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox1 = (CheckBox)sender;// приводим отправителя к элементу типа CheckBox
            flag1 = checkBox1.Checked;

        }

        private void q_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox2 = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            flag2 = checkBox2.Checked;
        }
    }
}
