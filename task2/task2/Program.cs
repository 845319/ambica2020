using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            car cr = new car();
            cr.showcar();
            car cr1 = new car("845821");
            cr1.showcar();
            car cr2 = new car("audi", "black");
            cr2.showcar();
            car cr3 = new car("black","audi","reg845319",5000000);
            cr3.showcar();


        }
    }
}
