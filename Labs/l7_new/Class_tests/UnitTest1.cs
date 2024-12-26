using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;

namespace Class_tests
{
    [TestClass]
    public class UnitTest1
    {   
        public struct elem
        {
            public string name_t;
            public string name_k;
            public int win;
        }

        [TestMethod]
        public void TestMethod1()
        {
            int k = 0;
            Elem element1=new Elem(3);
            k = element1.lst1.Count();
            Assert.AreEqual(k, 3);
        }
        [TestMethod]
        public void TestMethod2()
        {
            List_prosedure element1 = new List_prosedure(3);
            double sl = element1.Sred(element1.lst1);
            double k = 0;
            for (int i = 0;i<element1.lst1.Count;i++)
            {
                k += element1.lst1[i].win;
            }
            k = k / element1.lst1.Count();
            Assert.AreEqual(k, sl);


        }
    }
}