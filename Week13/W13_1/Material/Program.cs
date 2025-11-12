static class Program
{
    static void Main()
    {
        /*
            C# is a strongly typed language. Even methods have a type
            It allows you to treat methods as variables,
            so you can then (for example) send these to methods.
            We will see this when we look at LINQ and
            higher order functions
        */

        // Remember storing a variable has this syntax:
        // type name = value;
        int n = 1;

        // We can also store methods in variables.
        // Func<paramType1, paramType2, ..., returnType>
        Func<int, bool> isNeg = IsNegative; // isNeg takes an int and returns a bool
        Func<int, int, int> sum = Sum; // sum takes two ints and returns an int
        Func<string> sayBoo = SayBoo;

        // We can rewrite these using lambdas
        Func<int, bool> isNeg2 = number => number < 0;
        Func<int, int, int> sum2 = (a, b) => a + b;
        Func<string> sayBoo2 = () => "Boo!";

        // We can use our "new names" to call the methods as normal:
        int result = sum2(1, 2);

        // We cannot use void as the return type
        // Func<string, void> notGonnaWork = Print; //Error, can't use void

        // Instead, we have to use Action for methods that have a void return type.
        // Action<paramType1, paramType2, ...>
        Action helloWorld = HelloWorld;
        Action<string> print = Print;

        // We can rewrite these using lambdas
        Action helloWorld2 = () => Console.WriteLine("Hello world!");
        Action<string> print2 = s => Console.WriteLine(s);
        // Or: Action<string> print2 = Console.WriteLine;

        // We can then use our "new names" to call the methods as norma;
        helloWorld2();

        /*
            The lambdas that we have looked at so far are known as
            expression lambdas. Expression lambdas have an expression
            as its body. A statement lambda has a statement block
            as its body, containing multiple statements.
        */
        Func<int[], int> sumArray = (array) =>
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count += array[i];
            }
            return count;
        };

        Action<int[]> printArray = (array) =>
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        };
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

    public static void InClassExercises()
    {
        /*
            Store lambdas which do the following:
            - squares a given number
            - prints the first element in an array
            - multiplies three numbers together
            - sum a 2D int array
            - sets the first element in an array to a given value
            - print a jagged string array
        */

        Func<int, int> square = x => x * x; // Squares a given number
        Console.WriteLine($"Square of 5: {square(5)}");

        // prints the first element in an array
        Action<int[]> printFirstElement = arr => Console.WriteLine($"First element: {arr[0]}");
        printFirstElement([10, 20, 30]);

        // Multiplies three numbers together
        Func<int, int, int, int> multiplyThree = (a, b, c) => a * b * c;
        Console.WriteLine($"Multiply 2, 3, 4: {multiplyThree(2, 3, 4)}");

        // Sum a 2D int array
        Func<int[,], int> sum2DArray = arr =>
        {
            int sum = 0;
            foreach (var num in arr)
                sum += num;
            return sum;
        };
        int[,] matrix = { { 1, 2 }, { 3, 4 } };
        Console.WriteLine($"Sum of 2D array: {sum2DArray(matrix)}");

        // Sets the first element in an array to a given value
        Action<int[], int> setFirstElement = (arr, value) => arr[0] = value;
        int[] numbers = [5, 6, 7];
        setFirstElement(numbers, 99);
        Console.WriteLine($"Updated first element: {numbers[0]}");

        // print a jagged string array
        Action<string[][]> printJaggedArray = jagged =>
        {
            foreach (var innerArray in jagged)
            {
                Console.WriteLine(string.Join(", ", innerArray));
            }
        };
        string[][] jaggedArray = [
            ["Hello", "World"],
            ["C#", "Lambda", "Funcs"]
        ];
        printJaggedArray(jaggedArray);
    }
}