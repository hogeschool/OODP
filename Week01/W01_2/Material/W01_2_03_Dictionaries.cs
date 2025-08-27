public static class W01_2_03_Dictionaries
{
    public static void Main3()
    {
        // Create an empty Dictionary: new() or []
        // (or new Dictionary<int, string>())
        Dictionary<int, string> numbers = new();
        Dictionary<int, string> passengers = [];

        // Create a Dictionary
        Dictionary<int, string> students = new()
        {
            { 111, "Bill" },
            { 123, "Bob" },
            { 321, "Jane" },
            { 333, "Rita" }
        };

        // Add a new key-value pair
        students.Add(444, "Anne");

        // Update an existing value
        students[123] = "Bobby"; // Overwrites "Bob"

        // Remove a key-value pair
        bool check = students.Remove(444);

        // Iterate through the dictionary  -> key value pair
        Console.WriteLine("Dictionary contents:");
        foreach (var kvp in students)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // Look up with error handling
        // TryGetValue(int key, out string value) 
        // Gets the value associated with the specified key
        // Output Parameter: If the key is found, 
        // the corresponding value (the student's name) 
        // is assigned to the name variable.
        if (students.TryGetValue(111, out string name))
        {
            Console.WriteLine($"Key 111 maps to: {name}");
        }
        else
        {
            Console.WriteLine("Key not found.");
        }

        // Clear: Removes all keys and values from the Dictionary
        students.Clear();
        Console.WriteLine("Dictionary cleared.");
    }
}