using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XmlConv
{
    class Program
    {
        static void Main(string[] args)
        {            

            XDocument xmlFile = XDocument.Load("C:\\Test\\asdfTest.xml");
            var query = xmlFile.Elements("catalog").Elements("book").Select(c => c);
            foreach (XElement book in query)
            {
                //book.Attribute("id").Value = "MyNewValue";  // replace !!!
                book.Add(new XElement("Account", new XAttribute("id", "variable")));  // new Value
            }

            xmlFile.Save("C:\\Test\\asdfTest2.xml");


        }
    }
}
