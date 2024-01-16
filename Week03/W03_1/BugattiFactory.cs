public static class BugattiFactory
{
    public static int DivoTopSpeed = 380;
    public static int VeyrTopSpeed = 410;

    //Alternatively, you can use a static constructor
    //to assign values to static fields.
    //static BugattiFactory()
    //{
    //    DivoTopSpeed = 380;
    //    VeyrTopSpeed = 410;
    //}

    public static Bugatti ProduceDivo() => new Bugatti("Divo", DivoTopSpeed);
    public static Bugatti ProduceVeyron() => new Bugatti("Veyron", VeyrTopSpeed);
}