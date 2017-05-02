namespace StudentClass.Models
{
    using Utils;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.NullVerification(value);
                this.name = value;
            }
        }

        public int? Age { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Name: {this.Name}");

            if (this.Age != null)
            {
                builder.AppendLine($"Age: {this.Age}");
            }
            else
            {
                builder.AppendLine($"Age: <not specified>");
            }

            return builder.ToString();
        }

    }
}
