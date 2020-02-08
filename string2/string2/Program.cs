using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string2
{
    class Program
    { 
        public string firstname(string str1)
        {
           
            str1 = "ambica";
            return str1;
        }
        public string lastname(string str2)
        {
            str2 = "kalyani";
            return str2;
        }

        static void Main(string[] args)
        {
            string str;
            string str1;
            string str2;
            Program p = new Program();

            str = String.Concat(str1, str2);


        }
    }
}
