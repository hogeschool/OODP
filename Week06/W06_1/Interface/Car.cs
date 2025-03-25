namespace Interface;

public class Car : LandVehicle, IRentable
{
    public int RentalId { get; set; }
    public string CurrentRenter { get; set; }
    public double PricePerDay { get; set; }
}