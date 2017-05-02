using System;
using System.Numerics;

namespace DecimalToHex
{
    class DecimalToHex
    {
        public static string DecToHex(long x)
        {
            string result = "";

            while (x != 0)
            {
                if ((x % 16) < 10)
                    result = x % 16 + result;
                else
                {
                    string temp = "";

                    switch (x % 16)
                    {
                        case 10: temp = "A"; break;
                        case 11: temp = "B"; break;
                        case 12: temp = "C"; break;
                        case 13: temp = "D"; break;
                        case 14: temp = "E"; break;
                        case 15: temp = "F"; break;
                    }

                    result = temp + result;
                }

                x /= 16;
            }

            return result;
        }

        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(DecToHex(n));
        }
    }
}
