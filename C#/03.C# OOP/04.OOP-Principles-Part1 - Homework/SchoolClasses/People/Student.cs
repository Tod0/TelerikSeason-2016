namespace SchoolClasses.People
{
    using System;

    using Interfaces;

    public class Student : Person, IComment
    {
        private int classNumber;

        public Student()
        {

        }

        public Student(string firstName, string lastName, int classNumber) : base(firstName, lastName) 
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Class number is invalid!");
                }
                this.classNumber = value;
            }
        }
    }
}
