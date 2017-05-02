using System;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
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
            BigInteger result = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));

            Console.WriteLine(result);
        }
    }
}
