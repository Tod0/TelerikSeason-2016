using System;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n /= 100;
            n %= 10;

            if (n == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + n);
            }
        }
    }
}
