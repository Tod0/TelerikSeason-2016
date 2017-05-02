using System;
using System.Numerics;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            BigInteger binaryNum = BigInteger.Parse(binary);
            BigInteger sum = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                BigInteger lastDigit = binaryNum % 10;
                sum = (sum + lastDigit * (BigInteger)(Math.Pow(2, i)));
                binaryNum = binaryNum / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
