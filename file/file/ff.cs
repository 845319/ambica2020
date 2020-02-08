using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;
namespace file
{
    class ff
    {
        private static void createxmlwithlinq()
        {
            XDocument doc = new XDocument(new XElement("Items", new XElement("Item", new XElement("ItemName", "cake"), new XElement("price", "250")),
            new XElement("Item", new XElement("ItemName", "pastry"), new XElement("price", "200"))));

            doc.Save(Directory.GetCurrentDirectory() + "//xmlItem.xml");
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
