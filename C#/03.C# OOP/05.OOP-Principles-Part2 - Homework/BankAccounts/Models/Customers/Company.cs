namespace BankAccounts.Models.Customers
{
    using System;
    using System.Text;

    public class Company : Customer
    {
        private string companyManager;

        public Company(string name, int id, string companyManager) : base(name, id)
        {
            this.CompanyManager = companyManager;
        }

        public string CompanyManager
        {
            get { return this.companyManager; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("There can not be company account without a company manager's name!");
                }

                this.companyManager = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(100);

            builder.Append($"Company Manager: {this.CompanyManager}");

            return base.ToString() + builder.ToString();
        }
    }
}
