Revision
---------------------------
* Can you give an example of a generic collection?
    > List<T> is a generic collection. The `T` represents the type of object the list will store.
* What is a generic method?
    > A generic method is a method that uses one or more type parameters. This allows the same method to work with different data types while maintaining type safety. For example:
    ```csharp
    public static T GetFirst<T>(List<T> items)
    {
        return items[0];
    }
    ```
* What is a generic class?
    > A generic class is a class that uses one or more type parameters, allowing it to work with different types while reusing the same code. Example:
    ```csharp
    public class Box<T>
    {
        public T Contents { get; set; }
    }
    ```
* Can you have more than one generic type in a class?
    > Yes. A generic class can have multiple type parameters.
* Why would you use generics?
    > Generics allow you to write reusable code that works with different types while maintaining compile-time type safety and avoiding unnecessary casting.
* Explain the keyword `default`.
    > The `default` keyword returns the default value for a type. For reference types it is `null`, for numeric types it is `0`, for `bool` it is `false`, etc.
* Explain the keyword `where`. When would you use it?
    > The where keyword is used to add constraints to generic type parameters. Constraints limit the types that can be used with a generic class or method and allow you to safely use members of those types.