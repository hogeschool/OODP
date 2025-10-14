static class CountDownExample
{
    public static void Run()
    {
        Console.WriteLine("=== Countdown from 10 ===");
        PrintCountDown(10);
    }
    
    private static void PrintCountDown(int count)
    {
        if (count == 0) // Base case: when to stop
        {
            Console.WriteLine("0, fire!");
            return;
        }
        // else: recursive case
        Console.WriteLine(count);
        // Recursive step: count - 1 (moves closer to 0)
        // Recursive call: PrintCountDown(count - 1)
        PrintCountDown(count - 1); // Recursive call
    }
    
    // Method PrintCountDown has a flaw.
    // For what values of count does it result in an infinite loop/StackOverflowException?
}