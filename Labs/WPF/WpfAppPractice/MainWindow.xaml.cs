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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppPractice
{
    public struct elem
    {
        public String name_k;
        public String name_t;
        public int win;
    }
    public partial class MainWindow : Window
    {
        public static int count = 1;
        public static List<elem> lst1;
        public static String team = "";
        public static String nwin = "";
        List<elem> list = new List<elem>();
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            //Close();
           // Person tmp;
           // tmp = (Person)dG1.SelectedItem;
           // tmp.age += 1;
           // dG1.ItemsSource = null;
           // dG1.ItemsSource = list;


        }

        private void add_but_Click(object sender, RoutedEventArgs e)
        {
            elem el;
            el = new elem();
            if (text_komand.Text != "")
            {
                el.name_k = text_komand.Text;
            }
            else
            {
                el.name_k = "NO name_komand";
            }
            if (text_trener.Text != "")
            {
                el.name_t = text_trener.Text;
            }
            else
            {
                el.name_t = "NO name_trener";
            }
            if (text_win.Text != "")
            {
                el.win = Convert.ToInt32(text_win.Text);
            }
            else
            {
                el.win = 0;
            }
            if (index.Text != "")
            {
                int ind = Convert.ToInt32(index.Text);
                lst1.Insert(ind, el);
            }
            else
            {
                lst1.Add(el);
            }
        }
        private void left_Click(object sender, EventArgs e)
        {
            right.IsEnabled = true;

            if ((index.Text != "") & (index.Text != "0"))
            {
                int ind = Convert.ToInt32(index.Text) - 1;
                text_komand.Text = lst1[ind].name_k;
                text_trener.Text = lst1[ind].name_t;
                text_win.Text = Convert.ToString(lst1[ind].win);
                index.Text = Convert.ToString(ind);
            }
            else
            {
                left.IsEnabled = false;
            }
        }
        private void right_Click(object sender, EventArgs e)
        {
            left.IsEnabled = true;
            if (index.Text != "")
            {
                int ind = Convert.ToInt32(index.Text) + 1;
                if (ind != lst1.Count)
                {
                    text_komand.Text = lst1[ind].name_k;
                    text_trener.Text = lst1[ind].name_t;
                    text_win.Text = Convert.ToString(lst1[ind].win);
                    index.Text = Convert.ToString(ind);
                }
                else
                {
                    right.IsEnabled = false;
                }
            }
            else
            {
                text_komand.Text = lst1[0].name_k;
                text_trener.Text = lst1[0].name_t;
                text_win.Text = Convert.ToString(lst1[0].win);
            }
        }
        private void redact_Click(object sender, EventArgs e)
        {
            elem el = new elem();
            if (index.Text != "")
            {
                el.name_t = text_trener.Text;
                el.name_k = text_komand.Text;
                el.win = Convert.ToInt32(text_win.Text);
                lst1[Convert.ToInt32(index.Text)] = el;
            }
            else
            {
                index.Text = "0";
                el.name_t = text_trener.Text;
                el.name_k = text_komand.Text;
                el.win = Convert.ToInt32(text_win.Text);
                lst1[Convert.ToInt32(index.Text)] = el;
            }
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
