# Exercise 11: Using and modifying existing class

This exercise is about using and modifying an existing class. The 
solution contains a new class called Book in the Book.cs file. 
 
1. Have a look inside the Book.cs file and see what the Book 
   class definition contains. It is a fairly simple class with some 
   instance fields, one constructor and some Get methods. The methods 
   BorrowFromLibrary and ReturnToLibrary are 
   noteworthy. They are to be used when a user loans a book 
   from the library and returns it again. Also, the method 
   PrintInformation prints out all information about a book.

2. Now try to use the Book class yourself. Insert some code into 
   the solution (in the Main method), that does 
   the following: 

   (a) Creates a new Book object 
   (b) Print out some information about the book (there is a 
       method you can call for that, remember?) 
   (c) Loan the book and print the book information again 
   (d) Return the book and print the book information again 

3. After this, we decide that we want to keep track of the 
   number of times a book has been borrowed. To do this, you 
   must add code to the Book class. More specifically, you need 
   to:  

   (a) Add a new instance field numberOfLoans to store the 
       number of times a book has been borrowed (what 
       would be a good type to use for this field?), 
   (b) Update the constructor to give this instance field an 
       initial value (what seems like an obvious initial value?), 
   (c) Figure out when we should change the value of the new 
       field (Hint: What method will be activated when you 
       borrow a book?), 
   (d) Add a method GetNumberOfLoans, that will return the 
       value of the new field, 
   (e) Update the code that prints book information, so that it 
       also includes the number of times the book has been 
       loaned 

4. Finally, test your new code by updating the code from part 2. 
   You should try to loan and return a book several times, to see 
   if the value for number of book loans is updated correctly 

5. [Extra – only if you have time] It seems strange that we can 
   call BorrowFromLibrary many times, without calling 
   ReturnToLibrary in between those calls. That does not make 
   sense in the real world. Could we somehow change the code 
   to handle this (Hint: That would probably require use of a 
   conditional statement, which we have not really talked about 
   yet)?