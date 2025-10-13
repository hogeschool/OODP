static class Program
{
    static void Main()
    {
        BasicExamples();
        FuncExamples();
        ActionExamples();
        PracticalExamples();
        CurriedLambdaExample();
    }

    static void BasicExamples()
    {
        Console.WriteLine("=== Basic Lambda Examples ===");

        // A simple lambda that squares a number
        Func<int, int> square = x => x * x;
        Console.WriteLine($"Square of 5 = {square(5)}");

        // A lambda with multiple parameters
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine($"3 + 4 = {add(3, 4)}");

        // A lambda with a more explicit syntax
        Func<int, int> doubleValue = (int n) => { return n * 2; };
        Console.WriteLine($"Double of 6 = {doubleValue(6)}");

        Console.WriteLine();
    }

    static void FuncExamples()
    {
        Console.WriteLine("\n=== Func Examples ===");

        // Func<TInput, TResult>
        Func<string, int> countLetters = word => word.Length;
        Console.WriteLine($"'Hello' has {countLetters("Hello")} letters");

        // Func with no input, just returning something
        Func<DateTime> getNow = () => DateTime.Now;
        Console.WriteLine($"The time is: {getNow()}");

        Console.WriteLine();
    }

    static void ActionExamples()
    {
        Console.WriteLine("\n=== Action Examples ===");

        // Action<T> — does something, returns nothing
        Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
        greet("Alice");

        // Action with no parameters
        Action sayHi = () => Console.WriteLine("Hi there!");
        sayHi();

        // Action with multiple parameters
        Action<int, int> printSum = (a, b) => Console.WriteLine($"{a} + {b} = {a + b}");
        printSum(5, 7);

        Console.WriteLine();
    }

    static void PracticalExamples()
    {
        Console.WriteLine("\n=== Practical Lambda Example ===");

        int[] numbers = [1, 2, 3, 4, 5, 6];
        Func<int, int> triple = x => x * 3;
        
        // Transforming data
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = triple(numbers[i]);
        }
        
        Console.WriteLine("\nTripled numbers:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        
        Console.WriteLine();
    }

    static void CurriedLambdaExample()
    {
        Console.WriteLine("=== Curried lambda example: configurable filters ===");

        int[] scores = [45, 55, 60, 70, 80, 90];

        // A curried lambda that builds a filtering function
        Func<int, Func<int, bool>> isPassingWithThreshold =
            threshold => score => score >= threshold;

        // "Partially apply" the first argument to create new filters
        Func<int, bool> isPassing50 = isPassingWithThreshold(50);
        Func<int, bool> isPassing75 = isPassingWithThreshold(75);

        Console.WriteLine("Students passing with threshold 50:");
        foreach (int score in scores)
        {
            if (isPassing50(score))
                Console.Write(score + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Students passing with threshold 75:");
        foreach (int score in scores)
        {
            if (isPassing75(score))
                Console.Write(score + " ");
        }
        Console.WriteLine();
    }
}