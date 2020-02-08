using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart tsd = new ThreadStart(getnumbers);
            Thread th = new Thread(tsd);
            th.Start();

            ThreadStart td = new ThreadStart(getevennumbers);
            Thread t = new Thread(td);
            t.Start();
        }
        public static void getnumbers()
        {
            for(int i=0;i<=10;i++)
            {
                Console.Write("{0}\t", i);
                Thread.Sleep(500);
            }
        }
        public static void getevennumbers()
        {
            for(int i=0;i<=10;i++)
            {
                if(i%2==0)
                {
                    Console.Write("{0}", i);
                    Thread.Sleep(400);
                }
            }
        }

    }
}
