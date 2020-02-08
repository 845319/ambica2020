using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struc
{
    class adds
    {
        int[] a = { 11, 12, 13, 14, 15, 16 };
        int e;
        public  int show()
        {
            for(int i=0;i<a.Length;i++)
            {
                if(i%2==0)
                {
                    e += a[i];
                    Console.WriteLine(e);
                }
            }
        }
    }
}
