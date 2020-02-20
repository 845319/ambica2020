using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace pc
{
    class purchase
    {
        [Key]
        public int id { get; set;}
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public int cid { get; set; }
        public int pid { get; set; }
        public virtual customer customer { get; set; }
        public virtual product product { get; set; }
    }
}
