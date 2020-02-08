using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("hello");
            Console.WriteLine(str);
            str.Append(2345);
            Console.WriteLine("append long values {0}", str);
            int i = str.Capacity;
            Console.WriteLine("initial capacity of string builder {0}", i);
            str.Insert(6, "world");
            Console.WriteLine("inserted at 6 id {0}", str);
            str.Remove(7, 3);
            Console.WriteLine("after removing {0}", str);
            str.Replace("lo", "arious");
            Console.WriteLine("after removing {0}", str);
                
        }
    }
}
