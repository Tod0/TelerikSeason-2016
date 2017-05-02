using System;
using System.Collections.Generic;
using System.Text;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string s = Console.ReadLine();

            // with string
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    s = s.Remove(i, 1);
                    i -= 1;
                }
            }

            Console.WriteLine(s);

            // with list
            /*
            List<char> list = new List<char>(s);

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    list.RemoveAt(i);
                    i -= 1;
                }
            }

            foreach (var ch in list)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
            */

            // with StringBuilder
            /*
            StringBuilder sb = new StringBuilder(s);

            for (int i = 0; i < sb.Length - 1; i++)
            {
                if (sb[i] == sb[i + 1])
                {
                    sb.Remove(i, 1);
                    i -= 1;
                }
            }

            Console.WriteLine(sb);
            */
        }
    }
}
