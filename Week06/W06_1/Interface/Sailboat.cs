namespace Interface;

public class Sailboat : IRental
{
    public int RentalId { get; set; }
    public string CurrentRenter { get; set; }
    public double PricePerDay { get; set; }
}