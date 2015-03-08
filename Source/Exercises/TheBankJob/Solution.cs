using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// note: step 4 isn't part of this solution.

namespace Exercises.TheBankJob
{
    class Runner
    {
        public void Run()
        {
            // test of basis account
            Console.WriteLine();
            Console.WriteLine("Test of basis account");
            BasicAccountSolution basic = new BasicAccountSolution("Mr. Basic", 1);
            PrintAccountInformation(basic);

            basic.Deposit(3000);
            PrintAccountInformation(basic);

            basic.Deposit(3000);
            basic.Deposit(3000);
            basic.Deposit(3000);
            basic.Deposit(3000);
            PrintAccountInformation(basic);

            basic.Withdraw(1000);
            PrintAccountInformation(basic);

            basic.Withdraw(1000);
            basic.Withdraw(1000);
            basic.Withdraw(1000);
            basic.Withdraw(1000);
            PrintAccountInformation(basic);

            // test of savings account
            Console.WriteLine();
            Console.WriteLine("Test of savings account");
            SavingsAccountSolution saving = new SavingsAccountSolution("Mr. Savings", 2, 10000);
            PrintAccountInformation(saving);

            saving.Deposit(3000);
            PrintAccountInformation(saving);

            saving.Deposit(3000);
            PrintAccountInformation(saving);
            saving.Deposit(3000);
            PrintAccountInformation(saving);
            saving.Deposit(3000);
            PrintAccountInformation(saving);
            saving.Deposit(3000);
            PrintAccountInformation(saving);

            saving.Withdraw(1000);
            PrintAccountInformation(saving);

            saving.Withdraw(1000);
            PrintAccountInformation(saving);
            saving.Withdraw(1000);
            PrintAccountInformation(saving);
            saving.Withdraw(1000);
            PrintAccountInformation(saving);
            saving.Withdraw(1000);
            PrintAccountInformation(saving);

            // test of young limited account
            Console.WriteLine();
            Console.WriteLine("Test of young limited account");
            YoungLimitedAccountSolution young = new YoungLimitedAccountSolution("Mr. Limited", 3, 2000);
            PrintAccountInformation(young);

            young.Deposit(3000);
            PrintAccountInformation(young);

            young.Deposit(3000);
            young.Deposit(3000);
            young.Deposit(3000);
            young.Deposit(3000);
            PrintAccountInformation(young);

            young.Withdraw(1000);
            PrintAccountInformation(young);

            young.Withdraw(1000);
            PrintAccountInformation(young);
            young.Withdraw(1000);
            PrintAccountInformation(young);
            young.DailyMaintenance();
            young.Withdraw(1000);
            PrintAccountInformation(young);
            young.Withdraw(1000);
            PrintAccountInformation(young);
        }

        public void PrintAccountInformation(BasicAccountSolution acc)
        {
            Console.WriteLine("Account no. {0} owned by {1}, has a balance of {2} kr.", acc.GetAccountNo(), acc.GetOwnerName(), acc.GetBalance());
        }
    }

    // negative amounts aren't handled
    public class BasicAccountSolution
    {
        private double _balance;
        private string _owner;
        private int _accountNumber;

        public BasicAccountSolution(string owner, int accountNumber)
        {
            _owner = owner;
            _accountNumber = accountNumber;
        }

        public virtual void Deposit(double amount)
        {
            _balance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            _balance -= amount;
        }

        // assume each bank account have some sort of daily maintenance like calculating 
        // interest rate, resetting limits, etc. Another class must call this method. It 
        // isn't the bank account itself that detects the passing of a day.
        public virtual void DailyMaintenance()
        {
        }

        public double GetBalance()
        {
            return _balance;
        }

        public string GetOwnerName()
        {
            return _owner;
        }

        public int GetAccountNo()
        {
            return _accountNumber;
        }
    }

    class SavingsAccountSolution : BasicAccountSolution
    {
        // deposit limit updated every time a deposit is made.
        private double _depositLimit;
        private int _numberOfWithdraws;

        // as the exercise defines the values of these they are made constants. However,
        // they could be instance fields initialised through the constructor instead.
        private const int _numberOfWithdrawsLimit = 3;
        private const double _withdrawFee = 25.0;

        public SavingsAccountSolution(string owner, int accountNumber, double depositLimit)
            : base(owner, accountNumber)
        {
            _depositLimit = depositLimit;
        }

        public override void Deposit(double amount)
        {
            // deposit only allowed if amount is lower than or equal to deposit limit
            if (amount <= _depositLimit)
            {
                base.Deposit(amount);
                _depositLimit -= amount;
            }
            else
            {
                Console.WriteLine("This deposit of {0} exceeds the current deposit limit of {1}", amount, _depositLimit);
            }
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            _numberOfWithdraws++;

            // if limit for withdrawals has been exceeded a fee is charged
            if (_numberOfWithdraws > _numberOfWithdrawsLimit)
            {
                base.Withdraw(_withdrawFee);
                Console.WriteLine("You have beed charged a fee of {0} for your withdrawal", _withdrawFee);
            }
        }
    }

    class YoungLimitedAccountSolution : BasicAccountSolution
    {
        private double _dailyWithdrawLimit;
        private double _dailyWithdrawLeft;

        public YoungLimitedAccountSolution(string owner, int accountNumber, double dailyWithdrawLimit)
            : base(owner, accountNumber)
        {
            _dailyWithdrawLimit = dailyWithdrawLimit;
            _dailyWithdrawLeft = dailyWithdrawLimit;
        }

        public override void Withdraw(double amount)
        {
            // withdraw only allowed if amount is lower than or equal to the remaining withdraw limit
            if (amount <= _dailyWithdrawLeft)
            {
                base.Withdraw(amount);
                _dailyWithdrawLeft -= amount;
            }
            else
            {
                Console.WriteLine("The withdrawal of {0} kr. would cause you to exceed your daily withdraw limit", amount);
            }
        }

        // resets back to the original withdraw limit
        public override void DailyMaintenance()
        {
            base.DailyMaintenance();
            _dailyWithdrawLeft = _dailyWithdrawLimit;
        }
    }
}
