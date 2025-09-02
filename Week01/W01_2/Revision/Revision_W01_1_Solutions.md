Revision - Solutions
-------------------------------------
* What C# types did we look at? 
    > string, int, double, char, bool
* What is the result of this: `var doMath = 10 / 4;`, and why? 
    > 2, If you divide an integer by an integer then the result is an integer with the decimal part is truncated
* How do you print something to the console?
    > Console.WriteLine
* How do you read something in from the console?
    > Console.ReadLine()
* How could you improve the condition in the following code?
    ```
    int num = 5;
    bool isEven = num % 2 ==0;
    if (isEven == true){
        Console.WriteLine("Even");
    }
    ```
    > Solution:
    ```
    int num = 5;
    bool isEven = num % 2 ==0;
    if (isEven){
        Console.WriteLine("Even");
    }    
    ```
* Why does this result in an error?
    ```
    int num = 3;
    if (num < 1)
    {
        int ans = 5;
    }
    Console.WriteLine(ans);
    ```
    > `ans` only exists in the body (scope) of the `if`
What is a `switch` statement?
    > The `switch` statement selects and executes a block of code by comparing a given value against multiple case labels.
* What is a `switch` expression?
    > The `switch` expression evaluates a value and returns a result based on pattern-matching rules
* When should you use a `switch` vs an `if` statement?
    > When comparing the same variable to multiple constants a `switch` can be cleaner