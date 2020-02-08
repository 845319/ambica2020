using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlDocument xml= new XmlDocument();
            xml.Load(@"C:\Users\pyr\Desktop\ambica2020\ConsoleApp1\ConsoleApp1\XMLFile1.xml");
            XmlNode currentnode = xml.DocumentElement.FirstChild;
            Console.WriteLine(currentnode.InnerText);
            XmlNode nextnod = currentnode.NextSibling;
            Console.WriteLine(nextnod.InnerText);
            XmlNode node2 = nextnod.NextSibling;
            Console.WriteLine(node2.InnerText);

        } 
    }
}
