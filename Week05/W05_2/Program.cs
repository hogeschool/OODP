/*
 Contents:
  * PART 1: access modifiers
    - private fields & methods (repeat)
    - protected fields & methods (W05.2.C01)
  * PART 2: properties
    - get (W05.2.C02)
    - set; read/write; validation (W05.2.C03)
    - auto-implemented & default values (W05.2.C04)
    - virtual & override (W05.2.C05)
    - access modifiers (W05.2.C06)
    - ??? (W05.2.C07)
*/

static class Program
{
    public static void Main()
    {
        PrivateMembers();
        //ProtectedMembers();
        //PropertyGet();
        //PropertyReadWrite();
        //PropertyAuto();
        //PropertyDefault();
        //PropertyVirtual();
        //PropertyAccessMods();
    }

    private static void PrivateMembers()
    {
        //This is a repeat of last week.
        Console.WriteLine("=== Private fields and methods ===");

        List<IsoscelesTriangle> shapes = new()
        {
            new IsoscelesTriangle(4.0, 5.0, "Red"),
            new Pyramid(6.0, 7.0, "Yellow"),
        };

        foreach (IsoscelesTriangle s in shapes)
        {
            //None of the private members can be accessed from outside the class.
            //The following statements would all cause a runtime error
            //("is inaccessible due to its protection level")
            //Console.WriteLine("Base: " + s._base);
            //Console.WriteLine("Height: " + s._height);
            //Console.WriteLine("Slant height: " + s._slantHeight);
            //s.SetSlantHeight();

            if (s is Pyramid)
            {
                //Console.WriteLine("Apex: " + ((Pyramid)s)._apex);
                //Also look at the GetBase() method of the Pyramid class
            }
        }

        Console.WriteLine("Now we know we can only interact with the class " +
            "through public members, and not touch the private members.");
        foreach (IsoscelesTriangle s in shapes)
        {
            s.SetBase(2.5);
            s.SetHeight(3);

            if (s is Pyramid)
            {
                ((Pyramid)s).Paint("Blue", "White", "Red", "Orange", "Black");
            }
            else if (s is IsoscelesTriangle)
            {
                s.Paint("Orange");
            }

            Console.WriteLine(s.ToString() + "\n");
        }
    }

    private static void ProtectedMembers()
    {
        Console.WriteLine("===\n Protected fields and methods ===");

        List<IsoscelesTriangle> shapes = new()
        {
            new IsoscelesTriangle(4.0, 5.0, "Red"),
            new Pyramid(6.0, 7.0, "Yellow"),
        };

        foreach (IsoscelesTriangle s in shapes)
        {
            //Much like private members, we cannot access protected members
            //from here. The following statements would all cause a runtime error:
            //("is inaccessible due to its protection level")
            //Console.WriteLine("Color: " + s.Color);
            //Console.WriteLine("Is valid side: " + Isosceles.IsValidSide(7.5);
        }

        Console.WriteLine("Protected members can be accessed by derived classes. " +
            "Look at the Pyramid's SetApex method where IsValid is accessed, " +
            "and the overloaded Paint method where Color is accessed.\n");
    }

    private static void PropertyGet()
    {
        Console.WriteLine("===\n Read-only properties ===");
        ProductBundle hotdogs = new("Hotdogs", 10, "Tasty hotdogs!", 4);

        Console.WriteLine("Quantity can be read: " + hotdogs.Quantity);
        Console.WriteLine("Quantity cannot be written to:\n - " +
            "\"Property or indexer 'ProductBundle.Quantity' cannot be assigned to -- it is read only\"\n");
        //hotdogs.Quantity = 6; runtime error
        Console.WriteLine("Read-only properties may be set in the constructor," +
            "but once the object is constructed, it cannot be changed anymore.\n");
    }
    private static void PropertyReadWrite()
    {
        Console.WriteLine("===\n Reading from and writing to properties ===");

        ProductBundle hotdogs = new("Hotdogs", 10, "Tasty hotdogs!", 4);
        Console.WriteLine("Description is a read/write property:");
        var oldDescription = hotdogs.Description;
        hotdogs.Description = "Very tasty hotdogs!";
        Console.WriteLine($"Description updated " +
            $"from {oldDescription} to: {hotdogs.Description}\n");
        Console.WriteLine("Additional logic is used to write to the Description. " +
            "A backing field is required for this.\n");

        Console.WriteLine("Another example:");
        Product hotdog = new("Hotdog", 2.5, "Tasty hotdog!");
        hotdog.Price = -2.5;
        Console.WriteLine($"Attempted to update Price to -2.5, but must be " +
            $"at least 0. Therefore Price was set to: {hotdog.Price}\n");
    }

    private static void PropertyAuto()
    {
        Console.WriteLine("===\n Auto-implemented properties ===");
        Console.WriteLine("No additional logic is used to read and write the Name.");
        Product hotdog = new("Hotdog", 2.5, "Tasty hotdog!");
        var oldName = hotdog.Name;
        hotdog.Name = "Frankfurter";
        Console.WriteLine($"Name updated from {oldName} to: {hotdog.Name}\n");
    }

    private static void PropertyDefault()
    {
        Console.WriteLine("===\n Property default values ===");
        Console.WriteLine("Properties may be given default values:");
        Product hotdog = new("Hotdog", 2.5);
        Console.WriteLine($"Description was set to: {hotdog.Description}\n");
    }

    private static void PropertyVirtual()
    {
        Console.WriteLine("\n=== Virtual properties ===");
        Console.WriteLine("Like virtual methods, virtual properties may be " +
            "used as-is or overridden by a derived class:");
        List<Product> products = new()
        {
            new Product("Hotdog", 2.5, "Tasty hotdog!"),
            new ProductBundle("Hotdogs", 10, "Tasty hotdogs!", 4),
        };

        foreach (var product in products)
        {
            Console.WriteLine($"{product.Description}");
        }
    }

    private static void PropertyAccessMods()
    {
        Console.WriteLine("===\n Property access modifiers ===");
        Console.WriteLine("The get and the set may have different access modifiers.");

        Product hotdog = new("Hotdog", 2.5, "Tasty hotdog!");
        ProductBundle hotdogs = new("Hotdogs", 10, "Tasty hotdogs!", 4);

        hotdog.Sell();
        Console.WriteLine($"Property Sold may be read publically," +
            $"but only written to from within this and derived classes.");
        Console.WriteLine($"{hotdog.Name} sold: {hotdog.Sold}");
        Console.WriteLine("Sold cannot be written to:\n - " +
            "\"The property or indexer 'Product.Sold' cannot be used in this context because the set accessor is inaccessible.\"\n");
        //hotdog.Sold = 2; runtime error
    }
}
