# Exercise 30: Car pool manager

This exercise is about completing the definition of a class 
that makes use of a Dictionary object.

The project contains a Car class representating a car with only 
three instance fields: license plate, brand, and model. It doesn't 
need to be modified.

The project also contains CarPool class which is supposed to 
represent a pool of cars. For this purpose a _cars instance field 
type Dictionary is used to hold key/value pairs consisting of 
license plates and Car objects (since a car is uniquely identified
by its license plate).

  1. Have a look at the CarPool class definition. You'll see three 
     methods (AddCarToPool, RemoveCarFromPool, LookupCar) which require
	 implementation. Your job is to complete these methods according to 
	 the specification in the code file.
  2. In the file InsertCodeHere.cs, some code that tests the CarPool 
     class has been inserted. Run the program and check that your 
	 CarPool class behaves as expected.