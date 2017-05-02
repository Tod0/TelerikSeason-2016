using System;

namespace MMSAOfNNumbers
{
    class MMSAOfNNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            double min = 0;
            double max = 0;
            double sum = 0;
            double avg;

            for (int i = 0; i < n; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }

            min = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            max = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            avg = sum / n;

            Console.WriteLine("min=" + "{0:0.00}", min);
            Console.WriteLine("max=" + "{0:0.00}", max);
            Console.WriteLine("sum=" + "{0:0.00}", sum);
            Console.WriteLine("avg=" + "{0:0.00}", avg);
        }
    }
}
