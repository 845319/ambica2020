using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2
{
    class Program
    {
        static EFentityContainer efc = new EFentityContainer();
        static void Main(string[] args)
        {
            courseshow();
            examsshow();
            schoolshow();
            invigilatorshow();
            subjectshow();
            studentshow();

        }

        private static void studentshow()
        {
            var students = efc.Students;
            foreach (var c in students)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", c.STid, c.STname, c.Course.Cname, c.School.SClocation, c.School.SCid);
            }
        }

        private static void subjectshow()
        {
            var subject = efc.Subjects;
            foreach (var c in subject)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", c.Sid, c.Sname, c.Course.Cid);
            }
        }

        private static void invigilatorshow()
        {
            var invigilator = efc.Invigilators;
            foreach (var c in invigilator)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", c.Iid, c.Iname, c.School.SClocation);
            }
        }

        private static void schoolshow()
        {
            var school = efc.Schools;
            foreach (var c in school)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", c.SCid, c.SCname, c.SClocation);
            }
        }

        private static void examsshow()
        {
            var exams = efc.Exams;
            foreach (var c in exams)
            {
                Console.WriteLine("{0}\t\t{1}\t\t", c.Eid, c.School.SClocation);
            }
        }

        private static void courseshow()
        {
            var cources = efc.Courses;
            foreach (var c in cources)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", c.Cid, c.Cname, c.SchoolSCid);
            }
        }
    }
}
