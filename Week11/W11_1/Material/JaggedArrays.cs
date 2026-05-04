static class JaggedArrays
{
    public static void Run()
    {
        /*
            group 0: {"John", "Mary", "Tim"}
            group 1: {"Fred", "Wilma"}
            group 2: {"Lisa", "Bart", "Homer", "Marge", "Maggie"}
        */

        /* 
        "short" way
        type[][] name = [
            [value1, value2,...],
            [value1, value2,...],
        ];
        */
        string[][] groups = [
            ["John", "Mary", "Tim"],
            ["Fred", "Wilma"],
            ["Lisa", "Bart", "Homer", "Marge", "Maggie"],
        ];

        /*
        Long pre .NET 8 version:
        type[][] name = {
            new []{value1, value2,...},
            new []{value1, value2,...},
        }
        */
        string[][] groups2 = [
            ["John", "Mary", "Tim"],
            ["Fred", "Wilma"],
            ["Lisa", "Bart", "Homer", "Marge", "Maggie"]
        ];

        // Length

        // Accessing elements
        string firstInFirst = groups[0][0];
        string firstInSecond = groups[1][0];
        string lastInLast = groups[^1][^1];

        // Print using for
        Console.WriteLine("---\nfor:");
        for (int i = 0; i < groups.Length; i++)
        {
            for (int j = 0; j < groups[i].Length; j++)
            {
                Console.Write($"{groups[i][j]} ");
            }
            Console.WriteLine();
        }
        /*
                i   j   groups[i].Length    groups[i][j])
                0   0   3                   "John"
                0   1   3                   "Mary"
                0   2   3                   "Tim"
                1   0   2                   "Fred" 
                1   1   2                   "Wilma"
                2   0   5                   "Maggie"
                2   1   5                   "Lisa"
                2   2   5                   "Bart"
                2   3   5                   "Homer"
                2   4   5                   "Marge"     
        */

        //Print using foreach
        Console.WriteLine("---\nforeach:");
        foreach (string[] array in groups)
        {
            foreach (string name in array)
            {
                Console.Write($"{name} ");
            }
            Console.WriteLine();
        }
    }

    /*
        Write a method to create a triangular jagged array of a given size, filled with 1s. For example, if the given size is 4, the jagged array would be:
        ```
        [
            [1],
            [1,1],
            [1,1,1],
            [1,1,1,1]
        ]
        ```
    */
    public static int[][] GetTriangle(int size)
    {
        //type[][] name = new type[size][];

        int[][] triangle = new int[size][]; // {null, null, null, null}

        // Fill array, first create array in each slot, 
        // triangle[0] = new int[1];
        // triangle[1] = new int[2];
        // triangle[2] = new int[3];
        // ... better with a loop

        for (int i = 0; i < triangle.Length; i++)
        {
            triangle[i] = new int[i + 1];
            for (int j = 0; j < triangle[i].Length; j++)
            {
                // then put 1 in each slot of those arrays
                triangle[i][j] = 1;
            }
        }

        return triangle;
    }
}