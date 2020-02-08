using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str4
{
    class Program
    {

        static void Main(string[] args)
        {
            string str1 = "Ambica is a good girl";
            string str2 = "kalyani is also a good girl";

            string[] d =  str1.Split();
            string[] e = str2.Split();

            foreach(string s in d)
            {
                Console.WriteLine(s);
            }
            foreach(string s in e)
            {
                Console.WriteLine(s);
            }
        
        }
    }
}
