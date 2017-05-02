using System;

namespace BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());

            uint[] array1 = new uint[3];
            uint[] array2 = new uint[3];
            uint result, numberRightP;

            for (int i = 3; i < 6; i++)
            {
                numberRightP = number >> i;
                array1[i - 3] = numberRightP & 1;
            }

            for (int i = 24; i < 27; i++)
            {
                numberRightP = number >> i;
                array2[i - 24] = numberRightP & 1;
            }

            for (int i = 3; i < 6; i++)
            {
                if (array2[i - 3] == 0)
                {
                    uint mask = (uint)~(1 << i);
                    result = number & mask;
                }
                else
                {
                    uint mask = (uint)(1 << i);
                    result = number | mask;
                }
                number = result;
            }

            for (int i = 24; i < 27; i++)
            {
                if (array1[i - 24] == 0)
                {
                    uint mask = (uint)~(1 << i);
                    result = number & mask;
                }
                else
                {
                    uint mask = (uint)(1 << i);
                    result = number | mask;
                }
                number = result;
            }

            Console.WriteLine(number);
        }
    }
}
