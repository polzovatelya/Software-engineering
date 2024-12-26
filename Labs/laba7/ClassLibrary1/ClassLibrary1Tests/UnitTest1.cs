using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace ClassLibrary1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Cla num1 = new Cla();
            num1.SetMas(10);
            int k= 0;
            k = num1.PositiveMasElem();
            
            Assert.AreEqual(k, 8);
        }

        [TestMethod]
        public void TestMethod2()
        {
            clb child = new clb(12) ;
            bool flag = child.g1(13);
            Assert.AreEqual(flag, false);
        }

        [TestMethod]
        public void TestMethod3() 
            {
            Cla num1 = new Cla();
            num1.SetList("Sergei", 12);
            num1.SetList("Dima", 8);
            num1.SetList("Valera", 10);
            num1.SetList("Masha", 16);
            num1.SetList("Gleb", 14);

            int k = 8;
            bool flag = true;

            num1.SortList();

            foreach (elem person in num1.lst1)
            {
               if(person.Age != k) { flag = false; break; }
                k += 2;
            }


            Assert.AreEqual(flag, true);

        }
    }
}