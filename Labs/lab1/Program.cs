using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Вариант 7
/*
 7.	Если наибольший элемент двумерного массива A находится выше главной диагонали, 
найти сумму элементов массива, лежащих ниже главной диагонали. Считаем, что максимальный элемент – единственный.
 */

namespace lab1
{
    internal class Program
    {
        static double[,] Init(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("Введите [" + i + "," + j + "] элемент - ");
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }
            return matrix;
        }

        static void Main(string[] args)
        {
            //Создаем двумерный массив
            Console.Write("Введите количество элементов в строке (столбце):");
            int rows = Convert.ToInt32(Console.ReadLine());
            double[,] matrix = new double[rows, rows];
            matrix = Init(matrix);
            Console.WriteLine("Наша матрица:");
            PrintMatrix(matrix);
            Proc(matrix);
            
        }
        public static void Proc(double[,] matrix){
            double maxx = matrix[0, 0];
            int[] mas2;
            mas2 = new int[2];
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (maxx <= matrix[i, j])
                    {
                        maxx = matrix[i, j];
                        mas2[0] = i; mas2[1] = j;
                    }
                }
            }
            Console.WriteLine("Максимальный элемент =" + maxx + "; i=" + mas2[0] + "; j=" + mas2[1]);
            if (mas2[0] < mas2[1])
            {
                Console.WriteLine("Максимальный элемент выше главной диагонали.");
                double summ = 0;
                for (int i = 0; i < matrix.GetLength(0); ++i)
                {
                    for (int j = 0; j < i; j++)
                    {
                        summ += matrix[i, j];
                    }
                }
                Console.WriteLine("Сумма элементов ниже главной диагонали = " + summ);
            }
            else
            {
                Console.WriteLine("Максимальный элемент ниже или на диагонали.");
            }

        }
        public static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,10:0.##}", matrix[i, j]));
                }
                Console.WriteLine();
            }
        }

        public static void PrintVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; ++i)
            {
                Console.Write(String.Format("{0,10}", vector[i]));
            }
            Console.WriteLine();
        }

    }
}
