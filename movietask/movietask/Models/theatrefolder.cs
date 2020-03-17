using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace movietask.Models
{
    public class theatrefolder
    {
        [Key]
        public string th_name { get; set; }
        public int th_id { get; set; }
        public string th_loc { get; set; }
        public moviefolder movies { get; set; }

    }
}