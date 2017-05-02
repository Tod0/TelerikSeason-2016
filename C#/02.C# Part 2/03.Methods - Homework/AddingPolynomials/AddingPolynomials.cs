using System;
using System.Linq;

namespace AddingPolynomials
{
    class AddingPolynomials
    {
        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine();
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sum = new int[n];

            for (int i = 0; i < n; i++)
            {
                sum[i] = arr1[i] + arr2[i];
            }

            Print(sum);
        }
    }
}
