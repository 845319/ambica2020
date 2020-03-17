using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace cupr
{
    class customer:product
    {
        public product product { get; set; }
        public string productname { get; set; }
        public int productid { get; set; }
        public double productcost { get; set; }
    }
}
