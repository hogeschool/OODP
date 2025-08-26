public static class W01_2_02
{
    public static void Main2()
    {
        // Built-in class: List
        // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-8.0 
        // Creation: empty and populated
        List<int> aList = new List<int>(); // empty
        List<string> myStringList = new List<string>() { "one", "two", "three", "four" }; // populated

        // Shortcuts: new() and collection expression []
        List<bool> empty = new();
        List<bool> empty2 = [];
        List<double> measurements = [1.1, 1.1, 2.2];

        // Indexes 
        Console.WriteLine(myStringList[0]);

        // Count 
        Console.WriteLine(myStringList.Count);

        // Add 
        myStringList.Add("one");

        // Remove - Removes the first occurrence of a specific object from the List.
        bool check = myStringList.Remove("one");

        // RemoveAt - Removes the element at the specified index of the List.
        // Remove last element
        myStringList.RemoveAt(myStringList.Count - 1);


        // Foreach loops are great for looping through collections
        // when you want to read the data, but ...
        foreach (var item in myStringList)
        {
            Console.WriteLine(item);
        }

        // ... if you want to change the data you will need to use a for loop
        for (int i = 0; i < myStringList.Count; i++)
        {
            myStringList[i] += "!";
        }
    }
}