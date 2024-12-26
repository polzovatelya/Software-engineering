using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Cla
    {
        protected double[] mas1;
        protected double y1;
        public List<elem> lst1;

        public Cla()
        {
            this.lst1 = new List<elem>();
        }

        public void SetList(string str, byte age)
        {

            this.lst1.Add(new elem() { Name = str, Age = age });
        }

        public void SetMas(int n)
        {
            this.mas1 = new double[n];
            for (int i = 0; i < n; i++)
            {
                mas1[i] = (double)(i - 2);
            }
        }
        public void SortList()
        {
            lst1.Sort(delegate (elem x, elem y)
            {
                if (x == null && y == null) return 0;
                else if (x == null) return -1;
                else if (y == null) return 1;
                else
                    return x.Age.CompareTo(y.Age);
            }
            );
        }

        public int PositiveMasElem()
        {
            int counter = 0;
            for (int i = 0; i < mas1.Length; i++)
            {
                if (mas1[i] >= 0)
                {
                    counter += 1;
                }
            }
            return counter;
        }
    }

    public class elem
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public int CompareTo(object obj)
        {
            if ((obj == null) || (!(obj is elem)))
                return 0;
            else
                return string.Compare(Name, ((elem)obj).Name);
        }
    }

    public class clb : Cla
    {
        protected int s1;

        public clb(int s)
        {
            this.y1 = s; 
        }

        public bool g1(double number)
        {
            if (number < y1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}