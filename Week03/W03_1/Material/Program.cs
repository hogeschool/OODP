public class Program
{
    static void Main()
    {
        StaticMembers();
        StaticClass();
        InClassAssignments();
        ValueTuples.ValueTuplesBasics();
    }
    
    public static void StaticMembers()
    {
        // We do not need an instance of Person to access GetTotalPeople
        Console.WriteLine(Person.GetTotalPeople());

        Person p1 = new Person("Alice", 25);
        // We cannot access a static member using the object
        // Console.WriteLine(p1.GetTotalPeople()); // Error

        Console.WriteLine(Person.GetTotalPeople()); // static method

        Person p2 = new Person("Bob", 130);

        Console.WriteLine(p1.GetGreeting());
        Console.WriteLine(p2.GetGreeting());

        // Console.WriteLine(p1.GetTotalPeople()); // Error
        Console.WriteLine($"Maximum age allowed: {Person.MaxAge}");
        Console.WriteLine(Person.GetTotalPeople());
    }

    public static void StaticClass()
    {
        // PersonFactory pf = new PersonFactory(); // Error
        Person p1 = PersonFactory.CreateJohnDoe();
        Person p2 = PersonFactory.CreateJaneDoe();
    }

    public static void InClassAssignments()
    {
        Car c1 = new Car("Red", "Fiat", 300);
        Car c2 = new Car("Green", "Mercedes", 200);

        // CarFactory cf = new CarFactory(); //Error
        Car c3 = CarFactory.CreateBlueFiat();
        Car c4 = CarFactory.CreateRedBugatti();
    }
}