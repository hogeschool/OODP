static class Program
{
    static void Main()
    {
        Part1_Enums();
        Part2_StacksQueues();
    }
    
    public static void Part1_Enums()
    {
        // Season.Winter = 5; // See Season.cs: seasons go from 1-4, so this results in an error
        
        Season favoriteSeason = Season.Spring; // Enum member assignment
        
        string asString = favoriteSeason.ToString(); // Convert to string => "Spring"
        int asInt = (int)favoriteSeason; // Convert to int (int) => 2

        Season current = Season.Winter;
        // Can change int value to change to another enum member
        Season next = current + 1; // Summer

        // Cycle through the seasons GetNextSeason
        Season afterSpring = GetNextSeason(Season.Spring);
        Season afterAutumn = GetNextSeason(Season.Autumn);

        // Get all enum members Enum.GetValues
        PrintAllSeasons();

        // Switch with enums
        string winterTemp = GetTemperature(Season.Winter);

        // string to Enum TryParse()
        bool checkWinter = CheckValidSeason("Winter");
        bool checkRainySeason = CheckValidSeason("Rainy Season");
    }

    private static Season GetNextSeason(Season currentSeason) // Cycles from 1 to 4, then back to 1
    {
        if (currentSeason == Season.Autumn)
            return Season.Winter;
        return currentSeason + 1;
    }

    private static void PrintAllSeasons()
    {
        /*  
            Enum.GetValues(typeof(EnumName))
            returns an Array
            https://learn.microsoft.com/en-us/dotnet/api/system.enum.getvalues
        */
        // Array weird = Enum.GetValues(typeof(Season));
        foreach (Season season in Enum.GetValues<Season>())
        {
            Console.WriteLine($"Season {(int)season}: {season}");
        }
    }

    private static string GetTemperature(Season season)
    {
        /*
            use switch expression to get information about the enum.
            SYNTAX REMINDER: 
            value switch{
                1 => "a",
                2 => "b",
                _ => "default"
            }
        */
        // W: Cold, Sp: Cool, Su: Hot, A: Mild
        string result = season switch
        {
            Season.Winter => "Cold",
            Season.Spring => "Cool",
            Season.Summer => "Hot",
            Season.Autumn => "Mild",
            _ => "Not a season"
        };
        return result;
    }

    private static bool CheckValidSeason(string seasonStr)
    {
        /* 
           Enum.IsDefined(typeof(Enumtype), valueToCheck)
           note this can possibly result in an exception, 
           see Enum.TryParse for safer way
           https://learn.microsoft.com/en-us/dotnet/api/system.enum.isdefined
        */
        return Enum.IsDefined(typeof(Season), seasonStr);
    }

    private static string CheckValidSeason2(string seasonStr)
    {
        /* 
            Enum.TryParse(stringToCheck, out Enumtype variableName) 
            note that the stringToCheck is case sensitive
            https://learn.microsoft.com/en-us/dotnet/api/system.enum.tryparse
        */
        if (Enum.TryParse(seasonStr, out Season season))
        {
            return $"Valid, it is season number {(int)season}";
        }
        return "Invalid Season!!!!";
    }
    
    public static void Part2_StacksQueues()
    {
        Stacks();
        Queues();
    }
    
    // Function explaining Stack
    private static void Stacks()
    {
        // Stack is a collection of objects that are inserted and removed 
        // according to the last-in first-out (LIFO) principle.

        Stack<string> stack = new Stack<string>(); // Creating a stack
        // Stack<string> stack = new(); // Alterative 1
        // Stack<string> stack = []; // Alternative 2

        // Push
        stack.Push("cat");
        stack.Push("dog");
        stack.Push("fox");

        // Printing a value
        // Peek returns the object at the top of the stack without removing it
        Console.WriteLine(stack.Peek()); // fox

        // Removing a value
        // Pop removes and returns the object at the top of the stack
        string removedValue = stack.Pop();
        Console.WriteLine(removedValue); // fox

        // Contains; Count
        Console.WriteLine(stack.Contains("cat")); // true
        Console.WriteLine(stack.Count); // 2

        // Iterating through a stack
        // A stack can be enumerated without disturbing its contents.
        // The order of elements is LIFO, 
        // so the last element added to the stack 
        // is the first one to be enumerated.
        foreach (string item in stack)
        {
            Console.WriteLine(item);
         }

        /* Create a stack of strings that stores the following
           stack of cards stacked in this order:

           Seven of Diamonds <- Top
           Jack of Clubs
           Queen of Hearts
           Ace of Spades <- Bottom
        */
        Stack<string> cards = [];
        cards.Push("Ace of Spades");
        cards.Push("Queen of Hearts");
        cards.Push("Jack of Clubs");
        cards.Push("Seven of Diamonds");

        // What will the values of the following variables be?
        string pickACard = cards.Pop();
        string cheat = cards.Peek();

        // How could you get the bottom card? 
        // string last = cards[cards.Count - 1]; // Error
        while (cards.Count > 1)
        {
            cards.Pop();
        }

        string bottomCard = cards.Pop();
        // What will be in the stack at this point?

        // Or use LINQ (covered in next lesson)
        cards.Push("Ace of Spades");
        cards.Push("Queen of Hearts");
        cards.Push("Jack of Clubs");
        cards.Push("Seven of Diamonds");
        string bottomCard2 = cards.Last();
    }


    // Function explaining Queue
    public static void Queues()
    {
        // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1
        // Queue is a collection of objects that are inserted and removed
        // according to the First-In First-Out (FIFO) principle

        //Creating a queue
        Queue<string> queue = new Queue<string>();
        //Enqueue
        queue.Enqueue("cat");
        queue.Enqueue("dog");
        queue.Enqueue("fox");

        // Peek returns the object at the beginning 
        // of the queue without removing it.
        Console.WriteLine(queue.Peek()); // cat

        // Dequeue removes and returns the object at 
        // the beginning of the queue
        string removedValue = queue.Dequeue();
        Console.WriteLine(removedValue); // cat

        //Other methods: Contains; Count
        Console.WriteLine(queue.Contains("cat")); // false, because we dequeued it
        Console.WriteLine(queue.Count); // 2


        // Iterating through a queue
        // A queue can be enumerated without disturbing its contents.
        // The order of elements is FIFO, 
        // so the first element in the queue is the first one to be enumerated.
        foreach (string item in queue)
        {
            Console.WriteLine(item);
        }

        /*  
            Create a queue of string that represent customers
            The customers are in the queue in the following order:

            1. Alice
            2. Bob
            3. Clare
            4. Dave
        */
        Queue<string> customers = [];
        customers.Enqueue("Alice");
        customers.Enqueue("Bob");
        customers.Enqueue("Clare");
        customers.Enqueue("Dave");

        // What will the values of the following variables be?
        string serveNextCustomer = customers.Dequeue();
        string lookWhoIsNext = customers.Peek();

        // How could you get the last customer? 
        while (customers.Count > 1)
        {
            customers.Dequeue();
        }

        string last = customers.Dequeue();
        // What will be in the queue at this point?

        // ALT: LINQ: customers.Last();
    }
}