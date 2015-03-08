# The Bank Job

In this exercise we'll try to evolve parts of what could become a bank system. 
Note that the exercise is different from previous ones in that the end goal 
isn't as precisely defined. Your thoughts help shape the solution.

The progression of the exercise is to start out from a set of vague requirements 
and move toward a design for a set of classes. Then to try to code (and improve) 
upon this set of classes and use those in a complete application.

You'll have less guidance than usual and this means there's no one final or 
correct solution. Some requirements stated in the assignment might not be clear. 
You must then choose a way to interpret those.

## The setup

We wish to create an application for managing a bank. More specifically, for 
a bank with three kinds of bank accounts:

  - A "basic" account where you can deposit and withdraw money and retrieve the 
    balance.
  - A "savings" account which works like the "basic" account but with some 
    extra features:
	(a) You can only deposit money up to a certain limit.
	(b) You can only withdraw money from the account three times. After the 
	    third withdrawal there's a fee of 25 kr. for withdrawals.
  - A "young limited" account which works like the "basic" account but with 
    extra features:
    (a) You can only withdraw a certain amount of money per day.
	
Furthermore, all bank accounts should include:

  - A unique bank account number
  - The name of the bank account owner

## Step 1

Think about (not code) how you could implement this application. Which classes 
and instance are needed and how the methods would actually work. You can make 
notes, draw diagrams, and so on, but you don't need to code anything just yet. 

## Step 2

Try to actually code the classes you came up with in step 1. Remember to also 
create a few tests for the code you create. 

Important: You don't need to think about inheritance in this step.

## Step 3

See if your code from step 2 can be improved by using inheritance. The classes 
representing different kinds of bank accounts most likely have some things in 
common. For instance, they have common instance fields and methods. Think about 
how you can use inheritance to avoid declaring the same instance fields in many 
different classes. See if you can use the fact that we can override the 
implementation of a method, etc.

## Step 4

Develop a single, but probably a bit complex, class called Bank, which is supposed 
to be the interface or entry point to the bank system. A programmer using the 
bank system should thus not create bank account objects directly, but should do so 
through the methods of the Bank class. In fact, it should be possible to do all 
bank account operations through the Bank class, given the account number of a 
specific account. 

The Bank class must thus be able to create, store, and maintain bank account objects 
(by store we mean while the program is running, not in a file or database). This'll 
require that you think about what methods we need for the Bank class and how bank 
account objects are stored appropriately inside the Bank class.
