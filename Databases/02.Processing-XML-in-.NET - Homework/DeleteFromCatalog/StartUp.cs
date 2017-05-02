using System.Xml;

using DeleteFromCatalog.Extensions;

namespace DeleteFromCatalog
{
    class StartUp
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            var url = @"..\..\XML\catalog.xml";

            doc.Load(url);

            doc.Remove("/catalog/album[price>20]");

            doc.Save(url);
        }
    }
}
