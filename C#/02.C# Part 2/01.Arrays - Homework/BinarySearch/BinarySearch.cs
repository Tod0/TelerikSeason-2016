using System;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int x = int.Parse(Console.ReadLine());
            int index = Array.BinarySearch(arr, x);
            if (index < 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
