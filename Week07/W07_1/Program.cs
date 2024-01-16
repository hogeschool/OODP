/*
Contents:
 - Familiar generics (W07.1.C01)
 - Generic methods (W07.1.C02)
 - Multiple generic types (W07.1.C03)
 - Generic type conversion (W07.1.C04)
 - Method-level generics (W07.1.C05)
 - Default value of generic variable (W07.1.C06)
 - Inheritance from a generic class to generic types (W07.1.C07)
 - Inheritance from a generic class to concrete types (W07.1.C08)
*/

public class Program
{
    public static void Main()
    {
        ListsAreGeneric();
        GenericMethods();
        GenericClass();
        MultipleGenericTypes();
        MethodLevelGenerics();
        DefaultValue();
        GenericInheritance();
    }

    public static void ListsAreGeneric()
    {
        Console.WriteLine("=== Lists are generic ===");

        //You've already seen generics! List<T>
        //T denotes a generic type that could be anything.
        List<int> ints = new() { 1, 2, 3 };
        List<string> strings = new() { "Hello", "World", "!" };

        Console.Write("List of ints:");
        foreach (var i in ints)
        {
            Console.Write($" {i}");
        }

        Console.Write("\nList of strings:");
        foreach (var s in strings)
        {
            Console.Write($" {s}");
        }

        Console.WriteLine();
        //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0
    }

    public static void GenericMethods()
    {
        Console.WriteLine("\n=== Generic methods ===");

        Random rand = new();
        List<int> uniqueInts = new();
        for (int i = 0; i < 10; i++)
        {
            AddToUniqueList(uniqueInts, rand.Next(1, 7));
        }

        Console.WriteLine("First element removed: " + Pop(uniqueInts));
    }

    private static void AddToUniqueList<T>(List<T> list, T elem)
    {
        //Note: this method will not work for all types.
        //We will learn more about this later in the course.
        if (!list.Contains(elem))
            list.Add(elem);
    }

    private static T Pop<T>(List<T> list)
    {
        //Note: this method will not work for all types.
        //We will learn more about this later in the course.
        T first = list[0];
        list.RemoveAt(0);
        return first;
    }

    public static void GenericClass()
    {
        Console.WriteLine("\n=== Generic class ===");

        CourseResult<bool> english = new("English", true);
        CourseResult<string> skills = new("Soft skills", "Sufficient");
        CourseResult<double> programming = new("Programming basics", 7.5);

        Console.WriteLine($"{english.Name} {english.Grade}");
        Console.WriteLine($"{skills.Name} {skills.Grade})");
        Console.WriteLine($"{programming.Name} {programming.Grade}");
    }

    public static void MultipleGenericTypes()
    {
        Console.WriteLine("\n=== Multiple generic types ===");

        List<KeyValuePair<int, string>> numberPairs = new()
        {
            new(1, "one"),
            new(2, "two"),
            new(3, "three"),
        };
        foreach (var pair in numberPairs)
            PrintKeyValuePair(pair);

        List<KeyValuePair<string, bool>> areStaticallyTyped = new()
        {
            new("C#", true),
            new("Python", false)
        };
        foreach (var pair in areStaticallyTyped)
            PrintKeyValuePair(pair);
    }

    private static void PrintKeyValuePair<TKey, TValue>(KeyValuePair<TKey, TValue> pair)
    {
        Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
    }

    public static void MethodLevelGenerics()
    {
        Console.WriteLine("\n=== Method-level generics ===");
        //A generic type can be just for the method, not the class
        List<int> ints = new() { 1, 2, 3 };

        int picked = ListExtensions.PickRandom(ints);
        Console.WriteLine("Randomly picked from 1, 2 and 3: " + picked);

        ListExtensions.Shuffle(ints);
        Console.Write("Shuffled List:");
        foreach (int i in ints)
            Console.Write($" {i}");
        Console.WriteLine();
    }

    public static void DefaultValue()
    {
        Console.WriteLine("\n=== Default value ===");

        FormField<string> nameField = new("Name");
        nameField.Value = "John Doe";
        FormField<bool> subscribeField = new("Subscribe");
        subscribeField.Value = true;
        FormField<string> favoriteColorField = new("Favorite Color");
        favoriteColorField.Value = "Blue";

        Console.WriteLine("Name: " + nameField.Value);
        Console.WriteLine("Subscribed: " + subscribeField.Value);
        Console.WriteLine("Favorite color: " + favoriteColorField.Value);

        Console.WriteLine("\nResetting values...");
        nameField.ResetValue();
        subscribeField.ResetValue();
        favoriteColorField.ResetValue();
        Console.WriteLine("Name: " + nameField.Value);
        Console.WriteLine("Subscribed: " + subscribeField.Value);
        Console.WriteLine("Favorite color: " + favoriteColorField.Value);
    }

    public static void GenericInheritance()
    {
        Console.WriteLine("\n=== Generic inheritance ===");

        Vehicle<int> vehicle = new Car<int, int>();
        vehicle.Make = "Mitsubishi";
        vehicle.Model = "3000GT";
        vehicle.Engine = 6;

        Car<int, int> car = new();
        car.Make = "Mitsubishi";
        car.Model = "3000GT";
        car.Engine = 6;
        car.Transmission = 5;

        Sedan sedan = new();

        Console.WriteLine(vehicle);
        Console.WriteLine(car);
        Console.WriteLine(sedan);
    }
}
