using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise18
{
    // begin copy

    class BankAccount
    {
        private double _balance;

        public BankAccount()
        {
            _balance = 0;
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }

        public void Withdraw(double amount)
        {
            _balance = _balance - amount;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }

    // end copy
}
