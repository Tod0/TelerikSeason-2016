using System;

namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "integer")
            {
                int n = int.Parse(Console.ReadLine());
                n += 1;
                Console.WriteLine(n);
            }
            else if (type == "real")
            {
                double n = double.Parse(Console.ReadLine());
                n += 1;
                Console.WriteLine("{0:F2}", n);
            }
            else if (type == "text")
            {
                string str = Console.ReadLine();
                Console.WriteLine(str + "*");
            }

        }
    }
}
