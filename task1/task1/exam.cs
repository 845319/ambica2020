using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class exam
    {
        string name, id, center;
        int marks;
        public void GetData(string nm,string id,string cen,int marks)
        {
            name = nm;
            this.id = id;
            center = cen;
            this.marks = marks;
        }
        public void ShowData()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
            Console.WriteLine(center);
            Console.WriteLine(marks);
            Console.WriteLine();
        }

    }
}
