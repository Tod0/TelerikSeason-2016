using System;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            
            if (a % 2 == 0)
            {
                Console.WriteLine("even " + a);
            }
            else
            {
                Console.WriteLine("odd " + a);
            }
        }
    }
}
