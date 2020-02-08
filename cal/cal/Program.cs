using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator cal = new calculator(10,15);
            Console.WriteLine(cal.Add());
            Console.WriteLine(cal.Pro());
            Console.WriteLine(cal.Sub());

        }
    }
}
