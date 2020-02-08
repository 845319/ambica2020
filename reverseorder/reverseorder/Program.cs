using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseorder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            Array.Reverse(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

        }
    }
}
