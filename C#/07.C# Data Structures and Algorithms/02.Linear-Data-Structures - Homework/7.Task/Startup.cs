using System;
using System.Collections.Generic;

namespace Task7
{
    class Startup
    {
        public static void Main()
        {
            var arrayLength = int.Parse(Console.ReadLine());
            var array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            var counter = 0;
            var iteratedNumbers = new List<int>();
            for (int i = 0; i < arrayLength; i++)
            {
                if (iteratedNumbers.Contains(array[i]))
                {
                    continue;
                }

                for (int j = i; j < arrayLength; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }
                
                iteratedNumbers.Add(array[i]);

                Console.WriteLine($"{array[i]} -> {counter} times");
                counter = 0;
            }
        }
    }
}
