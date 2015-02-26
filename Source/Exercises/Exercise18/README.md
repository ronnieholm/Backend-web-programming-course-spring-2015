# Exercise 18: Bank account

This exercise contains a working BankAccount class. However, it has a few issues.

1. Try to test the BankAccount class by adding code in the usual place. 
   Specifically, include tests to make the balance become negative.
2. Now change the code in the Withdraw method so a withdrawal is only 
   done if the balance is larger than or equal to the given amount. Remember 
   to test that the change works as expected.
3. This makes the BankAccount class more realistic but there are still issues.
   You can call both Withdraw and Deposit with negative amounts (try it out), 
   which doesn't make much sense. Make changes to both methods such that they 
   only perform a withdrawal/deposit if the given amount is positive. Remember 
   that for the Withdraw method, the change made in part 2 must remain working.
4. Test that all your changes work as expected.