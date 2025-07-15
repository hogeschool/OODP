abstract class Vehicle
{
    public readonly int Horsepower;
    public readonly int Weight;
    public int KmsTravelled = 0;

    public Vehicle(int horsepower, int weight)
    {
        Horsepower = horsepower;
        Weight = weight;
    }

    // Abstract classes can have (virtual) methods, exactly like concrete classes
    public virtual void Travel() => KmsTravelled++;

    public string Info()
    {
        return $"This vehicle has an estimated top speed of {EstimateTopSpeedKph()}" +
            $" and has travelled {KmsTravelled} kms";
    }

    public override string ToString()
    {
        return $"Horsepower: {Horsepower}; Weight: {Weight})";
    }

    public abstract double EstimateTopSpeedKph();
}
