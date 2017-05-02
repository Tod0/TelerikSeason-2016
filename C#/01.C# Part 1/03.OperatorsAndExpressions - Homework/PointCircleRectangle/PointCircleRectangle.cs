using System;

namespace PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main(string[] args)
        {
            double centerX = 1;
            double centerY = 1;
            double radius = 1.5;
            double topY = 1;
            double leftX = -1;
            double width = 6;
            double height = 2;
            double rightX = leftX + width;
            double bottomY = topY - height;

            double pointX = double.Parse(Console.ReadLine());
            double pointY = double.Parse(Console.ReadLine());

            bool isWithinCircle = Math.Pow(pointX - centerX, 2) + Math.Pow(pointY - centerY, 2) <= radius * radius;
            bool isWithinRectangle = pointX >= leftX && pointX <= rightX && pointY <= topY && pointY >= bottomY;

            if (isWithinCircle && isWithinRectangle)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else if (!isWithinCircle && isWithinRectangle)
            {
                Console.WriteLine("outside circle inside rectangle");
            }
            else if (isWithinCircle && !isWithinRectangle)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            else
            {
                Console.WriteLine("outside circle outside rectangle");
            }
        }
    }
}
