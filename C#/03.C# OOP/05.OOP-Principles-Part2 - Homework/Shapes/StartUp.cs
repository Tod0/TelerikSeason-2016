namespace Shapes
{
    using System;

    using Models;

    public class StartUp
    {

        static void Main()
        {
            var shapes = new Shape[]
            {
                new Triangle(3, 5),
                new Triangle(2.4, 3.6),
                new Rectangle(4, 6),
                new Rectangle(4.5, 5.5),
                new Square(7),
                new Square(5.5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
