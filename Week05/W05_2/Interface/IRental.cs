namespace Interface;

public interface IRental
{
    int RentalId { get; set; }
    string CurrentRenter { get; set; }
    double PricePerDay { get; set; }
}