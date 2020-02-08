using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            pro p = new pro();
            p.Hours = 15;
            Console.WriteLine("hours {0}", p.Hours);
            p.showSeconds();
           

        }
    }
}
