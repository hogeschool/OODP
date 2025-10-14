static class FactorialExample
{
    public static void Run()
    {
        int num = 5;
        int result = Factorial(num);
        Console.WriteLine($"The factorial of {num} is {result}.\n");
        
        DecomposeProblem();
    }
    
    private static int Factorial(int n)
    {
        if (n == 1) // Base case 
            return 1;
        // Recursive case: n * Factorial(n - 1);
        // Recursive step: n - 1
        // Recursive call: Factorial(n - 1)
        return n * Factorial(n - 1);
    }
    
    private static void DecomposeProblem()
    {
        Console.WriteLine("Recursion is used to decompose a problem into smaller ones:");

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