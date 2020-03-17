using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace movietask.Models
{
    public class moviescontext:DbContext
    {
        public DbSet<moviefolder> Moviefolders { get; set; }
        public DbSet<theatrefolder> Theatrefolders { get; set; }
    }
    
}