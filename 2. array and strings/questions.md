# 02 Arrays and Strings

1. When to use String vs. StringBuilder in C# ?

    String for immutable, StringBuilder for frequent modification.

2. What is the base class for all arrays in C#?

    Array.

3. How do you sort an array in C#?

    Array.sort();

4. What property of an array object can be used to get the total number of elements in an array?

    Length.

5. Can you store multiple data types in System.Array?

    No.

6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?

    CopyTo require to have a destination array when Clone return a new array.
    CopyTo let you specify an index (if required) to the destination array.