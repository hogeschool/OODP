class Motorcycle : Vehicle
{
    public readonly int EngineDisplacement;

    public Motorcycle(int horsepower, int weight, int engineDisplacement)
        : base(horsepower, weight)
    {
        EngineDisplacement = engineDisplacement;
    }

    public override double EstimateTopSpeedKph()
    {
        double power = EngineDisplacement * 0.1; // assume 0.1 horsepower per cc
        double powerToWeightRatio = power / Weight;
        return Math.Sqrt(powerToWeightRatio * 25000) * 2;
    }

    public void DoWheelie() => Console.WriteLine("Doing a wheelie!");
}
