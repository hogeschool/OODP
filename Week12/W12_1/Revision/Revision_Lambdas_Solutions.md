Revision
---
- What are the parameter types and return type of `fun1`?\
`Func<int, bool, string> fun1;`\
&rarr;  parameters: `int` and `bool`, return: `string`
- What are the parameter types and return type of `fun2`?\
`Func<double> fun2;`\
&rarr;  parameters: none, return: double
- How do you store a method which takes in an `int` and does not return anything?\
&rarr; `Action<int>`
- What is an expression lambda?\
&rarr; An expression lambda has an expression as its body: `x => x + 1`
- What is a statement lambda?\
&rarr; A statement lambda has a statement block as its body:
    ```csharp
    x => { 
        if (x < 0)
            return "negative";
        else if (x > 0)
            return "positive";
        else
            return "zero";
    } 
    ```
- Why is it useful to be able to store methods/lambdas in a variable?\
&rarr; Because we can pass them as arguments or return them from other methods. This is especially useful in LINQ and functional programming patterns.