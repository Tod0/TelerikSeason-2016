using System;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            char[] alphabet = new char[26];
            string word = Console.ReadLine();
            char[] letter = word.ToCharArray();

            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)(i + ('a'));
            }

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (letter[i] == alphabet[j])
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }
    }
}
