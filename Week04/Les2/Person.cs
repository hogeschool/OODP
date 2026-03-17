

public class Person
{
    public string Name;

    public Person(string name)
    {
        this.Name = name;
    }

    public void SayHello()
    {
        Console.WriteLine($"Hello, I'm {this.Name}");
    }
}