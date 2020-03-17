using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace pandd
{
    public class doctors
    {
        [Key]
        public int did { get; set; }
        public string dname { get; set; }
        public string dwt { get; set; }

        public patients Patients { get; set; }

    }
}