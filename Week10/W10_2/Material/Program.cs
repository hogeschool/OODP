static class Program
{
    static void Main()
    {
        // The most important difference between Lists and arrays
        // is that arrays cannot change in size.

        // Creating an array to store the lock combination
        int[] combination = { 1, 2, 3, 4 };

        // Reading in user input to check the lock combination
        Console.WriteLine("Enter the lock combination:");
        int[] input = new int[4];
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }

        // Checking if the user input matches the lock combination
        bool isCorrect = true;
        for (int i = 0; i < combination.Length; i++)
        {
            if (input[i] != combination[i])
            {
                isCorrect = false;
                break;
            }
        }

        Console.WriteLine("The lock combination is " +
            (isCorrect ? "correct!" : "incorrect."));
    }
}