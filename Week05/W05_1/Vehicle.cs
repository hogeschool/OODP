public class Vehicle
{
    public string Make;
    public string Model;
    public int Mileage;
    public bool HasFreshTires;

    public Vehicle(string make, string model)
    {
        Make = make;
        Model = model;
        Mileage = 0;
        HasFreshTires = true;
    }

    public void Drive() => Drive(1);
    public virtual void Drive(int distance)
    {
        Mileage += distance;
        HasFreshTires = false;
    }

    public virtual void PerformMaintenance() => HasFreshTires = true;

    //Overrides 'ToString()' of base class 'Object'
    public override string ToString()
    {
        return $"{base.ToString()}: {Make} {Model}"
            + $"\n - Mileage: {Mileage}"
            + $"\n - Fresh tires: {(HasFreshTires ? "yes" : "no")}";
    }
}