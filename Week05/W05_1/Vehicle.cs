class Vehicle
{
    public string Make;
    public string Model;
    public bool HasFreshTires = true;
    private int _mileage = 0;

    public Vehicle(string make, string model)
    {
        Make = make;
        Model = model;
    }

    public void Drive() => Drive(1);
    public virtual void Drive(int distance)
    {
        IncreaseMileage(distance);
        HasFreshTires = false;
    }

    public int ReadMileage() => _mileage;
    private void IncreaseMileage(int distance)
    {
        if (distance < 0)
            return;
        _mileage += distance;
    }

    public virtual void PerformMaintenance() => HasFreshTires = true;

    //Overrides 'ToString()' of base class 'Object'
    public override string ToString()
    {
        return $"{base.ToString()}: {Make} {Model}"
            + $"\n - Mileage: {_mileage}"
            + $"\n - Fresh tires: {(HasFreshTires ? "yes" : "no")}";
    }
}
