using System;

namespace Task3.RefactorTheLoop
{
    public class StartUp
    {
        static void Main()
        {
            var arrayLength = int.Parse(Console.ReadLine());
            var array = new int[arrayLength];

            for (int i = 0; i < 100; i++)
            {
                var expectedValue = array[array.Length - 1];
                bool isDivisibleByTen = i % 10 == 0;

                if (isDivisibleByTen && array[i] == expectedValue)
                {
                    Console.WriteLine("Value Found");
                    break;
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
