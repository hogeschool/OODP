# Revision
## enums
- What is an `enum` type?
    > An `enum` type (or enumeration type) is a value type defined by a set of named constants of the underlying integral numeric type. In short, it is a set of named constants.
- When would you use an enum?
    > - When you want to represent a finite set of options while also:
      - improve code clarity and maintainability
      - use meaningful names instead of magic numbers/strings
- What is the underlying type of an enum in C#?
    > By default, the underlying type of an enum is `int`. However, you can specify another integral type like `byte`, `short`, `long`, etc.
- What is the integer value of `Option.Start`? Why?
    ```csharp
    public enum Option
    {
        Stop,
        Start,
        Continue
    } 
    ```
    > 1, because the first member has value 0 and `Start` is the second member.
- What is the integer value of `Option.Start` in this case? Why?
    ```csharp
    public enum Option
    {
        Stop = 1,
        Start,
        Continue
    } 
    ```
    > 2, because the first member has value 1 and `Start` is the second member.
-  Can you assign specific values to all `enum` members?
    > Yes
- How can you get the integer value of the `enum` member `Option.Stop` in code?
    > `int intValue = (int)Option.Stop;`
- How can you get the string value of the enum member `Option.Stop` in code?
    > `string stringValue = Option.Stop.ToString();`

## Stacks
- What is a `Stack` data structure?
    > A `Stack` is a data structure that stores items in a Last In, First Out (LIFO) order. The most recently added item is the first one to be removed.
- When would you use a `Stack`?
    > You would use a `Stack` structure when you need to process items in Last In, First Out (LIFO) order—meaning the most recently added item should be handled first. For example, a stack of cards, undo redo functionality, etc.
- How do you add something to a `Stack`?
    > `Push(T item)`
- How do you remove something from a `Stack`?
    > `Pop()`
- How do you get the top element of a `Stack`?
    > `Peek()`
- How can you check how many elements are in a `Stack`?
    > `Count`
- How can you check if a `Stack` contains something?
    > `Contains(T item)`
- How can you empty a `Stack`?
    > `Clear()`
- Given the following code, what value will be stored in result? Why?
    ```csharp
    Stack<int> numbers = new Stack<int>();
    numbers.Push(10);
    numbers.Push(20);
    numbers.Push(30);
    int result = numbers.Pop();
    ```
    > `result` will be 30 because it was the last value pushed onto the stack (LIFO).
- What happens if you call `Pop()` on an empty `Stack`?
    > An `InvalidOperationException` is thrown because there is no element to remove.
- How can you iterate over the elements in a `Stack`? In what order will they be returned?
    > using a `foreach`. Elements are returned from top to bottom (most recent first).

## Queues
- What is a `Queue` data structure?
    > A `Queue` is a data structure that stores items in a First In, First Out (FIFO) order. The first item added is the first one to be removed.
- When would you use a `Queue`?
    > You would use a `Queue` structure when you need to process items in First In, First Out (FIFO) order—meaning the first added item should be handled first. For example, a queue in a shop, print queue, task scheduler, etc.
- How do you add something to a `Queue`?
    > `Enqueue(T item)`
- How do you remove something from a `Queue`?
    > `Dequeue()`
- How do you get the front element of a `Queue`?
    > `Peek()`
- How can you check how many elements are in a `Queue`?
    > `Count`
- How can you check if a `Queue` contains something?
    > `Contains(T item)`
- How can you empty a `Queue`?
    > `Clear()`
- Given the following code, what value will be stored in result? Why?
    ```C#
    Queue<int> numbers = new Queue<int>();
    numbers.Enqueue(10);
    numbers.Enqueue(20);
    numbers.Enqueue(30);
    int result = numbers.Dequeue();
    ```
    > `result` will be 10 because it was the first value enqueued onto the queue (FIFO).
- What happens if you call `Dequeue()` on an empty `Queue`?
    > An `InvalidOperationException` is thrown because there is no element to remove.
- How can you iterate over the elements in a queue? In what order will they be returned?
    > using a `foreach`. Elements are returned from front to back (first added first).