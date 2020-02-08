using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fly
{

    interface air
    {
        void fly();
    }
    class heli : air
    {
        public void fly()
        {
            Console.WriteLine("Ambica");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            heli h = new heli();
            h.fly();

        }
    }
}
 