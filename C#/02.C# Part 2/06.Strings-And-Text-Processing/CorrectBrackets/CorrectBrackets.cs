using System;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int counter = 0;

            foreach (char symbol in str)
            {
                if (symbol == '(')
                {
                    counter++;
                }
                else if (symbol == ')')
                {
                    counter--;
                }

                if (counter < 0)
                {
                    break;
                }
            }

            if (counter == 0)
                Console.WriteLine("Correct");
            else
                Console.WriteLine("Incorrect");
        }
    }
}
