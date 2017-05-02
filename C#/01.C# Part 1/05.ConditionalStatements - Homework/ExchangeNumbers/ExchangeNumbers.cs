using System;

namespace ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double temp;

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine(a + " " + b);
        }
    }
}
