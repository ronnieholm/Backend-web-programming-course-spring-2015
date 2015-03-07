# Exercise 34: Exceptions

This exercise is about throwing and catching exceptions.

The project contains a BankAccount class. It defines a simple
bank account but there're a few restrictions to it (see the code). 
One restriction is that the balance must not become negative.

The project also contains three additional classes:

  - IllegalInterestRateException
  - NegativeAmountException
  - WithdrawAmountTooLargeException

They're all exception classes, i.e., they inherit from Exception. 
The specific purpose of each exception class is described in code.

The BankAccount class already uses the WithdrawAmountTooLargeException 
class to prevent the balance from becoming negative (see the Withdraw 
method).

  1. Modify the code in the BankAccount class such that the 
     additional exception classes are used.
  2. Update the test code found in the Runner class such that 
     method calls that could cause an exception to be thrown 
	 are enclosed in try/catch blocks.
  3. Test that exceptions are thrown and handled properly, by 
     adding test code to make the exceptions be thrown.