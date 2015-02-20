# Exercise 10: Using a class

This exercise is about using an existing Student class contained in
the Student.cs file.

1. Have a look inside the Student.cs file and see what the Student 
   class definition contains (constructors, methods, etc). See if you 
   can figure out what each method does.

2. Now try to use the Student class yourself. Insert code (in the Main 
   method) which does the following: 

   (a) Create a new student object
   (b) Add a few test scores to the student 
   (c) Print out the name and average test score for the 
       student (use Console.WriteLine(...))

3. Extend the code in the Student class so that it can also hold 
   information about the country for the student. Specifically, 
   you need to: 

   (a) Add a new instance field to hold the country value 
   (b) Change the constructor to include a country value in the 
       parameter list. Also remember to use the new parameter to
	   initialize the country instance field 
   (c) Add a method GetCountry to return the country value

4. Finally, test the new code by updating the code from part 2 
   such that country information is included.
