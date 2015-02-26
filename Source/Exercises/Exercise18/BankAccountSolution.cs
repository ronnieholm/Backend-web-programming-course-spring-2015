using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise18
{
    class Runner
    {
        public void Run()
        {
            // 1
            BankAccountSolution b1 = new BankAccountSolution();
            b1.Deposit(10);
            b1.Withdraw(15);
            Console.WriteLine(b1.GetBalance());

            // 2
            BankAccountSolution b2 = new BankAccountSolution();
            b2.Deposit(10);
            b2.Withdraw(15);
            Console.WriteLine(b2.GetBalance());

            // 3
            BankAccountSolution b3 = new BankAccountSolution();
            b3.Deposit(-10);
            b3.Withdraw(-10);
            Console.WriteLine(b3.GetBalance());
        }
    }

    class BankAccountSolution
    {
        private double _balance;

        public BankAccountSolution()
        {
            _balance = 0;
        }

        public void Deposit(double amount)
        {
            // 3
            if (amount > 0)
            {
                _balance = _balance + amount;
            }
        }

        public void Withdraw(double amount)
        {
            // 2 and 3
            if (amount <= _balance && amount > 0)
            {
                _balance = _balance - amount;
            }
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
