/*
    Contents:
    * PART 1: static
    *  - static fields (W03.1.1T01)
    *  - static methods (W03.1.1T02)
    *  - static classes (W03.1.1T03)
    *  - W03.1.1T04: what concepts did you just use?
    *  - W03.1.1T05: ??? (solve the bug)
    * PART 2: const
    *  - const fields (W03.1.1T06-08)
    * PART 3
    *  - ReadOnly fields (W03.1.1T09-10)
*/

static class Program
{
    public static void Main()
    {
        //PART 1
        StaticFields();
        //StaticMethods();
        //StaticClasses();

        ////PART 2
        //Constant();

        ////PART 3
        //ReadOnly();
    }

    public static void StaticFields()
    {
        Console.WriteLine("=== Static fields ===");
        Console.WriteLine(
            $"Bugattis are currently built in {Bugatti.FactoryLocation}");

        Console.WriteLine("\nThe factory is moved to Dorlisheim");
        Bugatti.FactoryLocation = "Dorlishheim";
        Console.WriteLine(
            $"Bugattis are currently built in {Bugatti.FactoryLocation}\n");
    }

    public static void StaticMethods()
    {
        Console.WriteLine("=== Static methods ===");

        Bugatti divo = new("Divo", 380);
        Bugatti veyr = new("Veyron", 410);
        Console.WriteLine(
            $"The {Bugatti.WhichIsFaster(divo, veyr).Model} is faster\n");
    }

    public static void StaticClasses()
    {
        Console.WriteLine("\n=== Static classes ===");

        Bugatti divo = BugattiFactory.ProduceDivo();
        Bugatti veyr = BugattiFactory.ProduceVeyron();

        Console.WriteLine(divo.Info());
        Console.WriteLine(veyr.Info());
        Console.WriteLine();
    }

    public static void Constant()
    {
        Console.WriteLine("\n=== Constant fields ===");

        Console.WriteLine($"Any Bugatti has {Bugatti.NumberOfWheels} wheels; "
            + "this cannot be changed.\n");
    }

    public static void ReadOnly()
    {
        Console.WriteLine("\n=== Read-only fields ===");

        Bugatti divo = BugattiFactory.ProduceDivo();
        Console.WriteLine($"This Bugatti's model is {divo.Model}. Now that this "
            + "object is constructed, its model can no longer be changed.\n");
        //divo.Model = "Veyron"; would result in an error
    }
}
