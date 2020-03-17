using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace movietask.Models
{
    public class moviefolder
    {
        [Key]
        public int movie_id { get; set; }
        public string movie_name { get; set; }
        public string movie_dist { get; set; }
        public theatrefolder theatres { get; set; }
    }
}