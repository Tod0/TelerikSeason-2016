using System;
using System.Numerics;

namespace CalculateAgain
{
    class CalculateAgain
    {
        static BigInteger Factorial(BigInteger i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }

        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            BigInteger result = Factorial(n) / Factorial(k);

            Console.WriteLine(result);
        }
    }
}
