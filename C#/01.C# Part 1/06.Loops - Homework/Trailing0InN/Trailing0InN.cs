using System;
using System.Numerics;

namespace Trailing0InN
{
    class Trailing0InN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int divider = 5;
            while (n / divider >= 1)
            {
                counter += n / divider;
                divider *= 5;
            }
            Console.WriteLine(counter);


            /*BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger fact = n;
            BigInteger counter = 0;

            for (int i = 1; i < n; i++)
            {
                fact = fact * i;
            }

            while (fact % 10 == 0)
            {
                counter++;
                fact /= 10;
            }

            Console.WriteLine(counter);*/
        }
    }
}
