using System;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 2 || n == 3 || n == 5 || n == 7) 
            {
                Console.WriteLine("true");
            }
            else if (n <= 1 || n % 2 == 0 || n % 3 == 0 || n % 5 == 0 || n % 7 == 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
