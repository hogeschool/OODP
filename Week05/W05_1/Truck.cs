public class Truck : GasCar
{
    public int CargoCapacity;

    public Truck(string make, string model, int cargoCapacity)
        : base(make, model) => CargoCapacity = cargoCapacity;

    public override string ToString()
    {
        return base.ToString()
            + $"\n - Cargo capacity: " + CargoCapacity;
    }
}