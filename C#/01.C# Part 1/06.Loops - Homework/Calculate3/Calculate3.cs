using System;
using System.Numerics;

namespace Calculate3
{
    class Calculate3
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
            BigInteger result = Factorial(n) / (Factorial(k) * Factorial(n - k));

            Console.WriteLine(result);
        }
    }
}
