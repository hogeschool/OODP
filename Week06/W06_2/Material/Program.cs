public class Program{
    static void Main(string[] args)
    {
        // You have already worked with generic classes
        // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1
        List<int> intList = new() { 1, 2, 3 };
        List<string> stringList = new() { "a", "b", "c" };
        List<Weapon> weaponList = new() {
            new Weapon("Spoon", 5),
            new Weapon("Pen", 10),
            new Weapon("Sword", 2),
        };

        // So let's make our own generic methods to add some extra functionality to List
        GenericMethods(intList, stringList, weaponList);

        // We can also make our own generic classes
        GenericClasses();

        // Classes can have multiple generic types
        GenericClassesMultipleTypes();

        // We can constrain the Generic type
        Where();
    }

    private static void GenericMethods(
        List<int> intList,
        List<string> stringList,
        List<Weapon> weaponList)
    {
        int randInt = ListExtensions.PickRandom(intList);
        string randString = ListExtensions.PickRandom(stringList);
        Weapon? randWeapon = ListExtensions.PickRandom(weaponList);

        int popInt = ListExtensions.Pop(intList);
        string popString = ListExtensions.Pop(stringList);
        Weapon popWeapon = ListExtensions.Pop(weaponList);

        // ASIDE: using keyword 'this' before the parameter type allows us to do this:
        Console.WriteLine(intList.PickRandomExtension());
    }

    private static void GenericClasses()
    {
        string q1 = "What is 1 + 1?";
        int a1 = 2;
        Exercise<int> e1 = new Exercise<int>(q1, a1);

        string q2 = "What shape has 3 sides?";
        string a2 = "Triangle";
        Exercise<string> e2 = new(q2, a2);

        string q3 = "Rewrite the equation 3x + 5x2 = 4x2 + 4 in standard form";
        Equation a3 = new Equation(1, 3, -4);
        Exercise<Equation> e3 = new(q3, a3);

        // We can make generic classes concrete
        string q6 = "What is 0 % 10?";
        int a6 = 0;
        MathQuestion qna6 = new MathQuestion(q6, a6);
    }

    private static void GenericClassesMultipleTypes()
    {
        KeyValuePair<int, string> kvp1 = new(1, "one");
        KeyValuePair<int, int> kvp2 = new(4, 9);
        KeyValuePair<double, bool> kvp3 = new(5.5, false);
    }

    public static void Where()
    {
        FlyingAnimalUtilities.FlyAndMakeNoise(new Bird());
        FlyingAnimalUtilities.FlyAndMakeNoise(new Bee());
        // FlyingAnimalMethods.FlyAndMakeNoise(new Cat()); //Error
        // FlyingAnimalMethods.FlyAndMakeNoise(new Airplane()); //Error
    }
}
