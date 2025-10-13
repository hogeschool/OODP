static class Program
{
    static void Main()
    {
        // The most important difference between Lists and arrays
        // is that arrays cannot change in size.

        int[] combination = [1, 2, 3, 4];
        int[] input = ReadCombinationInput(4);

        bool isCorrect = IsCombinationCorrect(combination, input);
        PrintResult(isCorrect);
    }

    static int[] ReadCombinationInput(int length)
    {
        Console.WriteLine("Enter the lock combination:");
        int[] input = new int[length];
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }
        return input;
    }

    static bool IsCombinationCorrect(int[] combination, int[] input)
    {
        for (int i = 0; i < combination.Length; i++)
        {
            if (input[i] != combination[i])
                return false;
        }
        return true;
    }

    static void PrintResult(bool isCorrect)
    {
        Console.WriteLine("The lock combination is " +
            (isCorrect ? "correct!" : "incorrect."));
    }
}