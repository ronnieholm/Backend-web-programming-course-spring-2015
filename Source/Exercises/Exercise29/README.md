# Exercise 29: Book collection

This exercise illustrates the concept of a collection, which is
a class that can store and use data of a certain type without 
revealing its internal representation of data to the user of 
the collection.

The project contains the Book class (note that we consider the 
ISBN instance field to be a key for Book, i.e., no two Book 
objects can have the same ISBN value). The project also contains
an (incomplete) BookCollection class. The three public methods 
in BookCollection allow the user to store and use Book objects in 
a simple way (see comments in code for more details about each 
method).

We've chosen to store Book objects in BookCollection using 
List<Book>. Your task is now:

  1. Complete the three methods in the BookCollection class.
  2. Study the tests written in the runner class and figure 
     out what you expect the test to output.
  3. Run the program and see if the output of the test matches 
     your expectations. If not, you'll have to examine the 
	 test and your code once again.
  4. Is there anything in the program that prevents a user 
     from entering two Book objects with the same ISBN value?