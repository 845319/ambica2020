using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace cupr
{
    class product
    {
        [Key]
        public List<product> Product { get; set; }
        public string name { get; set; }
        public string cid { get; set; }
        public double purchase { get; set; }
    }
}
