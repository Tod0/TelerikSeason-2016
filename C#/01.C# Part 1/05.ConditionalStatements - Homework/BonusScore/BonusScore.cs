using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 3)
            {
                n *= 10;
                Console.WriteLine(n);
            }
            else if (n >= 4 && n <= 6)
            {
                n *= 100;
                Console.WriteLine(n);
            }
            else if (n >= 7 && n <= 9)
            {
                n *= 1000;
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
