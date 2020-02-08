using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace al
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList() { "Ambica", "teju", "vishnu", "sree", "Anu", "dil" };

            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.Sort();
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            al.Add("Bharat");
            al.Add("kalyani");
            al.Insert(4, "Hrithik");

            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            al.Reverse();
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            string[] r = new string[] { "cat","rat" };
            al.SetRange(4, r);

            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            al.RemoveRange(2, 2);

            Console.WriteLine();
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }

        }

    }
}
