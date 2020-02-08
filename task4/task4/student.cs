using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class student
    {
        string name;
        int idno;
        string course;
        string firstname;
        string lastname;
        public student() { }
       

        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public int Idno
        {
            get { return idno; }
            set { idno = value; }

        }
        public string Course
        {
            get { return course; }
            set { course = value; }

        }
        public student(string fn,string ln)
        {
            firstname = fn;
            lastname = ln;

        }
    }
}
