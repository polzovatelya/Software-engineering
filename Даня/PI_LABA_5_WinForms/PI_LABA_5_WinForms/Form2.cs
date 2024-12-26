using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_LABA_5_WinForms
{
    public partial class Form2 : Form
    {
         public List<Country> countries { get; set; }  // Список стран
        private Country selectedCountry; // Текущая выбранная страна
        private Form dataGridForm;
        private Country anycountry;
        public Form2()
        {
            InitializeComponent();
            countries = new List<Country>()
            {
                new Country("Россия", 1466.2),
                new Country("Китай", 1443.5),
                new Country("Индия", 1380.0),
                new Country("США", 331.0),
                new Country("Индонезия", 273.5)

            };
            anycountry = new Country("-----", -100000);

            // Настраиваем ListView
            listView1.View = View.Details;
            listView1.Columns.Add("Страна", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Длина береговой линии (т км)", 150);
            listView1.DoubleClick += ListView1_DoubleClick;
            listView1.AfterLabelEdit += ListView1_AfterLabelEdit;
            // Добавляем элементы в ListView
            foreach (Country country in countries)
            {
                ListViewItem item = new ListViewItem(country.Name);
                item.SubItems.Add(country.Population.ToString());
                listView1.Items.Add(item);
            }
            listView1.FullRowSelect = true;
            listView1.LabelEdit = true;

            Button AddButton = new Button();
            AddButton.Text = "добавить";
            AddButton.Location = new Point(400, 300);
            AddButton.Click += AddButton_Click;
            this.Controls.Add(AddButton);


        }

        //public  List<Country> GetCountries() { 
        //    return countries;
        //}
       
        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
           
            ListViewItem selectedItem = listView1.SelectedItems[0];

           
            selectedCountry = countries.FirstOrDefault(c => c.Name == selectedItem.Text);

            
            if (selectedCountry != null)
            {
                
                if (dataGridForm != null && !dataGridForm.IsDisposed)
                {
                    dataGridForm.Close();
                }

                
                dataGridForm = new Form();
                dataGridForm.Text = "Редактирование страны";
                dataGridForm.Size = new Size(400, 200);


                Button saveButton2 = new Button();
                saveButton2.Text = "Сохранить";
                saveButton2.Location = new Point(100, 100);
                saveButton2.Click += SaveButton_Click;
                dataGridForm.Controls.Add(saveButton2);

                // Создать DataGridView
                DataGridView dataGridView = new DataGridView();
                dataGridView.Dock = DockStyle.Fill;
                dataGridView.Location = new Point(10, 10);
                dataGridView.DataSource = new BindingSource(new List<Country> { selectedCountry }, null);

                // Добавить DataGridView в форму
                dataGridForm.Controls.Add(dataGridView);
                
                dataGridForm.Show();
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Получаем данные из DataGridView
            DataGridView dataGridView = (DataGridView)dataGridForm.Controls[1];
            BindingSource bindingSource = (BindingSource)dataGridView.DataSource;
            Country updatedCountry = (Country)bindingSource.Current;

            // Обновляем данные в списке стран
            int index = countries.FindIndex(c => c.Name == selectedCountry.Name);
            if (index != -1)
            {
                countries[index] = updatedCountry;
            }

            // Обновляем ListView
            UpdateListView();

            // Закрываем форму с DataGrid
            dataGridForm.Close();
        }
        private void SaveNewButton_Click(object sender, EventArgs e)
        {
            // Получаем данные из DataGridView
            DataGridView dataGridView = (DataGridView)dataGridForm.Controls[1];
            BindingSource bindingSource = (BindingSource)dataGridView.DataSource;
            Country updatedCountry = (Country)bindingSource.Current;

            // Обновляем данные в списке стран
            countries.Add(updatedCountry);

            // Обновляем ListView
            UpdateListView();

            // Закрываем форму с DataGrid
            dataGridForm.Close();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {  
                anycountry.Population = 0;
                anycountry.Name = "";

                dataGridForm = new Form();
                dataGridForm.Text = "Добавление страны";
                dataGridForm.Size = new Size(400, 200);


                Button saveButton2 = new Button();
                saveButton2.Text = "Сохранить";
                saveButton2.Location = new Point(100, 100);
                saveButton2.Click += SaveNewButton_Click;
                dataGridForm.Controls.Add(saveButton2);

                // Создать DataGridView
                DataGridView dataGridView = new DataGridView();
                dataGridView.Dock = DockStyle.Fill;
                dataGridView.Location = new Point(10, 10);
                dataGridView.DataSource = new BindingSource(new List<Country> { anycountry }, null);

                // Добавить DataGridView в форму
                dataGridForm.Controls.Add(dataGridView);

                dataGridForm.Show();
            
        }

        private void ListView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            // Если редактирование отменено (CancelEdit = true), выход
            if (e.CancelEdit) return;

            // Обновляем данные в списке стран
            Country country = countries.FirstOrDefault(c => c.Name == listView1.Items[e.Item].Text);
            if (country != null)
            {
                if (e.Item == 0) // Если редактируется название
                {
                    country.Name = e.Label;
                }
                else if (e.Item == 1) // Если редактируется население
                {
                    if (double.TryParse(e.Label, out double population))
                    {
                        country.Population = population;
                    }
                }

                // Обновляем текст в ListView
                listView1.Items[e.Item].Text = country.Name;
                listView1.Items[e.Item].SubItems[1].Text = country.Population.ToString();

                // Обновляем данные в DataGrid (если форма открыта)
                if (dataGridForm != null && !dataGridForm.IsDisposed)
                {
                    ((DataGridView)dataGridForm.Controls[0]).DataSource = new BindingSource(new List<Country> { country }, null);
                }
            }
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();
            foreach (Country country in countries)
            {
                ListViewItem item = new ListViewItem(country.Name);
                item.SubItems.Add(country.Population.ToString());
                listView1.Items.Add(item);
            }
        }

        public class Country
        {
            public string Name { get; set; }
            public double Population { get; set; }

            public Country(string name, double population)
            {
                Name = name;
                Population = population;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
