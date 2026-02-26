public static class W02_1_1_Methods
{
    public static void Main2()
    {
        // Pro tip: In your IDE, CTRL click on a method name to nagivate to it
        // To navigate back:
        // - Visual Studio: CTRL -
        // - Visual Studio Code: ALT BACK

        // void methods
        PrintHello(); // In your IDE, CTRL click to go to the method

        // parameters (debug step over, into, out)
        PrintGreeting("Heya!");

        // non-void methods
        string greet1 = Shout("Hi");
        PrintGreeting(greet1);

        // code paths
        string en = NlOrEnGreeting("EN");
        PrintGreeting(en);
        PrintGreeting(NlOrEnGreeting("Dutch"));

        // Methods calling other methods
        GreetMultipleTimes(3, "Hi");

        // Expression body definition
        PrintHi();
        PrintGreeting(ShoutLoud("Good day"));
        PrintGreeting(FriendGreeting(true));

        // Revision Random class
        List<string> greetings = ["Hi", "Hey", "Yo", "Yello", "Howdy"];
        PrintGreeting(ShoutLoud(PickGreeting(greetings)));
    }

    // void methods PrintHello
    public static void PrintHello()
    {
        Console.WriteLine("Hello");
    }

    // parameters PrintGreeting
    public static void PrintGreeting(string greeting)
    {
        Console.WriteLine("******************");
        Console.WriteLine($"{greeting}");
        Console.WriteLine("******************");
    }

    // non-void methods Shout
    public static string Shout(string greeting)
    {
        return greeting + "!";
    }

    // code paths NlOrEnGreeting
    public static string NlOrEnGreeting(string language)
    {
        if (language == "NL")
        {
            return "Hoi";
        }
        if (language == "EN")
        {
            return "Hello";
        }
        // If the next line is commented out, there will be an error:
        //"not all code paths return a value"
        return "Language not supported";
    }

    // Methods calling other methods GreetMultipleTimes
    // DRY - Don't repeat yourself
    // SRP - Single Responsibility Principle 
    // Don't have methods that are too long, more difficult to read and maintain
    public static void GreetMultipleTimes(int times, string greeting)
    {
        for (int i = 0; i < times; i++)
        {
            // Console.WriteLine("******************");
            // Console.WriteLine($"{greeting}!");
            // Console.WriteLine("******************");
            PrintGreeting(greeting);
        }
    }

    // Expression body definition PrintHi ShoutLoud FriendGreeting
    public static void PrintHi() => Console.WriteLine("Hi");
    public static string ShoutLoud(string greeting) => greeting.ToUpper() + "!!!";
    public static string FriendGreeting(bool friend) => friend ? "Sup" : "Hello";

    // Revision Random class and List PickGreeting
    public static string PickGreeting(List<string> greetings)
    {
        // Random r = new();
        Random r = new();
        return greetings[r.Next(greetings.Count)];
    }
}
