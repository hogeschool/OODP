class Program
{

    // Dictionary assignments: W14.1.C01, W14.1.C02
    // Stack assignments: W14.1.C03
    // Queue assignments: W14.1.C04
    static void Main(string[] args)
    {
        //dicts();
        //stack();
        queue();
    }


    //Function explaining Dictionaries
    public static void dicts()
    {
        //Dictionary is a collection of key value pairs
        //Dictionary uses generic types
        //Key is unique, value can be duplicate

        //Creating a dictionary
        Dictionary<string, string> animalSounds = new Dictionary<string, string>();
        animalSounds.Add("cat", "meow");
        animalSounds.Add("dog", "woof");
        animalSounds.Add("fox", "what does the fox say?");

        //Accasing a value by key
        Console.WriteLine(animalSounds["cat"]);

        //Other methods
        Console.WriteLine(animalSounds.ContainsKey("cat")); //true
        Console.WriteLine(animalSounds.ContainsValue("meow")); //true
        Console.WriteLine(animalSounds.Count); //3

        //Removing an item by key
        animalSounds.Remove("cat");
        Console.WriteLine(animalSounds.ContainsKey("cat")); //false, because we removed it



        //Iterating through a dictionary
        foreach (KeyValuePair<string, string> entry in animalSounds)
        {
            string key = entry.Key;
            string value = entry.Value;
            Console.WriteLine($"{key} says {value}");
        }

    }


    //Function explaining Stack
    public static void stack()
    {
        //Stack is a collection of objects that are inserted and removed according to the last-in first-out (LIFO) principle
        //Stack uses generic types

        //Creating a stack
        Stack<string> stack = new Stack<string>();
        stack.Push("cat");
        stack.Push("dog");
        stack.Push("fox");

        //Printing a value
        //Peek returns the object at the top of the stack without removing it
        Console.WriteLine(stack.Peek()); //fox

        //Removing a value
        //Pop removes and returns the object at the top of the stack
        string removedValue = stack.Pop();
        Console.WriteLine(removedValue); //fox

        //Other methods
        Console.WriteLine(stack.Contains("cat")); //true
        Console.WriteLine(stack.Count); //2

        //Stacks are LIFO. So there is no way to access the bottom value without removing all the values above it
        //It has no index to access the values

        //iterating through a stack
        //A stack can be enumerated without disturbing its contents.
        //The order of elements is LIFO, so the last element added to the stack is the first one to be enumerated.
        foreach (string item in stack)
        {
            Console.WriteLine(item);
        }

    }


    //Function explaining Queue
    public static void queue()
    {
        //Queue is a collection of objects that are inserted and removed according to the first-in first-out (FIFO) principle
        //Queue uses generic types

        //Creating a queue
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("cat");
        queue.Enqueue("dog");
        queue.Enqueue("fox");

        //Printing a value
        //Peek returns the object at the beginning of the queue without removing it
        Console.WriteLine(queue.Peek()); //cat

        //Removing a value
        //Dequeue removes and returns the object at the beginning of the queue
        string removedValue = queue.Dequeue();
        Console.WriteLine(removedValue); //cat

        //Other methods
        Console.WriteLine(queue.Contains("cat")); //false, because we dequeued it
        Console.WriteLine(queue.Count); //2


        //Queues are FIFO. So there is no way to access the last value without removing all the values before it
        //It has no index to access the values

        //Iterating through a queue
        //A queue can be enumerated without disturbing its contents.
        //The order of elements is FIFO, so the first element in the queue is the first one to be enumerated.
        foreach (string item in queue)
        {
            Console.WriteLine(item);
        }


    }


}