/* Contents: enum
 *  - declaration and initialization (W15.2.C01)
 *  - switch (W15.2.C02)
 *  - looping (W15.2.C03)
 *  - conversion (W15.2.C04)
 */

/* 
In C#, an enum (or enumeration type) is used to assign constant names to a
group of numeric integer values. It makes constant values more readable.
For example, WeekDays.Monday is more readable then number 0 when referring to
the day in a week.

enum WeekDays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
*/

static class Program
{
    enum IceCreamFlavor // enum declaration
    {
        Vanilla = 1, // Initialization. The numbering is optional; it starts at 0 by default.
        Chocolate = 2, // If you leave out numbers 2-6, they will be numbered automatically.
        Strawberry = 3,
        Caramel = 4,
        Mint = 5,
        CookieDough = 6
    }

    static void Main()
    {
        // Enum member assignment
        IceCreamFlavor myFlavor = IceCreamFlavor.Caramel;
        Console.WriteLine("My favorite ice cream flavor is: " + myFlavor);

        // Get flavor message using switch statement
        string flavorMessage = GetFlavorMessage(myFlavor);
        Console.WriteLine(flavorMessage);

        // Looping over an enum
        Console.WriteLine("All available ice cream flavors:");
        foreach (IceCreamFlavor flavor in Enum.GetValues(typeof(IceCreamFlavor)))
        {
            Console.WriteLine(flavor);
        }
    }

    // Method to get flavor message based on the ice cream flavor.
    // This is how we 'convert' an enum member.
    static string GetFlavorMessage(IceCreamFlavor flavor) => flavor switch
    {
        IceCreamFlavor.Vanilla => "You selected Vanilla ice cream!",
        IceCreamFlavor.Chocolate => "You selected Chocolate ice cream!",
        IceCreamFlavor.Strawberry => "You selected Strawberry ice cream!",
        IceCreamFlavor.Caramel => "You selected Caramel ice cream!",
        IceCreamFlavor.Mint => "You selected Mint ice cream!",
        IceCreamFlavor.CookieDough => "You selected Cookie Dough ice cream!",
        _ => throw new ArgumentException("This ice cream flavor is not available."), // Not actually impossible to reach. Why do you think this is?
    };
}
