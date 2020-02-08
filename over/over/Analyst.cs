using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace over
{
    class Analyst:employee
    {
        public override string EmpSalary(double sal)
        {
            double incentive = 4000;
            double total = incentive + sal;
            return total.ToString();
        }
    }
}
