using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace over
{
    class employee
    {
        int id;
        string address;
        string name;
        public int EmpId { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public department Dept { get; set; }

        public virtual string EmpSalary (double sal)
        {
            return sal.ToString();
        }

    }
}
