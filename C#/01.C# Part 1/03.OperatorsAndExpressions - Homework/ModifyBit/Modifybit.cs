using System;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            ulong mask, result;

            if (v == 0)
            {
                mask = (ulong)~(1 << p);
                result = n & mask;
                Console.WriteLine(result);
            }
            else
            {
                mask = (ulong)1 << p;
                result = n | mask;
                Console.WriteLine(result);
            }
        }
    }
}
