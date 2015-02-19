# Exercise 14: Dice game

This exercise is about using an existing class and completing another unfinished one. 
The solution contains classes Die and DiceCup in the files Die.cs and DiceCup.cs, 
respectively.

1. Investigate the Die class. It's complete and fairly straightforward. Note how the Die
   class uses another class called Random, which is part of the .NET class library. Try out 
   the class by creating a Die object (in the usual place for inserting code) and call the 
   RollDie and GetValue methods and print the value you get back. Notice how running the 
   program multiple program, you get different results like for a real die.

2. Investigate the DiceCup class. It's supposed to represent a cup with two dice in it. 
   Hence, the class contains two instance fields of type Die. The constructor of the class
   has been completed. Next, three public methods in the DiceCup class needs to be 
   implemented:

   (a) RollDice: should roll both dices in the cup. No value is returned.
   (b) GetTotalValue: should return the total value of the two dice in the cup.
   (c) IsTotalValueLargerThan: should accept one integer value as input and 
       return either true or false. True if the total value of the two dice is 
	   larger than the input value, otherwise false.

3. Your job is to add the three methods to the DiceCup class. The signature for each method 
   is already included as comments in the class. Once you complete the methods, add code to
   test the DiceCup class works as expected.

4. Extra. Only if you have time. How can you change the game such that it uses 10-sided dice 
   instead of a 6-sided one? Can you make it so that the user decides how many sides the dice 
   should have?