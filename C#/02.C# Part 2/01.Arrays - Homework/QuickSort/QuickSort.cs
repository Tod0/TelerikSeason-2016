using System;

namespace QuickSort
{
    class QuickSort
    {
        public static void QuickSortAlgorithm(int[] arr, int left, int right)
        {

            int pivotIndex = (left + right) / 2;
            int leftIndex = left;
            int rightindex = right;
            int pivot = arr[pivotIndex];

            while (leftIndex <= rightindex)
            {
                while (arr[leftIndex] < pivot)
                {
                    leftIndex++;
                }

                while (arr[rightindex] > pivot)
                {
                    rightindex--;
                }

                if (leftIndex <= rightindex)
                {
                    int temp = arr[leftIndex];
                    arr[leftIndex] = arr[rightindex];
                    arr[rightindex] = temp;
                    leftIndex++;
                    rightindex--;
                }

                if (left < rightindex)
                {
                    QuickSortAlgorithm(arr, left, rightindex);
                }

                if (leftIndex < right)
                {
                    QuickSortAlgorithm(arr, leftIndex, right);
                }
            }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            QuickSortAlgorithm(arr, 0, n - 1);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
