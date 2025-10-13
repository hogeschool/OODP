static class NDimArray
{
    public static void Run()
    {
        Console.WriteLine("Welcome to Minesweeper!");

        char[,] board = CreateBoard(10, 10);
        PlaceMines(board, 15);
        PrintBoard(board);
    }

    private static char[,] CreateBoard(int rows, int cols)
    {
        char[,] board = new char[rows, cols];
        for (int r = 0; r < rows; r++)
            for (int c = 0; c < cols; c++)
                board[r, c] = '-';
        return board;
    }

    private static void PlaceMines(char[,] board, int numMines)
    {
        Random random = new();
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);
        int minesPlaced = 0;

        while (minesPlaced < numMines)
        {
            int row = random.Next(rows);
            int col = random.Next(cols);

            if (board[row, col] != '*')
            {
                board[row, col] = '*';
                minesPlaced++;
            }
        }
    }

    private static void PrintBoard(char[,] board)
    {
        Console.WriteLine("\nGenerated board:");
        for (int r = 0; r < board.GetLength(0); r++)
        {
            for (int c = 0; c < board.GetLength(1); c++)
                Console.Write(board[r, c] + " ");
            Console.WriteLine();
        }
    }
}