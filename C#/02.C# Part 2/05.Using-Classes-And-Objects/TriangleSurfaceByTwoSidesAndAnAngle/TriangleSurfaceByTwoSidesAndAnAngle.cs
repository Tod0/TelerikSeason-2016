using System;

namespace TriangleSurfaceByTwoSidesAndAnAngle
{
    class TriangleSurfaceByTwoSidesAndAnAngle
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            c = c * Math.PI / 180;
            double surface = (a * b * Math.Sin(c)) / 2;

            Console.WriteLine("{0:F2}", surface);
        }
    }
}
