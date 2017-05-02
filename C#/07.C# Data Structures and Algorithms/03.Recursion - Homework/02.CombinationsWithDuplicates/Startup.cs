using System;
using System.Linq;

namespace _02.CombinationsWithDuplicates
{
    public class Startup
    {
        public static void Main()
        {
            var loopsCount = int.Parse(Console.ReadLine());
            var combinationLength = int.Parse(Console.ReadLine());

            var numbers = Enumerable.Range(0, combinationLength).Select(x => 1).ToArray();

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

                range[range.Length - current]++;
            }

            range[range.Length - current] = 1;
        }
    }
}
