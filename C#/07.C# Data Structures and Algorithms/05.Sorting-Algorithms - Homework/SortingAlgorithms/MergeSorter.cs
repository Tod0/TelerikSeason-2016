using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms
{
    public class MergeSorter
    {
        public static List<int> Sort(List<int> collection)
        {
            if (collection.Count <= 1)
            {
                return collection;
            }

            int midIndex = collection.Count / 2;
            var left = collection.Take(midIndex).ToList();
            var right = collection.Skip(midIndex).ToList();

            left = Sort(left);
            right = Sort(right);

            return Merge(left, right);
        }

        public static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            int leftIndex = 0;
            int rightIndex = 0;
            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            while (leftIndex < left.Count)
            {
                result.Add(left[leftIndex]);
                leftIndex++;
            }

            while (rightIndex < right.Count)
            {
                result.Add(right[rightIndex]);
                rightIndex++;
            }

            return result;
        }
    }
}
