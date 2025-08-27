public static class W02_1_2_Classes
{
    public static void Main2()
    {
        // Object creation Random
        Random r = new Random();

        // Object creation Course   
        Course c1 = new Course("OODP", 13);
        Course c2 = new Course("Project B", 13);

        // Shortcut: new
        Course c4 = new("Life", int.MaxValue);

        // Accessing Fields
        Console.WriteLine(c1.Name);
        Console.WriteLine(c1.Credits);

        // Calling methods (must create an object)
        // GetInfo(); // Error
        Console.WriteLine(c1.GetInfo());
    }
}