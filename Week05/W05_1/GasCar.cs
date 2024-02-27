public class GasCar : Vehicle
{
    public bool HasNewSparkPlugs;

    public GasCar(string make, string model) : base(make, model)
    {
        HasNewSparkPlugs = true;
    }

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