PLAN
====

- 0910-1100 Data structures                
  - Simple variables vs collections of elements
    - Memory architecture
    - Memory allocator (see Memory model spreadsheet)
    - Virtual memory
    - Page file
    - Get-ChildItem c:\ -force
    - Garbage collector

  - Array
    - Syntax (compare with simple variable declaration)
    - Size fixed at creation time
    - Lookup by index (offset into memory, starts at zero)
    - Constant time access to elements
    - Search and insertions are slow
    - Out of bounds checks (buffer overruns)
    - Example
      - Allocate a million million bytes 
      - Allocate > 2GB (may fail before 2GB if available block too small)
      - Task manager (private bytes, page fault column)
    - Foreach loop for collection in general

  - List
    - Syntax: List<T>
    - ResizeArray had been a better name
    - Add, Clear, Contains, Count, Remove methods
    - Generics
    - Type param parameterizes types, regular param parameterizes functionality

  - Dictionary
    - Syntax: Dictionary<K, V>
    - Key/value collection optimized for key lookup
    - Generics
    - Hash function (CRC, SHA256, MD5)
    - Hash function collisions
    - Object.GetHashCode()
    - Constant time lookup by key
    - Key must be unique
    - Example with number plates

  - (Stack
    - Last-in, first-out

  - Queue
    - First-in, first-out)

  - A large number of other specialized collections exist
                 
  - 1100-1430 Exercises 28, 29, 30, 31
              Extra: midpoint displacement for generating clounds and hills in games



