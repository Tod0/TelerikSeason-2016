namespace AnimalHierarchy.Models
{
    using System;

    using Enumerations;
    using Interfaces;

    public class Dog : Animal, ISound
    {
        public Dog()
        {

        }

        public Dog(string name, int age, Gender gender) : base(name, age, gender)
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("The dog {0} makes a sound", this.Name);
        }
    }
}
