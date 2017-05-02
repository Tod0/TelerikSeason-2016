namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using People;

    class StartUp
    {
        static void Main()
        {
            Worker w1 = new Worker("Petko", "Georgiev", 500, 8);
            Console.WriteLine("The worker gets {0:F2} money per hour.", w1.MoneyPerHour());

            // Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            List<Student> students = new List<Student>();
            students.Add(new Student("Gosho", "Georgiev", 2));
            students.Add(new Student("Ivan", "Petrov", 5));
            students.Add(new Student("Krisko", "Beats", 6));
            students.Add(new Student("Cvetelina", "Petkova", 5));
            students.Add(new Student("Mitio", "TheEyes", 2));
            students.Add(new Student("Rick", "Astley", 4));
            students.Add(new Student("Petran", "Petranov", 4));
            students.Add(new Student("Todor", "Palazov", 5));
            students.Add(new Student("Georgi", "Kirilov", 3));
            students.Add(new Student("Tina", "Mihaylova", 6));

            var sortedStudents = students.OrderBy(x => x.Grade);
            Console.WriteLine("Students sorted by grade in ascending order:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("-------------------------");

            // Initialize a list of 10 workers and sort them by money per hour in descending order.
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Gosho", "Georgiev", 100, 20));
            workers.Add(new Worker("Ivan", "Petrov", 456, 5));
            workers.Add(new Worker("Krisko", "Beats", 869, 2));
            workers.Add(new Worker("Cvetelina", "Petkova", 1000, 10));
            workers.Add(new Worker("Mitio", "TheEyes", 10000, 1));
            workers.Add(new Worker("Rick", "Astley", 35, 3));
            workers.Add(new Worker("Petran", "Petranov", 256, 6));
            workers.Add(new Worker("Todor", "Palazov", 750, 5));
            workers.Add(new Worker("Georgi", "Kirilov", 900, 9));
            workers.Add(new Worker("Tina", "Mihaylova", 200, 5));

            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            Console.WriteLine("Workers sorted by money per hour in descending order:");
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine("-------------------------");

            // Merge the lists and sort them by first name and last name.
            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            var sortedHumans =
                from h in humans
                orderby h.FirstName ascending, h.LastName ascending
                select h;
            Console.WriteLine("Sorted humans:");
            foreach (var h in sortedHumans)
            {
                Console.WriteLine(h);
            }
        }
    }
}
