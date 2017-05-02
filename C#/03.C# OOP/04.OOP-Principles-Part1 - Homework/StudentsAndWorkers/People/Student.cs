namespace StudentsAndWorkers.People
{
    using System;

    public class Student : Human
    {
        private int grade;

        public Student()
        {

        }

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Grade must be in the range [2, 6]!");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}'s grade is {this.Grade}.";
        }
    }
}
