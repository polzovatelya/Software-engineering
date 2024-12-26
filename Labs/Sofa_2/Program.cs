using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sofa_2
{
    class Create
    {
        public int rows { get; set; }
        public int[,] matrix { get; set; }

        public Create(int rows)
        {
            matrix = new int[rows, rows];

        }
        public void SetMatrix(Create item)
        {
            for (int i = 0; i < item.matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < item.matrix.GetLength(1); j++)
                {
                    Console.Write("Введите [" + i + "," + j + "] элемент - ");
                    item.matrix[i, j] = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }
        }
        public void GetMatrix(Create item)
        {

            for (int i = 0; i < item.matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < item.matrix.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,10:0.##}", item.matrix[i, j]));
                }
                Console.WriteLine();
            }
        }
    }

    class Procedure : Create
    {
        public Procedure(int rows) : base(rows)
        {
        }
        public int[] Maxx(Procedure item)
        {
            double maxx = item.matrix[0, 0];
            int[] mas2;
            mas2 = new int[2];
            for (int i = 0; i < item.matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (maxx <= item.matrix[i, j])
                    {
                        maxx = item.matrix[i, j];
                        mas2[0] = i; mas2[1] = j;
                    }
                }
            }
            Console.WriteLine("Максимальный элемент =" + maxx + "; i=" + mas2[0] + "; j=" + mas2[1]);
            return mas2;

        }
        public int Summ(int rows,int col, int [,] matrix)
        {
           int summ = 0; int summ1 = 0;
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                summ += matrix[rows, i];
                summ1 += matrix[i, col];
            }
            return summ + summ1;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Procedure b = new Procedure(2) { rows = 2 };
            b.SetMatrix(b);
            b.GetMatrix(b);
            int[] mas2;
            mas2 = new int[2];
            mas2 = b.Maxx(b);
            int summ = 0;
            if (mas2[0] < mas2[1])
            {
                summ = b.Summ(mas2[0], mas2[1], b.matrix);
                Console.WriteLine("Сумма по строке и столбцу = " + b.Summ(mas2[0], mas2[1], b.matrix));
            }
            else
            {
                Console.WriteLine("Максимальный элемент ниже или на диагонали.");
            }





        }
    }
}

