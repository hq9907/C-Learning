# 01 Introduction to C# and Data Types

## Understanding Data Types

1. What type would you choose for the following “numbers”?

	A person’s telephone number: string

	A person’s height: float

	A person’s age: byte

	A person’s gender (Male, Female, Prefer Not To Answer): Enum

	A person’s salary: float

	A book’s ISBN: string

	A book’s price: float

	A book’s shipping weight: float

	A country’s	population: int

	The	number of stars	in the universe: long

	The	number of employees	in each	of the small or	medium businesses in the United Kingdom (up to about 50,000 employees per business): short

2. What are the difference between value type and reference type variables? What is boxing and unboxing?

    Variables of reference types store references to their data (objects), while variables of value types directly contain their data.

	Boxing is the process of converting a value type to the type object or to any interface type implemented by this value type. When the common language runtime (CLR) boxes a value type, it wraps the value inside a System. Object instance and stores it on the managed heap. Unboxing extracts the value type from the object.

3. What is meant by the terms managed resource and unmanaged resource in .NET?

    Managed resources are those that are pure . NET code and managed by the runtime and are under its direct control. Unmanaged resources are those that are not.

4. Whats the purpose of Garbage Collector in .NET?

    NET's garbage collector manages the allocation and release of memory for your application.

## Controlling Flow and Converting Types

1. What happens when you divide an int variable by 0?

    DivideByZeroException.

2. What happens when you divide a double variable by 0?

    No exception, returns NaN.

3. What happens when you overflow an int variable, that is, set it to a value beyond its range?

    In a checked context, an OverflowException is thrown. In an unchecked context, the most significant bits of the result are discarded and execution continues.

4. What is the difference between x = y++; and x = ++y;?

    x = y after the first instruction, but x = y + 1 after the second one.

5. What is the difference between break, continue, and return when used inside a loop statement?

    Break ends the loop, continue skips the current step and back to the begining of the loop, return ends the current function.

6. What are the three parts of a for statement and which of them are required?

    Initialization , condition and iterator. All parts are optional.

7. What is the difference between the = and == operators?

    = is assignment and == is compaison.

8. Does the following statement compile? for ( ; true; ) ;

    Yes.

9. What does the underscore _ represent in a switch expression?

    It matches everything, like default.

10. What interface must an object implement to be enumerated over by using the foreach statement?

    IEnumerable.