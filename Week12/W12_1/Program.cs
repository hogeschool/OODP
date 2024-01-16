/*
Contents:
 - Recursion
     - Recursion
         - Recursion
             - Recursion
                 - ...

No, seriously now:
 - the purpose of recursion: decomposition
     - example: factorial
 - Base case
 - Recursive step
 - Advantages
 - Disadvantages

Some good sources:
 - https://www.sparknotes.com/cs/recursion/whatisrecursion/section1/
 - https://www.recursionvisualizer.com/
 */

public class Program
{
    static void Main()
    {
        DecomposeProblem();
        BaseCase();
        RecursiveStep();
        Advantages();
        Disadvantages();
        FibonacciDemo();
    }

    static void DecomposeProblem()
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

    static int Factorial(int n)
    {
        // Put breakpoints on the next 3 lines
        if (n == 1) // Base case 
            return 1;
        return n * Factorial(n - 1); // Recursive step
    }

    static void BaseCase()
    {
        Console.WriteLine(
            "Why do we need a base case?" +
            "Reaching the base case means we are ready to solve the problem. " +
            "Also without this base case, the recursion would continue indefinitely " +
            "and eventually result in a stack overflow error.");
    }

    static void RecursiveStep()
    {
        Console.WriteLine(
            "In the recursive case, we decompose a problem into a " +
            "smaller version of the problem. " +
            "In the case of Factorial, we assume that we know how to " +
            "calculate (n-1)!. We use this assumption to calculate n! " +
            "by multiplying n by (n-1)!. This process continues " +
            "recursively until we reach the base case of n=1, " +
            "at which point we simply return 1. The recursive step is what" +
            " makes recursion so powerful - it allows us to break down complex" +
            " problems into simpler subproblems, and solve them in a way" +
            " that's elegant and easy to understand.");
    }

    static void Advantages()
    {
        Console.WriteLine(
            "Solving certain problems using recursion " +
            " - is simpler / shorter / easier to understand" +
            " - is easier to implement/more elegant (Ex: Fibonacci)");
    }

    static void Disadvantages()
    {
        Console.WriteLine(
            "Solving certain problems using recursion " +
            " - takes more memory" +
            " - can result in stack overflow exception" +
            " - can be less intuitive");
    }

    static void FibonacciDemo()
    {
        Console.WriteLine("Let's calculate Fibonacci iteratively:");
        Console.WriteLine("Fibonacci.Iteratively(5) = " + Fibonacci.Iteratively(5));

        //Console.WriteLine("Let's calculate Fibonacci recursively:");
        //Console.WriteLine("Fibonacci.Recursively(5) = " + Fibonacci.Iteratively(5));
    }
}