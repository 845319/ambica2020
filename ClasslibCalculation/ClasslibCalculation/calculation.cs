using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibCalculation
{
   public class calculation
    {
        public int No1 { get; set; }
        public int No2 { get; set; }
        public string Add()
        {
            return string.Format("sum={0}", No1 + No2);
        }
        public string Difference()
        {
            return string.Format("diff={0}", No1 - No2);
        }
        public string Mul()
        {
            return string.Format("mul={0}", No1 * No2);
        }
    }
}
