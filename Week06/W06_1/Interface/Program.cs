namespace Interface;
/*
Code is heavily based on video by IAmTimCorey: https://www.youtube.com/watch?v=4sxyDXt1igs
Highly recommended watch!


    has                       is
+---------------+       +-----------------+
| IRentable     |       | LandVehicle     |
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
        List<IRentable> rentals = new()
        {
            new Car() { RentalId = 1, PricePerDay = 50, CurrentRenter = "John Doe"},
            new Truck() { RentalId = 2, PricePerDay = 75, CurrentRenter = "Jane Doe"},
            new Sailboat() { RentalId = 3, PricePerDay = 100, CurrentRenter = "Jack Doe"},
        };

        foreach (var rental in rentals)
        {
            Console.WriteLine($"{rental}'s rental ID: {rental.RentalId}");
            Console.WriteLine($"{rental}'s price per day: {rental.PricePerDay}");
            Console.WriteLine($"{rental}'s current renter: {rental.CurrentRenter}");

            if (rental is LandVehicle lv)
            {
                lv.StartEngine();
                lv.StopEngine();
            }

            Console.WriteLine();
        }
    }
}
