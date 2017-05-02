using System;
using System.Diagnostics;

namespace Assertions_Homework
{
    public class Assertion
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Selection sort array cannot be null!");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Search array cannot be null!");
            Debug.Assert(startIndex < endIndex, "Start index cannot be larger or equal to the end index!");
            Debug.Assert(startIndex >= 0, "Start index should be equal or greater than 0!");
            Debug.Assert(endIndex > startIndex, "End index cannot be smaller or equal to the start index!");
            Debug.Assert(endIndex <= arr.Length - 1, "End index cannot be larger than the search array length!");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            Debug.Assert(minElementIndex >= startIndex, "Smallest value index cannot be less than the start index!");
            Debug.Assert(minElementIndex <= endIndex, "Smallest value index cannot be greater than the end index!");

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            Debug.Assert(x != null, "First parameter to swap cannot be null!");
            Debug.Assert(y != null, "Second parameter to swap cannot be null!");

            T oldX = x;
            x = y;
            y = oldX;
        }

        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Search array cannot be null!");
            Debug.Assert(value != null, "Search value cannot be null!");

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] searchArray, T value, int startIndex, int endIndex)
        where T : IComparable<T>
        {
            while (startIndex <= endIndex)
            {
                Debug.Assert(startIndex >= 0, "Start index should be greater or equal to 0!");
                Debug.Assert(endIndex < searchArray.Length, "End index should be smaller than the length or the searched array!");

                int midIndex = (startIndex + endIndex) / 2;
                if (searchArray[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (searchArray[midIndex].CompareTo(value) < 0)
                {
                    // Search for value on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search for value on the left half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}
