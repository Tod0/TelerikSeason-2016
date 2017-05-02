using System;

namespace OddOrEvenProduct
{
    class OddOrEvenProduct
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] stringArr = Console.ReadLine().Split(' ');
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(stringArr[i]);
            }

            long productOdd = 1;
            for (int i = 0; i < n; i += 2)
            {
                productOdd *= arr[i];
            }

            long productEven = 1;
            for (int i = 1; i < n; i += 2)
            {
                productEven *= arr[i];
            }

            if (productEven == productOdd)
            {
                Console.WriteLine("yes " + productEven);
            }
            else
            {
                Console.WriteLine("no " + productOdd + " " + productEven);
            }
        }
    }
}
