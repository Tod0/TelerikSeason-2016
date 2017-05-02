using System;
using System.Linq;

namespace FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static int func(int[] arr)
        {
            int index = 0;

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if ((arr[i] > arr[i - 1]) && (arr[i] > arr[i + 1]))
                {
                    index = i;
                    break;
                }
            }

            if (index != 0)
                return index;
            else
                return -1;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());      // this input is useless but bg coder needs it
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(func(numbers));
        }
    }
}
