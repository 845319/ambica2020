using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Scale
    {
        double centimeter;

        public double Inch
        {
            get { return centimeter ; }
            set
            {
                centimeter= value/2.54;
            }
        }
        public void showInches()
        {
            Console.WriteLine("{0}", centimeter);
        }

    }
}
