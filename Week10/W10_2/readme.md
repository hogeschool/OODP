# Week 10

## Day 2 (W10.2)

### Contents: arrays
* Create (W10.2.1T01)
* Access elements; `.Length` (W10.2.1T02)
* Reverse (W10.2.1T03)
* Replace elements (W10.2.1T04)
* 'Adding' elements (W10.2.1T05)
* 'Removing' occurrences (W10.2.1T06)

Summary

Arrays are a lot like `List`s, except they have a fixed size. In other words, once created, you cannot add or remove elements. This makes them simple, predictable, and fast.

Example:
```csharp
int[] numbers = { 2, 4, 6, 8 };
// Alternative: int[] numbers = [2, 4, 6, 8];
Console.WriteLine(numbers[0]); // 2
Console.WriteLine(numbers.Length); // 4
```

Arrays don’t come with methods like `.Add()` or `.Remove()`.\
However, you can still use indices (`[0]`, `[1]`, …) to access or modify values.

Arrays vs Lists
Feature	Array	List
Size	Fixed	Flexible
Syntax	`int[] arr = new int[5]`;	`List<int> list = new()`;
Access	Index (`arr[0]`)	Index (`list[0]`)
Add/Remove	Not directly supported	`.Add()`, `.Remove()`
Performance	Slightly faster, less overhead	Slightly slower, but more convenient

Lists are built on top of arrays, offering more features at the cost of a little flexibility and performance overhead. **Arrays are best when you know exactly how many items you’ll have, or when you need high efficiency** (for example, in numerical or graphical computations).

### What You’ll Learn
You’ll work with arrays from the ground up — creating them, manipulating elements, and thinking carefully about their fixed structure.

### Looking Ahead

Arrays give you the foundation for working with fixed-size data structures — a concept that returns later when dealing with multidimensional arrays and performance-sensitive algorithms.
You’ll also see how arrays fit naturally with loops, LINQ, and higher-order functions in later weeks, where you’ll process collections in more expressive and powerful ways.