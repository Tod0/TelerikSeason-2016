using System.Xml;

namespace DeleteFromCatalog.Extensions
{
    public static class XmlNodeExtensions
    {
        public static void Remove(this XmlNode node, string xpath)
        {
            var nodes = node.SelectNodes(xpath);
            foreach (XmlNode match in nodes)
            {
                match.ParentNode.RemoveChild(match);
            }
        }
    }
}
