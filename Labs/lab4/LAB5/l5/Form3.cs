using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l5
{
    public partial class Form3 : Form1
    {
        
        public Form3()
        {
            InitializeComponent();
            lst1 = new List<elem>();
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            if (ind.Text == ""){
                elem el = new elem();
                el.name_k = komanda.Text;
                el.name_t = trener.Text;
                el.win = Convert.ToInt32(win.Text);
                if (lst1.Contains(el)){
                    lst1.Remove(el); 
                }
            }
            else
            { int index = Convert.ToInt32(ind.Text);
                if (0 <= index && index <= (lst1.Count - 1)){
                    lst1.RemoveAt(Convert.ToInt32(ind.Text));
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lst1 = new List<elem>();

        }

        private void add_Click(object sender, EventArgs e)
        {
            elem el;
            el = new elem();
            if (komanda.Text != "") { 
                el.name_k = komanda.Text; 
            }
            else {
                el.name_k = "NO name_komand";
            }
            if (trener.Text != "")
            {
                el.name_t = trener.Text;
            }
            else
            {
                el.name_t = "NO name_trener";
            }
            if (win.Text != "")
            {
                el.win = Convert.ToInt32(win.Text);
            }
            else
            {
                el.win = 0;
            }
            if (ind.Text != "")
            {
                int index = Convert.ToInt32(ind.Text);
                lst1.Insert(index, el);
            }
            else { 
                lst1.Add(el); 
            }

        }

        private void left_Click(object sender, EventArgs e)
        {
            right.Enabled = true;

            if ((ind.Text != "")&(ind.Text != "0")){
                int index = Convert.ToInt32(ind.Text) - 1;
                komanda.Text = lst1[index].name_k;
                trener.Text = lst1[index].name_t;
                win.Text = Convert.ToString(lst1[index].win);
                ind.Text = Convert.ToString(index);
            }
            else
            {
                left.Enabled = false;
            }
        }

        private void right_Click(object sender, EventArgs e)
        {   left.Enabled = true;
            if (ind.Text != "")
            {   int index = Convert.ToInt32(ind.Text)+1;
                if (index != lst1.Count)
                {
                    komanda.Text = lst1[index].name_k;
                    trener.Text = lst1[index].name_t;
                    win.Text = Convert.ToString(lst1[index].win);
                    ind.Text = Convert.ToString(index);
                }
                else
                {
                    right.Enabled = false;
                }
            }
            else
            {
                komanda.Text = lst1[0].name_k;
                trener.Text = lst1[0].name_t;
                win.Text = Convert.ToString(lst1[0].win);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            count = trackBar1.Value;
            lst1 = new List<elem>();
            elem el = new elem();
            el.name_t = "no_name_trener";
            el.name_k = "no_name_komanda";
            el.win = 0;
            for (int i = 0; i < count; i++)
            {
                lst1.Add(el);
            }
            ind.Text = "0";
        }

        private void edit_Click(object sender, EventArgs e)
        {
            elem el = new elem();
            if (ind.Text != "")
            {
                el.name_t = trener.Text;
                el.name_k = komanda.Text;
                el.win = Convert.ToInt32(win.Text);
                lst1[Convert.ToInt32(ind.Text)] = el;
            }
            else
            {
                ind.Text = "0";
                el.name_t = trener.Text;
                el.name_k = komanda.Text;
                el.win = Convert.ToInt32(win.Text);
                lst1[Convert.ToInt32(ind.Text)] = el;
            }
        }

        private void ind_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
