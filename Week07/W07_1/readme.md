# Week 07

## Day 1 (W07_1)

### Contents:

PART 1
* IComparable (W07.1.1T01)
  * https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1
  * https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1.compareto

PART 2
* IEquatable (W07.1.1T02)
  * https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1
  * https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1.equals

## Summary

### `IComparable`
When a class implements `IComparable`, it gains the ability to decide which of two objects should come first. This is what makes sorting lists of custom objects possible.

For example:
```chsarp
class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Grade { get; set; }

    public int CompareTo(Student other)
    {
        return Grade.CompareTo(other.Grade);
    }
}
```

Now, a `List<Student>` can be sorted automatically using `students.Sort()` — because each student knows how to compare itself to another.

### `IEquatable`

IEquatable is similar, but instead of asking “Which one comes first?”, it answers “Are these two the same?”\
This is useful when checking equality beyond basic reference comparison.

```csharp
class Student : IEquatable<Student>
{
    public string Name { get; set; }
    public int Grade { get; set; }

    public bool Equals(Student other)
    {
        return Name == other.Name && Grade == other.Grade;
    }
}
```

By defining equality ourselves, we make our classes work naturally with methods like `Contains`, `Remove`, or when using them as dictionary keys.

### Closing
By the end of this topic, you’ll be able to:
* Implement `IComparable` to define a custom sort order
* Implement `IEquatable` to define what makes two objects equal
* Understand how these interfaces make generic collections more powerful