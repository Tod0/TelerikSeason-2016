using System;

namespace BitSwap
{
    class BitSwap
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if (Math.Max(p, q) + k > 32)
            {
                Console.WriteLine("Out of range.");
            }
            else if (Math.Min(p, q) + k > Math.Max(p, q))
            {
                Console.WriteLine("Overlapping.");
            }
            else
            {
                uint[] array1 = new uint[k];
                uint[] array2 = new uint[k];
                uint result, numberRightP;

                for (int i = p; i < p + k; i++)
                {
                    numberRightP = (uint)number >> i;
                    array1[i - p] = numberRightP & 1;
                }

                for (int i = q; i < q + k; i++)
                {
                    numberRightP = (uint)number >> i;
                    array2[i - q] = numberRightP & 1;
                }

                for (int i = p; i < p + k; i++)
                {
                    if (array2[i - p] == 0)
                    {
                        uint mask = (uint)~(1 << i);
                        result = (uint)number & mask;
                    }
                    else
                    {
                        uint mask = (uint)(1 << i);
                        result = (uint)number | mask;
                    }
                    number = result;
                }

                for (int i = q; i < q + k; i++)
                {
                    if (array1[i - q] == 0)                 
                    {
                        uint mask = (uint)~(1 << i);
                        result = (uint)number & mask;
                    }
                    else                                              
                    {
                        uint mask = (uint)(1 << i);
                        result = (uint)number | mask;
                    }
                    number = result;
                }

                Console.WriteLine(number);
            }
        }
    }
}
