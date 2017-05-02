namespace BankAccounts.Models.Customers
{
    using System;
    using System.Text;

    using Infrastructure.Enumerations;

    public class Individual : Customer
    {
        public Individual(string name, int id, DateTime birthDate, GenderType gender) : base(name, id)
        {
            this.BirthDate = birthDate;
            this.Gender = gender;
        }

        public DateTime BirthDate { get; private set; }

        public GenderType Gender { get; private set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(100);

            builder.AppendLine($"Birth Date: {this.BirthDate:dd.MM.yyyy}");
            builder.Append($"Gender: {this.Gender}");

            return base.ToString() + builder.ToString();
        }
    }
}
