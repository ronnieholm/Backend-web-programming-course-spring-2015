# Exercise 33: Company info II

This exercise comes with just the Employee class. It's supposed to serve as 
base class for a number of derived classes as in the previous exercise.

  1. Examine the Employee class. You see how an employee has just a name and
     nothing else. The rules for how a salary is calculated are now completely 
	 free and should be made concrete in the derived classes. However, general
	 rules for salary calculation do exist:

     (a) Part of the salary is considered to be a bonus.
     (b) The bonus is paid if a certain condition is met.

  2. The above rules for calculating the salary are vague and the Employee class 
     can therefore not contain any specific implementation of salary calculation. 
	 However, a number of abstract methods relating to salary calculation are 
	 included in the Employee class. Since all methods are defined as abstract, 
	 the Employee class itself becomes abstract. Can you then create an Employee 
	 object?

  3. We now wish to define a Worker classto represent a worker kind of employee.
     A worker has the following characteristics with regards to salary:

     (a) A worker is paid a fixed amount per hour.
     (b) A worker works a fixed number of hours per month.
     (c) A Worker does not receive a bonus.

  4. Given the above definitions, implement the Worker class. It'll should be
     derived from Employee. You'll need to include instance fields for hourly pay 
	 and hours worked per month and provide concrete implementations of the abstract 
	 methods. Should you be able to create a Worker object?

  5. We now wish to define a Manager class. A manager is somewhat more 
     weakly defined than a worker with regards to salary:

     (a) A manager has a fixed monthly base salary.
     (b) A manager has a fixed monthly bonus.
     (c) The condition for when the bonus is paid out may vary depending
	     on the specific type of manager (so Manager might become a base 
		 class?).

  6. Given the above definitions, implement the Manager class. It should be
     derived from Employee. You'll need to include instance fields for monthly 
	 base salary and monthly bonus and provide concrete implementations for some 
	 of the abstract methods. Should you be able to create a Manager object 
	 (probably not, and why not)? 
	 
	 Should the Manager class then be an abstract class?

  7. We now wish to define a JuniorManager class. This class will be derived 
     from the Manager class. A junior manager will have the bonus paid out 
	 if (s)he has worked more than 180 hours during the month. So we'll need
	 to add an instance field to hold the number of hours worked, a way of 
	 setting this value, and, very importantly, to provide a concrete implementation 
	 of the IsBonusPaidOut() method. 
	 
	 Should you be able to create a JuniorManager object (you probably should)?

  8. We now wish to define a SeniorManager class. This class will be 
     derived from the Manager class. A senior manager will have the bonus 
	 paid out if (s)he has a "performance level" of at least 6 during 
	 the month. So we'll need to add an instance field to hold the performance 
	 level, a way of setting this value, and, very importantly, to provide a 
	 concrete implementation of the IsBonusPaidOut() method. 

	 Should you be able to create a SeniorManager object (you probably should)?

  9. Create tests of the classes as usual in the runner class. More specifically, you 
     should

     (a) Create a list which can hold Employee objects.
     (b) Create some Worker objects and add them to the list.
     (c) Create some JuniorManager objects, set the hours worked, and 
	     add them to the list.
     (d) Create some SeniorManager objects, set the performance level, and 
	     add them to the list.
     (e) Using a loop statement, print out the content of the list, like 
	     "(name) has a salary of (salary)".
