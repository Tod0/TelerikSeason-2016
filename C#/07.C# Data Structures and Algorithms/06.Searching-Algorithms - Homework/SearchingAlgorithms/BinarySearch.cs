namespace SearchingAlgorithms
{
    public class BinarySearch
    {
        public static object ArrayBinarySearch(int[] array, int key, int min, int max)
        {
            if (min > max)
            {
                return "Nil";
            }
            else
            {
                int mid = (min + max) / 2;
                if (key == array[mid])
                {
                    return ++mid;
                }
                else if (key < array[mid])
                {
                    return ArrayBinarySearch(array, key, min, mid - 1);
                }
                else
                {
                    return ArrayBinarySearch(array, key, mid + 1, max);
                }
            }
        }
    }
}
