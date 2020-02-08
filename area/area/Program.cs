using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area
{
    class Program
    {
        public static double mydel(double b,double h)
        {
            return 0.5 * b * h;
        }
        static void Main(string[] args)
        {
            Func<double, double, double> value = mydel;
            Console.WriteLine(value(1, 2));
        }
    }
}
