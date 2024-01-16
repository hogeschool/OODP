/*
    Contents:
    * PART 1
    * while (W01.2.C01)
    * do-while (W01.2.C02)
    * for (W01.2.C03-04)
    * scope (Homework)
    * 
    * PART 2
    * Main (W01.2.C05)
    * Built-in class: List
    *  - Indexes (W01.2.C06)
    *  - Count (W01.2.C06)
    *  - Create (W01.2.C07)
    *  - Add (W01.2.C07)
    *  - Remove (W01.2.C07)
    *    
    * PART 3
    * Built-in classes: Random
    *  - random int (W01.2.C08)
    *  - pseudorandom int (W01.2.C09)
    *  - random double (W01.2.C10)
*/

public static class Program
{
    public static void Main()
    {
        //If there is a 'static void Main' in the project,
        //it will be the entry point of the program.
        //It is similar to using if __name__ == "__main__" in Python.

        //Uncomment the part you wish you demonstrate:
        //While();
        //DoWhile();
        //For();
        //Scope();
        //Lists();
        //Random();

        //The next part is run multiple times, to demonstrate that a
        //seeded Random generates predictable numbers.
        //for (int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine($"===Run #{i+1}===");
        //    PseudoRandom();
        //}
    }

    public static void While()
    {
        //The while-loop works exactly the same as in Python.
        int i = 0;
        while (i < 10)
        {
            i++;
        }
        Console.WriteLine(i);
    }

    public static void DoWhile()
    {
        /*
         * The do-while-loop has only one difference with the regular
         * while-loop: it is always executed at least once.
         * This is useful for example when you want to get
         * valid input from the user.
         */
        int i = 10;
        do
        {
            i++;
        } while (i < 10);
        Console.WriteLine(i);
    }

    public static void For()
    {
        /*
         * The for-loop in C# works differently than in Python.
         * In Python, it is used to iterate over a sequence, like a List.
         * In C#, it is essentially a controlled while-loop.
         */
        Console.WriteLine("Loop #1");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        /*
         * C#'s for-loop might remind you of
         * a for-loop using a 'range' in Python:
         * for i in range(5, 10, 2):
         *     print(i)
         * This prints 5, 7 and 9.
         */
        Console.WriteLine("\nLoop #2");
        for (int i = 5; i < 9; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    public static void Scope()
    {
        //Like with if/else/else-if blocks, variables created inside
        //code blocks will no longer exist after the code block is finished.
        Console.WriteLine("While-loop #1");
        int i = 0;
        while (i < 10)
        {
            var temp = "i is currently " + i++;
            Console.WriteLine(temp);
        }
        //Console.WriteLine(temp); would cause an error as 'temp' no longer exists

        //This also includes the initializer of the for-loop:
        Console.WriteLine("\nFor-loop #1");
        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine(j);
        }
        //Console.WriteLine(j); would cause an error as 'j' no longer exists

        //Note that if you need the variable afterwards, you can do this:
        Console.WriteLine("\nFor-loop #2");
        int k = 0;
        for (; k < 10; k++)
        {
            Console.WriteLine(k);
        }
        Console.WriteLine("After the for-loop, k is " + k);
    }

    public static void Lists()
    {
        //Creating a List object. Lists are much like lists in Python,
        //but there are differences. For example, it can contain only
        //one type of element.
        //Therefore you need to specify the type of the elements.
        List<int> myIntList = new() { 1, 2, 3 };
        List<string> myStringList = new() { "Hello", "World" };

        //Index (same as in Python)
        //Which element will it print?
        Console.WriteLine("The first/second/third? element is "
            + myIntList[1]);

        //Similar to len() in Python
        Console.WriteLine("\nAmount of elements in the list: "
            + myIntList.Count);

        //Adding to a List
        //In Python, this is Append()
        myIntList.Add(1);

        //Removing from a List
        myIntList.Remove(1);
        //What do you think this removes?
        // a: first occurrance of given element
        // b: all occurrances of given element
        // c: element at given index

        //Loop
        Console.WriteLine("\nPrinting all elements of a List object");
        for (int i = 0; i < myStringList.Count; i++)
        {
            Console.WriteLine(myStringList[i]);
        }
        //Next week you'll learn an even better way
        //to loop through a List object!
    }

    public static void Random()
    {
        Random rand = new();

        Console.WriteLine("Randomly generate an int from 0 to 4");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(rand.Next(5));
        }

        Console.WriteLine("\nRandomly generate an int in the range of 5 to 9");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(rand.Next(5, 10));
        }

        Console.WriteLine("\nRandomly generate a double between 0 and 1");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(rand.NextDouble());
        }
    }

    public static void PseudoRandom()
    {
        Random pseudoRand0 = new(0); //seed 0
        Random pseudoRand1 = new(1); //seed 1
        Console.WriteLine("Not truly random numbers");
        int max = 9;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(
                pseudoRand0.Next(max+1) + " " + pseudoRand1.Next(max+1));
        }
    }
}
