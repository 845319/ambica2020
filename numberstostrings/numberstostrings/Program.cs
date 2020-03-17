using System;

namespace numberstostrings
{
    class Program
    {
        public void convert(int n)
        {
            
            int r, rev = 0;
            while(n>0)
            {
                r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }
            int r1;
            while(rev>0)
            {
                r1 = rev % 10;
                rev = rev / 10;
                con(r1);
                
            }
        }
        public void con(double r1)
        {
            switch(r1)
            {
                case 0: Console.Write("zero");break;
                case 1: Console.Write("one" +" "); break;
                case 2: Console.Write("two"+" "); break;
                case 3: Console.Write("three" + " "); break;
                case 4: Console.Write("four"+ " " ); break;
                case 5: Console.Write("five"+" "); break;
                case 6: Console.Write("six"+" "); break;
                case 7: Console.Write("seven"+" "); break;
                case 8: Console.Write("eight"+" "); break;
                case 9: Console.Write("nine"+" "); break;


            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int x = int.Parse(Console.ReadLine());
            p.convert(x);
        }
        
    }
}
