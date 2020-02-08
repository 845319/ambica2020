using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace task
{
    class Program
    {
        static void Main(string[] args)
        {

            employee e = new employee();
           e.me1(  1, "Ambica", "PAT", 22000);
            e.me1(2, "teju", "PAT", 22000);
            e.me1(3, "vishnu", "PAT", 22000);
            e.me1(4, "Anu", "PAT", 22000);
            e.show();
            e.remove(2);
            e.show();

        }
    }
}
