namespace AnimalHierarchy.Models
{
    using System;

    using Enumerations;
    using Interfaces;

    public class Tomcat : Cat, ISound
    {
        public Tomcat()
        {

        }

        public Tomcat(string name, int age) : base(name, age, Gender.Male)
        {

        }

        public new void MakeSound()
        {
            Console.WriteLine("The tomcat {0} makes a sound", this.Name);
        }
    }
}
