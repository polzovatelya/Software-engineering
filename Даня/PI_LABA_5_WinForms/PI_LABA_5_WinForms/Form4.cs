using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_LABA_5_WinForms
{
    public partial class Form4 : Form

    {
        Form2 inputform_;
        public Form4(Form2 InputForm)
        {
            InitializeComponent();
            inputform_ = InputForm;
            int gg = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t = 5;

            Form2.Country countryBest = inputform_.countries.OrderByDescending(c=>c.Population).First();

            // Выводим результат (или используем его в коде)
            MessageBox.Show($"Страна с самым длинным пляжем: {countryBest.Name}");



        }
    }
}
