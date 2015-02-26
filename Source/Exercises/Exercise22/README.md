# Exercise 22: Sentinel-controlled while loops

This exercise is about implementing sentinel-controlled while-statement.

1. In the CubeCalculator.cs file a CubeCalculator class has been defined. 
   It contains methods to calculate the cube of a number provided by the
   user. Read the comments in the class definition and make sure you 
   understand what each method does. It isn't necessary to understand how 
   the methods work.
2. Execute the program. You'll be able to input a number and the cube of 
   that number is calculated. The program even handles the situation where 
   the input isn't a number. All this is accomplished by the code in the 
   Runner class. Read the code and make sure you understand how it works.
3. A major drawback of the program is that you have to re-start it each 
   time you wish to calculate a new cube value. 
   
   Change the code in the Runner class so that it becomes a sentinel-
   controlled while-loop, i.e., the user should be able to keep entering 
   numbers until a special value (the sentinel such as 0) is entered. 
   The exact details are left for you to decide.