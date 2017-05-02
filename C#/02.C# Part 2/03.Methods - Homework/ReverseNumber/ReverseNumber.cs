using System;
using System.Linq;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static decimal Reverse(decimal number)
        {
            string reversedString = new string(number.ToString().Reverse().ToArray());
            decimal reversedDecimal = decimal.Parse(reversedString);

            return reversedDecimal;
        }

        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());

            Console.WriteLine(Reverse(n));
        }
    }
}
