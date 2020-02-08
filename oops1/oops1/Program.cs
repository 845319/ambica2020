using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class Program
    {
        private static void Main(string[] args)
        {
            cal c = new cal();
            Console.WriteLine(c.area(12));
            Console.WriteLine(c.area(12, 14));
            Console.WriteLine(c.area(60.8));
            Console.WriteLine(c.area(10.2,53));



        }
    }
}
