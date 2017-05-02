using System;
using System.Linq;

namespace AppearanceCount
{
    class AppearanceCount
    {
        static int numberCount(int[] arr, int number)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
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
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(numberCount(numbers, x));
        }
    }
}
