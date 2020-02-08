using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
        private static void lambdaorder()
        {
            int[] nos = { 52, 56, 25, 41, 22 };
            var sort = nos.OrderBy(x => x);
            Console.WriteLine(String.Join(" ", sort));

        }
    }
}
