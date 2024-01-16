public abstract class Vehicle
{
    public int Horsepower;
    public int Weight;
    public int KmsTravelled;

    public Vehicle(int horsepower, int weight)
    {
        Horsepower = horsepower;
        Weight = weight;
        KmsTravelled = 0;
    }

    //Abstract classes can have (virtual)
    //methods, exactly like concrete classes
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