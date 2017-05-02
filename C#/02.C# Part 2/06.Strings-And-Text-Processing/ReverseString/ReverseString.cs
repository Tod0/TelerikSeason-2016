using System;

namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
        }
    }
}
