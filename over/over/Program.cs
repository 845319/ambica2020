using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace over
{
    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee
            {
                EmpId = 101,
                Name = "ambica",
                Address = "chennai",
                Dept = new department { Depid = 1, D_name = "production" }
            };

        }
    }
}
