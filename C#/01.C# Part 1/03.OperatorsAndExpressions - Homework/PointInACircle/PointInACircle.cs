using System;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            double centerX = 0;
            double centerY = 0;
            double radius = 2;
            double pointX = double.Parse(Console.ReadLine());
            double pointY = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(pointX * pointX + pointY * pointY);

            if (Math.Pow(pointX - centerX, 2) + Math.Pow(pointY - centerY, 2) <= radius * radius)
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
