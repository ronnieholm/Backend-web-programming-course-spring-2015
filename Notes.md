# What is backend web programming?

A typical modern application: a web shop 
 
What tasks are involved in a web shop? 

  * Presenting content 
  * Receiving user input 
  * Constructing an order 
  * Storing an order 
  * Storing other data (user preferences, ...)

We usually divide such an application into layers, although terminology may vary.

  * GUI Layer
  * Logic Layer
  * Data layer

GUI Layer: responsible for presenting content and managing user 
interactions (receiving input, showing output).
 
Logic Layer: responsible for applying business rules (logic) to 
incoming data, producing data for storage. 
 
Data layer: storing the final data, e.g., for processing by other 
subsystems like an order shipment system.

## Why divide into these layers?

  * Right tools for the job. The tools used for constructing the 
different parts of an application are different in nature
  * Flexibility. Having an application pieced together by 
dedicated subsystems makes it easier to replace or 
supplement, say, the GUI while preserving logic/data parts

## PBA Web terminology

  * GUI Layer is Frontend 
  * Logic layer is Backend 
  * Data Layer is Databases 

In backend we concentrate on tools and techniques 
for implementing business rules and logic, using an 
object-oriented programming language. 

Note: some might be familiar with ASP.NET technology. Is that not backend? In this 
context, we don't consider it pure backend since it deals with 
the creation of HTML, i.e., GUI. It's a bit in the grey zone, though.

# Course Goals

Experience from previous semesters: object-oriented programming is quite 
different from what most non-computer science students have experienced before. How 
much experience do you have with:

  * HTML
  * CSS
  * JavaScript
  * PHP
  * Other programming languages

Goals for the course:

  * To be able to read, understand, and modify C# programs of 
    low-to-moderate complexity
  * To be able to create (from scratch) C# programs of low complexity

You will not become a full-blown C# programmers after this course and nobody 
expects you to.

# How we work in PBA Web BE Programming

Schedule: 5 classes/week, 15 weeks in a semester = 75 classes of 45 
minutes each.

What will the exam be like?

  * Oral exam
  * 30 minutes total, 20-25 minutes actual talk

You must be able to

  * Explain concepts within a given area in the curriculum
  * Explain a given piece of code
  * Use the relevant vocabulary
  * Do all this in an understandable English

## Your resources

  * Classes. Teacher explains and illustrates main concepts, no time for all details, work on exercises, projects
  * Book. Rather large, use for background and details
  * Lecture notes. Defines what will be tested at the exam
  * Exercises. Including solved versions of all exercises
  * Class website
  * Internet. Use it actively to find tutorials, alternative explanations, etc.

Your most important tool: practice.

Even though the course goals are to primarily become able to read and understand 
code, experience shows that actually programming yourself is 
key to deeper learning about the concepts.

If you're unable to do the exercises in class, then give it a try at home, 
maybe using the solved versions of the exercises for reference. Also pose 
some challenges for yourself. Start out with something very simple, then 
gradually work your way towards more complex problems.

# The Programming Process

If you've never tried programming before, it may seem 
like a mysterious activity. What is it really that we do? If we 
focus primarily on programming as a way of defining business logic, we're
usually defining and manipulating a model of a small piece of the world.

What does that mean specifically? Suppose we wish to make a program 
for administration of a school. Then we probably need to store certain 
information about students (and other things) in the program. What things 
are relevant to know about a student? Date of birth? Shoe size? That will 
depend entirely on the requirements for the system, which someone will 
have to define.

The result will be that certain information is needed while 
others can be left out. So, the model of a student in the 
program may only contain certain information: the information which is 
relevant in relation to the requirements. Exatcly which pieces of 
information we include will depend on the specific situation, i.e., the 
specific requirements.

Once we've figured out which information we need to include for each
concept (student, teacher, class room, ...) in the model, we need to 
figure out how to represent that information in our program. We get 
to that part in a moment.

In almost all cases, the information will need to be manipulated somehow. 
A very simple manipulation could be showing the information to a 
user. A more complex manipulation could be changing the information. 
For a student, some information will probably never change (the date of
birth) while others will most likely change (the number of 
courses taken).

The way information changes can range from simple to very complex. 
The simplest change could be changing the current value to a new
value. Say, when a student has taken one more course, the number of 
courses is increased by one. Other change are more complex. If we  
store an average of the exams passed, then passing an 
additional exam will require a recalculation of the average. In any case, 
there will always be rules for how to manipulate the information.

In programming, we try to translate such rules, formulated in a 
human language, to instructions/logic written in a language the computer
can understand. In this course this language is C#. This will result in 
writing a number of statements. When we have large collections of 
statements, we organise those into methods which we discuss later.

# Environment

Backend programming is often done in terms of an object-oriented 
programming language. We have chosen C# (why?)

What is C#?

  * Object-oriented language
  * Part of Microsoft's .NET technology
  * Related to Java and C++

Most widespread tool for C# programming is Microsoft Visual Studio (VS). Latest 
stable version is 2013 which we use in this course.

VS proper is a professional and commercial tool. Express versions scaled down.

  * Has quite a lot of features, huge knowledge base (+)
  * Has quite a lot of features, not easy to master (-)

We only need a fraction of the features

  * Understand the structure of a solution and project
  * Be able to navigate a project
  * Understand the role of included files
  * Add code to a project
  * Compile/build a project
  * Run a project
  * Understand error messages from the compiler

Try not to be too intimidated by the environment (tunnel vision).

Top level of a C# application is a solution. An application is a solution.

A solution can contain one or more projects.

A solution consists of several files: we don't need to worry about all of the files.

The Solution Explorer gives us an overview of the current solution. Do 
not worry about what is contained in the Properties and References sections.

Below these sections is a list of files with the .cs extension. 
These files contain the actual source code of the application.

Files with the .cs extension contains C# classes. We'll get back to classes later.

Classes contain methods, methods contains statements. A statement 
is one single instruction for the program about what to do next (add 
two numbers, print something, etc.).

How do I open a Project/Solution in VS?

  * Choose File | Open | Project/Solution
  * Navigate to the folder where the project is (note that a C# project is 
    contained in a single folder in the file system)
  * Click on the file with the same name as the project with the extension 
    .sln (.sln for solution)
  * The project should now be loaded and you can see it in Solution Explorer

Before a program can be run (executed), it must be compiled and built. VS will

  * Check that the code is vaild (correct syntax)
  * Compile the code into native .NET code
  * Build the project, making it executable

Our main concern is to enter valid (and correct) code into a project. VS does the rest.

Note the difference between valid and correct code. A piece of code 
is valid if it obeys the syntax of C#. This makes compilation possible. 
However, we only consider a piece of code to be correct
if it does what it's intended to. That's an important difference.

Running a program: press the little green triangle (or press F5).

# Statements

At the most fundamental level all C# programs consist of a collection of C# statements.

Statements are organized into methods and classes. We'll get to that later.

Statements are instructions to the program about what to do next. Examples are:

  * Do some arithmetic or logical calculation
  * Read or write data to a file, the screen
  * Control the flow of execution

Only common property for all statements: they end with a ";" (semicolon).

Depending on their purpose a statement has a certain syntax.

Syntax is very important as it must be obeyed completely. If not, you'll get an 
error message from the compiler. In fact, if a statement 
isn't syntactically correct, you'll be notified even before running the 
program. Wavy red lines will appear in VS.

You will be annoyed by this, but there's no way around it. Well, it's 
possible to switch off the wavy red lines but it's better to get used to it.

Don't ignore the wavy red lines. They indicate that something is wrong. So fix 
it right away. It can be somewhat annoying that the red lines appear as soon as you 
type in a statement.

If an error appears in the form of a wavy red line, hover the mouse over the 
error indicator. A tooltip with an error description will appear. Alternatively 
press F6 (build solution) and a list of errors will appear in a window at the bottom.

Error descriptions can sometimes be more confusing than helpful. Best 
advice is to read the code again and use common sense.

Good advice when programming:

  * Fix errors as soon as possible
  * Keep the number of open errors to a minimum
  * Test whenever possible

# Programming fundamentals

What is programming? Presentation, manipulation, and storage of data.

In web programming terms

  * Presentation: Frontend
  * Manipulation (Calculation): Backend
  * Storage: Databases

Data manipulation can (a bit abstractly) be broken down into:

  * Receive the data needed for the calculation
  * Store the data in memory in a suitable data structures
  * Perform manipulation according to business logic
  * Store the result in suitable data structures
  * Enable the user to access the result

In backend programming we concentrate on:

  * Data representation using suitable data structures
  * Data manipulation using suitable logic

What types of data do we wish to manipulate:

  * Numerical data
  * Text data
  * Logical data (true/false, boolean logic)
  * Binary data, e.g., pictures isn't our primary focus

# Types and variables

How does a program store the data it needs to manipulate? Data is 
stored in the memory of the computer (in RAM).

What is computer memory actually? Just a lot of elements (called bits), 
each of which can be either 0 or 1. We refer to a collection of eight bits 
as a byte. 256 possible distinct values.

Each byte in memory has an address. A modern computer has billions
of adresses (one billion bytes = gigabyte).

Raw storage of data, no matter the type, amounts to setting the value 
of certain bytes at certain addresses in memory. This is possible
but somewhat tedious.

Almost all programming languages therefore support the use of 
variables.

What is a variable actually? It's a piece of memory: a certain 
amount of bytes located at a certain address in memory.

In order to make it easy for humans to use a variable, we assign
it a name instead of referring to the actual address 
in memory. Also, we don't need to define the actual address of the
variable ourselves. The .NET runtume does that for us.

In addition to this we must choose a type for the variable. This defines 
the kind of data the variable can hold.

Some types for storing data (primitive built-in types):

  * int: whole numbers (no decimals) from about -2,000,000,000 to 2,000,000,000. Uses 32 bits = 4 bytes
  * double: decimal numbers with high precision. Why not exact values? Uses 64 bits = 8 bytes
  * bool: a true/false value. Usually uses 4 bytes even though in theory it should use much less
  * string: a text of arbitrary length. Uses two byte for each character in the string

The great advantage of having types is that we don't have to convert the 
data from the human type (e.g., a string) to the computer type which 
is always 0/1 values.

Declaration of a variable in C#:

    // reserve space in memory for an int.
    // Refer to the address by the name age
    int age;

    // put the value 24 in the bytes
    // referred to by age
    age = 24;

Note that the above type may also be written as bool, double, or string
with a name that you prefer.

# Arithmetic

A important part of most programming tasks is arithmetic. Almost 
all programming languages support arithmetic since much data manipulation 
is arithmetic in nature. We perform calculations.

C# supports most common arithmetic operations but there're certain 
operations that differ from classic arithmetic.

We've already seen assignment:

    int age;
    age = 24; // assignment, NOT an expression

Important to note: this means "set age equal to 24". It does 
NOT mean "age is equal to 24" (which may be true or false).

Simple arithmetic:

    int age;
    age = 24 + 32; // now age is 56
    age = age + 10; // now age is 66

    int legalAge = 18;
    age = legalAge + 10; // now age is 28

The right-hand side is always evaluated first and the result 
stored in a variable. The same variable can occur on both sides of the "="
(assignment) sign.

Note that the exact type is important. Consider this assignment:

    int a = 7;
    int b = 4;
    int c = a / b; // a divided by b

The result is NOT 1.75 as you might expect but 1. When doing arithmetic 
with integers the result will also be an integer. There's no rounding of 
the result. It might seem more natural that c should 
become 2, but it doesn't.

There are some non-standard operators in C#. For instance the remainder 
operator % (or modulo):

    int a = 7 % 4;

The result of the above is 3 which is the remainder when dividing 7 with 4 (integer division).

Usual rules for precedence apply:

    int a = 2 * 3 + 4; // this is 10, NOT 14

Some forms of conversion between types are possible, like:

    int a = 7;
    double b = a;     // b is now 7.00000
    double c = b / 4; // c is now 1.75

Type conversion is a larger subject. Short story: you can convert automatically 
when you don't lose information (7 -> 7.0 is OK, 7.4 -> 7 isn't).

Use of brackets is also allowed and follow standard rules. It's a good idea to use 
brackets to increase readability even if they aren't strictly necessary.

# Simple data output on the screen

Even though backend programming isn't about GUI, we still need to output 
data to the screen so we can see if our program works as expected. We 
have seen how to do this already:

    Console.WriteLine("Hello world");

The statement Console.WriteLine outputs to the screen. 
In the above example, it will output:

    Hello world

In general, Console.WriteLine outputs the data we specify within the 
brackets (). If we 
write something within quotation marks, like "Hello world", then it's 
interpreted as data of type string and the string (but not the
quotation marks themselves) is printed. However, Console.WriteLine is 
rather flexible. Consider this piece of code:

    int age = 21;
    Console.WriteLine(age);

If you execute this piece of code, the program will print:

    21

Why didn't it print "age" instead? In general, Console.WriteLine
prints a string. If we put something else between the brackets, the program 
will try to convert it to a string. That is, not the variable itself, but 
the value of the variable. In fact, all values can be converted to a string.
What was actually printed in the example is the string "21", because the 
value 21 was converted to the string "21". This can be done for all types 
of values.

Also very useful is the ability to chain together values:

    int age = 21;
    Console.WriteLine("The age is " + age);

If you execute this piece of code the program will print:

    The age is 21

What's going on inside the brackets? First, it 
seems we're adding two things: a string and an int. Can we even do that? 
In general, you can only add things of the same type. But since any value 
can be converted to a string, the value of age (21) can be converted 
to a string. 

So, we are adding "The age is " and "21". Since 
addition of two string is defined as concatenating the strings (writing 
the first string after the other), the result of the addition is "The age 
is 21". This ability to chain 
together several values (you can add as many values as you like inside 
the brackets) is very useful for outputting a message on the screen.

Using string concatenation is one way of printing a longer message  
consisting of a mix of text parts and variable values to the screen. 
However, there is another way to do this which might be more convenient.
Namely using a formatting string.

Suppose we have two variables like:

    string name = "James"; 
	int age = 23;

and want to print a message like:

    James is 23 years old

Using a formatting string this'll look like:

    Console.WriteLine("{0} is {1} years old", name, age);

Notice the use of curly braces like the {0} and {1} inside the string. 
This is interpreted as: take the value from the first variable 
following the string (in this case, the variable called name), and 
replace {0} with that value. Then take the value from the next variable (age),
and replace {1} with that value. So in this example {0} is replaced with 
"James" and {1} is replaced with "23", producing the string above. 

Note that 
you can use this principle for as many variables as you wish by 
including {2}, {3} etc. in the formatting string and adding the variables 
themselves after the formatting string (separated by commas).

# Logic

The ability to work with Boolean logic is a very important feature of C#.

Boolean logic: expressions can evaluate to true or false. It becomes very 
important for controlling the flow of execution through control statements (later).

The most common use of boolean logic is when testing for equality or 
testing for a relation (strictly speaking equality is a type of relation).

Testing for equality: are two entities (like two numbers) equal to each other or 
different from each other?

Testing for relation: do two entities (like two numbers) have a particular 
relation to each other, such as one being greater than the other.

Just like for arithmetic, there's a number of relational (or logic) operators
available in C#:

  * == means "equal to" (two equal signs)
  * != means "not equal to"
  * > means "greater than"
  * < means "smaller than"
  * >= means "greater than or equal to"
  * <= means "smaller than or equal to"

Notice that we use these operators to compare values, not to change values.

Any expression using these relational operators will evaluate to either True
or False which are exactly the values a variable of type bool can hold.

    int a = 7;
    bool b = (a == 7);   // b will be True
    bool c = (a < 7);    // c will be False
    bool d = (a <= 7);   // d will be True

Fairly straightforward for integers, slightly more tricky for doubles (decimal numbers).
4.0000000002 is not equal to 4.0000000001 (but maybe it's "close enough"?).

Comparing strings is also done using the "==" operator.

How can we test if the value of a variable is inside an interval, e.g. between 10 and 20 (included)?

    int a = 14;
    bool lowLimitOK = (a >= 10);
    bool highLimitOK = (a <= 20);
    bool isInInterval = lowLimitOK && highLimitOK;

Notice the && operator which means "and".
The expression A && B is only true if A is true and b is true as well.

We also have an || operator which means "or".
The expression A || B is true if A is true or b is true. Note that the expression is also true if both A and B are true.

Finally, we have the ! operator whcih means "not".
The expression !A is true if A is false and vice versa. The ! operator can be said to reverse the value of an expression.

"or" is obviously more forgiving than "and". By using these operators we can 
combine expressions to form quite complicated expressions:

    bool isOK = ((a < 20) && (a > 10)) || (a > 60);

Logical expressions become harder and harder to understand as they grow in size.

Another way to look at the results produced by these operators is through a truth table:

<table>
  <tr>
    <th>A</th>
	<th>B</th>
	<th>A && B</th>
	<th>A || B</th>
	<th>!A</th>
  <tr>
  <tr>
    <td>True</td>
	<td>True</td>
	<td>True</td>
	<td>True</td>
	<td>False</td>
  </tr>
  <tr>
    <td>True</td>
	<td>False</td>
	<td>False</td>
	<td>True</td>
	<td>False</td>
  </tr>
  <tr>
    <td>False</td>
	<td>True</td>
	<td>False</td>
	<td>True</td>
	<td>True</td>
  </tr>
  <tr>
    <td>False</td>
	<td>False</td>
	<td>False</td>
	<td>False</td>
	<td>True</td>
  </tr>
</table>

# The concept of functions

With arithmetic and boolean expressions we can begin to write non-trivial pieces 
of business logic. For instance we can calculate the average of three integers:

    int average = (a1 + a2 + a3) / 3;

This is rather simple, but if done at many places in our code it can 
become tedious to write. Instead, we would like to define the logic in one place, 
and then refer to that logic instead of writing it over and over. We can 
do this by defining a function.

A function is a fundamental concept in programming. The syntax may vary from language
to language but you always need to:

  - Name the piece of logic so you can refer to it
  - Define what input the function needs
  - Define the logic of the function
  - Define what the output of the function is

A function for calculating average as per above could look something like
this (details of syntax not important for now):

    int CalculateAverage(int val1, int val2, int val3) {
        int average = (val1 + val2 + val3) / 3;
        return average;
    }

This function is called CalculateAverage, takes three integers as input, and 
produces one integer as output.

Now we can refer to this logic when we wish to calculate an average. For the 
previous example it will look like:

    int average = CalculateAverage(a1, a2, a3);

We say that we call or invoke the function CalculateAverage. Now the caller 
of the function doesn't need to know the details of the logic, only how to refer to it.

When we call the function we can use the output, called 
the return value, in the same way as any other value. For instance, in an 
assignment statement as above. We can even use function calls in expressions:

    int total = func1(x) + func2(y);

assuming the functions func1 and func2 were defined.

You can compare a function in C# to a function in mathematics: it takes some 
input and produces some output, depending on the specific nature of the function.

# Pre-OO programming

We have now been introduced to types and variables, basic arithmetic and 
logic statements, and the concept of functions.

In the "old days" of computer programming (before 1990), before Object-Oriented 
programming, this was more or less the level of abstraction programs were written at.

  - Good: using variables and types allows us not to worry about details of data 
    representation and memory management.
  - Bad: still quite far between real-life concepts such as Student, Employee, Animal, ...
    and data representation.

Note that it's quite possible to make very complex software using the "old school" 
style. Still, it was recognized by industry that a different paradigm would make it possible 
to create better representations of real-life concepts in software.

# Object-oriented (OO) Programming

In non-OO programming data and functions are separated. No encapsulation so data 
belonging to the same conceptual entity is spread out over multiple data structures.

In OO programming data and functions are joined into objects. 
The state (data) and behavior (methods which are essentially the same as functions) 
of objects of a certain type are specified in a class definition.

Advantages:

  - Code structure will be more similar to conceptual models.
  - Encapsulation. The user of a certain class only gets to know what the 
    user needs to know. There's freedom to change the internal structure of a class.
  - Reuse. OO contains facilities that allows reuse of code through inheritance and
    composition.

NOTE: OO is still just a tool for helping humans develop computer programs and  
the internal representation in memory is the same as before.

# The Class concept

A class definition is a recipe or blueprint that defines how an object of this 
particular class will behave.

A class definition defines the object's interface to the outside world by
defining methods that a user of the object can invoke. This is 
very similar to the functions discussed earlier.

Methods are collections of statements such that a sequence of statements can 
easily be executed by calling the method. By calling we mean that somebody 
invokes the method, thereby executing the statements in the method.

A class definition also defines the internal structure of the object, more 
specifically the state of the object represented by one or more 
instance fields (a special kind of variable).

A class definition may also define some internal methods that can help the 
object perform its tasks without being directly available to an external user 
of the object.

The interface to the external user should prefereably not change. If it changes, 
the user of the object may have to change his code and we generally want to avoid that. 
As long as the interface doesn't change, we have freedom to change the internal 
structure without affecting an external user.

# Using objects of an existing class

It's possible to start using classes without actually knowing anything about 
how to define those.

We use a class by creating an object of that class, i.e., an object which 
will behave as specified in the class definition.

    // create a new Student object
    Student s1 = new Student();

Note that this is actually quite similar to a statement like:

    int age = 19;

On the left-hand side of the assignment operator we have the declaration of 
a variable, consisting of a type and a name of the variable.

On the right-hand side of the assignment operator we have an actual value 
which we assign to the variable. In the case of new that value is actually 
a new object of type Student.

The new keyword is always used when creating a new object followed by the 
name of the class (here Student).

Now the variable s1 refers to (points to) an object of type Student and we 
can begin to call methods on the object.

When a variable refers to an object of a certain type we can call methods on 
that object by using the "dot" syntax:

    // call a public method
    s1.PrintName();

Notice the dot (full stop) that follows the variable name. After the dot 
we write the name of the method we wish to use.

How can we know which methods are available? If we wrote the 
methods ourselves it's easy. In a more professional system there'll be 
documentation of the available methods to refer to.

In VS you will see that a list box of available methods pops up
as soon as you type the dot. Don't be confused.

In general, in order to call a method on an object we must supply

  - The method name
  - Any parameters needed (the parameter list)

Some methods may require information from the caller in order to do its job. 
We could imagine a method on a Student object:

    s1.SetTestResult("English", 80);

This method requires the caller to provide two parameters: a string (the name 
of the subject tested for) and an int (the result of the test). 
Parameters are always provided inside the brackets () that follow the method 
name and must be provided in the correct order and must have the correct type.

Other methods may return information to the caller. This is called a return value. 
This will also be indicated in the documentation. The special return value void means 
"no return value". It may seem strange that you have to specify that a method does 
not return any information. The syntax of C# is so that you must specifiy what a 
method will return to the caller and the word void has this special meaning of 
indicating that nothing comes back when calling this method.

If we want to use the return value for something (we usually do) we need to 
"pick it up" in a variable:

    int average = s1.GetAverageTestScore();

Now the average variable will have the value which was returned by the method call.

Note that when a method call returns a value that value can be used directly 
just as a simple variable:

    Console.WriteLine(s1.GetAverageTestScore());

We cannot, however, make assignment in this way:

    // NOTE: This will NOT work
    s1.GetAverageTestScore() = 75;

# Class definition elements

A definition of a class is usually placed in a separate file with the .cs extension. 
The class definition itself must contain:

The signature of the class definition. The first line will contain the name of 
the class and the rest of the definition (the body) must follow inside the area 
delimited by { and }.

    public class Student {
        // rest of class definition is here
    }

Zero or more instance fields. An instance field is a variable which belongs 
specifically to an individual object. Each object of a given class will have its 
own set of instance fields. Setting the values of the instance fields on one 
object will not affect the values of the instance fields of another object.

One or more public methods. The public methods are the methods that a user 
of the class can invoke on the object. These methods fall into two categories: 
Those who ask a question to the object (accessor) and those who may 
change the state of the object (mutators). Note that a method definition is 
also delimited by { and }. The collection of statements inside the delimiters 
is called the body of the method.

Zero or more private methods. The private methods are helper methods who
assist the public methods complete their tasks. They aren't available to an 
external user.

One or more constructors. A constructor is a special kind of method 
invoked when the object is created. Its primary purpose is to ensure that the 
object is created in a well-defined state, i.e., give the instance variables 
well-defined values.

# Instance fields and state

Class definition (part of):

    public class Student {
        private string name;
        private int yearOfBirth;
        private int testsTaken;
        private bool isMale;
    }

The four lines between { and } define four instance fields which aren't 
directly available to a user as indicated by the private keyword in front 
of each definition. In object-oriented programming an instance field is 
typically made private since an external user shouldn't manipulate the value 
of the instance fields directly, but rather do it indirectly by calling methods.

All of the values for the instance fields define the state of a specific object. 
Recall that state is indeed object-specific. Two different objects of the same class 
will have the same set of instance fields but the values of the instance fields may 
be different:

    State of one object: { "John", 1988, 3 , True}
    State of a different object: { "Susan", 1984, 0, False}

# Methods and behavior

Class definition (part of):

    public class Student {
        public void PrintName() {
            Console.WriteLine(Name);
        }

        public void IncreaseTestsTaken(int NewTests) {
            TestsTaken = TestsTaken + NewTests;
        }

        public int GetTestsTaken() {
            return TestsTaken;
        }

        public bool IsStudentMale() {
            return isMale;
        }
    }

A method definition consists of

  - Access specifier
  - Return type
  - Method name
  - Parameters

Some methods return information about the state of the object. This could simply be 
the value of an instance field or it could be a compound or calculated value.

Note that when a method doesn't return any value we indicate this by using the 
void return value.

Methods that return information are often called accessors while methods that 
change the state are called mutators.

Some methods are neither accessors nor mutators, but have some kind of "side effect"
like printing something (not very common in backend code). Also, some methods may both 
be an accessor and a mutator. Usually not recommended, since it may indicate too 
many responsibilities for one method.

Note that we use the keyword public to indicate that a method is available 
to an external user. Only methods that an external user is intended to use should 
be marked public. A private method can only be used by other methods in the 
class itself.

Instance fields are usually private. We want to encapsulate the true 
representation. Users don't need to know its representation so we 
can change it without affecting the user.

Note that we can use local variables inside a method. They're used to 
make caluclations easier and are only alive while the method executes. 
They cannot be accessed by other methods in the class or by external users.

# Class constructors

A constructor is invoked when we create a new instance of a class, i.e., when 
we create an object:

    // call constructor without parameters
    Student s1 = new Student();

The primary purpose of the constructor is to set the state of the object to 
something sensible and well-defined.

In many cases it will not make sense to create an object without having certain 
information available, like name and birth for a Student. We would then use a 
constructor with parameters:

    // call constructor with parameters
    Student s1 = new Student("Per", 1967, true);

We define constructors. And we may define as many as we want: one without 
parameters and one (or more) with parameters. Note that if we don't define 
any constructors, a default constructor with zero parameters that does 
nothing still exists. This is usually not a recommended approach.

In general, if it doesn't make sense to create an object without certain 
information the constructor should include parameters that represent this 
information. This prevents objects being created without this information.

Example of a constructor for the Student class:

    public class Student {
        public Student(string aName, int aYearOfBirth, bool aIsMale) {
            name = aName;
            yearOfBirth = aYearOfBirth;
            isMale = aIsMale;
            testsTaken = 0;
        }

        ... 
        // methods follow here
    }

Note two very important features of a constructor:

  - It looks like a method but it always has the same name as the class
  - It has no return type

You can always recognize a constructor by these features.

The statements inside the constructor do exactly what we stated before: set instance fields 
to well-defined values. Some of these values are 
provided from outside, in this case name, year of birth, and gender, 
while the number of tests taken is set to 0. The first three 
values are thus individual for each new object, while the last one is 
zero for all Student objects. This is very typical: some initial 
values are individual and require information from the caller while other values
have a sensible initial value which is the same for all objects of the class.

Note also the naming of parameters in the constructor ('a' and then something).
Why did we not just write:

    public Student(string name, int yearOfBirth, bool isMale) {
        name = name;
        yearOfBirth = yearOfBirth;
        isMale = isMale;
        testsTaken = 0;
    }

If we did this (it's correct syntax) then we suddenly have two things with the 
same name: the instance field name and the parameter name. The computer cannot 
infer the left-hand side to be the instance field and the right-hand 
side to be the parameter. By definition, the computer assume the developer meant the parameter on both sides 
which is not what we want.

In order to resolve this issue, we can do two things. We can use different names as in 
the 'a' example or we can use the this keyword:

    public Student(string name, int yearOfBirth, bool isMale) {
        this.name = name;
        this.yearOfBirth = yearOfBirth;
        this.isMale = isMale;
        this.testsTaken = 0;
    }

The this keyword should be understood as "this specific object". Writing 
this-dot-something refer to elements inside the specific object. It's 
a matter of taste if you prefer the "different names for instance fields and 
parameters" approach over the "using the
this keyword" approach.

# Handling conditions

So far we can only define "deterministic" sequences of statements to
always execute in the same order. This imposes significant constraints on 
the code we can write.

To create more complex code we need statements that control the flow 
of other statements. That is, the order in which other statements are executed.

These statements are called control statements. The main types of control 
statements are:

  - Conditional statements
  - Repetition statements

In the category of conditional statements the if-statement is the most 
prominent member.

Other conditional statements:

  - if/else-statement
  - switch-statement

## The if-statement

The business logic we're trying to implement will almost always contain conditions.

Examples:

  - Only allow withdrawal from a bank account if the balance is larger than 
    the amount to withdraw
  - A car is defined as being a family car if it has at least four seats 
    and has air conditioning

The C# syntax for a conditional statement is:

    if (condition) {
        // sequence of statements
    }

Three elements make up an if-statement:

  1. The if keyword
  2. The logical condition (a boolean expression) inside the brackets
  3. The code block inside the { and }

Remember how a boolean (or logical) expression always evaluate to 
true or false. The expression can be simple or complex, but it must 
evaluate to either true or false.

How will the withdraw method from the BankAccount class look if we add 
the condition that balance must be larger than or equal to the amount 
we're trying to withdraw?

    if (balance >= amount) {
        balance = balance - amount;
    }

It's important to understand the main propertiers of the if-statement

  - If the condition evaluates to true, the code inside the code block 
    executeds once and the program continues with 
	the statements following the if-statement.
  - If the condition evaluates to false, code inside the { } block 
    is skipped (not executed) and the program immediately 
	continues with statements following the if-statement.

If the code block consists of only one line, it's possible to write it
like:

    if (balance >= amount)
        balance = balance - amount;

For readability, and to avoid bugs in the program, it's recommended 
to always use { and } to delimit the code block.

Watch out: do not put a semicolon right after the condition. It's almost always an
error but not a syntax error. The if-statement will then "do nothing" no 
matter the value of the condition.

## The if/else statement

In many situations there's a natural alternative action if the 
condition evaluates to false.

We could write it as:

    if (balance >= amount) {
        balance = balance - amount;
    }
    if (balance < amount) {
        Console.Writeline("Error");
    }

but that's somewhat dangerous. Can we be absolutely sure that 
the two conditions are mutually exclusive and that one will always 
be executed?

It's more convenient (and safe) to include the alternative as an integrated part 
of the if-statement by adding an else-part to it:

    if (balance >= amount) {
        balance = balance - amount;
    } else {
        Console.Writeline("Error");
    }

Now we're guaranteed that exactly one of the statements 
is always executed. Never none, never both.

## Nested if-statement

It's also possible to nest if-statements within each other. We could've a 
condition like:

    if ((age >= 18) && (nationality == "Danish")) {
        Console.Writeline("You can vote");
    }

This is perfectly legal but could also have been written as:

    if (age >= 18) {
        if (nationality == "Danish") {
            Console.Writeline("You can vote");
        }
    }

Notice the indentation. It makes the code easier to read.

In general, the code block can contain any code you want, such as additional 
conditional statements. Watch out for very complex combinations.

You can, of course, also nest if/else-statements.

## Multi if/else-statements

Oftentimes you have more than two possible alternatives. For instance, a translation 
of scores to grades:

If score is above 90, grade is A

If score is above 75, grade is B

If score is above 55, grade is C

If none of the above, grade is D

Using nested if/else-statement, it translates to:

    if (score > 90) {
        grade = "A";
    } else {
        if (score > 75) {
            grade = "B";
        } else {
            if (score > 55) {
                grade = "C";
            } else {
                grade = "D";
            }
        }
    }

An alternative way of writing it would be:

    if (score > 90) {
        grade = "A";
    } else if (score > 70) {
        grade = "B";
    } else if (score > 55) {
        grade = "C";
    } else {
        grade = "D";
    }

They're logically equivalent but the latter is easier to read. It's mostly a 
matter of style and preferences.

## Switch-statements

Sometimes business logic is of a nature where there's a distinct outcome 
for each possible specific value of a variable.

Maybe the logic for calculating child support is like so:

0 children amounts to 0 kr. of child support per month

1 child amounts to 1,200 kr. of child support per month

2 children amounts to 2,000 kr. of child support per month

3 children amounts to 2,600 kr. of child support per month

more than 3 children amounts to 3,000 kr. of child support per month

There's no simple formula for this dependency between number of child and child support.
We'd have to write out all case as a 
nested or multi if/else-statement. The switch-statement allows us to express the
same logic but more succintly:

    switch (noOfChildren) {
        case 0:
            childSupport = 0;
            break;
        case 1:
            childSupport = 1200;
            break;
        case 2:
            childSupport = 2000;
            break;
        case 3:
            childSupport = 2600;
            break;
        default:
            childSupport = 3000;
            break;
    }

There're important properties to note about the switch-statement:

  - At the outermost level we use the switch keyword followed by an
    expression (often a variable) that we switch upon inside the brackets ().
  - We write a case statement for each of the cases that we wish to handle 
    using the case keyword followed by the actual value followed 
	by ":" (colon, not semicolon).
  - Each case contains a sequence of statements ending with a break statement. 
    The break statement indicates that no more code within the case 
	should be executed. It's perfectly legal to include if-statements, 
	etc. before the break statement but often you'll have a	single line of code.
  - If the value isn't handled explicitly by a matching case statement, it's 
    caught in the default statement and the lines of code specified here are 
	executed.

Again, there's nothing you can do in a switch-statement that you cannot do 
in an if-statement. They're logically equivalent.

Choose the type of statement that you feel fits the problem best and that makes the
code the easiest to understand.

# Handling repetition

The if statement allows some control of execution flow but we still cannot 
easily repeat a block of statements.

In practice, we often need to repeat a block of code multiple times 
while some condition is true. For this purpose we have loop statements,
aka. repetition statements.

Types of repetition statements:

  - while-statement
  - for-statement
  - foreach-statement

The foreach-statement is closely related to collections so we only look 
at while and for-statements for now.

## The while-loop

The basic structure of the while-loop:

    while (condition) {
        // code block
    }

The code block can contain almost any piece of C# code, including other control statements 
(code nesting).

The condition is the same type as we saw for if-statements: a logical 
condition that evaluates to true or false.

If the condition is true, the statements in the code block are executed once. 
This is called an iteration.

After an iteration, the condition is checked again. If it's still true, 
another iteration is performed. If it's false, the code block is skipped
and the statements after the while-statement are executed.

How can the value of the condition change? The value of the condition is 
evaluated after each execution of the code block so some of the statements 
in the code block must affect the value of the condition.

If no action in the code body can affect the condition we have an infinite loop.

Typical variants of while-loops:

### Counter-controlled while-loop

    int counter = 1;
    while (counter < 10) {
        // do something
        counter = counter + 1;
    }

Appropriate when we wish to repeat code a fixed (either at compile-time or 
at run-time) number of times.

### Sentinel-controlled while-loop

    int grade = GetGradeFromUser();
    while (grade >= 0) {
        // do something
        grade = GetGradeFromUser();
    }

Appropriate when some external source (e.g., the user) controls how many times we 
need to execute code. Execution stops when the user inputs a certain flag value 
(a flag value must not also be a valid data value).

Note that four properties are common for both types of loops:

  1. Initialization: Before the loop itself is entered we usually, but not always, 
     initialize some variable that's also used as part of the condition.
  2. Condition: The logical condition itself which is evaluated before performing 
     another iteration of the loop.
  3. Change: Since the condition itself is fixed, at least one of the values of the 
     variables in the condition must have the chance to change during an iteration. 
	 Otherwise, we have an infinite loop.
  4. Code block: The sets of statements that are executed during an iteration. Some of 
     those statements must cause the change mentioned above.

## The for-loop

As mentioned above, a counter-controlled while-loop has four components:

    int counter = 1; // initialization
    while (counter < 10) // condition {
		// code block (do something)
        counter = counter + 1; // change
    }

This construction is so commonly used that another repetition statement, the for-loop, is 
available for this purpose. This is the generic structure of the for-loop:

    for (initialisation; condition; change) {
        // code block
    }

A typical for-loop:

    for (int counter = 1; counter <= 10; counter++) {
        // code block
    }

Note that counter++ means "increase the value of the counter variable by one".

Advantages of for-loop:

  - Statement "header" takes care of all
  - Harder to forget, e.g., the change statement

Except for some very special cases for-loops and while-loops are equivalent. You 
can write any repetition statement as either a for-loop or a while-loop. However, 
using for-loops in case of counter controlled repetitions is common.

Legal, but not advisable:

    for (int grade = getGradeFromUser();
         grade >= 0;
         grade = getGradeFromUser()) {
         // do something...
    }

In general:
  
  - Use for-loops for counter-controlled repetitions
  - Use while-loops for sentinel-controlled repetitions

# Arrays

## Motivation

We often need to represent multiple entities of the 
same type, called a collections, of say

  - Integer measurement results
  - Student objects
  - Names as text strings

Using a single variable for each instance quickly becomes 
unmanageable. Imagine having to represent 100 students in your 
program and having variables like:

    Student s1 = ...;
    Student s2 = ...;
    Student s3 = ...;
    // ...
    Student s100 = ...;

An array object can store many instances of identical type and 
still allows manipulation of individual elements. This is a much 
more flexible solution.

## Declaration

Since an array is indeed an object it's

  - Created with a new statement
  - Referred to by a variable (by reference)

The variable is declared as follows:

    int[] numberArray; // declares a variable

The creation of the array itself looks like:

    // array with 10 elements
    numberArray = new int[10];
	
It's important to note the use of []. Also note that the actual 
size of the array is specified with its creation, not its declaration. 

An array has a fixed size but it can be changed by using the Resize 
method defined on the Array class:

    // resize array to 20 elements
    Array.resize(ref numberArray, 20);

Resizing is somewhat expensive so we should avoid it. There're other 
and better ways to deal with the situation in which the number of 
elements isn't known in advance and we discuss those later.

## Usage

Once the array contains elements (see later), we can use each element 
just as if it's an ordinary variable.

Each specific element is specified by its position in the array. We 
usually call this the index.

    // add 2 to the fifth element in the array
    numberArray[4] = numberArray[4] + 2;

Catch: the first element in the array has index 0 (zero). In an array 
of 10 elements the last element has index 9.

Notice that we can use array elements both on the left-hand side and 
the right-hand side of an expression. They act as any other 
variable of that type.

We can initialize an array directly if the values for 
all elements are fixed:

    // initializes the array to five elements
    int[] numberArray = {12, 42, -9, 34, 10};

We often use arrays together with some type of repetition statement:

    int[]numberArray = new int[10];
    // do some initialization...

    for (int index = 0; index < 10; index++) {
        Console.WriteLine(numberArray[index]);
    }

This prints out values of each element in the array, starting 
from the element with index 0 up to the element with index 9 (not 10).

We can ask an array how long it is, giving us more robust code 
(in the sense that if we change the length of the array, we don't 
have to remember to change the value in the condition as well):

    for (int index = 0; index < numberArray.Length; index++) {
        Console.WriteLine(numberArray[index]);
    }

If we try to use an index which is "out of bounds" (negative or 
greater than the index of the last element), the code 
generates/throws an exception indicating that an error occurred 
during execution of the program.

## The foreach statement

Iterating through all elements of an array, or any type of 
collection, is a common task in programming. So common in fact
that a special type of repetition statement exists for this
purpose. It's called the foreach statement.

Purpose: for each element in the collection, do a certain action.

    foreach (int number in numberArray) {
        Console.WriteLine(number);
    }

Here the number variable takes on the value of each of 
the elements in the collection, in this case the type is int 
but it can be any type.

It's syntactically simpler and there's no risk of getting 
the initialization and/or condition wrong.

However, it isn't as versatile as the general for-loop and is used
only in connection with processing of collections and typically 
if we wish to do something for all elements in the collection.

## Lists

Arrays are useful but they're a bit old-school in their style:

  - Fixed-size (or resize manually)
  - Not much help with common tasks (insertion, search, ...)

The .NET Framework Class Library, which is a large collection of predefined 
classes available to the programmer, provides a number of classes 
for handling collections of objects (called collection classes). With
those classes, we don't need to worry about size issues. Collections are 
automatically resized for us.

We have many methods available: Add, Clear, Remove, ...

One of the simplest of these collection classes is the List class.
When declaring a List object we must provide the type of the 
elements in the list as a parameter to the List type:

    List<int> numberList; // a list of integers

When we create a List object we don't need to specify any size:

    numberList = new List<int>();

We can now call various methods on the List object:

  - Add
  - Clear
  - Contains
  - Count
  - Remove
  - ...

Note that the List class actually uses an array under the covers.

The most commonly used method is Add which adds an element to the 
back of the list (list grows longer). We can use Insert to insert 
an element at a specific position.

We get hold of an element in the same way as for arrays: we use the 
[] notation. Again index 0 for the first element.

    numberList[2]; // the element with index 2

The method Contains can tell us if a specific element is contained 
in the list:

    // is an element with value 77 in the list?
    numberList.Contains(77);

There're many useful methods in the List class. See documentation or read 
in pop-up list.

## Dictionary

The List class is a significant improvement over old-school arrays, 
but some tasks are still somewhat difficult.

We often have classes where one instance field serves as a 
key to the data (i.e., uniquely identifies it). CPR number for a person, 
license plate for a car, ISBN for a book, etc.

Common task: given the key, find the corresponding object.

This is a bit hard to do efficiently using lists. You have 
to search through the list element by element until you either find 
the correct element or can conclude it's node there. Code 
must be explicitly written and can be rather slow (has to search 
through much data).

The Dictionary class allows us to store a key/value relationship.

When declaring a Dictionary object we must provide the type 
of the key and the type of the value as "parameters" to the 
Dictionary type:

    // key is String (CPR)
    // value is Student object
    Dictionary<String, Student> students;

When we wish to add a key/value pair to the dictionary we use 
the Add method which now takes two parameters:

    students.Add("020388-1208", aStudent);

When we wish to remove an element from the dictionary, we only need 
to provide the key.

    students.Remove("020388-1208");

If we want to retrieve data about a student we only need 
to provide the key. The Dictionary class can then retrieve the 
data very efficiently.

The syntax is similar to the List syntax but instead of a 
numerical index we use the key value as index:

    Student aStudent = students["020388-1208"];

Note that if no student with that specific key exists we get an 
error. We can use the ContainsKey method to check if the 
dictionary contains the key before trying to retrieve it. If not, 
we shouldn't try to look up the value.

In general, use

  - List: if you can look up the data by numerical index or 
    don't have any particular need for looking up data
  - Dictionary: if you need to look up data often and there's 
    a natural key for the data

Remember to check the documentation for available methods when 
using these classes.

# The concept of inheritance

Another promise of object-orientation is more code reuse. We can (possibly) reuse 
code when we define classes. This allows us to implement class hierarchies in C#. A derived 
class should have an is-a relationship to a base class.

What's an is-a relationship? Consider the concepts Vehicle
and Car. A car is definitely a special type of vehicle. In other 
words: a car is a vehicle. So Car has an is-a relationship 
to Vehicle. This is different from the relationship between, 
say, Car and Wheel. A wheel isn't a special type of car, 
but a car definitely has wheels. We say that Car has a has-a
relationship to Wheel.

The mechanism for implementing an is-a relationship in code is the 
concept of inheritance. A class may inherit from a base class, meaning 
that all methods and instance fields in the base class are also included 
in the derived class.

## Base Classes and Derived Classes

Syntax for creating a derived class:

    // this class inherits from Student
    class GraduateStudent : Student {
        ...
    }

The derived class can call all public methods in the base class, just 
as any other user. It cannot, however, call private methods and access private instance 
fields.

The protected access level allows usage by derived classes, but not 
by other users.

It's tempting to make instance fields and methods protected but it isn't 
recommended. Potential problems:

  - Base class loses control over instance fields since the derived 
    class can access and manipulate them.
  - Derived class may depend too much on representation.

If the base class only has constructors that contain parameters, i.e.,
no default constructor, we must explicitly invoke the base class 
constructor from the derived class, providing the necessary parameters.

Syntax for calling base class constructor:

    public GraduateStudent(string bachelorDegree, string name, int yearOfBirth)
    : base(name, yearOfBirth) {
        this.bachelorDegree = bachelorDegree;
    }

Inheritance allows us to replace (to override) the implementation of a base 
class method with an alternative implementation in the derived class.

The base class must allow for a method to be overridden by using 
the virtual keyword:

    // implementation in Student (base)
    public virtual string GetName() {
        return name;
    }

The derived class must also indicate that it's overriding the 
implementation by using the override keyword:

    // implementation in GraduateStudent (derived)
    public override string GetName() {
        return "Dr. " + base.GetName();
    }

## The Object class

All classes in C# inherit, directly or indirectly, from the mother 
of all classes called Object. This base class contains seven methods:

  - Equals
  - Finalize
  - GetHashCode
  - GetType
  - MemberwiseClone
  - ReferenceEquals
  - ToString

Some of these methods need to be overrided if we want a certain 
class to have certain abilities, like being able to store objects 
of that type in a Dictionary-based container (GetHashCode), to 
define equality in a non-trivial way (Equals), etc.

This is why IntelliSense always show quite a few methods available on all 
objects. They're inherited from Object.

## Polymorphic variables and behavior

A great advantage of inheritance is code reuse. Another great 
advantage is being able to program towards general (base) classes, 
instead of more specific (derived) classes. This makes it easy to 
extend code without much modification.

OO design principle: code should be closed for modification, but 
open for extension.

Consider these classes:

  - Shape (has a virtual Draw method)
  - Circle (inherits from Shape, overrides Draw)
  - Triangle (inherits from Shape, overrides Draw)

Then this is valid code:

    Shape shapeA = new Shape();
    Circle circleA = new Circle();
    Triangle triA = new Triangle();

But also this:

    Shape shapeA = new Shape();
    Shape circleA = new Circle();
    Shape triA = new Triangle();

Why is the last piece of code interesting? Because we can then write code 
that doesn't know the true type of an object, but can still 
use its methods:

    public void DrawAShape(Shape s) {
        Console.WriteLine("Now I draw something");
        s.Draw(); // what type is s actually?
    }

The true type of s may be Circle or Triangle but the 
method doesn't need to know that.

Calling Draw on s may exhibit different behavior depending 
on the actual type of s. This is known as polymorphic behavior 
(Polymorphic: many forms).

A further advantage is extensibility. If we need more shapes we 
can just add them to the shape package as long as they inherit 
from Shape. We need not change any client code as 
it only knows about the base class. No modification, 
only extension.

## Abstract methods and classes

A problem in the Shape class is what the proper implementation 
of the Draw method should be?

Do nothing, perhaps? Could work but does it even make sense to 
create a Shape object in itself? Not really. Shape is just 
a common denominator for shape-oriented classes but a Shape
object in itself isn't very useful.

By turning the Draw method into an abstract method, we gain
a couple of advantages:

  - We don't have to provide a (meaningless) implementation in 
    the base class.
  - We cannot create any objects of the base class.
  - A derived class must provide an implementation of the abstract 
    method(s).

Note the difference between virtual and abstract:
 
  - Virtual: has an implementation in the base class which may be 
    overridden. Use when a sensible implementation of the method 
	exists for the base class.
  - Abstract: has no implementation in the base class which must 
    be overridden. Use when no sensible implementation of the method 
	exists for the base class.
	
If a class definition contains just one abstract method the whole 
class also becomes abstract.	

# Interfaces

Imagine a situation where all methods in a class would be 
abstract. Such a class is called an interface.

Interfaces are used quite heavily in C#. Think of an interface as 
a contract. The interface defines the methods available in any 
implementation of the interface and should include a description 
of the functionality to be expected. It does not provide any 
specific implementation.

Interfaces follow a slightly different syntax than classes:

    public interface IShape {
        void Draw();
    }

  - Usually starts with an I (naming convention)
  - Uses the interface keyword instead of class
  - All methods are public (but we don't write public explicitly)
  - No instance fields

Advantages are the same as before (allows polymorphic behavior) just 
taken to the extreme. Two classes that both implement the interface 
may be completely unrelated with regards to implementation.

The C# class library contains many interfaces in itself, e.g., 
IComparable.

# Defensive programming

In real-life scenarios, we have to prepare for unexpected data values 
and exceptional situations in general.

What can go wrong? Some examples:

  - Value is correct type-wise but is outside the range of meaningful 
    values (example: A test score is supposed to be between 0 and 100 
	but an int can represent many other values, such as -27, 22987).
  - Value is used for indexing into an array but only values from 0 (zero) up 
    to (length - 1) are meaningful. Other values will produce an error.
  - A string doesn't follow a given syntax (e.g., for a license plate).
  - A variable that's supposed to refer to an object has the value 
    null instead.
  - A file contains data that has a different format than expected or 
    the file is missing.
  - A database is unavailable for some reason.
  - An Internet connection is unavailable for some reason.

The action of the program in the above cases is situation-dependent. 
Program may halt, show an error message, silently handle the error, 
fall back to a default value, etc.

In any case, we should be prepared to handle all possible situations 
in a graceful manner.

In practice we then have to validate all critical variables before 
use.

When should we validate?

  - Early: as soon as the variable has the value that'll be used 
    in a critical situation.
  - Late: just before the variable is actually used.

When to validate is also situational-dependent. Argument against early 
validation could be that value might not be used at all.

We detect an error during program execution. Now what? Management 
of errors can be broken down into several tasks:

  - Detection. Realizing that an error situation has occurred.
  - Signaling. Making the surrounding code aware that an error 
    has been detected.
  - Capturing. Taking responsibility for handling of the error.
  - Handling. Actually performing the error handling actions.

All these actions can be distributed in code. This may imply 
that the detecting part of the code doesn't know how to handle 
the error.

Problems to consider:

  - How do we signal an error?
  - How do we capture an error?
  - What should happen after the error has been handled?

The standard mechanism for managing errors in C#, and many other OO-languages,
is through exceptions.

## Exceptions - throw

An exception is in itself just another class.

An exception object is created just as any other object: using new 
and the proper class.

The interesting part: we can throw and catch exceptions.

If an exceptional situation (an error) occurs, the code can 
throw an exception:

    public void deposit(int amount) {
        if (amount < 0) {
            NegativeAmountException ex =
                new NegativeAmountException("...");
            throw ex;
        }
        balance += amount;
    }

Note the use of the throw keyword.

As soon as an exception is thrown, no more code within the method is executed.

We throw because we don't know how to handle the error.

## Exceptions - catch

Throwing an exception signals to the outside world that an error occurred.

The part of the code that wishes to capture the error must catch 
the exception.

Code that might throw an exception should be executed within a 
try-catch block:

    BankAccount myAcc = new BankAccount();
    try {
        int amount = ...; // from user
        myAcc.deposit(amount);
    } catch (NegativeAmountException ex) {
        Console.WriteLine("Negative amount not allowed");
    }

Caller is aware that an exception may occur and decides how to handle it.

General principle: Throw early, catch late.

  - Throw as soon as an error is detected
  - Only catch if you really know how to handle the error (don't be tempted
    to silently consume the error)

## Exceptions - catch

What code is executed after the catch-part has been executed?

Control doesn't return to the code that threw the exception. It returns 
to the first statement after the catch-block. More precisely after 
the last catch-block since you can have several catch-blocks handling 
different exceptions.

This may cause problems if the code that threw the exception has 
claimed some system resources, for instance through opening a file.

How can we make sure that a file for instance is closed, regardless of 
whether or not an exception has occurred?

In C# a finally clause is used for this purpose. Code placed in a 
finally-block is guaranteed to be executed, exception or not.

    try {
        theFile.open(fileName);
        ... // File processing
    } catch (IOException ex) {
        Console.WriteLine("File processing failed...");
    } finally {
        theFile.close();
    }

Code for releasing resources should be in a finally-block.

## Exceptions - details

A lot of the methods in the .NET base class library may throw exceptions. Just 
dividing by zero will cause an exception.

How can we learn which exceptions a method may throw? Look in 
the documentation. Documenting exceptions is an important 
part of the documentation of your own code.

C# contains a class hierarchy of exception classes. The base class is 
called Exception.

Use the built-in exception classes if they're appropriate. Otherwise 
create your own exception classes. Your own exception classes must
inherit from an existing exception class since you can only throw an 
object which inherit from Exception.

An exception object has a number of properties which provide more 
information about the nature of the exception. For instance, the 
Message property. See the documentation for further information.

Should I always throw exceptions in case of errors? No, not if 
you are absolutely sure how the error should be handled.

Remember to consider architectural issues. It may be unwise to 
present an error to a user in a GUI-specific manner inside a 
business-logic class.

# Constants

Suppose we wish to create a program for a simple simulation of an 
ecosystem. There're many parameters to decide on:

  - Size of simulation grid (x,y)
  - Initial number of predators
  - Initial number of prey
  - Breeding rates
  - ...

All these values will be constant throughout the execution of the 
program so they can be set directly in the code:

    for (int x = 0; x < 50; x++) {
        for (int y = 0; y < 40; y++) {
            // do something for each cell
        }
    }

The values might occur many times in the code, e.g., every time we 
have to do something for the entire grid. There're problems with 
this approach:

  1. Hard to read the code. What does the value 50 mean in 
     a specific context?
  2. If we wish to change the value we'll have to do it 
     in each and every place. We could forget some places.

Much more convenient to use constants instead.

A constant is a variable that has a fixed value (hardly a variable then).

Declaration of constants:

    public class EcoSimulation {
        public const int GridWidth = 50;
        public const int GridHeigth = 40;
        ...
	}

Using constants:

    for (int x = 0; x < GridWidth; x++) {
        for (int y = 0; y < GridHeigth; y++) {
            // do something for each cell
        }
    }

It's much easier to understand the code if constants have 
meaningful names. If we need to change the grid width, we 
only have to change it in one place.

General principle in programming: we don't want to specify the 
same information more than once. Analogous with Headings, etc. 
in document. This provides an extra layer of indirection.

# Static methods and classes

The standard way of using a class is to:

  - Create an object of the class using the new keyword.
  - Call methods on the object.

However, if the class doesn't contain any kind of state, and thus 
no instance variables, there isn't really any need to create objects 
since we cannot change their state.

In that case we can make the class a static class:

    static class StringMethods {
        public static String GetStringSubsection(string s, int start, int end);
        public static String GetLetterCount(string letter);
        ....
	}

When we wish to call methods in the class we use this syntax:

    int bCount = StringMethods.GetLetterCount("b");

Here we don't have to use new. We just type the name of the class
followed by the dot followed by the name of the method.

Note that if we make the entire class static it can only contain 
static methods. However, we can also declare methods in an ordinary 
(non-static) class to be static. This is typically done for methods 
that do not use or alter the state of the object.

It's also possible to define an instance variable to be static. 
No matter how many objects we then create of that class there will 
still only be one instance of that variable: it's shared amongst
the objects.

One example could be to keep track of the number of objects that have 
been created of a given class: define a static instance field and 
increment it by one in the class constructor which is executed 
whenever a new object is created.

Static and non-static elements can be mixed in these ways:

  - A static class can only contain static methods and 
    static fields.
  - A non-static class can contain both static and non-
    static methods and instance fields.
  - A static method can only use static instance fields
  - A non-static method can use both static and non-static 
    instance variables.

A lot of (static) methods are found in the Math class (part of 
the .NET base class library).

Actually, you've used static classes and methods from day 1. 
Think of Console.WriteLine(...).

# Enumerations

The primitive types available in C# are often not exactly what we 
want. Suppose we wish to make a program that deals with fruit, say 
these five kinds of fruit: apple, pear, cherry, banana, and kiwi. 
How do we represent a fruit?

  - As a bool: impossible, only two possible values
  - As an int: possible (say values 1 to 5), but not very convenient.
    We have to check for legal values and code can be hard to 
	understand (maybe use constants?)
  - As a string: possible, but again we need to check for legal values.

What we would really like is a type that can only hold exactly the 
five values given above. We shouldn't be able to specify a wrong value. This can 
be done using an enumerated type.

    class Fruit {
        public enum FruitType { Apple, Pear, Cherry, Banana, Kiwi };
		...
	}

We can now declare a variable of this type (syntax is slightly awkward, 
notice the use of dot):

    Fruit.FruitType aFruit = Fruit.FruitType.Apple;

The point is: we can never assign a wrong value to the variable 
since the type itself specifies the legal values. Errors are caught 
at compile-time rather than at run-time.