using System;

namespace HexToDecimal
{
    class HexToDecimal
    {
        public static long HexToDec(string x)
        {
            long result = 0;
            long count = x.Length - 1;
            for (int i = 0; i < x.Length; i++)
            {
                long temp = 0;
                switch (x[i])
                {
                    case 'A': temp = 10; break;
                    case 'B': temp = 11; break;
                    case 'C': temp = 12; break;
                    case 'D': temp = 13; break;
                    case 'E': temp = 14; break;
                    case 'F': temp = 15; break;
                    default: temp = -48 + x[i]; break; 
                }

                result += temp * (long)(Math.Pow(16, count));
                count--;
            }

            return result;
        }

        static void Main(string[] args)
        {
            string hex = Console.ReadLine();

            Console.WriteLine(HexToDec(hex));
        }
    }
}
