using System;

namespace Calculate
{
    class Calculate
    {
        static int Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += Factorial(i) / Math.Pow(x, i);
            }

            Console.WriteLine("{0:F5}", sum);
        }
    }
}
