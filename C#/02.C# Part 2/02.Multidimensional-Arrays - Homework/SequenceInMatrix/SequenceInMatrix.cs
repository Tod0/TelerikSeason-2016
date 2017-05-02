using System;
using System.Linq;

namespace SequenceInMatrix
{
    class SequenceInMatrix
    {
        static void Main()
        {
            int[] arrSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = arrSize[0];
            int m = arrSize[1];
            int[,] matrix = new int[n, m];
            int counter = 1;
            int biggestCounter = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentLine[col];
                }
            }

            // Horizontal
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        for (int j = col; j < matrix.GetLength(1) - 1; j++)
                        {
                            if (matrix[row, j] == matrix[row, j + 1])
                            {
                                counter++;

                                if (counter > biggestCounter)
                                {
                                    biggestCounter = counter;
                                }
                            }

                            else
                            {
                                break;
                            }
                        }
                    }

                    counter = 1;
                }
            }

            // Vertical
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        for (int i = row; i < matrix.GetLength(0) - 1; i++)
                        {
                            if (matrix[i, col] == matrix[i + 1, col])
                            {
                                counter++;

                                if (counter > biggestCounter)
                                {
                                    biggestCounter = counter;
                                }
                            }

                            else
                            {
                                break;
                            }
                        }
                    }

                    counter = 1;
                }
            }

            // Left to right diagonal
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    for (int i = row, j = col; i < matrix.GetLength(0) - 1 && j < matrix.GetLength(1) - 1; i++, j++)
                    {
                        if (matrix[i, j] == matrix[i + 1, j + 1])
                        {
                            counter++;

                            if (counter > biggestCounter)
                            {
                                biggestCounter = counter;
                            }
                        }

                        else
                        {
                            break;
                        }
                    }

                    counter = 1;
                }
            }

            // Right to left diagonal
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 1; col--)
                {
                    for (int i = row, j = col; i < matrix.GetLength(0) - 1 && j >= 1; i++, j--)
                    {
                        if (matrix[i, j] == matrix[i + 1, j - 1])
                        {
                            counter++;

                            if (counter > biggestCounter)
                            {
                                biggestCounter = counter;
                            }
                        }

                        else
                        {
                            break;
                        }
                    }

                    counter = 1;
                }
            }

            Console.WriteLine(biggestCounter);
        }
    }
}
