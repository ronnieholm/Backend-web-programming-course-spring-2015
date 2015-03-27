# Exercise 32: Company info I

This exercise comes with just the Employee class. It's supposed to serve as 
base class for a number of derived classes.

  1. Examine the Employee class. You can tell that an employee has a name 
     and a monthly salary, both of which are set from the constructor. 
	 After construction the values cannot be changed. Note also how the 
	 GetSalaryPerMonth() method is declared virtual.

  2. Define a Worker class to be derived from Employee. A 
     worker has a skill to be represented by a string, like "truck driver" 
	 or "maintenance". Thus, the Worker class should have an instance field 
	 to represent or store skill. This instance field should be set when a
	 Worker object is constructed and it should be possible to change it 
	 later. When implementing the Worker class, pay special attention when 
	 implementing the constructor (it must call the base class constructor).

  3. Define a Manager class to be derived from the Employee. In addition to 
     having a monthly salary, a manager also has a monthly bonus, which should 
	 be specified at construction. The bonus is paid out if the manager has 
	 worked more than 180 hours in a month. It should be possible to specify 
	 the number of hours worked after the object has been created. When implementing 
	 the Manager class, pay special attention when implementing the 
	 GetSalaryPerMonth() method as it should include the bonus if the bonus 
	 condition is met. It's supposed to override the base class method.

  4. Define a class Director to be derived from Manager, i.e., not the Employee 
     class. A director is a manager who has a fixed monthly bonus of 20000. The 
	 condition for triggering the bonus is the same as for a manager. When 
	 implementing the Director class, pay special attention to the constructor. Does 
	 the class need anything but a constructor?

  5. Create a test for the classes as usual with a runner class. More 
     specifically, you should 
	 
	 (a) Create a list which can hold Employee objects
	 (b) Create a few Worker objects and add them to the list
	 (c) Create a few Manager objects, set the hours worked, and add them to 
	     the list
     (d) Create few Director objects, set the hours worked, and add 
	     them to the list
     (e) Using a loop statement, print out the content of the arraylist in the
	     format "(name) has a salary of (salary)".