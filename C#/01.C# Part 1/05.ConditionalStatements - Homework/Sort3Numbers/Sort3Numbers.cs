using System;

namespace Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long biggest = a;
            long smallest = a;
            long middle = 0;

            if (biggest < b)
            {
                biggest = b;
            }
            if (biggest < c)
            {
                biggest = c;
            }
            if (smallest > b)
            {
                smallest = b;
            }
            if (smallest > c)
            {
                smallest = c;
            }
            if ((biggest == a || smallest == a) && (biggest == b || smallest == b))
            {
                middle = c;
            }
            else if ((biggest == a || smallest == a) && (biggest == c || smallest == c))
            {
                middle = b;
            }
            else if ((biggest == b || smallest == b) && (biggest == c || smallest == c))
            {
                middle = a;
            }

            Console.WriteLine(biggest + " " + middle + " " + smallest);
        }
    }
}
