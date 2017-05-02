using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace ExtractAllSongsFromCatalog
{
    class StartUp
    {
        static void Main()
        {
            var url = @"..\..\XML\catalog.xml";

            Console.WriteLine("All songs in the catalog:");
            using (XmlReader reader = XmlReader.Create(url))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement() && reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadElementContentAsString());
                    }
                }
            }

            // Same as above but with XDocument and LINQ query
            /*
            var url = @"..\..\XML\catalog.xml";
            var doc = XDocument.Load(url);
            
            var allTitles = 
                from title in doc.Root.Descendants()
                where title.Name == "title"
                select title.Value;

            Console.WriteLine("All songs in the catalog:");
            foreach (var title in allTitles)
            {
                Console.WriteLine(title);
            }
            */
        }
    }
}
