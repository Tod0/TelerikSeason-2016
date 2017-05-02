using System;
using System.Linq;

namespace GetLargestNumber
{
    class GetLargestNumber
    {
        static int GetMax(int a, int b)
        {
            if (a >= b)
                return a;
            else
                return b;
        }

        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int a = numbers[0];
            int b = numbers[1];
            int c = numbers[2];

            Console.WriteLine(GetMax(a, GetMax(b, c)));
        }
    }
}
