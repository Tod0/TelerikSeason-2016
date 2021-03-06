﻿using System;

namespace _09.LargestConnectedArea
{
    public class Startup
    {
        private const int MatrixSize = 6;

        private static bool[,] matrix =
        {
            { true, false, false, false, true, true },
            { true, true, true, false, false, false },
            { false, false, false, true, true, true },
            { true, true, true, false, false, true },
            { true, true, true, false, false, true },
            { true, true, true, true, true, true },
        };

        private static int maxSteps = 0;

        public static void Main()
        {
            FindPath(0, 0, 0);

            Console.WriteLine(maxSteps);
        }

        private static void FindPath(int row, int col, int steps)
        {
            if (row + 1 < MatrixSize && matrix[row + 1, col])
            {
                matrix[row + 1, col] = false;
                FindPath(row + 1, col, steps + 1);
                matrix[row + 1, col] = true;
            }

            if (col + 1 < MatrixSize && matrix[row, col + 1])
            {
                matrix[row, col + 1] = false;
                FindPath(row, col + 1, steps + 1);
                matrix[row, col + 1] = true;
            }

            if (row - 1 >= 0 && matrix[row - 1, col])
            {
                matrix[row - 1, col] = false;
                FindPath(row - 1, col, steps + 1);
                matrix[row - 1, col] = true;
            }

            if (col - 1 >= 0 && matrix[row, col - 1])
            {
                matrix[row, col - 1] = false;
                FindPath(row, col - 1, steps + 1);
                matrix[row, col - 1] = true;
            }

            if (maxSteps < steps)
            {
                maxSteps = steps;
            }
        }
    }
}
