/*
Contents:
 - jagged arrays (W10.2.C01-02)
 - multidimensional arrays (W10.2.C03-04)
 - string methods 
	-> https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0#methods
    Some string methods to mention:
        - Contains, Trim, Split, Length, Substring, 
        - IsNullOrEmpty, ToUpper, ToLower
*/

public class Program
{
    static void Main()
    {
        JaggedArrays();
        //NDimArrays();
    }

    static void JaggedArrays()
    {
        Console.WriteLine("Welcome to the Observation Tracker!");

        Console.Write("How many days would you like to track observations for? ");
        int numDays = int.Parse(Console.ReadLine());
        // Initialize array to store observations for each day
        int[][] observations = new int[numDays][];

        for (int i = 0; i < observations.Length; i++)
        {
            Console.Write($"How many observations did you make on day {i + 1}? ");
            int numObs = int.Parse(Console.ReadLine());
            // Initialize array to store observations for current day
            observations[i] = new int[numObs];

            // Loop over each observation for current day
            for (int j = 0; j < observations[i].Length; j++)
            {
                Console.Write($"Enter observation {j + 1} for day {i + 1}: ");
                observations[i][j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Observation tracker complete! Here are the results:");
        for (int i = 0; i < observations.Length; i++)
        {
            Console.Write($"Day {i + 1}: {observations[i].Length} observations\n -");
            foreach (int obs in observations[i])
            {
                Console.Write(" " + obs);
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }

    static void NDimArrays()
    {
        Console.WriteLine("Welcome to Minesweeper!");

        // Set up board size
        int numRows = 10;
        int numCols = 10;
        int numMines = 15;

        // Initialize board with empty spaces
        char[,] board = new char[numRows, numCols];
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j] = '-';
            }
        }

        // Randomly place mines
        Random random = new();
        int numMinesPlaced = 0;
        while (numMinesPlaced < numMines)
        {
            int randRow = random.Next(0, numRows);
            int randCol = random.Next(0, numCols);

            if (board[randRow, randCol] != '*')
            {
                board[randRow, randCol] = '*';
                numMinesPlaced++;
            }
        }

        // Print board to console
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
