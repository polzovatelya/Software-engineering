using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
namespace ClassLibrary1
{
    public class Elem
    {
        public struct elem
        {
            public String name_k;
            public String name_t;
            public int win;
        }
        public List<elem> lst1;
        public static int count;

        public Elem(int count=1)
        {
            lst1 = new List<elem>();
            elem el = new elem();
            el.name_t = "Trener";
            el.name_k = "Komanda";
            el.win = 2;
            for (int i = 0; i < count; i++)
            {
                lst1.Add(el);
            }
        }
        public List<elem> getlist()
        {
            return lst1;
        }
    }
}