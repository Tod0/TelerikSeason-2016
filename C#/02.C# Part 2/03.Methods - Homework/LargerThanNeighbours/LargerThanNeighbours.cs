using System;
using System.Linq;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static int func(int[] arr)
        {
            int counter = 0;

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if ((arr[i] > arr[i - 1]) && (arr[i] > arr[i + 1]))
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());      // this input is useless but bg coder needs it
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(func(numbers));
        }
    }
}
