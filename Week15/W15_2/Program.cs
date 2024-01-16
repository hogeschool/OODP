/* Contents: enum
 *  - declaration and initialization (W15.2.C01)
 *  - switch (W15.2.C02)
 *  - looping (W15.2.C03)
 *  - conversion (W15.2.C04)
 *  - description (W15.2.C05)
 */

/* 
In C#, an enum (or enumeration type) is used to assign constant names to a group of numeric integer values. It makes constant values more readable, for example, WeekDays.Monday is more readable then number 0 when referring to the day in a week.

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

public class Program
{
    public enum IceCreamFlavor // enum declaration
    {
        [Description("Classic Vanilla")] // Descriptions are optional
        Vanilla = 1, // Initialization. The numbering is optional.
        [Description("Decadent Chocolate")]
        Chocolate = 2,
        [Description("Sweet Strawberry")]
        Strawberry = 3,
        [Description("Buttery Caramel")]
        Caramel = 4,
        [Description("Refreshing Mint")]
        Mint = 5,
        [Description("Irresistible Cookie Dough")]
        CookieDough = 6
    }

    public static void Main()
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
    static string GetFlavorMessage(IceCreamFlavor flavor)
    {
        switch (flavor)
        {
            case IceCreamFlavor.Vanilla:
                return "You selected Vanilla ice cream!";
            case IceCreamFlavor.Chocolate:
                return "You selected Chocolate ice cream!";
            case IceCreamFlavor.Strawberry:
                return "You selected Strawberry ice cream!";
            default:
                return "You selected a different ice cream flavor!";
        }
    }

    // Custom attribute to store enum member descriptions.
    // You don't need to know this!
    [AttributeUsage(AttributeTargets.Field)]
    class DescriptionAttribute : Attribute
    {
        public string Description { get; }

        public DescriptionAttribute(string description)
        {
            Description = description;
        }
    }
}
