using System;

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int counter = 1;
            int biggestCounter = 1;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                }

                else if (arr[i] != arr[i + 1])
                {
                    counter = 1;
                }

                if (biggestCounter < counter)
                {
                    biggestCounter = counter;
                }
            }

            Console.WriteLine(biggestCounter);
        }
    }
}

