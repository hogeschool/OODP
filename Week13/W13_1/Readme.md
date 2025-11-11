# Week 13

## Day 1 (W13_1)

### Contents: Higher-Order Functions (HOFs)
- HOF that takes a function (W13.1.1T01)
- HOF that returns a function (W13.1.1T02)
- Generic HOF (W13.1.1T03)

### Summary
A **higher-order function** is a method that takes one or more functions as arguments, and/or returns a function as its result.

You’ve actually already encountered several of these. For example, many methods in C#’s List<T> class are higher-order functions:
- `ForEach` takes a function and applies it to every element in the list.
- `Find` takes a function (a condition) and returns the first element that satisfies it.

These methods don’t just perform a single hard-coded action — instead, they let you define the behavior by passing in a function.\
That flexibility is exactly what makes them higher-order functions.

#### Why higher-order functions?
Higher-order functions are useful because they let us separate what we do from how we do it
For example, instead of writing multiple loops that all look the same but do slightly different things, we can write one reusable method that takes a function to specify the unique part.

This helps us:
- Avoid code duplication (write once, reuse often)
- Make our code more readable and expressive

Think at a higher level of abstraction (“apply this rule to all elements”) rather than focusing on loops and details.

In short: HOFs let you tell your code what to do, not how to do it.

#### Example
You might have already seen something like this:
```csharp
public void UpdateGrades(Func<decimal, decimal> f)
{
    foreach (var studentId in _grades.Keys.ToList()) // 'f' is a function — we can apply it to each grade
    {
        decimal updated = f(_grades[studentId]);
        _grades[studentId] = (updated == DefaultGrade)
            ? DefaultGrade
            : Math.Clamp(updated, MinGrade, MaxGrade);
    }
}
```

This method takes a function, so it’s a higher-order function.\
Depending on the function you pass, you can use it to curve grades, cap them, or even normalize them — all without changing the method itself.