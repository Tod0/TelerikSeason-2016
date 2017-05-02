using System;
using System.Linq;

namespace SortingArray
{
    class SortingArray
    {
        static int maxElement(int[] arr, int index)
        {
            int max = arr[index];

            for (int i = index; i < arr.Length; i++)
            {
                if (arr[i] > max) 
                {
                    max = arr[i];
                }
            }

            return max;
        }

        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine();
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());      // this input is useless but bg coder needs it
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(numbers);
            Print(numbers);
        }
    }
}
