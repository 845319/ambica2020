using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strarr
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Ambica Kalyani";
            char[] chararr = s.ToCharArray();

            foreach (char ch in chararr)
            {
                Console.WriteLine(ch);
            }
            char[] chars = new char[15];
            chars[1] = 'a';
            chars[2] = 'm';
            chars[3] = 'b';
            chars[4] = 'i';
            chars[5] = 'c';
            chars[6] = 'a';
            chars[7] = ' ';
            chars[8] = 'k';
            chars[9] = 'a';
            chars[10] = 'l';
            chars[11] = 'y';
            chars[12] = 'a';
            chars[13] = 'n';
            chars[14] = 'i';

            string charsstr = new string(chars);

            Console.WriteLine("chars to string {0}", charsstr);



        }
    }
}
