namespace School.Models
{
    using Utils;

    public class Student
    {
        private string name;
        private int id;

        public Student(string name)
        {
            this.Name = name;
            this.Id = IdGenerator.GenerateId();
        }

        public string Name {
            get
            {
                return this.name;
            }
            protected set
            {
                Validator.ValidateNullOrEmpty(value, Constants.StudentNameCannotBeNull);
                this.name = value;
            }
        }

        public int Id {
            get
            {
                return this.id;
            }
            private set
            {
                Validator.ValidateIntRange(value, Constants.MinimumIdNumber, Constants.MaximumIdNumber, Constants.IdOutOfRange);
                this.id = value;
            }
        }
    }
}
