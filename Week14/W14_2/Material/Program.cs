static class Program
{
    static void Main()
    {
        CountDownExample();
        
        
        // Factorial + decomposition
        int num = 5;
        int result = Console.WriteLine(Factorial(num));
        Console.WriteLine($"The factorial of {num} is {result}");
        
    }
    
    public static void CountDownExample()
    {
        Console.WriteLine("=== Countdown from 10 ===");
        PrintCountDown(10);
    }
    
    private static void PrintCountDown(int count)
    {
        if (count == 0) // Base case
        {
            Console.WriteLine("0, fire!");
            return;
        }

        Console.WriteLine(count); // Recursive step
        PrintCountDown(count - 1); // Recursive call
    }
    
    // Method PrintCountDown has a flaw.
    // For what values of count does it result in an infinite loop/StackOverflowException?
    
    public static int Factorial(int n)
    {
        if (n == 1) // Base case 
            return 1; // Base step
        return n * Factorial(n - 1); // Recursive case and step
    }
    
    private static void DecomposeProblem()
    {
        Console.WriteLine("Recursion is used to decompose" +
            " a problem into smaller ones:");

        Console.WriteLine("Factorial(5)");
        Console.WriteLine(" = 5 * Factorial(4)");
        Console.WriteLine(" = 5 * 4 * Factorial(3)");
        Console.WriteLine(" = 5 * 4 * 3 * Factorial(2)");
        Console.WriteLine(" = 5 * 4 * 3 * 2 * Factorial(1)");
        Console.WriteLine(" = 5 * 4 * 3 * 2 * 1");
        Console.WriteLine(" = 120");

        Console.WriteLine("Let's see this in action:");
        int factorial5 = Factorial(5);
        Console.WriteLine(factorial5);
    }
}