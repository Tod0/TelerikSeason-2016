using System;

namespace Assertions_Homework
{
    public class StartUp
    {
        static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            Assertion.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            Assertion.SelectionSort(new int[0]);
            Assertion.SelectionSort(new int[1]);

            Console.WriteLine(Assertion.BinarySearch(arr, -1000));
            Console.WriteLine(Assertion.BinarySearch(arr, 0));
            Console.WriteLine(Assertion.BinarySearch(arr, 17));
            Console.WriteLine(Assertion.BinarySearch(arr, 10));
            Console.WriteLine(Assertion.BinarySearch(arr, 1000));
        }
    }
}
