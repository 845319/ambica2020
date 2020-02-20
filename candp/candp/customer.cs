using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace candp
{
    class customer:DbContext
    {
        public List<product> Product { get; set; }
        public string name { get; set; }
        public string cid { get; set; }
        public double purchase { get; set; }
    }
}
