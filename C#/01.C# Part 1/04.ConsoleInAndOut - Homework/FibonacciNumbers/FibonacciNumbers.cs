using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void FibonacciSequence(long len)
        {
            long a = 0, b = 1, c;
            if (len == 1)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.Write("{0}, {1}", a, b);
                for (long i = 2; i < len; i++)
                {
                    c = a + b;
                    Console.Write(", {0}", c);
                    a = b;
                    b = c;
                }
                Console.WriteLine();
            }   
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FibonacciSequence(n);
        }
    }
}
