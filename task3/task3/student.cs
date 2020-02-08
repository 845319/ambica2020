using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class student
    {
        string name;
        int idno;
        string course;
        DateTime joindate;

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
        public DateTime Joindate
        {
            set { joindate = value; }
            get { return joindate; }
        }
    }
}
