namespace SchoolClasses
{
    using System.Collections.Generic;

    public class School
    {
        private List<Class> classes = new List<Class>();

        public School()
        {

        }

        public List<Class> Classes
        {
            get
            {
                return this.classes;
            }
            set
            {
                this.classes = value;
            }
        }

        public void AddClass(Class schoolClass)
        {
            this.Classes.Add(schoolClass);
        }

        public void RemoveClass(Class schoolClass)
        {
            this.Classes.Remove(schoolClass);
        }
    }
}
