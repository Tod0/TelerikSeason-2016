using System;
using System.Linq;

namespace MaximalKSum
{
    class MaximalKSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < k; i++)
            {
                int max = arr.Max();

                for (int j = 0; j < n; j++)
                {
                    if (arr[j] == max)
                    {
                        sum += arr[j];
                        arr[j] = -5000;     // bcuz arr[j] = 0 is not valid for some of bgcoder's tests
                        break;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
