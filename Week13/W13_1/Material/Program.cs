static class Program
{
    static void Main()
    {
        HigherOrderFunctions();
        UsingHOFs();
        HOFsReturningHOFs();
    }
    
    public static void HigherOrderFunctions()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // What is the difference between IncreaseArray and TripleArray?
        IncreaseArray(numbers);
        TripleArray(numbers);

        // We can use a higher order function (HOF) instead.

        // We can send "usual" methods...
        UpdateArray(numbers, Increase);

        // ... or stored lambdas...
        Func<int, int> increase = x => x + 1;
        UpdateArray(numbers, increase);

        // ... or inline lambdas.
        UpdateArray(numbers, x => x + 3);

        // More examples
        Repeat10(HelloWorld);
        Repeat10(HumptyDumpty);
        Repeat10(() => Console.WriteLine("Round we go"));
    }

    private static int Increase(int number)
    {
        return number + 1;
    }

    private static void IncreaseArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arr[i] + 1;
        }
    }

    private static void TripleArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arr[i] * 3;
        }
    }

    private static void HumptyDumpty()
    {
        Console.WriteLine("Humpty Dumpty sat on a wall,");
        Console.WriteLine("Humpty Dumpty had a great fall.");
        Console.WriteLine("All the king's horses and all the king's men");
        Console.WriteLine("Couldn't put Humpty together again.");
    }

    //UpdateArray
    private static void UpdateArray(int[] arr, Func<int, int> update)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = update(arr[i]);
        }
    }
    //Repeat10
    private static void Repeat10(Action repeatThis)
    {
        for (int i = 0; i < 10; i++)
        {
            repeatThis();
        }
    }

    public static void UsingHOFs()
    {
        int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        List<string> words = ["hi", "hello", "bye"];
        // THe thing you will do most often with higher order functions is use them
        //Find/FindAll
        int three = Array.Find(nums, x => x == 3);
        int largerThanThree = Array.Find(nums, x => x > 3);
        int[] allLargerThanThree = Array.FindAll(nums, x => x > 3);

        string result = words.Find(s => s == "bye");
        List<string> beginsWithH = words.FindAll(s => s[0] == 'h');

        //ForEach
        Array.ForEach(nums, x => Console.WriteLine(x));
        words.ForEach(s => Console.WriteLine(s));
    }

    public static void HOFsReturningHOFs()
    {
        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        // We are able to call our methods like so:
        IncreaseArray(numbers);
        TripleArray(numbers);
        // Now we need to send in an extra parameter:
        UpdateArray(numbers, x => x + 1);

        // We can get back the original functionality by creating a
        // Higher Order Function which returns an Action
        // So this method generates methods, like a method factory.
        
        // We then create the methods:
        Action<int[]> increaseArray = GenerateMethod(x => x + 1);
        Action<int[]> tripleArray = GenerateMethod(x => x * 3);

        // Then we can call them like we did before:
        increaseArray(numbers);
        tripleArray(numbers);

        // How could we store our Generate method?
        Func<Func<int, int>, Action<int[]>> generateMethod = GenerateMethod;

        // We can even do the following if we do not wish to create and store a method
        GenerateMethod(x => x + 1)(numbers);
    }

    // Generate Method
    private static Action<int[]> GenerateMethod(Func<int, int> update)
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