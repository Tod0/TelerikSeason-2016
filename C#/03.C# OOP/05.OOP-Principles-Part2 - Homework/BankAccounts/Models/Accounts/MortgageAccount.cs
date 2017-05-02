namespace BankAccounts.Models.Accounts
{
    using System;

    using Customers;
    using Contracts;

    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {

        }

        public override decimal InterestAmount(int months)
        {
            decimal interestAmount = 0.00m;

            if (this.Customer is Individual && months > 6)
            {
                interestAmount = this.InterestRate / 100 * (months - 6);
            }
            else if (this.Customer is Company && months <= 12)
            {
                interestAmount = (this.InterestRate / 100 * months) / 2;
            }
            else if (this.Customer is Company && months > 12)
            {
                interestAmount = this.InterestRate / 100 * (months - 12) + (this.InterestRate / 100 * 12) / 2;
            }

            return interestAmount;
        }

        public void DepositMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You can not deposit a negative amount of money!");
            }

            if (this.Balance <= amount)
            {
                Console.WriteLine("You have paid your mortgage!");
                this.Balance = 0;
            }
            else
            {
                this.Balance -= amount;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
