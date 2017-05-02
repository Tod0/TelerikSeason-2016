using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            double perimeter = (2 * width) + (2 * height);

            //Console.WriteLine(area.ToString("0.00") + " " + perimeter.ToString("0.00"));  // i tova stava
            Console.WriteLine("{0:0.00} {1:0.00}", area, perimeter);
        }
    }
}
