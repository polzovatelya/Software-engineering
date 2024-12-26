using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class List_prosedure : Elem
    {
        public static int count = 0;
        public List_prosedure(int count=1)
        {
            elem el = new elem();
            el.name_t = "Trener";
            el.name_k = "Komanda";
            el.win = 1;
            for (int i = 0; i < count; i++)
            {
                lst1.Add(el);
            }
        }
        public void Add(List<elem> lst1, elem el)
        {
            lst1.Add(el);
        }
        public void Edit(List<elem> lst1, int index, elem el)
        {
            if (index >= 0 && index < lst1.Count)
            {
                lst1[index] = el;
            }
        }
        public void Delete(List<elem> lst1, int index)
        {
            if (index >= 0 && index < lst1.Count)
            {
                lst1.RemoveAt(index);
            }
            
        }
        public double Sred(List<elem> lst1)
        {
            double aver = lst1.Average(item => item.win);
            return aver;
        }

    }
}