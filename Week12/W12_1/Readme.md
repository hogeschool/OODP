# Week 12

## Day 1 (W12_1)

### Contents: LINQ
  * `Where`, `OrderBy`/`OrderByDescending` (W12.1.1T01)
  * `Intersect`, `Union` (W12.1.1T02)
  * `GroupBy` (W12.1.1T03)
  * Query expressions (W12.1.1T04)

### Summary
LINQ stands for Language INtegrated Query.
It allows you to query and transform collections such as lists and arrays in a clear and expressive way.

For example:

```csharp
List<string> uniqueZipCodes = people
    .Select(p => p.ZipCode)
    .Distinct()
    .ToList();
```

Or:
```csharp
foreach (Person person in people
    .Where(p => p.CountryOfBirth == "The Netherlands" && p.Age >= 18)
    .OrderBy(p => p.LastName)
    .ThenBy(p => p.FirstName))
{
    Console.WriteLine(person);
}
```

As you can see, LINQ methods often take functions (usually written as lambdas) to describe what you want to filter, sort, or select.\
That makes LINQ a natural next step after learning about lambdas and higher-order functions.