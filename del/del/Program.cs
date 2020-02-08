using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace del
{
    class Program
    {

        public delegate string mydel(int x, int y);
        static void Main(string[] args)
        {
            mydel delg = new mydel(Add);
            Console.WriteLine(delg(12, 25));
            delg += new mydel(Subtract);
            Console.WriteLine(delg(12, 25));
            delg -= new mydel(Subtract);
            Console.WriteLine(delg(20, 50));
        }
        static string Add(int x, int y)
        {
            int z = x + y;
            return string.Format("{0}+{1}={2}", x, y, z);
        }
        static string Subtract(int x,int y)
        {
            int z = x - y;
            return string.Format("{0}-{1}={2}", x, y, z);
        }
       
    }
}
  