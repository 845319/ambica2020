using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class employee
    {

        List<coll> lst = new List<coll>();



        public void me1(int eid, string ename, string designation, double salary)
        {
            lst.Add(new coll {eid=eid, ename = ename, designation = designation, salary = salary });
        }

        public void show()
        {

            foreach (coll e in lst)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", e.eid, e.ename, e.designation, e.salary);
            }
            
           
        }
        public void remove(int n)
        {
          
                lst.RemoveAt(n);
            
        }
    }
}
