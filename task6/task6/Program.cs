using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            product p = new product { Id = 1, Pname = "Chocolate", Price = 500 };
            Console.WriteLine("Id:{0}\nPname:{1}\nPrice:{2}",p.Id, p.Pname, p.Price);
        }
    }
}
 