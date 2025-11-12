static class Program
{
    static void Main()
    {
        MethodsAsVariables();
        HigherOrderFunctions();
        UsingHOFs();
        HOFsReturningHOFs();
    }

    private static void MethodsAsVariables()
    {
        // C# is a strongly typed language. Even methods have a type.
        // It allows you to treat methods as variables

        // Func<paramType1, paramType2, ..., return type>
        int n = 1;
        Func<int, bool> isNeg = IsNegative; // isNeg takes an int and returns a bool
        Func<int, int, int> sum = Sum; // sum takes two ints and returns an int
        Func<string> sayBoo = SayBoo;

        // We can rewrite these as lambdas
        Func<int, bool> isNeg2 = number => number < 0;
        Func<int, int, int> sum2 = (a, b) => a + b;
        Func<string> sayBoo2 = () => "Boo!";

        // Func<string, void> notGonnaWork = Print; //Error, can't use void
        // Instead, we have to use Action for methods that have a void return type
        // Action<paramType1, paramType2, ...>
        Action<string> cw1 = Print;
        Action helloWorld = HelloWorld;

        // We can rewrite these as lambdas
        Action<string> cw2 = s => Console.WriteLine(s);
        Action helloWorld2 = () => Console.WriteLine("Hello world!");

        // We can then use our "new names" to call the methods 
        bool ans = isNeg(5);
    }

    public static bool IsNegative(int n)
    {
        return n < 0;
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static string SayBoo()
    {
        return "Boo!!";
    }

    public static void Print(string s)
    {
        Console.WriteLine(s);
    }

    public static void HelloWorld()
    {
        Console.WriteLine("Hello World!");
    }

    private static void HigherOrderFunctions()
    {
        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        // What is the difference between IncreaseArray and TripleArray?
        IncreaseArray(numbers);
        TripleArray(numbers);

        // Can use higher order function instead
        // Can send our "usual" methods
        UpdateArray(numbers, Increase);

        // Or send a stored lambda
        Func<int, int> increase = x => x + 1;
        UpdateArray(numbers, increase);

        // Or send an inline lambda
        UpdateArray(numbers, x => x + 3);

        Repeat10(HelloWorld);
        Repeat10(HumptyDumpty);
        Repeat10(() => Console.WriteLine("Round we go"));
    }

    public static int Increase(int number)
    {
        return number + 1;
    }

    public static void HumptyDumpty()
    {
        Console.WriteLine("Humpty Dumpty sat on a wall,");
        Console.WriteLine("Humpty Dumpty had a great fall.");
        Console.WriteLine("All the king's horses and all the king's men");
        Console.WriteLine("Couldn't put Humpty together again.");
    }

    static void IncreaseArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arr[i] + 1;
        }
    }

    static void TripleArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arr[i] * 3;
        }
    }

    static void UpdateArray(int[] arr, Func<int, int> update)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = update(arr[i]);
        }
    }

    static void Repeat10(Action repeatThis)
    {
        for (int i = 0; i < 10; i++)
        {
            repeatThis();
        }
    }

    private static void UsingHOFs()
    {
        int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        List<string> words = ["hi", "hello", "bye"];
        // The thing you will do most often with higher order functions is use them
        // Find/FindAll
        int three = Array.Find(nums, x => x == 3);
        int largerThanThree = Array.Find(nums, x => x > 3);
        int[] allLargerThanThree = Array.FindAll(nums, x => x > 3);

        string? result = words.Find(s => s == "bye");
        List<string> beginsWithH = words.FindAll(s => s[0] == 'h');

        // ForEach
        Array.ForEach(nums, x => Console.WriteLine(x));
        // Or: Array.ForEach(nums, Console.WriteLine);
        words.ForEach(s => Console.WriteLine(s));
        // Or: words.ForEach(Console.WriteLine);
    }

    static void HOFsReturningHOFs()
    {
        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        // We were able to call our methods like so:
        IncreaseArray(numbers);
        TripleArray(numbers);
        // Now we need to send in an extra parameter
        UpdateArray(numbers, x => x + 1);

        // We can get back the original functionality by creating a
        // Higher Order Function which returns an Action.
        // So this method generates methods, like a method factory.

        // We then create the methods:
        Action<int[]> increaseArray = GenerateMethod(x => x + 1);
        Action<int[]> tripleArray = GenerateMethod(x => x * 3);

        // Then we can call them like we did before:
        increaseArray(numbers);
        tripleArray(numbers);

        // How could we store our Generate method?
        Func<Func<int, int>, Action<int[]>> generateMethod = GenerateMethod;

        // We can even do the following if we do not wish to create and store a method.
        GenerateMethod(x => x + 1)(numbers);
    }

    // Generate Method
    static Action<int[]> GenerateMethod(Func<int, int> update)
    {
        return arr =>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = update(arr[i]);
            }
        };
    }
}