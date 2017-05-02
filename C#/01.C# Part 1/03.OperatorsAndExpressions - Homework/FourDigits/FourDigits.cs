using System;

namespace FourDigits
{
    class FourDigits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstDigit = n / 1000;

            int secondDigit = n / 100;
            secondDigit %= 10;

            int thirdDigit = n / 10;
            thirdDigit %= 10;

            int forthDigit = n % 10;

            Console.WriteLine(firstDigit + secondDigit + thirdDigit + forthDigit);
            Console.WriteLine("{0}{1}{2}{3}", forthDigit, thirdDigit, secondDigit, firstDigit);
            Console.WriteLine("{0}{1}{2}{3}", forthDigit, firstDigit, secondDigit, thirdDigit);
            Console.WriteLine("{0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, forthDigit);
        }
    }
}
