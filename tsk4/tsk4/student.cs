using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsk4
{
    class student
    {
        public Program(string fn, string ln)
        {
            firstname = fn;
            lastname = ln;
        }
        public string Name
        {
            get{return string.Format("{0} {1}"),firstname,lastname);}
        }
        public int Idno
        {
            set { idno = value;}
            get { return idno; }
        }
    }
}
