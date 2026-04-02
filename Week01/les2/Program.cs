// loops.

// what loops do we know from python?

{
    bool correctInput = false;
    while (!correctInput)
    {
        Console.WriteLine("Enter a nickname!");
        string input = Console.ReadLine();

        if (input.Length > 4 && input[0] >= 'A' && input[0] <= 'Z')
        {
            correctInput = true;
            Console.WriteLine("correct");
        }
        else
        {
            Console.WriteLine("Try again");
        }
    }
}

{
    bool q = false;
    do
    {
        Console.WriteLine("1) option 1");
        Console.WriteLine("2) option 2");
        Console.WriteLine("3) option 3");
        Console.WriteLine("4) quit");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1" or "2" or "3":
                break;
            case "4":
                q = true;
                break;
        }
    }
    while(!q);
}

//for loop
{
    // for i in range(0, 10):
    //      print(i)
    for (int i = 0; i < 10; i+=2)
    {
        Console.WriteLine(i);
    }

    // this is not common
    foreach(int i in Enumerable.Range(0, 10))
    {
        Console.WriteLine(i);
    }

    // normally to iterate over a collection. 
    // for example a string
    foreach(char letter in "Hello world")
    {
        char c = '\n'!;
        Console.WriteLine(letter);
    }

    foreach(var word in "Hello world, hope you are doing fine".Split(" "))
    {
        Console.WriteLine(word);
    }
}


// lists
{
    // List<TValue>
    List<string> helloWorld = new List<string>();
    helloWorld.Add("Hello");
    helloWorld.Add("world");

    helloWorld = new List<string>(){"Hello", "world"};
    helloWorld = new (){"Hello", "world"};
    helloWorld = ["Hello", "world"];

    // amount of items, with count not with length.
    // under the hood there is a fixed size array. This can be bigger than the amount of items.
    int amountOfItems = helloWorld.Count;
    // sneak peak in to later weeks. Use linq to count specific items.
    helloWorld.Count(s => s.StartsWith("H"));

    helloWorld.Remove("world");
    helloWorld.RemoveAt(0);

    helloWorld.Add("Hello");
    helloWorld[0] = "Hello";

    for (int i = 0; i < helloWorld.Count; i++)
    {
        Console.WriteLine(helloWorld[i]);
    }

    // better for simple cases.
    foreach(string item in helloWorld)
    {
        Console.WriteLine(item);
    }

    // an exception is if you want to mutate the data.
    // this is not aloud and possible in a foreach
    for (int i = 0; i < helloWorld.Count; i++)
    {
        helloWorld[i] += " ";
    }


}

// dictionaries
{
    //Dictionary<TKey, TValue>
    Dictionary<string, int> Grades = new Dictionary<string, int>();
    Grades.Add("Jan", 7);
    Grades.Add("Josefien", 9);

    Grades = new (){
        ["Jan"] = 7,
        ["Jan"] = 6, // is overwriting the value
    };

    // old fashion
    var capitals = new Dictionary<string, string>
    {
        { "Nederland", "Amsterdam" },
        { "België", "Brussel" },
        { "Duitsland", "Berlijn" },
        // { "Duitsland", "Berlijn" } will give runtime exception
    };

    capitals.Remove("Duitsland");
    if (capitals.ContainsKey("Nederland"))
    {
        Console.WriteLine($"capital is {capitals["Nederland"]}");
    }

    Console.WriteLine($"capital is {capitals.GetValueOrDefault("Nederland", "Rotterdam")}");

    if (capitals.TryGetValue("Nederland", out string capital))
    {
        Console.WriteLine($"capital is {capital}");
    }

    foreach (KeyValuePair<string, string> item in capitals)
    {
        Console.WriteLine($"{item.Key}: {item.Value}");
    }

    foreach(var (country, city) in capitals)
    {
        Console.WriteLine($"{country}: {city}");
    }

    Dictionary<int, Dictionary<string, string>> students = new ()
    {
        
    };
}

{
    // Built-in classes: Random
    // Creating a random object (Pseudorandom - uses system clock to generate)
    Random randomGenerator = new Random();

    // Next (int maxValue) int [0, maxValue)
    int rNum1 = randomGenerator.Next(10);

    // ext (int minValue, int maxValue) [minValue, maxValue)
    int rNum2 = randomGenerator.Next(5, 10);

    // NextDouble () (0.0, 1.0)
    double rNum3 = randomGenerator.NextDouble();

    // How to get a random double between 4 and 10?
    // -> r * (max - min) + min
    int min = 4;
    int max = 10;
    double rNum4 = (randomGenerator.NextDouble()) * (max - min) + min;
    // 0.0 * 6 = 0.0 + 4 = 4.0 -> 0.9 * 6 = 5.4 + 4 = 9

    // Reproducible sequence of random numbers - supply the seed
    Random predictable1 = new Random(1);
    Random predictable2 = new Random(1);

    int p1n1 = predictable1.Next(10);
    int p1n2 = predictable1.Next(10);

    int p2n1 = predictable2.Next(10);
    int p2n2 = predictable2.Next(10);

    // Shortcut: new(), new(1)
    Random r = new(); // instead of Random()
    Random r1 = new(1); // instead of Random(1)
}




