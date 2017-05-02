namespace AnimalHierarchy.Models
{
    using System;

    using Enumerations;
    using Interfaces;

    public class Frog : Animal, ISound
    {
        public Frog()
        {

        }

        public Frog(string name, int age, Gender gender) : base(name, age, gender)
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("The frog {0} makes a sound", this.Name);
        }
    }
}
