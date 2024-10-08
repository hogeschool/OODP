class Car : Vehicle
{
    public readonly int NumberOfWheels;

    public Car(int horsepower, int weight) : this(horsepower, weight, 4) { }
    public Car(int horsepower, int weight, int numberOfWheels)
        : base(horsepower, weight)
    {
        NumberOfWheels = numberOfWheels;
    }

    public override double EstimateTopSpeedKph()
    {
        double powerToWeightRatio = (double)Horsepower / Weight;
        return Math.Sqrt(powerToWeightRatio * 10000) * NumberOfWheels;
    }
}
