namespace SchoolClasses.People
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    public class Person : IComment
    {
        private string firstName;
        private string lastName;
        private List<string> comments = new List<string>();

        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The person must have a name!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The person must have a name!");
                }
                this.lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return this.ToString();
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
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
