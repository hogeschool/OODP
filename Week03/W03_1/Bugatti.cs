﻿class Bugatti
{
    public readonly string Model;
    public int TopSpeed;
    public static string FactoryLocation = "Molsheim";
    public const int NumberOfWheels = 4;

    public Bugatti(string model, int topSpeed)
    {
        Model = model;
        TopSpeed = topSpeed;
    }

    //Alternatively, you can use a static constructor
    //to assign values to static fields.
    //static Bugatti() => FactoryLocation = "Molsheim";

    public string Info() => $"This Bugatti {Model} has a top speed of {TopSpeed}";

    public static Bugatti? WhichIsFaster(Bugatti bugatti1, Bugatti bugatti2)
    {
        if (bugatti1 is null && bugatti2 is null)
            return null;
        if (bugatti1 is null)
            return bugatti2;
        if (bugatti2 is null)
            return bugatti1;
        return bugatti1.TopSpeed > bugatti2.TopSpeed ? bugatti1 : bugatti2;
    }
}
