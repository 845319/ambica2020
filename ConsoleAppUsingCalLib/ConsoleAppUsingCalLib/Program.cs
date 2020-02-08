using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibCalculation;

namespace ConsoleAppUsingCalLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.No1 = 40;
            c.No2 = 20;
            Console.WriteLine(c.Add());
            Console.WriteLine(c.Difference());
            Console.WriteLine(c.Mul());
        }
    }
}
