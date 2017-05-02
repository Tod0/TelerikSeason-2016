using System.Xml.Xsl;

namespace XslStylesheetAndXslTransformation
{
    class StartUp
    {
        static void Main()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(@"..\..\XML\catalog.xsl");
            xslt.Transform(@"..\..\XML\catalog.xml", @"..\..\XML\catalog.html");
        }
    }
}
