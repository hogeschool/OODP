static class Program
{
    static void Main()
    {
        Console.WriteLine("Countdown from 10");
        PrintCountDown(10);
    }
    
    static void PrintCountDown(int count)
    {
        if (count == 0) // Base case
        {
            Console.WriteLine("0, fire!");
            return;
        }

        Console.WriteLine(count); // Recursive step
        PrintCountDown(count - 1); // Recursive call
    }
}

// Method PrintCountDown has a flaw.
// For what values of count does it result in an infinite loop/StackOverflowException?