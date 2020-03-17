using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Right;

namespace Lib
{
    class Program
    {
        static void Main(string[] args)
        {
            Up u = new Up();
            int No1 = 10;
            int No2 = 20;
            int result = u.Addition(No1, No2);
            int result1 = u.Sub(No1, No2);
            int result2 = u.Mul(No1, No2);
            Console.WriteLine("{0}", result);
            Console.WriteLine("{0}", result1);
            Console.WriteLine("{0}", result2);
        }
    }
}
