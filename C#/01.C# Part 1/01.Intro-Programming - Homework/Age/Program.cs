using System;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birthday: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            int age = today.Year - birthday.Year;
            if (today < birthday.AddYears(age))
                age--;
            Console.WriteLine("Your age is: " + age);
            Console.WriteLine("Your age after 10 years will be: " + (age + 10));   
        }
    }
}
