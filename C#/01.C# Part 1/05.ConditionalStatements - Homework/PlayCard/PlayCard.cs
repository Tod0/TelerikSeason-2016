using System;

namespace PlayCard
{
    class PlayCard
    {
        static void Main(string[] args)
        {
            string[] arr = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string str = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == str)
                {
                    Console.WriteLine("yes " + str);
                    counter = 1;
                }
            }
            
            if(counter == 0)
            {
                Console.WriteLine("no " + str);
            }
        }
    }
}
