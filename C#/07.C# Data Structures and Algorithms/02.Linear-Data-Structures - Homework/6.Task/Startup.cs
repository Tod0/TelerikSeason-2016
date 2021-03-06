﻿using System;
using System.Collections.Generic;

namespace Task6
{
    class Startup
    {
        public static void Main()
        {
            var inputValues = new List<int>();
            while (true)
            {
                var nextLine = Console.ReadLine();
                if (string.IsNullOrEmpty(nextLine))
                {
                    break;
                }

                int nextValue;
                var isParsed = int.TryParse(nextLine, out nextValue);
                if (isParsed)
                {
                    inputValues.Add(nextValue);
                }
            }

            var occurancesCounters = new Dictionary<int, int>();
            foreach (var value in inputValues)
            {
                var keyExists = occurancesCounters.ContainsKey(value);
                if (keyExists)
                {
                    occurancesCounters[value]++;
                }
                else
                {
                    occurancesCounters.Add(value, 1);
                }
            }

            var result = new List<int>();
            foreach (var item in occurancesCounters)
            {
                if (item.Key % 2 == 0)
                {
                    for (int i = 0; i < item.Value; i++)
                    {
                        result.Add(item.Key);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
