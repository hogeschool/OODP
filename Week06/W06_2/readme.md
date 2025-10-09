## Day 2 (W06_2)

## Contents:

### PART 1: generic classes and methods
* `List<T>` is generic (W06.2.1T01)
* Generic methods (W06.2.1T02)
* Multiple generic types (W06.2.1T03)
* Generic properties (W06.2.1T04)
* Generic methods + Multiple generic types (W06.2.1T05)
* Default value (`default` keyword) (W06.2.1T06)
* Inheritance of generic class with one type to multiple (W06.2.1T07)
* Inheritance of generic class to concrete types (W06.2.1T08)

### PART 2: generic constraints (`where`)
* `where` (W06.2.1T09)

## Summary
Generics allow us to write flexible, reusable code that can work with any data type, while still keeping type safety.

Instead of writing separate methods or classes for each data type (for example, one for int and another for string), generics let us define a single version that adapts automatically.
You’ve already seen this in action with types like `List<T>` and `Dictionary<TKey, TValue>`. The `<T>` acts as a **placeholder** for any type you choose when using the class.

We’ll also learn about the `where` keyword, which lets us add restrictions to what kinds of types can be used as the generic type parameter.\
For example:

```csharp
interface IPrint
{
    void Print();
}

public void PrintAll<T>(List<T> items) where T : IPrint // T must implement IPrint
{
    foreach (IPrint printable in items)
    {
        printable.Print();
    }
}
```

This way, we can use generics safely while still ensuring that the provided types have the features we need.

By the end of this topic, you’ll be able to:
- Create your own generic methods and classes
- Apply constraints using the `where` keyword