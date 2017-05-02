using System;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static bool isPrime(int number)
        {
            int boundary = (int)Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
