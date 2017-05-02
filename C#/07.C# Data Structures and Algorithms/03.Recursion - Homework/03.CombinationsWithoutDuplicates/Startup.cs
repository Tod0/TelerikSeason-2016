using System;
using System.Linq;

namespace _03.CombinationsWithoutDuplicates
{
    public class Startup
    {
        public static void Main()
        {
            var loopsCount = int.Parse(Console.ReadLine());
            var combinationLength = int.Parse(Console.ReadLine());

            var numbers = Enumerable.Range(1, combinationLength).ToArray();

            CombinationWrite(numbers, combinationLength, loopsCount);
        }

        private static void CombinationWrite(int[] range, int current, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (current > 1)
                {
                    CombinationWrite(range, current - 1, count);
                }
                else
                {
                    Console.WriteLine(string.Join(" ", range));
                }

                IncrementWithoutDuplicates(range, range.Length - current);
                if (!ValueIsInRange(range, range.Length - current, count))
                {
                    break;
                }
            }

            range[range.Length - current] = 1;
        }

        private static void IncrementWithoutDuplicates(int[] range, int index)
        {
            var isDuplicate = false;
            do
            {
                range[index]++;
                isDuplicate = false;

                for (int i = 0; i < index; i++)
                {
                    if (range[i] == range[index])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
            }
            while (isDuplicate);
        }

        private static bool ValueIsInRange(int[] range, int index, int maxValue)
        {
            return range[index] <= maxValue;
        }
    }
}
