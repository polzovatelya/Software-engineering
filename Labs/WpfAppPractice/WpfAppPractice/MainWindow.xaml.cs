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
    class Person
    {
        public string name { get; set; }

        public int age { get; set; }
    }
    public partial class MainWindow : Window
    {
        List<Person> list = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            Person person = new Person();
            person.name = "Ivanov";
            person.age = 25;
            list.Add(person);
            dG1.ItemsSource = list;
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            //Close();
            Person tmp;
            tmp = (Person)dG1.SelectedItem;
            tmp.age += 1;
            dG1.ItemsSource = null;
            dG1.ItemsSource = list;


        }
    }
}
