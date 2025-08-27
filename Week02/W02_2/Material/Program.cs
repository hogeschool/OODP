public class Program
{
    public static void Main2()
    {
        // * Objects in memory p1
        Person p1 = new("John", "Doe"); // Remember that new() is a shortcut
        Person p1Copy = p1;
        p1Copy.FirstName = "Jim";

        // *  null
        // p1 = null;
        // string shortName1 = p1.FormatName(); //Exception

        List<Person> people =
        [
            new Person("Adam", "Duffy"),
            new Person("Jane", "Plane"),
            new Person("Mike", "Anderson")
        ];

        // * classes with objects as fields
        Company c1 = new("IT Solutions", p1);
        Console.WriteLine(c1.Information());

        // *  Returning objects
        Console.WriteLine(c1.GetManager().FormatName());

        // *  Taking in objects
        Person p2 = new("Lisa", "Holmes");
        c1.SetManager(p2);
        Console.WriteLine(c1.GetManager().FormatName());

        // * classes with objects as fields null
        // c1.ChangeManager(null);
        // Console.WriteLine(c1.GetManager().FormatName()); //Exception

        // *  Classes with List as field 
        Person pa = new("Sam", "Smith");
        c1.Hire(pa);
        c1.BulkHire(people);
        Console.WriteLine(c1.Information());

        // *  Default values
        // *  Default constructors
        Medal m = new("Silver", 20.0);
        Athlete a = new();
        a.ReceiveMedal(m);
        a.ReceiveMedal(new Medal("Gold", 100.0));
        a.ReceiveMedal(new Medal("gold", 200.0));
    }
}