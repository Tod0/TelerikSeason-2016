using System;
using System.Linq;
using System.Numerics;

namespace IntegerCalculations
{
    class IntegerCalculations
    {
        static int Minimum(int[] arr)
        {
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        static int Maximum(int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        static double Average(int[] arr)
        {
            double avg = (double)Sum(arr) / arr.Length;

            return avg;
        }

        static int Sum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        static BigInteger Product(int[] arr)
        {
            BigInteger product = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }

            return product;
        }

        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(Minimum(numbers));
            Console.WriteLine(Maximum(numbers));
            Console.WriteLine("{0:F2}", Average(numbers));
            Console.WriteLine(Sum(numbers));
            Console.WriteLine(Product(numbers));
        }
    }
}
