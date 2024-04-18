/*
 Contents:
  - Tuples/ValueTuples (W11.1.C01-C03)
  - Arrays: creation (W11.1.C04)

  Not covered; should speak for itself:
  - Arrays: Length & accessing elements (W11.1.C05-C06)
  - Arrays: Sort & Reverse (W11.1.C07)

  - Indexer overloading (W11.1.C08)
*/

static class Program
{
    static void Main()
    {
        Tuples();
        Arrays();
        IndexerOverloading(); //Extra
    }

//Tuples
    static void Tuples()
    {
        Console.WriteLine("\n=== Tuples ===");

        var result1 = Divide1(10, 3);
        Console.WriteLine("Quotient: " + result1.Item1);
        Console.WriteLine("Remainder: " + result1.Item2);

        var result2 = Divide2(10, 3);
        Console.WriteLine("Quotient: " + result2.Quotient);
        Console.WriteLine("Remainder: " + result2.Remainder);
    }

    //Tuple
    static Tuple<int, int> Divide1(int dividend, int divisor)
    {
        int quotient = dividend / divisor;
        int remainder = dividend % divisor;
        return Tuple.Create(quotient, remainder);
    }

    //ValueTuple (essentially better than Tuple)
    static (int Quotient, int Remainder) Divide2(int dividend, int divisor)
    {
        int quotient = dividend / divisor;
        int remainder = dividend % divisor;
        return (quotient, remainder);
    }

//Arrays
    static void Arrays()
    {
        Console.WriteLine("\n=== Arrays ===");

        //Creating an array to store the lock combination
        int[] combination = { 1, 2, 3, 4 };

        //Reading in user input to check the lock combination
        Console.WriteLine("Enter the lock combination:");
        int[] input = new int[4];
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }

        //Checking if the user input matches the lock combination
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

    static void IndexerOverloading() //Extra
    {
        Console.WriteLine("\n=== Indexer overloading ===");
        int[] ints = new[] { 3, 5, 1, 6, -2 };
        MyData myData = new(ints);

        Console.WriteLine(myData[0]);

        myData[2] = 4;
        Console.WriteLine(myData[2]);
    }
}
