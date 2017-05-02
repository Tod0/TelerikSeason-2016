using System;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[100, 100];
       
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + i + 1; j++)
                {
                    arr[i, j] = j;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + i + 1; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
