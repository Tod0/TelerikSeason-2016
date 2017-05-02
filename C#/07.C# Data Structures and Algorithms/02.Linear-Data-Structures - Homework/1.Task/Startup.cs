using System;
using System.Collections.Generic;

namespace Task1
{
    class Startup
    {
        public static void Main()
        {
            var list = new List<int>();

            while (true)
            {
                var number = Console.ReadLine();

                if (number == "")
                {
                    break;
                }

                list.Add(int.Parse(number));
            }

            Console.WriteLine($"Sum = {CalculateSum(list)}");
            Console.WriteLine($"Average = {CalculateAverage(list):F2}");
        }

        static int CalculateSum(List<int> list)
        {
            var sum = 0;

            foreach (var n in list)
            {
                sum += n;
            }

            return sum;
        }

        static double CalculateAverage(List<int> list)
        {
            var sum = 0;
            foreach (var n in list)
            {
                sum += n;
            }

            var average = 0d;
            average = (double)sum / list.Count;

            return average;
        }
    }
}
