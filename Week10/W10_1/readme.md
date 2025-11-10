## Day 1 (W10_1)

## Contents:

### PART 1: `enum`
* `enum` creation (W10.1.1T01)
* `enum` in combination with `switch` (W10.1.1T02)
* `enum` looping & parsing (W10.1.1T03)
* `enum` mapping (W10.1.1T04)

### PART 2: `Stack`s & `Queue`s
* `Stack`s (W10.1.1T05)
* `Queue`s (W10.1.1T06)

## Summary
PART 1: enum

An `enum`eration lets you define a set of named constants — values that belong together conceptually. They make your code easier to read, safer, and less error-prone than using “magic numbers” or raw strings.

Example:

```csharp
enum Direction
{
    North,
    East,
    South,
    West
}
```

You can use an `enum` in a `switch` statement, loop through its values, or even convert between numbers and enum values.

By the end of this part, you’ll know how to:
- Create and use an `enum`
- Combine `enum` with `switch` for cleaner logic
- Loop through and parse `enum` values
- Convert between `enum` and other types

PART 2: Stacks & Queues

Both `Stack` and `Queue` are special collection types that control the order in which elements are added and removed. They are like specialized lines or piles — perfect for situations where order matters.

🧱 `Stack<T>`

A `Stack` follows the LIFO rule — Last In, First Out.\
Imagine a stack of plates: the last one you put on top is the first one you take off.

```csharp
Stack<string> plates = new Stack<string>(); // or Stack<string> plates = [];
plates.Push("Bottom");
plates.Push("Middle");
plates.Push("Top");

Console.WriteLine(plates.Pop()); // "Top"
```

🚶🚶🚶 `Queue<T>`

A `Queue` follows the FIFO rule — First In, First Out.\
It’s like a line at the supermarket: the first person in line is the first to be served.

```csharp
Queue<string> customers = [];
customers.Enqueue("Alice");
customers.Enqueue("Bob");
customers.Enqueue("Charlie");

Console.WriteLine(customers.Dequeue()); // "Alice"
```

By the end of this part, you’ll be able to:
- Understand when to use a `Stack` vs. a `Queue`
- Use `Push`, `Pop`, `Peek`, and `Count` for stacks
- Use `Enqueue`, `Dequeue`, `Peek`, and `Count` for queues
- Visualize how elements move through these collections
