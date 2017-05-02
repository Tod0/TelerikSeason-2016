using System;

namespace Sub_stringInText
{
    class Program
    {
        static void Main()
        {
            string pattern = Console.ReadLine();
            pattern = pattern.ToLower();
            string text = Console.ReadLine(); 
            text = text.ToLower();
            int currentIndex = 0;
            int counter = 0;
            int index = 0;

            while (text.IndexOf(pattern, index) != -1)
            {
                currentIndex = text.IndexOf(pattern, index);
                counter++;
                index = currentIndex + pattern.Length;
            }

            Console.WriteLine(counter);
        }
    }
}
