using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> Mul = (x, y) => Console.WriteLine("{0}",x*y);
            Mul(3, 7);
            Func<int, int, double> ad = (x, y) => x + y;
            Console.WriteLine("{0}",ad(3,4));
            List<Student> lst = new List<Student>
            {
                new Student{Id=354,Sname="Ambica",course="c#"},
                new Student{Id=348,Sname="teja",course="c#"},
                new Student{Id=351,Sname="vish",course="c#"},
            };
            

            Predicate<Student> fst = x => x.Sname=="teja";

            var st = lst.Find(fst);
            Console.WriteLine("{0}\t{1}\t{2}",st.Id,st.Sname,st.course);

            lst.Sort();
            foreach (var s in lst)
            {
                Console.WriteLine("{0}\t{1}\t{2}", s.Id, s.Sname, s.course);
            }

        }
    }
}
