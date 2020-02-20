using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace pc
{
    class context:DbContext
    {
        public context() : base("Context") { }
        public DbSet<customer> customers { get; set; }
       // public DbSet<product> products { get; set; }
        public DbSet<purchase> purchases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();      
        }

    }
}
