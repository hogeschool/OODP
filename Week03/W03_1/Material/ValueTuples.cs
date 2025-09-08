public static class ValueTuples
{
    /*
        Tuples allow us to group data in a lightweight data structure,
        so you do not need to create a class.
        They are typically used when returning more than one value from a method.
        
        There are two types of tuples in C#:
        - Tuples: we will NOT use this type in the course
        - ValueTuples: we will use this type in the course
        
        Note: ValueTuples are passed by value, not by reference.
    */
    public static void ValueTuplesBasics()
    {
        //(type1, type2, ...) name = (value1, value2, ...);
        (string, int) person1 = ("Sarah", 33);

        // Each item is accessed using Item1, Item2, ...
        Console.WriteLine($"Name: {person1.Item1}, age: {person1.Item2}");

        // You can also specify tuple field names
        //(type1 Name1, type2 Name2, ...) name = (value1, value2, ...);
        (string Name, int Age) person2 = new("Sarah", 33);

        // Each item is accessed using the given name
        Console.WriteLine($"Name: {person2.Name}, age: {person2.Age}");

        // We can change the values.
        person2.Age++;

        // One of the most common use cases of tuples is as a method return type.

        // Notice that tuple items keep Names
        var check1 = CheckIfAdult(person1);
        Console.WriteLine($"Is adult? {check1.IsAdult}, they are a {check1.Status}");

        // Notice that Tuple items are renamed
        (bool, string) check2 = CheckIfAdult(person2);
        // Console.WriteLine($"Is adult? {check2.IsAdult}, they are a {check2.Status}"); // Error

        List<int> numbers = [6, 2, 9, 1, 4, 5];
        var countAndAverage = GetCountAndAverage(numbers);
    }

    // CheckIfAdult takes in a person ValueTuple and
    // returns a ValueTuple with bool (>=18) and string (adult or child)
    public static (bool IsAdult, string Status) CheckIfAdult((string Name, int Age) person)
    {
        bool isAdult = person.Age >= 18;
        string status = $"{person.Name} is {(isAdult ? "an adult" : "a child")}";
        return (isAdult, status);
    }

    /*
        Exercise:
        Write a method which takes in a List of integers and 
        Returns a tuple containing the Count and Average of the numbers
    */
    public static (int Count, double Average) GetCountAndAverage(List<int> numbers)
    {
        int count = numbers.Count;
        double sum = 0;

        foreach (double number in numbers)
        {
            sum += number;
        }

        double average = sum / count;
        return (count, average);
    }
}