using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace custpro
{
    class pro
    {
        [Key]
        public List<pro> product { get; set; }
        public string name { get; set; }
        public string cid { get; set; }
        public double purchase { get; set; }
    }
}
