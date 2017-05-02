namespace SchoolClasses.People
{
    using System.Collections.Generic;

    using Interfaces;

    public class Teacher : Person, IComment
    {
        private List<Discipline> disciplines = new List<Discipline>();

        public Teacher()
        {

        }

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.Disciplines.Remove(discipline);
        }
    }
}
