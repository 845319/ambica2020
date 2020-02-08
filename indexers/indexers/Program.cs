using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            {
                var stringcol = new generic<string>();
                stringcol[0] = "this is a Indexer demo";
                Console.WriteLine(stringcol[0]);
                var stdetails = new generic<student>();
                stdetails[0] = new student
                {
                    ID = 985,
                    stname = "ambica",
                    course = "c#",
                };
                stdetails[1] = new student
                {
                    ID = 555,
                    stname = "kalyani",
                    course = "c",
                };
                Console.WriteLine("{0}\t{1}\t{2}\t", stdetails[0].ID, stdetails[0].stname, stdetails[0].course);
                Console.WriteLine("{0}\t{1}\t{2}\t", stdetails[1].ID, stdetails[1].stname, stdetails[1].course);
            }
        }
    }
}
