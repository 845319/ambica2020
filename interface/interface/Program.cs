using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{

    interface Ihello
    {
        void getit();
    }
    class Doit : Ihello
    {
        public void getit()
        {
            Console.WriteLine("hello");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Doit d = new Doit();
            d.getit();
        }
    }
}
