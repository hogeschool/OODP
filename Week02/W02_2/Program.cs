/*
    Contents:
    * PART 1
    *  a: classes with objects as fields (W02.2.C01)
    *  b: null (W02.2.C02-03)
    * PART 2
    *  - returning objects (W02.2.C04)
    * PART 3
    *  a: List of objects (W02.2.C06)
    *  b: foreach (W02.2.C05)
    *  c: classes with List as field (W02.2.C07)
    * PART 4
    *  - default constructors (W02.2.C08)
*/

static class Program
{
    public static void Main()
    {
        Part1a();
        Part1b();

        Part2();

        Part3ab();
        Part3c();

        Part4();
    }

    public static void Part1a()
    {
        Console.WriteLine("=== Objects as fields ===");
        Company inGen = new("John Hammond");
        Console.WriteLine("InGen's founder is "
            + inGen.Founder.Name);
    }

    public static void Part1b()
    {
        //Objects as fields; null
        Console.WriteLine("\n=== Object field is not null :D ===");
        Engine engine = new(200);
        Car car1 = new Car(engine);
        Console.WriteLine(car1.Info());

        Console.WriteLine("\n=== Object field is null :'( ===");
        Car car2 = new Car(null);
        Console.WriteLine(car2.Info());
    }

    public static void Part2()
    {
        Console.WriteLine("\n=== Method that returns an object ===");
        ToyFactory factory = new();
        Toy newToy = factory.Produce(); //Produce() returns a Toy object
    }

    public static void Part3ab()
    {
        //Part 3a
        Console.WriteLine("\n=== List of objects ===");
        ToyFactory factory = new();
        List<Toy> toys = new();
        int howManyToys = 5;
        for (int i = 0; i < howManyToys; i++)
        {
            toys.Add(factory.Produce());
        }
        //Place a breakpoint at the line below
        //to see the produced toys in the Heap
        Console.WriteLine("Amount of toys produced: " + toys.Count);

        //Part 3a
        Console.WriteLine("\n=== foreach-loop ===");
        Console.WriteLine("Testing the toys, very important!");
        foreach (var toy in toys)
        {
            Console.WriteLine(toy.Squeak());
        }
    }

    public static void Part3c()
    {
        Console.WriteLine("\n=== List as field ===");

        Author author = new("Stephen King");
        author.PublishBook("Carrie");
        author.PublishBook("Rage");
        author.PublishBook("The Dead Zone");
        Console.WriteLine(author.Info());
    }

    public static void Part4()
    {
        Console.WriteLine("\n=== Default constructor ===");

        Athlete athlete = new();
        Random rand = new();
        for (int i = 0; i < 10; i++)
        {
            switch (rand.Next(1, 4))
            {
                case 1: athlete.WinFirstPlace(); break;
                case 2: athlete.WinSecondPlace(); break;
                case 3: athlete.WinThirdPlace(); break;
                default: break;
            }
        }

        Console.WriteLine("Amount of gold medals: " + athlete.GoldMedalsCount);
        Console.WriteLine("Amount of silver medals: " + athlete.SilverMedalsCount);
        Console.WriteLine("Amount of bronze medals: " + athlete.BronzeMedalsCount);
    }
}
