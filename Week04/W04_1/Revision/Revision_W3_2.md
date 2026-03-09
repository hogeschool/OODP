Revision
--------------------------
# Unit testing
- What is a project?
- What is an SLN file?
- What command do you use to create a new ms test project?
- What do you need to do to link this to the project you wish to test?
-  What do the following mean?
    - [TestClass]
    - [TestMethod]
    - [DataRow()]
    - Asserts

# Exceptions
- What is an exception and how does it differ from a compile time error?
- What does `throw` do?
- When should you throw an Exception?
- It is not good practice to throw an exception of type Exception. Why and what should you do instead.
- What is an `ArgumentException` and an `ArgumentOutOfRangeException`?
- What is a `try-catch` statement?
- How does `finally` work?
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
- What happens if an exception is not caught?
- It is best practice to avoid `try-catch` when possible. What can you do instead?
