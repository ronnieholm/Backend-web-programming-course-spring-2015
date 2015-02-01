# Exercise 1: Calculate change (no computer involved)

In many supermarkets it's no longer the cashier who determines how much change a customer should
get back (in the rare case a customer actually pays in cash). Instead, the cashier inserts the 
cash into a machine, which then returns the correct change. Such a machine requires software to 
work, including software to calculate the correct change.

Calculating correct change is as such trivial. Simply subtract the due amount from the given 
cash. What's less trivial is to determine *how* to pay out the cash such that the customer
receives as few bills and coins as possible. 

For instance, suppose the due amount is 352 kr and the customer pays with one 500 kr bill. The 
change is then 148 kr. The optimal way to pay out this amount using the current Danish coin and 
bill system is then to pay out: 

  * 1 x 100-kr bill 
  * 2 x 20-kr coins 
  * 1 x 5-kr coin 
  * 1 x 2-kr coin 
  * 1 x 1-kr coin

Your task is now to describe (in writing) the calculation logic in so much detail that each step 
becomes trivial to perform. That way it becomes a easy task for a programmer to turn the logic 
into a working piece of software. 

You should consider the following points: 

  * What's the input to the calculation?
  * What steps are involved in calculating the change? (this is the hardest part) 
  * What's the output of the calculation?

Solve the exercise in groups and try out your logic on a couple of examples:

  * Due amount is 66 kr, customer pays 200 kr
  * Due amount is 1284 kr customer pays 2000 kr

As a final test, you could swap you logic with another group and see if you're capable of 
following the other groups logic and end up with the correct result. If you're unable to 
reach the correct result, discuss the reason with the other group. Is the logic wrong, or 
has it not been described in sufficient detail?