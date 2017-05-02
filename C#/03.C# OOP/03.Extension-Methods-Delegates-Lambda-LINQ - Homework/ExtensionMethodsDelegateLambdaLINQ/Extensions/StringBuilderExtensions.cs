namespace ExtensionMethodsDelegateLambdaLINQ.Extensions
{
    using System;
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            var output = new StringBuilder(input.ToString(index, length));
            return output;
        }

        public static StringBuilder Substring(this StringBuilder input, int index)
        {
            var output = new StringBuilder(input.ToString(index, input.Length - index));
            return output;
        }
    }
}
