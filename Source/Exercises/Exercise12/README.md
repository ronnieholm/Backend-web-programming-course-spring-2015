# Exercise 12: Using and modifying existing class

This exercise is about using and modifying an existing class. The solution contains 
a class called Status in the Status.cs file.

1. Have a look inside Status.cs and see what the Status class definition contains. 
   See if you can identify the instance fields, the constructor, the methods that 
   return information (accessors), and the methods that change the value of an 
   instance field (mutators).

2. Now try to use the Status class. Insert code into the solution that does the 
   following: 
   
   (a) Creates a new Status object.
   (b) Prints out information about the Status object, such as the status text, 
       the number of likes, and the number of dislikes. In order to do so, you 
	   need to call methods on the Status object. 
   (c) Calls the methods which change the number of likes and dislikes. 
   (d) Prints out the information once again to observe how the information 
       has changed.

3. Now we decide to also keep track of the number of times the status has been read. 
   To do so we need to add code to the Status class. Specifically, we need to: 
   
   (a) Add a new _numberOfReads instance field to store the number of times a status 
       has been read
   (b) Update the constructor to set the instance field to an initial value. 
       What seems like an good initial value?
   (c) Add a new ReadStatus method which increases the number of times the status
       has been read by one. The method will be similar to AddOneLike method.
   (d) Add a GetNumberOfReads method to return the value of the new instance field
   (e) Update your test code to exercise the newly added methods.

4. Extra. If you have time. Add a ReadStatusMultiple method which increases the
   number of times the status has been read by a number provided by the user.
   The method needs to take this number as a parameter.