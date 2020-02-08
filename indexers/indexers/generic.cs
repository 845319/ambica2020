using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexers
{
    class generic<T>
    {
        private T[] arr = new T[100];
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

    }
   class student
    {
        public int ID;
        public string stname;
        public string course;

        public int id { get; set;}
        public string Sname { get; set; }
        public string Course { get; set; }
    }
}
