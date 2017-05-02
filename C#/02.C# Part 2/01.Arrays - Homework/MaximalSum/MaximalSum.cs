using System;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = int.MinValue;
            int currentSum = 0;
            int tmpStart = 0;
            int end = n;
            int start = 0;

            for (int j = 0; j != n; ++j)
            {
                currentSum += arr[j];
                end = j;

                // if the sum is equal, choose the one with more elements
                if (currentSum > maxSum || (currentSum == maxSum && (end - start) < (j - tmpStart)))
                {
                    maxSum = currentSum;
                    start = tmpStart;
                    end = j;
                }

                if (currentSum < 0)
                {
                    currentSum = 0;
                    tmpStart = j + 1;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
