class ElectricCar : Vehicle
{
    public int BatteryCapacity;

    public ElectricCar(string make, string model) : this(make, model, 40) { }
    public ElectricCar(string make, string model, int batteryCapacity)
        : base(make, model)
    {
        BatteryCapacity = batteryCapacity;
    }

    //Methods 'Drive' and 'PerformMaintenance'
    //are not overridden; they are used as is

    public override string ToString()
    {
        return base.ToString()
            + $"\n - Battery capacity: {BatteryCapacity}";
    }
}
