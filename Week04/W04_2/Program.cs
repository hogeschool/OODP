/*
    Contents:
    * PART 1: overloaded methods
    *  - overload styles
    *     * code duplication
    *     * method forwarding
    *  - parameter types
    * PART 2: overloaded constructors
    *  - overload styles
    *     * code duplication
    *     * constructor chaining
    *  - 'copy' constructor (not an official term)
    * PART 3: inheritance
    *  - creating objects
    *  - constructor
*/

public class Program
{
    public static void Main()
    {
        OverloadedMethods();
        OverloadedConstructors();
        Inheritance();
    }

    public static void OverloadedMethods()
    {
        Console.WriteLine("=== Method overloading ===");
        //StringFormatter.Capitalize and StringFormatter.Lowercase
        //are overloaded in different ways. Have a look at the code.

        //Note that the parameter type determines which method is called
        char h = 'h';
        char H = StringFormatter.Capitalize(h);
        Console.WriteLine($"'{h}' was changed to '{H}'");

        //Note that the parameter count determines which method is called
        string hello = "hello!";
        string toUpper1 = StringFormatter.Capitalize(hello);
        string toUpper2 = StringFormatter.Capitalize(hello, false);
        string toUpper3 = StringFormatter.Capitalize(hello, true);
        foreach (var word in new List<string>() {toUpper1, toUpper2, toUpper3 })
        {
            Console.WriteLine($"'{hello}' was changed to '{word}'");
        }
        Console.WriteLine();

        char W = 'W';
        char w = StringFormatter.Lowercase(W);
        Console.WriteLine($"'{W}' was changed to '{w}'");

        string world = "WORLD!";
        string toLower1 = StringFormatter.Lowercase(world);
        string toLower2 = StringFormatter.Lowercase(world, false);
        string toLower3 = StringFormatter.Lowercase(world, true);
        foreach (var word in new List<string>() { toLower1, toLower2, toLower3 })
        {
            Console.WriteLine($"'{world}' was changed to '{word}'");
        }
        Console.WriteLine();
    }

    public static void OverloadedConstructors()
    {
        Console.WriteLine("\n=== Constructor overloading ===");

        //The Vehicle constructor has constructor that are commented out.
        //Have a look at the code to see the different styles.

        Vehicle car1 = new("Toyota", "Camry", 2020);
        Vehicle car2 = new("Toyota", 2020);
        Vehicle car3 = new(2020);
        Vehicle car4 = new(car1);

        foreach (var car in new List<Vehicle>() { car1, car2, car3, car4 })
        {
            Console.WriteLine("Make: " + car.Make);
            Console.WriteLine("Model: " + car.Model);
            Console.WriteLine("Year: " + car.Year);
            Console.WriteLine();
        }
    }
    
    public static void Inheritance()
    {
        Console.WriteLine("\n=== Inheritance ===");

        Console.WriteLine("Class car reuses the fields and one constructor of" +
            "its base class Vehicle.");
        Vehicle vehicle = new("New Holland", "T7.270", 2018);
        Car car = new("Toyota", "Camry", 2020, "Petrol");
    }
}
