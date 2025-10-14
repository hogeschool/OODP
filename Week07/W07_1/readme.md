# Week 07

## Day 1 (W07_1)

### Contents:

PART 1
* IComparable (W07.1.1T01)
  * https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1
  * https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1.compareto

PART 2
* IEquatable (W07.1.1T02-03)
  * https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1
  * https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1.equals

## Summary

### `IComparable`
When a class implements `IComparable`, it gains the ability to decide which of two objects should come first. This is what makes sorting lists of custom objects possible.

For example:
```csharp
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

Now, a `List<Student>` can be sorted automatically using `students.Sort()` and `students.OrderBy()` (`OrderBy` will come later in the course) — because each student knows how to compare itself to another.\

### `IEquatable`

IEquatable is similar, but instead of asking “Which one comes first?”, it answers “Are these two the same?”\
This is useful when checking equality beyond basic reference comparison.

```csharp
class Student : IEquatable<Student>
{
    public int Id { get; }
    public string Name { get; set; }
    public int Grade { get; set; }

    public bool Equals(Student other)
    {
        return Id == other.Id;
    }
}
```

Now we don't have to worry about how to check for equality when adding a student to a list. So instead of this:
```csharp
public void AddStudent(Student student)
{
    if (!Students.Any(s => s.Id == student.Id)) // Compare by Id
        Students.Add(student);
}
```

... we can now simply do this:
```csharp
public void AddStudent(Student student)
{
    if (!Students.Contains(student)) // Compare by equality
        Students.Add(student);
}
```

By defining equality ourselves, we make our classes work naturally with methods like `Contains`, `Remove`, or when using them as dictionary keys.

### Closing
By the end of this topic, you’ll be able to:
* Implement `IComparable` to define a custom sort order
* Implement `IEquatable` to define what makes two objects equal
