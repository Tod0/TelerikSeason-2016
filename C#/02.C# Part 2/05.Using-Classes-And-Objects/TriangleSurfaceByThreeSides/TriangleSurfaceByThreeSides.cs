using System;

namespace TriangleSurfaceByThreeSides
{
    class TriangleSurfaceByThreeSides
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double p = (a + b + c) / 2;
            double surface = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("{0:F2}", surface);
        }
    }
}
