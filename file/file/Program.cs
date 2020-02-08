using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;


namespace xmlsample
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();

            xml.Load(@"C:\Users\pyr\Desktop\ambica2020\ConsoleApp1\ConsoleApp1\XMLFile1.xml");
           // xml.Load(@"D:");
            XmlNode currentnode = xml.DocumentElement.FirstChild;
            Console.WriteLine(currentnode.OuterXml);
            XmlNode nextnode = currentnode.NextSibling;
            Console.WriteLine(nextnode.OuterXml);
            XmlNode node3 = nextnode.NextSibling;
            Console.WriteLine(node3.OuterXml);
            createxmlwithlinq();
            Console.ReadKey();

        }
        public static void createxmlwithlinq()
        {
            XDocument doc = new XDocument(new XElement("items",
            new XElement("item",
            new XElement("itemname", "cake"),
            new XElement("price", 250)),
            new XElement("item",
            new XElement("itemname", "choclate"),
            new XElement("price", 25))));
            doc.Save(Directory.GetCurrentDirectory() + "//product.xml");
        }
        private static void createxmldoc()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmldeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmldeclaration, root);
            XmlElement element1 = doc.CreateElement(string.Empty, "products", string.Empty);
            doc.AppendChild(element1);
            XmlElement element2 = doc.CreateElement(string.Empty, "product", string.Empty);
            XmlElement element3 = doc.CreateElement(string.Empty, "product", string.Empty);

            XmlText text1 = doc.CreateTextNode("laptop");
            element1.AppendChild(element2);
            element2.AppendChild(element3);
            element3.AppendChild(text1);

            XmlElement element4 = doc.CreateElement(string.Empty, "price", string.Empty);
            XmlText text2 = doc.CreateTextNode("45000");
            element4.AppendChild(text2);
            element2.AppendChild(element4);

            doc.Save(Directory.GetCurrentDirectory() + "//Product.xml");
        }
    }
}

