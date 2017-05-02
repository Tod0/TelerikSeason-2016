using System;
using System.Linq;

namespace SumIntegers
{
    class SumIntegers
    {
        static long SumOfIntegers(int[] arr)
        {
            long sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(SumOfIntegers(numbers));
        }
    }
}
