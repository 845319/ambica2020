using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dell
{
    class Program
    {
        public delegate void Mydelg(string s);
        static void Main(string[] args)
        {
            Mydelg del = a => Console.WriteLine(a);
            del("hello");

        }
    }
}
