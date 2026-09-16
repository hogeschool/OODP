/*
IEquatable<T>
https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=net-8.0
*/
public class Person : IEquatable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Implement the method from the IEquatable<Person> interface
    public bool Equals(Person other)
    {
        if (other is null) { return false; }

        // Compare name and age
        return (this.Name == other.Name) && (this.Age == other.Age);
    }

    // Override Object.Equals so it uses our Person equality
    // even when the Person is treated as an instance of a base class,
    // in this case Object.
    public override bool Equals(object obj)
    {
        return Equals(obj as Person);
    }
}