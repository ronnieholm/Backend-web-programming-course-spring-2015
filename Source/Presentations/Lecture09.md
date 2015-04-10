# Lecture 9

- 0910-1110
  - Syntax templates present for all constructs below in books
  - Constants
    - Variable whose value cannot change after initialization
    - Useful for enhancing code readability by avoiding magic string and numbers
    - Template: const <datatype> = <value>
   
  - Enumerations
    - Enum without enum type (constants or variables + naming convention)
    - Bool can store a fixed set of values (true, false)
    - Enum lets you create your own fixed set of values
    - Underlying type used for storage (int is default)
      Each enum value is stored as a value of an underlying type
    - Show example converting back and forth between data types

        directionByte = (byte)myDirection;
        myDirection = (Orientation)myByte;
        directionString = myDirection.ToString();
        Orientation myDirection = (Orientation)Enum.Parse(typeof(Orientation), "North");

    - Each value is assigned an underlyting type value automatically,
      according to the order in which it's defined, starting from zero
    - Show example where None = 0 to avoid initialization errors

  - Static and instance class members
    - Global for objects of a given class
    - Allows access to data og calling methods independent of any object instance
    - Example
      - Console.WriteLine
      - Math.* methods
    - Make class itself static to prevent instances being created from it
    - Downside
      - Doesn't work well with multithreading
      - Saving memory is generally not a concern

  - Runtime error handling
    - Deal with expected errors (file not found, argument invalid)
    - Detecting party may not know how to handle exception
    - try/catch/finally (structured exception handling)
      - Don't catch unless you can actually handle the exception
      - Replacement for constantly checking return value.
      - Typical program flow becomes more obvious/easier to follow
      - Unhalted exceptions move up the call stack
      - Top-level exception handler is a Windows routine (pop-up window)
    - Generate exceptions with throw keyword
    - Exception classes are a way to pass error info between trigger and handler
    - Exception classes are regular classes inheriting from Exception base
    - Catch block for more specific exception must come first in catch list

  - var keyword
    - Local type inference
    - ILSpy example

- 1110-1445 Exercises 34, 35, 36