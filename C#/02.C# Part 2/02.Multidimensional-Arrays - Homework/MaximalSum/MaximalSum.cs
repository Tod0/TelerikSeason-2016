using System;
using System.Linq;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            long[] arrSize = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long n = arrSize[0];
            long m = arrSize[1];
            long[,] matrix = new long[n, m];
            long sum = 0;
            long bestSum = 0;

            for (long row = 0; row < n; row++)
            {
                long[] currentLine = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

                for (long col = 0; col < m; col++)
                {
                    matrix[row, col] = currentLine[col];
                }
            }

            for (long row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (long col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum = matrix[row, col] 
                        + matrix[row, col + 1] 
                        + matrix[row + 1, col] 
                        + matrix[row + 1, col + 1] 
                        + matrix[row, col + 2] 
                        + matrix[row + 1, col + 2] 
                        + matrix[row + 2, col + 2] 
                        + matrix[row + 2, col + 1] 
                        + matrix[row + 2, col];

                    if (sum > bestSum)
                        bestSum = sum;

                    sum = 0;
                }
            }

            Console.WriteLine(bestSum);
        }
    }
}
