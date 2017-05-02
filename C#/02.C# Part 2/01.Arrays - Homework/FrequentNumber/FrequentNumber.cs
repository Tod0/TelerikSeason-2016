using System;

namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int counter = 1;
            int biggestCounter = 1;
            int mostFreqNumber = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                }

                if (biggestCounter < counter)
                {
                    biggestCounter = counter;
                    mostFreqNumber = arr[i];
                }

                counter = 1;
            }

            Console.WriteLine("{0} ({1} times)", mostFreqNumber, biggestCounter);
        }
    }
}
