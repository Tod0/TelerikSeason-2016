using System;
using System.Text;

namespace ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            var address = Console.ReadLine();
            int index = 0;

            // protocol
            StringBuilder protocol = new StringBuilder();
            int indexOfColon = address.IndexOf(':');
            protocol.Append(address, 0, indexOfColon);

            // server
            StringBuilder server = new StringBuilder();
            int indexOfServerStart = indexOfColon + 3;
            int indexOfServerEnd = address.IndexOf('/', indexOfServerStart);
            server.Append(address, indexOfServerStart, indexOfServerEnd - indexOfServerStart);
            // string server = address.Substring(indexOfServerStart, indexOfServerEnd - indexOfServerStart);
            // can be done with string as well

            // resource
            StringBuilder resource = new StringBuilder();
            int indexOfResourceStart = indexOfServerEnd;
            resource.Append(address, indexOfResourceStart, address.Length - indexOfResourceStart);

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
