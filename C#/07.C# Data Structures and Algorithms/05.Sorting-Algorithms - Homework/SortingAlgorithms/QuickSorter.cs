using System.Collections.Generic;

namespace SortingAlgorithms
{
    public class QuickSorter
    {
        public static List<int> Sort(List<int> collection)
        {
            if (collection.Count <= 1)
            {
                return collection;
            }

            int pivotIndex = collection.Count / 2;
            int pivot = collection[pivotIndex];

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < pivotIndex; i++)
            {
                if (collection[i] <= pivot)
                {
                    left.Add(collection[i]);
                }
                else
                {
                    right.Add(collection[i]);
                }
            }
            for (int i = pivotIndex + 1; i < collection.Count; i++)
            {
                if (collection[i] < pivot)
                {
                    left.Add(collection[i]);
                }
                else
                {
                    right.Add(collection[i]);
                }
            }
            
            List<int> result = new List<int>();
            result.AddRange(Sort(left));
            result.Add(pivot);
            result.AddRange(Sort(right));

            return result;
        }
    }
}
