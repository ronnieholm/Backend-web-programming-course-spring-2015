# Lecture 8

- 0910-1040 Presentatation
  - if statements
  - do and while loops
  - for/foreach loops
  - Arrays
  - List<T>
  - Dictionary<K,V>

- 1100-1200 Combining classes

  - Book isn't good on subject
  
  - Separate Lecture 4 - Understanding encapsulation.pptx

  - Inheritance
    - Class inherits all members from another class
    - C# supports only single inheritance (problems?)
    - Controller example from ASP.NET MVC?
    - Member accessibility influences what gets inherited 
      - Seperate illustration
      - public, private, and protected
    - Inheritance behavior (abstract or virtual)
    - Abstract classes are like interfaces (C++ uses them as such)
      - Can also not be implementation but may contain implementation
    - Object base class
    - Makes it easy to extend code without modification

  - Polymorphism
    - Through inheritance classes have an overlap in public methods
    - Enables treating objects instantiated from subclasses as
      if they were instantiated from base class. Also works with
      interfaces as base types
    - New subtypes can be added an existing code will not need to know
    - Controls example

  - Interfaces
    - Collection of public instance methods without implementations
    - Interfaces are implemented by classes
    - Cannot be instantiated
    - Relate to ASP.NET MVC interfaces
    - Class can implement multiple interfaces
      One interface can be implemented by multiple classes
    - Interfaces make it possible to replace one type with another
    - IEquatable, IComparable (with custom Person class and relational operators)

  - Relationship between objects
    - inheritance vs. Containment
    - is-a vs. has-a relationship

- 1200-1445 Exercises 32, 33