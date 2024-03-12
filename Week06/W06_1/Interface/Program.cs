namespace Interface;
/*
Code is heavily based on video by IAmTimCorey: https://www.youtube.com/watch?v=4sxyDXt1igs
Highly recommended watch!


    has                       is
+---------------+       +-----------------+
| IRental       |       | LandVehicle     |
+---------------+       +-----------------+
   |                       |
   |                       |
   |   +---------------+   |
   |   | Car           |   |
   +---| (implements)  |---+
   |   +---------------+   |
   |                       |
   |                       |
   |   +---------------+   |
   |   | Truck         |   |
   +---| (implements)  |---+
   |   +---------------+
   |
   |
   |   +---------------+
   |   | Sailboat      |
   +---| (implements)  |
       +---------------+
*/

public class Program
{
    public static void Main()
    {
        List<IRental> rentals = new()
        {
            new Car() { RentalId = 1, PricePerDay = 50, CurrentRenter = "John Doe"},
            new Truck() { RentalId = 2, PricePerDay = 75, CurrentRenter = "Jane Doe"},
            new Sailboat() { RentalId = 3, PricePerDay = 100, CurrentRenter = "Jack Doe"},
        };

        foreach (var rental in rentals)
        {
            Console.WriteLine($"{rental.ToString()}'s rental ID: {rental.RentalId}");
            Console.WriteLine($"{rental.ToString()}'s price per day: {rental.PricePerDay}");
            Console.WriteLine($"{rental.ToString()}'s current renter: {rental.CurrentRenter}");
            var landVehicle = rental as LandVehicle;
            landVehicle?.StartEngine();
            landVehicle?.StopEngine();
            Console.WriteLine();
        }
    }
}
