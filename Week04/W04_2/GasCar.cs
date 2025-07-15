//Note: we cannot access the private members
//IncreaseMileage nor _mileage from this class

class GasCar : Vehicle
{
    public bool HasNewSparkPlugs = true;

    public GasCar(string make, string model) : base(make, model) { }

    public override void Drive(int distance)
    {
        //The base class' implementation can still be accessed through 'base'
        base.Drive(distance);
        HasNewSparkPlugs = false;
    }

    public override void PerformMaintenance()
    {
        base.PerformMaintenance();
        HasNewSparkPlugs = true;
    }

    public override string ToString()
    {
        return base.ToString() +
            $"\n - New spark plugs: {(HasNewSparkPlugs ? "yes" : "no")}";
    }
}
