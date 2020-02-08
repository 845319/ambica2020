using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskfunc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<pre> lst = new List<pre>
            {
                new pre{Id=354,Sname="Ambica",course="c#"},
                new pre{Id=348,Sname="teja",course="c#"},
                new pre{Id=351,Sname="vish",course="c#"},
            };

            foreach (var s in lst)
            {
                Console.WriteLine("{0}\t{1}\t{2}", s.Id, s.Sname, s.course);
            }

            lst.Sort((a, b) => a.Id.CompareTo(b.Id));

            foreach(var s in lst)
            {
                Console.WriteLine("{0}\t{1}\t{2}", s.Id, s.Sname, s.course);
            }
            
        }
    }
}
