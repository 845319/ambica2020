using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    class calculator
    {
        int a, b;

        public calculator(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public calculator(int a)
        {
            this.a = a;
        }
        public int Add()
        {
            return a + b;
        }
        public int Sub()
        {
            return a - b;
        }
        public int Pro()
        {
            return a * b;
        }
    }
}
