using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace sl
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList slist = new SortedList();
            slist.Add("ambica",253);
            slist.Add("teju", 5685);
            slist.Add("dssnf", 6554);
            slist.Add("hgyif", 44984);
            foreach(string i in slist.Keys)
            {
                Console.WriteLine(i);
            }
            foreach(int v in slist.Values)
            {
                Console.WriteLine(v);
            }
        }
    }
}
