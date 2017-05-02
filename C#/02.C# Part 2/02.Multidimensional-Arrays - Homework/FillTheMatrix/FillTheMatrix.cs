using System;

namespace FillTheMatrix
{
    class FillTheMatrix
    {
        static void Print(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    Console.Write(string.Format("{0} ", matrix[row, col]));

                    if (col == matrix.GetLength(1) - 2)
                    {
                        Console.Write(matrix[row, col + 1]);
                    } 
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            if (c == 'a')
            {
                int i = 1;

                for (int col = 0; col < n; col++)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = i;
                        i++;
                    }
                }

                Print(matrix);
            }

            else if (c == 'b')
            {
                int row = 0;
                int col = 0;
                int maxRotations = n * n;
                string direction = "down";

                for (int i = 1; i <= maxRotations; i++)
                {
                    if (direction == "down" && row == n)
                    {
                        direction = "up";
                        row--;
                        col++;
                    }
                    if (direction == "up" && row < 0)
                    {
                        direction = "down";
                        row++;
                        col++;
                    }

                    matrix[row, col] = i;

                    if (direction == "down")
                    {
                        row++;
                    }
                    if (direction == "up")
                    {
                        row--;
                    }
                }

                Print(matrix);
            }

            else if (c == 'c')
            {
                int i = 1;

                // Print lower left side

                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    for (int col = 0; col < matrix.GetLength(0) - row; col++)
                    {
                        matrix[row + col, col] = i;
                        i++;
                    }
                }

                // Print upper right side

                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 1; col < matrix.GetLength(1) - row; col++)
                    {
                        matrix[col - 1, col + row] = i;
                        i++;
                    }
                }

                Print(matrix);
            }

            else if (c == 'd')
            {
                int row = 0;
                int col = 0;
                int maxRotations = n * n;
                string direction = "down";

                for (int i = 1; i <= maxRotations; i++)
                {
                    if (direction == "down" && (row == n || matrix[row, col] != 0))
                    {
                        direction = "right";
                        row--;
                        col++;
                    }
                    if (direction == "right" && (col == n || matrix[row, col] != 0))
                    {
                        direction = "up";
                        col--;
                        row--;
                    }
                    if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                    {
                        direction = "left";
                        row++;
                        col--;
                    }
                    if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                    {
                        direction = "down";
                        col++;
                        row++;
                    }

                    matrix[row, col] = i;

                    if (direction == "down")
                    {
                        row++;
                    }
                    if (direction == "right")
                    {
                        col++;
                    }
                    if (direction == "up")
                    {
                        row--;
                    }
                    if (direction == "left")
                    {
                        col--;
                    }
                }

                Print(matrix);
            }
        }
    }
}
