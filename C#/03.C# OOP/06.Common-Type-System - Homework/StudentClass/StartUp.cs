namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Models;
    using Enumerations;

    public class StartUp
    {
        static void Main()
        {
            // Student Tests!
            Console.WriteLine("Student Tests:");
            Student firstStudent = new Student("Pesho", "Georgiev", "Ivanov", 656123, "Liulin 5", "xXxkillerxXx@abv.bg", "0885235465", "IT", SpecialtyType.Cooking, UniversityType.Cambridge, FacultyType.Medicine);
            Student secondStudent = new Student("Stela", "Ivanova", "Petrova", 659876, "Mall Sofia", "slatkutuuumaceeee@gmail.com", "0888123568", "Maths", SpecialtyType.SoftwareEngineering, UniversityType.Oxford, FacultyType.Mathematics);

            var equalStudents = firstStudent == secondStudent;
            var hashCode = firstStudent.GetHashCode();

            // Testing Equal()
            Console.WriteLine("\nFirst and second student are equal? -> {0}", equalStudents);
            Console.WriteLine(new string('-', 60));

            // Testing GetHashCode()
            Console.WriteLine("Hash code of first student -> " + hashCode);
            Console.WriteLine(new string('-', 60));

            // Printing Student
            Console.WriteLine(firstStudent);
            Console.WriteLine(new string('-', 60));

            // Changing the specialty on the cloning student doesnt affect the original firstStudent 
            var firstStudentCloning = firstStudent.Clone() as Student;
            firstStudentCloning.Faculty = FacultyType.Sports;
            Console.WriteLine(firstStudentCloning);

            // Comparing students by first criteria -> Names, then by second criteria -> SS Number
            Console.WriteLine(new string('-', 60));
            Console.WriteLine("Comparisson -> " + firstStudent.CompareTo(secondStudent) + Environment.NewLine);
            Console.WriteLine(new string('-', 60));

            // Person Tests
            Console.WriteLine("Person Tests:");
            Console.WriteLine();
            Person firstPerson = new Person("Dragoi Blagoev", 5);
            Person secondPerson = new Person("Ivcho");

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}
