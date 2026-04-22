# Revision
## enums
- What is an `enum` type?
- When would you use an `enum`?
- What is the underlying type of an `enum` in C#?
- What is the integer value of `Option.Start`? Why?
    ```csharp
    public enum Option
    {
        Stop,
        Start,
        Continue
    } 
    ```
- What is the integer value of `Option.Start` in this case? Why?
    ```csharp
    public enum Option
    {
        Stop = 1,
        Start,
        Continue
    } 
    ```
- Can you assign specific values to all enum members?
- How can you get the integer value of the enum member `Option.Stop` in code?
- How can you get the string value of the enum member `Option.Stop` in code?
- How can you get all the values in an `enum`, for example in `Option`? What type will you get?
- How can you check if a `string` has a corresponding `enum`?

## Stacks
- What is a `Stack` data structure?
- When would you use a `Stack`?
- How do you add something to a `Stack`?
- How do you remove something from a `Stack`?
- How do you get the top element of a `Stack`?
- How can you check how many elements are in a `Stack`?
- How can you check if a `Stack` contains something?
- How can you empty a `Stack`?
- Given the following code, what value will be stored in result? Why?
    ```csharp
    Stack<int> numbers = new Stack<int>();
    numbers.Push(10);
    numbers.Push(20);
    numbers.Push(30);
    int result = numbers.Pop();
    ```
- What happens if you call `Pop()` on an empty `Stack`?
- How can you iterate over the elements in a `Stack`? In what order will they be returned?

## Queues
- What is a `Queue` data structure?
- When would you use a `Queue`?
- How do you add something to a `Queue`?
- How do you remove something from a `Queue`?
- How do you get the top element of a `Queue`?
- How can you check how many elements are in a `Queue`?
- How can you check if a `Queue` contains something?
- How can you empty a `Queue`?
- Given the following code, what value will be stored in `result`? Why?
    ```C#
    Queue<int> numbers = new Queue<int>();
    numbers.Enqueue(10);
    numbers.Enqueue(20);
    numbers.Enqueue(30);
    int result = numbers.Dequeue();
    ```
- What happens if you call `Dequeue()` on an empty `Queue`?
- How can you iterate over the elements in a `Queue`? In what order will they be returned?