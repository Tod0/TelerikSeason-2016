namespace Task_2
{
    using System;

    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var age = int.Parse(Console.ReadLine());

            var human = new Human(age);
        }
    }
}
