using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise23
{
    class CorrectChangeSolution
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
            int changeLeftToPay = changeToPayBack;

            while (changeLeftToPay >= 100)
            {
                numberOf100krBills = numberOf100krBills + 1;
                changeLeftToPay = changeLeftToPay - 100;
            }

            while (changeLeftToPay >= 10)
            {
                numberOf10krCoins = numberOf10krCoins + 1;
                changeLeftToPay = changeLeftToPay - 10;
            }

            numberOf1krCoins = changeLeftToPay;

            Console.WriteLine(
                "Your change is {0} 1 kr coins, {1} 10 kr coins and {2} 100 kr bills",
                numberOf1krCoins, numberOf10krCoins, numberOf100krBills);
            Console.WriteLine("A total of {0} kr", changeToPayBack);
        }
    }
}
