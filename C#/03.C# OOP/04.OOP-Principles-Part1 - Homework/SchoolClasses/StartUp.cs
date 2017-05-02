namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using People;

    class StartUp
    {
        static void Main()
        {
            Student peshoPeshov = new Student("Pesho", "Peshov", 1);
            Student iliqPetkov = new Student("Iliq", "Petkov", 2);
            Student ivanDraganov = new Student("Ivan", "Draganov", 3);

            List<Student> studentsInClassA = new List<Student>();
            studentsInClassA.Add(peshoPeshov);
            studentsInClassA.Add(iliqPetkov);
            studentsInClassA.Add(ivanDraganov);

            foreach (var student in studentsInClassA)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine();

            Discipline math = new Discipline("Math", 10, 10);
            Discipline language = new Discipline("Language", 20, 10);
            Discipline art = new Discipline("Art", 5, 10);

            Teacher dinkoPetrov = new Teacher("Dinko", "Petrov");
            dinkoPetrov.AddDiscipline(math);
            dinkoPetrov.AddDiscipline(language);

            Teacher penkaHubavenkova = new Teacher("Penka", "Hubavenkova");
            penkaHubavenkova.AddDiscipline(art);

            List<Teacher> teachersForAClass = new List<Teacher>() { dinkoPetrov, penkaHubavenkova };

            Class classA = new Class("10A");
            classA.AddTeacher(dinkoPetrov);
            classA.AddTeacher(penkaHubavenkova);
            Console.WriteLine(classA.ToString() + "\n" + string.Join(", ", classA.Teachers));
        }
    }
}
