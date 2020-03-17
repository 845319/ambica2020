using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using booktask.Models;
namespace booktask.datalayer
{
    public class bookcontext:DbContext
    {
        public bookcontext(DbContextOptions<bookcontext> options):base (options)
        {

        }
        public DbSet<one> ones { get; set; }
    }
}
