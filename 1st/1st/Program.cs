using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st
{
    class Program
    {
        static void Main(string[] args)
        {
            //getTrObj();
            Console.WriteLine();
            //getTr1Obj();
            Console.WriteLine();
            getTr2Obj();

        }

        private static void getTr2Obj()
        {
            Class1 K = new Class1();
            K.Getdata("Vishnu", "emp845392", "AP", 21);
            K.age = 23;
            K.name = "ambica";
            K.Showdata();
        }

        private static void getTr1Obj()
        {
            Class1 cl1 = new Class1();
            cl1.Getdata("Teju", "emp845302", "AP", 21);
            cl1.Showdata();
        }

        private static void getTrObj()
        {
            Class1 cl = new Class1();
            cl.Getdata("Ambica", "Emp845319", "AndhraPradesh", 21);
            cl.Showdata();
        }
    }
}
