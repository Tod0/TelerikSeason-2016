namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    using People;
    using Interfaces;

    public class Class : IComment
    {
        private string textId;
        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();
        private List<string> comments = new List<string>();

        public Class()
        {

        }

        public Class(string textId)
        {
            this.TextId = textId;
        }

        public string TextId
        {
            get
            {
                return this.textId;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Text ID can not be empty!");
                }
                this.textId = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }

        public IList<string> Comments
        {
            get
            {
                return this.comments;
            }
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }

        public override string ToString()
        {
            return this.TextId;
        }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
