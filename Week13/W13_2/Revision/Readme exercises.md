`MyLINQ`
  - Task 1a: Implement `MyCount`\
      Write a method named `Count` that:
    - Accepts an array of integers and a predicate function (a function that takes an int and returns a bool).
    - Returns the number of elements in the array for which the predicate function evaluates to true.

  - Task 1b: Implement `MyWhere`\
      Write a method named `MyWhere` that:
    - Accepts an array of integers and a predicate function (a function that takes an int and returns a bool).
    - Returns a new array containing all elements from the input array for which the predicate function evaluates to true.

`GuessingGame`
  - Task 2: Improve the guessing game\
    Right now the "Secret" criteria is that the value is even. But I would like to make this customizable and set the criteria when I start the game. Adjust the code so that I can do this.\
    As an introduction play the game "I am allowed on the boat because..."

`AndThen`
- Task 3: Implement `Then`\
      Write a method named `Then` that:
    - Accepts two functions, `f` and `g`, each taking an `int` and returning an `int`.
    - Returns a new function that, when called with an integer `x`, applies f to x first, and then applies `g` to the result of `f(x)`. In other words apply `f` first, **then** `g`.
    - Example of calling the code:
        ```csharp
        Func<int, int> add2mul2 = Then(x => x + 2, x => x * 2);
        int result = add2mul2(5);
        ```
        Explanation:
        - In line 1 `Then` is called and
            - `f` is `x => x + 2` (add 2).
            - `g` is `x => x * 2` (multiply by 2).
            - it returns `x => g(f(x))` (add 2 **then** multiply 2)
            This is stored in `add2mul2`
        - In line 2 we call the method created 
            - Apply `f` where `x` is 5: f(5) = 5 + 2 = 7
            - Apply `g` to that result (`f(x)`): g(7) = 7 * 2 = 14
            - So result becomes 14.