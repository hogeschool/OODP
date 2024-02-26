/*
    Contents:
    * PART 1: static
    *  - static fields (W03.1.C01)
    *  - static methods (W03.1.C02)
    *  - static classes (W03.1.C03)
    *  - W03.1.C04: what concepts did you just use?
    *  - W03.1.C05: ??? (solve the bug)
    * PART 2: const
    *  - const fields (W03.1.C06-08)
    * PART 3
    *  - readonly fields (W03.1.C09-10)
    
    * Resources: const vs readonly https://www.bytehide.com/blog/const-vs-readonly-in-c-explanation-in-3-minutes
*/

public class Program
{
    public static void Main()
    {
        //PART 1
        StaticFields();
        StaticMethods();
        StaticClasses();

        //PART 2
        Const();

        //PART 3
        Readonly();
    }

    public static void StaticFields()
    {
        Console.WriteLine("=== Static fields ===");
        Console.WriteLine(
            $"Bugattis are currently built in {Bugatti.FactoryLocation}");

        Console.WriteLine("\nThe factory is moved to Dorlisheim");
        Bugatti.FactoryLocation = "Dorlishheim";
        Console.WriteLine(
            $"Bugattis are currently built in {Bugatti.FactoryLocation}");
    }

    public static void StaticMethods()
    {
        Console.WriteLine("\n=== Static methods ===");

        Bugatti divo = new("Divo", 380);
        Bugatti veyr = new("Veyron", 410);
        Console.WriteLine(
            $"The {Bugatti.WhichIsFaster(divo, veyr).Model} is faster");
    }

    public static void StaticClasses()
    {
        Console.WriteLine("\n=== Static classes ===");

        Bugatti divo = BugattiFactory.ProduceDivo();
        Bugatti veyr = BugattiFactory.ProduceVeyron();

        Console.WriteLine(divo.Info());
        Console.WriteLine(veyr.Info());
    }

    public static void Const()
    {
        Console.WriteLine("\n=== Constant fields ===");

        Console.WriteLine($"Any Bugatti has {Bugatti.NumberOfWheels} wheels; "
            + "this cannot be changed.");
    }

    public static void Readonly()
    {
        Console.WriteLine("\n=== Readonly fields ===");

        Bugatti divo = BugattiFactory.ProduceDivo();
        Console.WriteLine(
            $"This Bugatti's model is {divo.Model}. "
            + "Now that this object is constructed, "
            + "its model can no longer be changed.");
        //divo.Model = "Veyron"; would result in an error
    }
}
