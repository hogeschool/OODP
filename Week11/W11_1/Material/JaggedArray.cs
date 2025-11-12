static class JaggedArray
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
        Long pre dotnet 8 version:
        type[][] name = {
            new [] {value1, value2,...},
            new [] {value1, value2,...},
        }
        */
        string[][] groups2 = {
            new []{"John", "Mary", "Tim"},
            new []{"Fred", "Wilma"},
            new []{"Lisa", "Bart", "Homer", "Marge", "Maggie"}
        };

        // Accessing elements
        string firstInFirst = groups[0][0];
        string firstInSecond = groups[1][0];
        string lastInLast = groups[^1][^1];

        // Length
        Console.WriteLine($"Number of rows: {groups.Length}");
        Console.WriteLine($"Number of columns in the first row: {groups[0].Length}");
        Console.WriteLine($"Number of columns in the second row: {groups[1].Length}");
        Console.WriteLine($"Number of columns in the third row: {groups[2].Length}");

        // Print using for
        Console.WriteLine("---\nfor:");
        for (int i = 0; i < groups.Length; i++)
        {
            for (int j = 0; j < groups[i].Length; j++)
            {
                Console.Write(groups[i][j] + " ");
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
        foreach (var array in groups)
        {
            foreach (var name in array)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
}