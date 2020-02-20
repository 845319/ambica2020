using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace pc
{
    class product
    {
        [Key]
        public int pid { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public customer cid { get; set; }
        public virtual ICollection<purchase> purchases { get; set; }
    }
}
