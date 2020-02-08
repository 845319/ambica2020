using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class scale
    {
        double centi;

        public double In
        {
            get { return centi / 2.54; }
            set
            {
                centi = value*2.54;
            }
        }

        public void Show()
        {
            Console.WriteLine("{0}", centi);
        }
    }
}
