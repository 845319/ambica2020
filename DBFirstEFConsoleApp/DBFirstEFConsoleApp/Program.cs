using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstEFConsoleApp
{
    class Program
    {
       static EmployeDBEntities1 emp1 = new EmployeDBEntities1();
        static void Main(string[] args)
        {
           // employees();
           // departments();
            //NewMethod();
            depinsert();
        }

        private static void NewMethod()
        {
            Console.WriteLine("enter emp id");
            string id = Console.ReadLine();
            Console.WriteLine("enter emp name");
            string name = Console.ReadLine();
            Console.WriteLine("enter emp designation");
            string Des = Console.ReadLine();
            Console.WriteLine("enter emp depid");
            string di = Console.ReadLine();
            var emp = new Emp
            {
                Eid = id,
                Ename = name,
                Designation = Des,
                Did = di,

            };
            emp1.Emps.Add(emp);
            emp1.SaveChanges();

            

        }

        private static void depinsert()
        {
            Console.WriteLine("enter Department name");
            string dname = Console.ReadLine();
            Console.WriteLine("enter did");
            string depid = Console.ReadLine();
            var dep = new Dep
            {
                Did = depid,
                Dname = dname,
            };
            emp1.Deps.Add(dep);
            emp1.SaveChanges();
        }

        private static void departments()
        {
            Console.WriteLine("Departments are");
            var Dep = emp1.Deps;
            foreach (var t in Dep)
            {
                Console.WriteLine("{0}\t{1}\t", t.Dname, t.Did);
            }
        }

        private static void employees()
        {
            Console.WriteLine("all employees ");
            var emp = emp1.Emps;
            foreach (var c in emp)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", c.Eid, c.Ename, c.Designation, c.Did);
            }
        }
    }
}
