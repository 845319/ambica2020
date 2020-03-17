using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using booktask.datalayer;
using Microsoft.Extensions.DependencyInjection;

namespace booktask.Models
{
    public class sealedclass
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context =new bookcontext(serviceProvider.GetRequiredService<DbContextOptions<bookcontext>>())  )
            {
                if(context.ones.Any())
                {
                    return;
                }
                context.ones.AddRange(
                    new one 
                    {
                        Btitle="Sydney Sheldon",
                        Category="Action Drama",
                        AuthorName="Sheldon",
                        Publisher="Sheldon publications",
                        Releasedate=Convert.ToDateTime("06-06-1993"),
                        Price=500
                    },
                    new one 
                    {
                        Btitle="The girl Ambica",
                        Category="true story",
                        AuthorName="Ambica",
                        Publisher="TVS publications",
                        Releasedate=Convert.ToDateTime("05-06-1998"),
                        Price=1000
                   },
                    new one
                    {
                        Btitle = "HarryPotter",
                        Category = "Fiction",
                        AuthorName = "JK Rowling",
                        Publisher = "JK Publishers",
                        Price=7000,
                        Releasedate = Convert.ToDateTime("10-09-2014")
                    });

                context.SaveChanges();
            }
        }
    }
}
