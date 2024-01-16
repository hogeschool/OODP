public class Car : Vehicle
{
    public string FuelType;

    public Car(string make, string model, int year, string fuelType) : base(make, model, year)
    {
        FuelType = fuelType;
    }
}