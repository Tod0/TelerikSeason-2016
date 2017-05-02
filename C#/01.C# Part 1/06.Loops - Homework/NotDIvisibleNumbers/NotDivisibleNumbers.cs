using System;

namespace NotDIvisibleNumbers
{
    class NotDivisibleNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                else if (i % 7 == 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
