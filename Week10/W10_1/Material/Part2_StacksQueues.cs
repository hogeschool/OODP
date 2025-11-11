static class Part2_StacksQueues
{
    public static void Start()
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