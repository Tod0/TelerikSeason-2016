using System.Collections.Generic;

namespace SortingAlgorithms
{
    public class SelectionSorter
    {
        public static void Sort(List<int> collection)
        {
            int pos_min, temp;

            for (int i = 0; i < collection.Count - 1; i++)
            {
                pos_min = i;

                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j] < collection[pos_min])
                    {
                        pos_min = j;
                    }
                }

                if (pos_min != i)
                {
                    temp = collection[i];
                    collection[i] = collection[pos_min];
                    collection[pos_min] = temp;
                }
            }

        }
    }
}
