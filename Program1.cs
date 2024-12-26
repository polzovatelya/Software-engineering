using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

                float x1, x2;
                double y1, y2;
                y1 = 12.63;
                x1 = -89.236f; //но лучше double

                Console.WriteLine("y=");
                y1 = Convert.ToDouble(Console.ReadLine());
                y2 = Math.Exp(y1);
                Console.WriteLine("Exp= " + y2.ToString("E4"));
                Console.WriteLine("Hello World!");
                Console.ReadLine();


                int[] mas1 = { -5, 89, 8, 5 };
                int[] mas2, mas3;
                mas2 = new int[5];
                for (int i = 0; i < mas2.Length; i++)
                {
                    Console.Write("Mas[" + i + "]=");
                    mas2[i] = Int32.Parse(Console.ReadLine());
                }
                int? num = null;
                for (int i = 0; i < mas2.Length; i++)

                    if (mas2[i] > 15)
                    {
                        num = i;
                        break;
                    }
                if (num == null)
                    Console.WriteLine("NO");
                else
                    Console.WriteLine("Num= " + num);

                int sum = 0;
                foreach (int x in mas1)
                    sum += x;


            //Прямоугольные
            double[,] arr2;
            arr2 = new double[2, 3];
            for (int i = 0; i < arr2.GetLength(0); i++)
                for (int j = 0; j < arr2.GetUpperBound(1); j++)
                {
                    Console.Write(i + " " + j + " ");
                    arr2[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            int kol = 0;
            foreach (int r in arr2)
                if (r > 0) kol++;
            Console.WriteLine("Kol=" + kol);

            //Ступенчатые
            int[][] mas25;
            int n;
            mas25 = new int[3][];
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Elements in row " + i + " ");
                n = Convert.ToInt32(Console.ReadLine());
                mas25[i] = new int[n];
            
            }


            for (int i = 0; i < mas25.Length; i++)
                for (int j = 0; j < mas25.Length; j++)
                {
                    Console.Write(i + " " + j + " ");
                    mas25[i][j] = Convert.ToInt32(Console.ReadLine());
                }

        }

    }
    }

