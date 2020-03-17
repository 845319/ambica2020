using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace th_task.Models
{
    public class theatre
    {
        [Key]
        public string th_name { get; set; }
        public int th_id { get; set; }
        public string th_loc { get; set; }
        public ICollection <movie> movies { get; set; }

    }
}