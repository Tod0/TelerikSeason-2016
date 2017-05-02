using System;

namespace _08.SinglePath
{
    public class Startup
    {
        private const int MatrixSize = 100;

        private static bool[,] matrix = new bool[MatrixSize, MatrixSize];

        private static bool isPossible;

        private static int goalRowCoordinate = 80;
        private static int goalColCoordinate = 90;

        public static void Main()
        {
            FindPath(0, 0);

            Console.WriteLine(isPossible);
        }

        private static void FindPath(int row, int col)
        {
            if (isPossible)
            {
                return;
            }

            if (row == goalRowCoordinate && col == goalColCoordinate)
            {
                isPossible = true;
                return;
            }

            if (row + 1 < MatrixSize && !matrix[row + 1, col])
            {

                matrix[row + 1, col] = true;
                FindPath(row + 1, col);
                matrix[row + 1, col] = false;
            }

            if (col + 1 < MatrixSize && !matrix[row, col + 1])
            {
                matrix[row, col + 1] = true;
                FindPath(row, col + 1);
                matrix[row, col + 1] = false;
            }

            if (row - 1 >= 0 && !matrix[row - 1, col])
            {
                matrix[row - 1, col] = true;
                FindPath(row - 1, col);
                matrix[row - 1, col] = false;
            }

            if (col - 1 >= 0 && !matrix[row, col - 1])
            {
                matrix[row, col - 1] = true;
                FindPath(row, col - 1);
                matrix[row, col - 1] = false;
            }
        }
    }
}
