static class MultiDimArrays
{
    public static void Run()
    {
        // Creation
        // type[,] name = new type[rows, cols]
        // rows: number of arrays, cols: size of each array

        string[,] name = new string[4, 2];

        /*
            4 rows, 2 columns
            {null, null}
            {null, null}
            {null, null}
            {null, null}

        */
        /* 
            With values
            type[,] name = {
                {value1, value2, ...}, 
                {value1, value2, ...}
            };
        */
        int[,] numbers = {
            {1, 2, 3, 3},
            {4, 5, 6, 6},
            {7, 8, 9, 9},
        };

        // Length: gives you the total count of elements
        int total = numbers.Length;

        // GetLength: number of elements in the specified dimension
        // GetLength(0); // number of rows/arrays
        int rows = numbers.GetLength(0);
        // GetLength(1); // number of cols
        int cols = numbers.GetLength(1);

        // Accessing an element
        int first = numbers[0, 0];
        int last = numbers[numbers.GetLength(0) - 1, numbers.GetLength(1) - 1];
        int last2 = numbers[rows - 1, cols - 1];

        // Printing

        // Print using foreach
        // (Note: prints one line! Probably not what you want.)
        Console.WriteLine("foreach:");
        foreach (var item in numbers)
        {
            Console.Write($"{item} ");
        }

        // Print using for
        Console.WriteLine("---\nfor:");
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write($"{numbers[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}