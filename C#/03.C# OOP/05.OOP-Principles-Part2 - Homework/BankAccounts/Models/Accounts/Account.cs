namespace BankAccounts.Models.Accounts
{
    using System;
    using System.Text;

    using Customers;
    using Infrastructure.Constants;

    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; private set; }

        public decimal Balance
        {
            get { return this.balance; }
            protected set
            {
                if (value < ValidationConstants.MinAccountBalance)
                {
                    throw new ArgumentOutOfRangeException($"Bank Balance must be at least {ValidationConstants.MinAccountBalance}!");
                }

                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            private set
            {
                if (value <= ValidationConstants.MinAccountInterestRate)
                {
                    throw new ArgumentOutOfRangeException($"Interest rate must be a positive number bigger than {ValidationConstants.MinAccountInterestRate}");
                }

                this.interestRate = value;
            }
        }

        public abstract decimal InterestAmount(int months);

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(500);

            builder.AppendLine($"{GetType().Name} owner: {this.Customer}");
            builder.AppendLine($"Balance: {this.Balance}");
            builder.AppendLine($"Interest Rate: {this.InterestRate}");

            return builder.ToString();
        }
    }
}
