using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI
{
    class Fixed:Bank
    {
        public override string interestamt(double si)
        {
            double fix = si * 0.03;
            return fix.ToString();
        }
    }
}
