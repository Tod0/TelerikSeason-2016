namespace School.Models
{
    using System;
    using System.Collections.Generic;

    using Utils;

    public class Course
    {
        private IList<Student> students;

        public Course()
        {
            this.students = new List<Student>();
        }

        public IList<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public void AddStudent(Student student)
        {
            if (this.students.Count == Constants.CourseMaxCapacity)
            {
                throw new ArgumentException(string.Format(Constants.CourseIsFull, Constants.CourseMaxCapacity));
            }
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (this.students.Count == Constants.CourseMinCapacity)
            {
                throw new ArgumentException(string.Format(Constants.CourseIsEmpty, Constants.CourseMinCapacity));

            }
            this.students.Remove(student);
        }
    }
}
