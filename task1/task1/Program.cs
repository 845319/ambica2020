using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            exam e = new exam();
            e.GetData("Ambica", "emp845319", "Chennai", 50);
            e.ShowData();
        }
    }
}
