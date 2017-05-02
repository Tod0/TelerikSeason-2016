using System;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static long GCD(long a, long b)
        {
            if (a == 0)
                return b;
            else if (b == 0)
                return a;

            if (a > b)
                return GCD(a % b, b);
            else
                return GCD(a, b % a);
        }

        static void Main(string[] args)
        {
            string[] stringArr = Console.ReadLine().Split(' ');
            long[] arr = new long[2];

            for (int i = 0; i < 2; i++)
            {
                arr[i] = Convert.ToInt64(stringArr[i]);
            }

            if (arr[0] < 0)
            {
                arr[0] = Math.Abs(arr[0]);
            }

            else if (arr[1] < 0)
            {
                arr[1] = Math.Abs(arr[1]);
            }

            else if (arr[0] == 0 || arr[1] == 0)
            {
                Console.WriteLine(0);
            }
            
            Console.WriteLine(GCD(arr[0], arr[1]));
        }
    }
}
