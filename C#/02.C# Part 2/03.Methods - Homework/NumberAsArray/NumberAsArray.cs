using System;
using System.Linq;

namespace NumberAsArray
{
    class NumberAsArray
    {
        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine();
        }

        static void Main()
        {
            int[] arrSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = arrSize[0];
            int m = arrSize[1];
            int max = Math.Max(n, m);
            int min = Math.Min(n, m);
            bool ednoNaum = false;
            int[] number1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] number2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sum = new int[max];

            if (min == n)
            {
                Array.Resize(ref number1, max);
                for (int i = min; i < max; i++)
                {
                    number1[i] = 0;
                }
            }
            else if (min == m)
            {
                Array.Resize(ref number2, max);
                for (int i = min; i < max; i++)
                {
                    number2[i] = 0;
                }
            }

            for (int i = 0; i < max; i++)
            {
                if (ednoNaum)
                {
                    sum[i] = number1[i] + number2[i] + 1;
                    ednoNaum = false;

                    if (sum[i] > 9)
                    {
                        sum[i] %= 10;
                        ednoNaum = true;
                    }
                }

                else
                {
                    sum[i] = number1[i] + number2[i];

                    if (sum[i] > 9)
                    {
                        sum[i] %= 10;
                        ednoNaum = true;
                    }
                }
            }

            Print(sum);
        }
    }
}
