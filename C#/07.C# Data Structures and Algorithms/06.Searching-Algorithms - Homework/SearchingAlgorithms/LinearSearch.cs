namespace SearchingAlgorithms
{
    public class LinearSearch
    {
        public static int ArrayLinearSearch(int[] array, int item)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == item)
                {
                    return i;

                }
            return -1;
        }
    }
}
