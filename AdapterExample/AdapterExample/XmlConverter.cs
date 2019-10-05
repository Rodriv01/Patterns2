using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdapterExample
{
    public class XmlConverter
    {
        public XDocument GetXML()
        {
            ManufacturerDataProvider provider = new ManufacturerDataProvider();
            var xDocument = new XDocument();
            var xElement = new XElement("Manufacturers");
            var xAttributes = provider.GetData()
                .Select(m => new XElement("Manufacturer",
                                    new XAttribute("City", m.City),
                                    new XAttribute("Name", m.Name),
                                    new XAttribute("Year", m.Year)));

            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            Console.WriteLine(xDocument);

            return xDocument;
        }
    }
}
