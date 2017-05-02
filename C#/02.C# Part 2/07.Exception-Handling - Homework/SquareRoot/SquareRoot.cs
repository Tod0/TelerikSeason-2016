using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                double number = double.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new FormatException("The number must not be negative");
                }
                
                Console.WriteLine("{0:F3}", Math.Sqrt(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
