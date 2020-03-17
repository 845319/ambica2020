using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace custpro
{
    class cust:DbContext
    {

        public string productname { get; set; }
        public int productid { get; set; }
        public double productcost { get; set; }

    }
}
