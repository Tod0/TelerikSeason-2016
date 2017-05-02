namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    public class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private List<string> comments = new List<string>();

        public Discipline() {

        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The person must have a name!");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The number of lectures must be positive!");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The number of exercises must be positive!");
                }
                this.numberOfExercises = value;
            }
        }

        public IList<string> Comments
        {
            get
            {
                return this.comments;
            }
        }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.NumberOfLectures}, {this.NumberOfExercises}";
        }
    }
}
