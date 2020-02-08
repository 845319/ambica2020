using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arr1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 11, 12, 13, 14, 15, 16 };
            int Adds(int[] a)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        Console.WriteLine(arr[i] );
                    }

                }
            }

        }
    }
}
