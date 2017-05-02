namespace ExtensionMethodsDelegateLambdaLINQ.Tests
{
    using System;
    using System.Text;

    using Extensions;

    public class StringBuilderTest
    {
        public static void Test()
        {
            var sb = new StringBuilder("¿Què pasa hombre?");
            var result = new StringBuilder();

            result = sb.Substring(9);
            Console.WriteLine(result);

            result = sb.Substring(5, 4);
            Console.WriteLine(result);
        }
    }
}
