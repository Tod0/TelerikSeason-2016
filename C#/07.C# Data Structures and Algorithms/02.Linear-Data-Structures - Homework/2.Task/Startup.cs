using System;
using System.Collections.Generic;

namespace Task2
{
    class Startup
    {
        public static void Main()
        {
            var numberCount = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            for (int i = 0; i < numberCount; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                stack.Push(currentNumber);
            }

            var reversedStack = new Stack<int>();
            while (stack.Count != 0)
            {
                reversedStack.Push(stack.Pop());
                Console.WriteLine(reversedStack.Peek());
            }
        }
    }
}
