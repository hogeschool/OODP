namespace Interface;

public interface IRentable
{
    int RentalId { get; set; }
    string CurrentRenter { get; set; }
    double PricePerDay { get; set; }
}