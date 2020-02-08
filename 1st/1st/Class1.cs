using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st
{
    class Class1
    {
        public string name, id, address;
       public int age;
        public void Getdata(string na,string id,string add, int ag)
        {
            name = na;
            this.id = id;
            address = add;
            age = ag;
        }
       public void Showdata()
        {
            Console.WriteLine(name);
            Console.WriteLine(id + " " + address);
            Console.WriteLine(age);
        }
    }
}
