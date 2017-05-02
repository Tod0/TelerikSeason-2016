namespace AnimalHierarchy.Models
{
    using System;

    using Enumerations;
    using Interfaces;

    public class Cat : Animal, ISound
    {
        public Cat()
        {

        }

        public Cat(string name, int age, Gender gender) : base(name, age, gender)
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("The cat {0} makes a sound", this.Name);
        }
    }
}
