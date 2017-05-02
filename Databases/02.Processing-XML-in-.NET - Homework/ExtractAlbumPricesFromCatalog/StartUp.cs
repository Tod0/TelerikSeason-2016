using System;
using System.Xml;

namespace ExtractAlbumPricesFromCatalog
{
    class StartUp
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            var url = @"..\..\XML\catalog.xml";

            doc.Load(url);

            var currentYear = DateTime.Now.Year.ToString();
            XmlNodeList albumPricesList = doc.SelectNodes($"/catalog/album[year<{currentYear}-5]");

            foreach (XmlNode priceNode in albumPricesList)
            {
                var price = priceNode.SelectSingleNode("price");
                Console.WriteLine(price.InnerText);
            }
        }
    }
}
