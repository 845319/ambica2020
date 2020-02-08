using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    abstract class Shape
    {
        public int r;
        public abstract int Area();
    }
     class Dddd:Shape
    {
        public override int Area()
        {
            return r * r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dddd c = new Dddd(3);
           
            Console.WriteLine("{0}",c.Area());
        }
    }
}
