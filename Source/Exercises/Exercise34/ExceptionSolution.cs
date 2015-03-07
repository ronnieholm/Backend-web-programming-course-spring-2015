using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise34
{
    class RunnerSolution
    {
        public void Run()
        {
            // creates bank account with 25% interest rate (is that legal?)
            BankAccountSolution account = new BankAccountSolution(25.0);
            account.Deposit(2000);

            // should this be legal?
            account.Deposit(-1000);

            // attempt to withdraw
            try
            {
                account.Withdraw(3000);
            }
            catch (WithdrawAmountTooLargeException)
            {
                Console.WriteLine("You tried to withdraw too much money");
            }

            Console.WriteLine("Balance is now: {0}", account.GetBalance());
        }
    }

    class BankAccountSolution
    {
        // balance which must not become negative
        private double _balance;

        // interest rate must be between 0.0 and 20.0.
        private double _interestRate;

        public BankAccountSolution(double interestRate)
        {
            if (interestRate < 0 || interestRate > 20)
            {
                throw new IllegalInterestRateException();
            }

            _interestRate = interestRate;
            _balance = 0.0;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new NegativeAmountException();
            }
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new NegativeAmountException();
            }
            if (_balance < amount)
            {
                throw new WithdrawAmountTooLargeException();
            }
            _balance -= amount;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
