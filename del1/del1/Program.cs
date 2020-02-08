using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace del1
{
    class Program
    {
        public delegate void deleventhandler();
        public static event deleventhandler handler;

        static void Main(string[] args)
        {
            handler += new deleventhandler(square);
            handler += new deleventhandler(circle);
            handler.Invoke();
        }
        static void circle()
        {
            double r = 12.5;
            double ar = Math.PI * r * r;
            Console.WriteLine("circle area {0}", ar);
        }
        static void square()
        {
            int s = 5;
            int a = 5 * 5;
            Console.WriteLine("square {0}", a);
        }
    }
}
