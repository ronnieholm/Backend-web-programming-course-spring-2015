using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise34
{
    class Runner
    {
        public void Run()
        {
            // creates bank account with 25% interest rate (is that legal?)
            BankAccount account = new BankAccount(25.0);
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

    // exception to be thrown in case user attempts to withdraw amount larger than balance
    class WithdrawAmountTooLargeException : Exception
    {
    }

    // exception to be thrown in case the bank account is defined with illegal interest rate
    class IllegalInterestRateException : Exception
    {
    }

    // exception to be thrown in case user attempts to withdraw or deposit negative amount
    class NegativeAmountException : Exception
    {
    }

    class BankAccount
    {
        // balance which must not become negative
        private double _balance;

        // interest rate must be between 0.0 and 20.0.
        private double _interestRate;

        public BankAccount(double interestRate)
        {
            _interestRate = interestRate;
            _balance = 0.0;
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }

        public void Withdraw(double amount)
        {
            if (_balance < amount)
            {
                throw new WithdrawAmountTooLargeException();
            }

            _balance = _balance - amount;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
