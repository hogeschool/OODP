Revision
--------------------------
# Unit testing
- What is a project?
    > A collection of source code files, resources, and configuration.
- What is the .csproj file?
    > It stores references to source code files and resources
- What is a solution?
    > A grouping of one or more related projects
- What is an SLN file?
    > It stores the settings for solutions
- What command do you use to create a new ms test project?
    > `dotnet new mstest`
- What do you need to do to link this to the project you wish to test? For example, if you want to test a project named ProjectToTest
    > `dotnet add reference ../ProjectToTest/ProjectToTest.csproj`
-  What do the following mean?
    - [TestClass]
        > required on any class that contains unit test methods that you want to run.
    - [TestMethod]
        > Each test method that you want to run must have this attribute
    - [DataRow()]
        > Used to specify values for the inputs into a TestMethod
    - Asserts
        > Used to verify functionality
    

# Exceptions
- What is an exception and how does it differ from a compile time error?
    > An exception happens at run time. A compile time error means that something is wrong with your code and so it cannot be compiled and can therefore not run.
- What does `throw` do?
    > The `throw` statement throws an exception.
- When should you throw an Exception?
    > When your program really has no way to continue because of some problem. Exceptions should be used in exceptional situations.
- It is not good practice to throw an exception of type Exception. Why and what should you do instead.
    > It makes it more difficult to understand and handle the exception. Instead, you should throw a more specific exception. Specific exceptions make it easier for other developers to catch and handle particular error conditions.
- What is an `ArgumentException` and an `ArgumentOutOfRangeException`?
    > `ArgumentException`: Thrown when a method receives an argument that is invalid.
    > `ArgumentOutOfRangeException`: A more specific type of `ArgumentException`. Thrown when an argument is outside the allowable range of values.
- What is a `try-catch` statement?
    > It is used to handle exceptions that might occur during the execution of a code block. Place the code where an exception might occur inside a `try` block. Use a `catch` clause to specify the type of exceptions you want to handle in the corresponding `catch` block.
- How does `finally` work?
    > The `finally` block is executed regardless of whether an exception happens or not.
- What is wrong with the following code?
    ```
        try
        {
            Student s = new Student(student.Name, student.Age);
            Students.Add(s);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Not added - {ex.Message}. ");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Not added - {ex.Message}. ");
        }
    ```
    > There will be a compile-time error. The order of the exceptions caught is incorrect since `ArgumentOutOfRangeException` is a type of `ArgumentException` and therefore the second catch will never happen.
- What happens if an exception is not caught?
    > The program will stop executing.
- It is best practice to avoid `try-catch` when possible. What can you do instead?
    > Use code to control the flow of your program to do checks so that the exception will not be thrown. For example, check if a file exists before opening it, or validate input before processing.