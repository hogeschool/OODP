namespace Interface;

public class Truck : LandVehicle, IRental
{
    public int RentalId { get; set; }
    public string CurrentRenter { get; set; }
    public double PricePerDay { get; set; }
}