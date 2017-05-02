namespace AnimalHierarchy.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Enumerations;

    public abstract class Animal
    {
        private string name;
        private int age;

        public Animal()
        {

        }

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can not be empty!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The age can not be less than 0");
                }
                this.age = value;
            }
        }

        public Gender Gender { get; private set; }

        public static double CalculateAverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(a => a.Age);
        }
    }
}
