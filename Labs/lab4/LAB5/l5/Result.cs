using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace l5
{
    public partial class Result : Form1
    {
        int count = 0;
        public Result()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            team = "";
            double aver = lst1.Average(item => item.win);
            for (int i = 0; i < lst1.Count; i++)
            {
                if (lst1[i].win < aver)
                {
                    count++;
                    team += lst1[i].name_k + " " + lst1[i].name_t + "\n";

                }
            }
            int kol1 = lst1.Where(q => q.win == 0).Count();
            if (kol1 > 0)
            {
                nwin = Convert.ToString(kol1);
            }
            else
            {
                nwin = "Таких нет!";
            }

            kom.Text = team;
            no_win.Text = nwin;


        }
    }
}
