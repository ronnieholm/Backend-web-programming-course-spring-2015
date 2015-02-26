using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise23
{
    // begin copy

    class CorrectChange
    {
        public void Run()
        {
            int amountToPay = 266;
            int paidAmount = 500;
            int changeToPayBack = paidAmount - amountToPay;

            // to keep things simple, we assume pay back change
            // using: 1 kr coins, 10 kr coins, and 100 kr bills.
            int numberOf1krCoins = 0;
            int numberOf10krCoins = 0;
            int numberOf100krBills = 0;

            // add code to calculate the correct change here

            Console.WriteLine(
                "Your change is {0} 1 kr coins, {1} 10 kr coins and {2} 100 kr bills", 
                numberOf1krCoins, numberOf10krCoins, numberOf100krBills);
            Console.WriteLine("A total of {0} kr", changeToPayBack);
        }
    }

    // end copy
}
