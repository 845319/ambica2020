using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bike
{
    interface Firstname
    {
        void show();
    }
    interface Lastname
    {
        void mshow();
    }
    class Myclass : Firstname, Lastname
    {
       public void show()
        {
            Console.WriteLine("Ambica");
        }
        public void mshow()
        {
            Console.WriteLine("Kalyani");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass m = new Myclass();
            m.show();
            m.mshow();
        }
    }
}
