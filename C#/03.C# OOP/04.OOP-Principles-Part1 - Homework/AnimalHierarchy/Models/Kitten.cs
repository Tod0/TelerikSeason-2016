namespace AnimalHierarchy.Models
{
    using System;

    using Enumerations;
    using Interfaces;

    public class Kitten : Cat, ISound
    {
        public Kitten()
        {

        }

        public Kitten(string name, int age) : base(name, age, Gender.Female)
        {

        }

        public new void MakeSound()
        {
            Console.WriteLine("The kitten {0} makes a sound", this.Name);
        }
    }
}
