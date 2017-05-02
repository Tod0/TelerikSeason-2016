using System;

namespace PrintADeck
{
    class PrintADeck
    {
        static void Main(string[] args)
        {
            string cardSign = Console.ReadLine();
            string[] allCardSigns = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int pos = 0;

            for (int i = 0; i < allCardSigns.Length; i++)
            {
                if (cardSign == allCardSigns[i])
                {
                    pos = i;
                }
            }

            for (int i = 0; i <= pos; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", allCardSigns[i]);
            }
        }
    }
}
