using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace laba6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public struct elem
        {
            public String name_k;
            public String name_t;
            public int win;
        }
        public static int count = 2;
        public static List<elem> lst1;
        public static String team = "";
        public static String nwin = "";
        public static String r = "";
        public MainWindow()
        {
            InitializeComponent();
            lst1 = new List<elem>();
            elem el = new elem();
            el.name_t = "No";
            el.name_k = "No";
            el.win = 0;
            for (int i = 0; i < count; i++)
            {
                lst1.Add(el);
                ind.Text = Convert.ToString(i);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            MessageBox.Show(menuItem.Header.ToString());
        }
        private void MenuClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void add(object sender, RoutedEventArgs e)
        {
            elem el;
            el = new elem();
            if (komanda.Text != "")
            {
                el.name_k = komanda.Text;
            }
            else
            {
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
            else
            {
                lst1.Add(el);
            }
        }

        private void edit(object sender, RoutedEventArgs e)
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

        private void delete(object sender, RoutedEventArgs e)
        {
            if (ind.Text == "")
            {
                elem el = new elem();
                el.name_k = komanda.Text;
                el.name_t = trener.Text;
                el.win = Convert.ToInt32(win.Text);
                if (lst1.Contains(el))
                {
                    lst1.Remove(el);
                }
            }
            else
            {
                int index = Convert.ToInt32(ind.Text);
                if (0 <= index && index <= (lst1.Count - 1))
                {
                    lst1.RemoveAt(Convert.ToInt32(ind.Text));
                }
            }
        }

        private void Left1(object sender, RoutedEventArgs e)
        {
            right.IsEnabled = true;

            if ((ind.Text != "") & (ind.Text != "0"))
            {
                int index = Convert.ToInt32(ind.Text) - 1;
                komanda.Text = lst1[index].name_k;
                trener.Text = lst1[index].name_t;
                win.Text = Convert.ToString(lst1[index].win);
                ind.Text = Convert.ToString(index);
            }
            else
            {
                left.IsEnabled = false;
            }
        }

        private void Right(object sender, RoutedEventArgs e)
        {
            left.IsEnabled = true;
            if (ind.Text != "")
            {
                int index = Convert.ToInt32(ind.Text) + 1;
                if (index != lst1.Count)
                {
                    komanda.Text = lst1[index].name_k;
                    trener.Text = lst1[index].name_t;
                    win.Text = Convert.ToString(lst1[index].win);
                    ind.Text = Convert.ToString(index);
                }
                else
                {
                    right.IsEnabled = false;
                }
            }
            else
            {
                komanda.Text = lst1[0].name_k;
                trener.Text = lst1[0].name_t;
                win.Text = Convert.ToString(lst1[0].win);
            }
        }

        private void MenuResult_Click(object sender, RoutedEventArgs e)
        {
            team = "Худшие команды \n";
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
            r = team + "\n" + "Команды без побед "+ "\n"+ nwin;

            new Window1(r).ShowDialog();
        }
    }
}
