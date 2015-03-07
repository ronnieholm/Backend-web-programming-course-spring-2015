# Exercise 31: Student info manager

This exercise is about completing the definition of a class that 
uses a Dictionary object.

The project contains the Student class which represents a student 
with three instance fields: student id, name, and test scores. The 
first two should be self-explanatory, but the test scores field is a 
Dictionary holding key/value pairs of course name (string) and 
score (int).

The project also contains the StudentCollection class. It's supposed to be
able to retrieve information about a group of students. For this 
purpose, a students instance field of type Dictionary is used to hold 
key/value pairs consisting of student ids and Student objects (since 
a student is uniquely identified by a student id).

  1. The class Student is complete and you need not modify it. However, 
     take a good look at the Student class anyway and make sure you 
	 understand how the methods work. Pay particular attention to the 
	 GetScoreAverage method.
  2. Look in the StudentCollection class definition. You'll see five methods 
     (GetStudentCount, AddStudent, GetStudent, GetAverageForStudent, 
	 GetTotalAverage) which requires implementation. Your job is to 
	 complete these methods according to the specification provided as
	 code comments.
  3. The Runner class contains tests for the StudentCollection class. Run the 
     program and check that your StudentCollection class behaves as expected.