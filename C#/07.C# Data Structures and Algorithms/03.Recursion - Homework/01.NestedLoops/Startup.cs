using System;
using System.Linq;

namespace _01.NestedLoops
{
    public class Startup
    {
        public static void Main()
        {
            var loopsCount = int.Parse(Console.ReadLine());
            var numbers = Enumerable.Range(0, loopsCount).Select(x => 1).ToArray();

            LoopWrite(numbers, loopsCount, loopsCount);
        }

        private static void LoopWrite(int[] range, int current, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (current > 1)
                {
                    LoopWrite(range, current - 1, count);
                }
                else
                {
                    Console.WriteLine(string.Join(" ", range));
                }

                range[count - current]++;
            }

            range[count - current] = 1;
        }
    }
}
