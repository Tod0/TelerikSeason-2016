namespace BankAccounts.Models.Accounts
{
    using System;

    using Customers;
    using Contracts;
    using Infrastructure.Constants;

    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {

        }

        public override decimal InterestAmount(int months)
        {
            decimal interestAmount = 0.00M;

            if (this.Balance < GlobalConstants.MinAmountForDepositAccToHaveInterest)
            {
                Console.WriteLine("Bank balance must be larger than {0} to count Interest Amount. Your balance is: {1}", GlobalConstants.MinAmountForDepositAccToHaveInterest, this.Balance);
            }
            else
            {
                interestAmount = (this.InterestRate / 100 * months);
            }

            return interestAmount;
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public void WithdrawMoney(decimal amount)
        {
            if (this.Balance < amount)
            {
                Console.WriteLine("Not enough money to withdraw. Your balance is: {0:C}", this.Balance);
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
