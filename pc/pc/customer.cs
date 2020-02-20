using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace pc
{
    class customer
    {
        [Key]
        public int cid { get; set; }
        public string name { get; set; }
        public int quality { get; set; }
        public List<product> products { get; set; }
    }
}
