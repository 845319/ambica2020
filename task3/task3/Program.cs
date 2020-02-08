using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            std.Name = "ambica";
            std.Idno = 845319;
            std.Course = "c#";
            std.Joindate = DateTime.Parse("1-10-2020");
            Console.WriteLine("name is: {0} \nId is: {1}",std.Name,std.Idno);
            Console.WriteLine("Course is: {0} \nJoining Date: {1}",std.Course,std.Joindate);

        }
    }
}
