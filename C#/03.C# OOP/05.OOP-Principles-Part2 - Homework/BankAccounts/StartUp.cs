namespace BankAccounts
{
    using System;

    using Models.Accounts;
    using Models.Customers;
    using Infrastructure.Enumerations;

    public class StartUp
    {
        static void Main()
        {
            // Deposit Account Tests
            Console.WriteLine("Deposit Account Test:");
            Console.WriteLine();

            var individualDeposit = new DepositAccount(new Individual("Joro Ivanov", 666, new DateTime(1995, 3, 8), GenderType.Male), 100000, 3);
            Console.WriteLine("Before depositing and withdrawing money");
            Console.WriteLine(individualDeposit);
            individualDeposit.DepositMoney(15600);
            individualDeposit.WithdrawMoney(854);
            Console.WriteLine("After depositing and withdrawing money");
            Console.WriteLine(individualDeposit);

            Console.WriteLine("{0} Interest amount: {1}%", individualDeposit.GetType().Name, individualDeposit.InterestAmount(8));

            Console.WriteLine(new string('-', 50));

            var companyDeposit = new DepositAccount(new Company("Batman Inc", 1, "Bruce Wayne"), 200006, 111);
            Console.WriteLine(companyDeposit);

            Console.WriteLine(new string('-', 50));

            // Loan Account Tests
            Console.WriteLine("Loan Account Test:");
            Console.WriteLine();

            var loanAccount = new LoanAccount(new Individual("Penka Draganova", 5, new DateTime(1990, 11, 21), GenderType.Female), 1000, 2);
            Console.WriteLine(loanAccount);
            Console.WriteLine("Interest amount {0}%", loanAccount.InterestAmount(12));
            loanAccount.DepositMoney(2000);     // Paying the loan

            Console.WriteLine(new string('-', 50));

            // Mortgage Account Tests
            Console.WriteLine("Mortgage Account Test:");
            Console.WriteLine();

            var mortgageAcc = new MortgageAccount(new Company("Ivo's Company", 19500, "Ivo"), 280000, 5.5m);
            Console.WriteLine(mortgageAcc);
            Console.WriteLine("Interest amount {0}%", mortgageAcc.InterestAmount(12));
        }
    }
}
