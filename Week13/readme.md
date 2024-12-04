# Week 13

## Day 1 (W13_1)

### Contents:

PART 1: Higher-order Methods & Lambda's

In C#, a lambda expression is a shorthand syntax for creating an anonymous method. It allows you to define a block of code that can be passed as an argument to a method or stored in a variable, without having to define a named method separately.

Here's an example of a simple lambda expression: x => x * 2

In this example, x is the input parameter, => is the arrow symbol that separates the input parameter from the expression body, and x * 2 is the body of the expression.

You can think of a lambda expression as a kind of "inline" method definition. It's not named, but it can be used in the same way as a named method, such as by passing it as a parameter to another method or assigning it to a delegate variable.

More on Lambda expressions and anonymous functions:
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions


A higher-order method is a method that takes one or more methods as arguments and/or returns a method as its result. Some of the methods in the List class in C# do fit this definition. For example:

- The ForEach method takes a method or lambda as an argument and applies it to each element in the list.
- The Find method takes a method or lambda as an argument and returns the first element in the list that satisfies the method or lambda.

All of these methods take one or more methods as arguments, which makes them higher-order methods.

## Day 2 (W13_2)

### Contents:
None

