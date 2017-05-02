using System.Data.Entity;

using StudentSystem.Data;
using StudentSystem.Data.Migrations;

namespace StudentSystem.App
{
    class StartUp
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());

            var dbContext = new StudentSystemDbContext();

            using (dbContext)
            {
                Importer.AddCourses(50, dbContext);
                Importer.AddStudents(150, dbContext);
                Importer.AddHomeworks(450, dbContext);

                var studentsInWFwwciCourse = Searcher.GetAllStudenstByCourseName("WFwwci", dbContext);

                foreach (var student in studentsInWFwwciCourse)
                {
                    System.Console.WriteLine($"{student.FacultyNumber} --> {student.FirstName} {student.LastName}");
                }
            }
        }
    }
}
