using System;
using System.Xml;

namespace ExtractCatalog
{
    class StartUp
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            var url = @"..\..\XML\catalog.xml";

            doc.Load(url);

            var docElement = doc.DocumentElement;

            foreach (XmlNode node in docElement.ChildNodes)
            {
                Console.WriteLine("Artist {0} has 1 album in the catalog.", node["artist"].InnerText);
            }
        }
    }
}
