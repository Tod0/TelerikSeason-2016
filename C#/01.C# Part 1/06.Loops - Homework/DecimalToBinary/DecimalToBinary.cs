using System;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            int remainder;
            string result = string.Empty;

            if (decimalNumber == 0) {
                Console.WriteLine(0);
            }

            else
            {
                while (decimalNumber > 0)
                {
                    remainder = decimalNumber % 2;
                    decimalNumber /= 2;
                    result = remainder.ToString() + result;
                }
                Console.WriteLine(result);
            }
        }
    }
}
