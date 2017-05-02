using System;
using System.Numerics;

namespace NFactorial
{
    class NFactorial
    {
        static BigInteger Factorial(BigInteger number)
        {
            if (number <= 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }

        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(n));
        }
    }
}
