1. Describe the problem generics address.

    One wants to create a class/method that works on any data types.

2. How would you create a list of strings, using the generic List class?

    `List<string> list;`

3. How many generic type parameters does the Dictionary class have?

    2. One for keys and one for values.

4. True/False. When a generic class has multiple type parameters, they must all match.

    T

5. What method is used to add items to a List object?

    `Add(T)`, `AddRange(IEnumerable<T>)`

6. Name two methods that cause items to be removed from a List.

    `Remove(T)`, `Clear()`

7. How do you indicate that a class has a generic type parameter?

    `class SomeClass<T> {}`

8. True/False. Generic classes can only have one generic type parameter.

    F

9. True/False. Generic type constraints limit what can be used for the generic type.

    T

10. True/False. Constraints let you use the methods of the thing you are constraining to.

    T