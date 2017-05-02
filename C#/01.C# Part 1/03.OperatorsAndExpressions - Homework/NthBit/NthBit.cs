using System;

namespace NthBit
{
    class NthBit
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            long mask = 1 << p;
            long nAndMask = n & mask;
            long bit = nAndMask >> p;
            Console.WriteLine(bit);
        }
    }
}
