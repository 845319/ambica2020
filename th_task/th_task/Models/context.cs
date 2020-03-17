using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace th_task.Models
{
    public class context : DbContext
    {
        
   
        public DbSet<movie> movies { get; set; }
        public DbSet<theatre> theatres { get; set; }
    
     }
}