using System;

namespace BiggestOf3
{
    class BiggestOf3
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double biggest = a;

            if (biggest < b)
            {
                biggest = b;
            }
            if (biggest < c)
            {
                biggest = c;
            }
            Console.WriteLine(biggest);
        }
    }
}
