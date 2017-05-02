using System;
using System.Collections.Generic;
using System.Linq;

using StudentSystem.Data;
using StudentSystem.Models;

namespace StudentSystem.App
{
    public class Searcher
    {
        public static ICollection<Student> GetAllStudenstByCourseName(string courseName, StudentSystemDbContext dbContext)
        {
            if (string.IsNullOrEmpty(courseName))
            {
                throw new ArgumentNullException("The course name can not be null or empty string");
            }

            Course course = dbContext.Courses.Where(c => c.Name == courseName).FirstOrDefault();

            if (course == null)
            {
                throw new ArgumentException(nameof(courseName), $"This {courseName} doesn't exist");
            }

            var students = course.Students;

            return students;
        }
    }
}
