using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            scale s = new scale();
            s.In = 50;
            Console.WriteLine("{0}", s.In);
            s.Show();
        }
    }
}