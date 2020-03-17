using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstApp
{
    class Program
    {
        static ModelFirstEntityContainer mfc = new ModelFirstEntityContainer();
        static void Main(string[] args)
        {
            insertproducts();
            var ctg = new List<Product>
            {
                new Product{Pid=1,Ptitle="johnsons baby",Price=40,Cid=1},
                 new Product{Pid=2,Ptitle="Dove",Price=50,Cid=1},
                  new Product{Pid=1,Ptitle="Lays",Price=10,Cid=2},
                   new Product{Pid=1,Ptitle="Goodday",Price=40,Cid=2}

            };
            ctg.ForEach(c => mfc.Products.Add(c));
            foreach (var s in ctg)
            {
                Console.WriteLine("{0}{1}{2}{3}",s.Pid,s.Price,s.Ptitle,s.Cid);
            }
        }

        private static void insertproducts()
        {
            var ctg = new List<Catageory>
            {
                new Catageory{Cid=1,Cname="soaps"},
                new Catageory{Cid=2,Cname="Food"}
            };
            ctg.ForEach(s => mfc.Catageories.Add(s));
            foreach (var c in ctg)
            {
                Console.WriteLine("{0}{1}", c.Cid, c.Cname);
            }
            mfc.SaveChanges();
        }
    }
}
