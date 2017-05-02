using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            double x1, x2;

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                if (x1 < x2)
                {
                    Console.WriteLine("{0:0.00}", x1);
                    Console.WriteLine("{0:0.00}", x2);
                }
                else
                {
                    Console.WriteLine("{0:0.00}", x2);
                    Console.WriteLine("{0:0.00}", x1);
                }
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("{0:0.00}", x1);
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
