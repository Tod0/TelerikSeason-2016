using System;
using System.Collections.Generic;

namespace Task5
{
    class Startup
    {
        public static void Main()
        {
            var list = new List<int>();

            while (true)
            {
                var number = Console.ReadLine();

                if (number == "")
                {
                    break;
                }

                list.Add(int.Parse(number));
            }

            list.RemoveAll(i => i < 0);
            PrintList(list);
        }

        static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
