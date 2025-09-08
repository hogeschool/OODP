/*
    Modify the following class to include:
    - MaxAge; 120 which is the same for all people (use this in the constructor)
    - TotalPeople; which is a count of how many 
      people have been created so far
    - A static constructor (static Person())
    - A static method GetTotalPeople to report the TotalPeople
    - Use the static field Total people in the greet method
*/

public class Person
{
    public string Name;
    public int Age;
    public static int TotalPeople;
    public static int MaxAge;

    static Person()
    {
        TotalPeople = 0;
        MaxAge = 120;
        Console.WriteLine("Static constructor called. Static members initialized.");
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = (age <= MaxAge) ? age : MaxAge;
        TotalPeople++;
    }

    public string GetGreeting()
    {
        return $"Hi, I'm {Name} and I'm {Age} years old. I am one of {TotalPeople} people.";
    }

    public static string GetTotalPeople()
    {
        // string s = Name; // Error: cannot use non static members in static methods
        return $"{TotalPeople} have been created";
    }
}