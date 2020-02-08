using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hat
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add("Ambica", 12345);
            h.Add("Kalyani", 23456);
            h.Add("Teju", 34567);
            foreach(string k in h.Values)
            {
                Console.WriteLine(k);
            }
            h.Remove("Ambica");
                
        }
    }
}
