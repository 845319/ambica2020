using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace pandd
{
    public class patients
    {
        [Key]
        public int pid { get; set; }
        public string pname { get; set; }
        public string pdisease { get; set; }
        public doctors Doctors { get; set; }
    }
}