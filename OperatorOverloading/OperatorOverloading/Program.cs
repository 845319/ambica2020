﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        private static void Main(string[] args)
        {
            Demo1 d1 = new Demo1(20, 50);
            d1.showData();
            Demo1 d2 = new Demo1(500, 100);
            d2.showData();

            Demo1 s = new Demo1();
            s = d1 + d2;
            s.showData();
        }
    }
}
