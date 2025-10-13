# Week 11

## Day 2 (W11.1)

### Contents:

PART 1: lambda syntax
* Writing lambdas:
  * Inline functions; `Func`s (non-`void`) (W11.2.1T01)
  * Signatures (W11.2.1T02)
  * `Action`s (`void`) (W11.2.1T03)
PART 2: More advanced lambda forms
  * Statement lambdas (W11.2.1T04)
  * Curried lambdas (W11.2.1T05)

### Summary
Lambdas are powerful functions that can be passed around like data. Think of lambdas as “functions without names” — useful when you need quick, one-time logic.

For example:
// insert example here

###### `Func` vs `Action`
`Func` and `Action` are two built-in delegate types, with one difference:
- A `Func` always returns a value
- An `Action` does not--it is `void`

A `Func` example:
```csharp
Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(2, 3)); // 5
```

The **last** type parameter (`int` in this case) defines the return type.

An `Action` example:
```charp
Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
greet("Alice"); // Hello, Alice!
```

###### Lambda Expressions vs Statement Lambdas
A **lambda expression** is a short, single-line lambda that directly returns a result:
```csharp
Func<int, int> square = x => x * x;
```

A **statement lambda** can contain multiple lines of code enclosed in braces `{}`:
```csharp
Func<int, int> factorial = n =>
{
    int result = 1;
    for (int i = 2; i <= n; i++)
        result *= i;
    return result;
};

Console.WriteLine(factorial(5)); // 120
```

Statement lambdas are useful when your logic is too complex for a single expression.

###### What You’ll Learn
PART 1: Lambda syntax

You’ll start with the basics:
- Writing simple lambdas
- Understanding parameter and return types
- Seeing how C# infers types for you

PART 2: More advanced lambda forms

Once you’re comfortable with the syntax, you’ll move on to more expressive versions of lambdas:
- Statement lambdas, which can contain multiple lines of code
- Curried lambdas, which return other lambdas

###### Looking Ahead
After this week, you’ll see how lambdas come to life in LINQ, allowing you to query and transform data using expressive, functional-style syntax.
From there, you’ll learn about higher-order functions, which take lambdas to the next level — functions that create or consume other functions.