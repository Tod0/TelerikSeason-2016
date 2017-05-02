namespace BankAccounts.Models.Customers
{
    using System;
    using System.Text;

    using Infrastructure.Constants;

    public abstract class Customer
    {
        private string name;
        private int id;

        public Customer(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("There can not be customer account without a name!");
                }

                this.name = value;
            }
        }

        public int Id
        { 
            get { return this.id; }
            protected set
            {
                if (value <= ValidationConstants.MinCustomerIdNumber)
                {
                    throw new ArgumentOutOfRangeException($"Customer ID must be a positive number bigger than {ValidationConstants.MinCustomerIdNumber}");
                }

                this.id = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(100);

            builder.AppendLine(this.Name);
            builder.AppendLine($"Id: {this.Id}");

            return builder.ToString();
        }
    }
}
