using System;

namespace StringLength
{
    class StringLength
    {
        static void Main()
        {
            string str = Console.ReadLine();
            str = str.Replace(@"\", string.Empty);

            Console.WriteLine(str.PadRight(20, '*'));
        }
    }
}
