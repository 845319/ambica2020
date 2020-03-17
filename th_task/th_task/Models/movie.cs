using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace th_task.Models
{
    public class movie
    {
        [Key]
        public int movie_id { get; set; }
        public string movie_name { get; set; }
        public string movie_dist { get; set; }
        public ICollection<theatre> theatres { get; set; }
    }
}