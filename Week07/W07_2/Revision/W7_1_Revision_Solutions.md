Revision
---
`IComparable<T>`
- What is the purpose of the `IComparable<T>` interface?
    > The `IComparable<T>` interface allows an object to define its own natural sort order. Collections can use this to sort objects.
- Which method must be implemented when using `IComparable<T>`?
    > The `CompareTo(T other)` method must be implemented.
- What do the values mean that `CompareTo()` returns?
    > `CompareTo()` returns:
    > - A value less than 0 if the current object comes before the other object.
    > - 0 if the two objects are equal.
    > - A value greater than 0 if the current object comes after the other object.
- What happens if you call `Sort()` on a collection of objects that do not implement `IComparable<T>`?
    > A runtime exception will be thrown because the collection does not know how to compare the objects in order to sort them.

`IEquatable<T>`
- What is the difference between comparing objects by value and comparing them by reference?
    > Comparing by value checks whether two objects contain the same data. Comparing by reference checks whether two variables refer to the exact same object in memory.
- What does the `Contains()` method do?
    > It checks whether a collection contains a specified item and returns `true` if it is found; `false` otherwise.
- What is the purpose of the `IEquatable<T>` interface?
    > The `IEquatable<T>` interface allows a class to define what it means for two objects of that type to be equal.
- Which method must be implemented when using `IEquatable<T>`?
    > The `Equals(T other)` method must be implemented.
- Why do we override `Equals(object obj)` when implementing `IEquatable<T>`?
    > We override Equals(object obj) to ensure that all equality comparisons behave consistently, even when the object is referenced through a base object type. This allows methods and collections that use `object.Equals()` to use the same equality logic.