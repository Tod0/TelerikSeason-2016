using System;

namespace SayHello
{
    class SayHello
    {
        static string ReadName()
        {
            string name = Console.ReadLine();
            return name;
        }

        static void Print(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }

        static void Main()
        {
            string name = ReadName();
            Print(name);
        }
    }
}
