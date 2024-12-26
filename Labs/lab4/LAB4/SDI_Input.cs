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
    public partial class SDI_Input : Form1
    {
        public SDI_Input()
        {
            InitializeComponent();
        }
        public static double[,] matrix;
        public static double[] interval = {0, 100 };
        private static int row = 0;
        private static int c = 0;
        private void rows_TextChanged(object sender, EventArgs e)
        {   if (rows.Text.Length == 0)
            {
                row = 1;
            }
            else
            {
                row = int.Parse(rows.Text);
            }
            dataGridView1.RowCount = row;

        }

        private void cols_TextChanged(object sender, EventArgs e)
        {   if (cols.Text == "")
            {
                c = 1;
            }
            else {
                c = int.Parse(cols.Text);
            }
           
            dataGridView1.ColumnCount = c;
        }

        private void send_Click(object sender, EventArgs e)
        {
            matrix = new double[row, c];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dataGridView1[j, i].Value);
                }
            }
            result += Convert.ToString(flag1) + " ";
            result += Convert.ToString(flag2) + " " + Environment.NewLine;
            if (flag1)
            { 
                result += "Номера столбцов: ";
                for (int i = 0; i < row; i++)
                {
                    double summ = 0;
                    for (int j = 0; j < c; j++)
                    {
                        summ += matrix[j, i];
                    }
                    if ((summ > interval[0]) & (summ < interval[1]))
                    {
                        result += "[" + Convert.ToString(i) + "] =" + Convert.ToString(summ)+ " ";
                    }
                }
                result += Environment.NewLine;
            }
            else
            {
                result += "Номера столбцов не проверялись";
                result += Environment.NewLine;
            }
            if (flag2)
            {
                int count = 0;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        if (matrix[j, i] > 0)
                        {
                            count += 1;
                        }
                    }
                }
                if (count > (row+c)/2)
                {
                    result += "Положительных элементов больше половины.";
                    result += Environment.NewLine;
                }
                else
                {
                    result += "Положительных элементов меньше половины.";
                    result += Environment.NewLine;
                }
            }
            else
            {
                result += "Элементы не проверялись";
                result += Environment.NewLine;
            }
        }
        

        private void start_TextChanged(object sender, EventArgs e)
        {   
            if (start.Text != "")
            {
                interval[0] = double.Parse(start.Text);
            }
        }

        private void stop_TextChanged(object sender, EventArgs e)
        {
            if (stop.Text != "")
            {
                interval[1] = 100;
            }
        }
    }
}
