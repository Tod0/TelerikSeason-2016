using System;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int radius = 2;
            double distance = Math.Sqrt(x * x + y * y);

            if (x * x + y * y <= radius * radius)
            {
                Console.WriteLine("yes " + "{0:0.00}", distance);
            }
            else
            {
                Console.WriteLine("no " + "{0:0.00}", distance);
            }
        }
    }
}
