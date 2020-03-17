using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[] { 55, 56, 57, 52, 58 };

            for (int i = 0; i <= marks.Length- 1; i++)
            {
                Console.WriteLine("{0}", marks[i]);
            }
        }
    }
}
