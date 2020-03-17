using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procat
{
    class Program
    {
        static EmployeDBEntities emp = new EmployeDBEntities();
        static void Main(string[] args)
        {
            catinsert();
            proinsert();
        }

        private static void proinsert()
        {
            Console.WriteLine("enter pid");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter title");
            string tit = Console.ReadLine();
            Console.WriteLine("enter price");
            decimal pri = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter cid");
            int c = int.Parse(Console.ReadLine());
            var pro = new Product
            {
                pid = id,
                title = tit,
                price = pri,
                cid = c,
            };
            emp.Products.Add(pro);
            emp.SaveChanges();
        }

        private static void catinsert()
        {
            Console.WriteLine("enter cid");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter cname");
            string name = Console.ReadLine();
            var cat = new Category
            {
                cid = id,
                cname = name,
            };
            emp.Categories.Add(cat);
            emp.SaveChanges();
        }
    }
}
