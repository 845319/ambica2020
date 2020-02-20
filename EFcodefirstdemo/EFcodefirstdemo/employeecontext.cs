using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFcodefirstdemo
{
    class employeecontext:DbContext
    {
        DbSet<Employee> Employees { get; set; }


    }
}
