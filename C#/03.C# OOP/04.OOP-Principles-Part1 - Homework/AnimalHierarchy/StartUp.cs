namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models;
    using Enumerations;

    class StartUp
    {
        static void Main()
        {
            // Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat("Garfield", 5, Gender.Male));
            animals.Add(new Dog("Scooby Doo", 8, Gender.Male));
            animals.Add(new Frog("Mr. Toad", 2, Gender.Female));
            animals.Add(new Kitten("IWatchYouSleepAtNight", 3));
            animals.Add(new Tomcat("Tom", 5));
            animals.Add(new Cat("Pisana", 8, Gender.Female));
            animals.Add(new Dog("Mark", 4, Gender.Male));
            animals.Add(new Frog("Froggy", 2, Gender.Male));
            animals.Add(new Kitten("HoomanSlaya", 0));
            animals.Add(new Tomcat("PussInBoots", 3));
            animals.Add(new Cat("Pesho", 3, Gender.Male));
            animals.Add(new Dog("Sharo", 5, Gender.Male));
            animals.Add(new Frog("Kwak", 9, Gender.Female));
            animals.Add(new Kitten("DreamCrusher", 10));
            animals.Add(new Tomcat("Kotio", 9));

            var dogs = animals.Where(d => d is Dog);
            var frogs = animals.Where(f => f is Frog);
            var cats = animals.Where(c => c is Cat);
            var tomcats = animals.Where(t => t is Tomcat);
            var kittens = animals.Where(k => k is Kitten);
            
            Console.WriteLine($"Dogs' average age is: {Dog.CalculateAverageAge(dogs)}");
            Console.WriteLine($"Frogs' average age is: {Frog.CalculateAverageAge(frogs)}");
            Console.WriteLine($"Cats' average age is: {Cat.CalculateAverageAge(cats)}");
            Console.WriteLine($"Tomcats' average age is: {Tomcat.CalculateAverageAge(tomcats)}");
            Console.WriteLine($"Kittens' average age is: {Kitten.CalculateAverageAge(kittens)}");
        }
    }
}
