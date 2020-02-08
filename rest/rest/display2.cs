using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rest
{
    class display2:display

    {
        private string constring = " ";
        public display2()
        {
            constring = @"Data Source=BLT1080\SQLEXPRESS2014;Initial Catalog=EmployeDB;Integrated Security=True";

        }
        public void showmenu(display rt)
        {
            
        }
    }
}
