using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI
{
    class Program
    {
        static void Main(string[] args)
        {
            customer c = new customer
            {
                CID = 845319,
                Name = "Ambica",
                Address = "Chennai",
                b=new Bank { Accno=98453219},
                
            };
            Console.WriteLine("{0}\t{1}\t{2}", c.CID, c.Name, c.Address);
            Console.WriteLine("{0}", c.b.Accno);
            Console.WriteLine("{0}", c.interestamt(24000));
            Bank bk = new Bank();
            Console.WriteLine("{0}", bk.interestamt(24000));

            Fixed f = new Fixed();
            Console.WriteLine("{0}", f.interestamt(20000));

           
            

         
        
        }
    }
}
