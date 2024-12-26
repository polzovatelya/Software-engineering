using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Вариант7
/*
 Составить программу по объектно-ориентированной методике.
В программе должно быть не менее двух классов, связанных отношением наследования.
Все массивы – динамические. Наличие конструктора – обязательно. 
Если целочисленная квадратная матрица симметрична относительно главной диагонали,
обнулить все элементы, лежащие выше главной диагонали.
 */



namespace lab2
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

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Procedure b = new Procedure(3) { rows = 3 };
            b.SetMatrix(b);


           


        }
    }
}
