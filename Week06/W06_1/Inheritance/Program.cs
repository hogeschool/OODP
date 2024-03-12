namespace Inheritance;

/*
Code is heavily based on video by IAmTimCorey: https://www.youtube.com/watch?v=4sxyDXt1igs
Highly recommended watch!

                                  +---------------+
             ---------------------| RentalVehicle |---------------------
            |                |    +---------------+    |                |
            |                |                         |                |
            |                |                         |                |
+----------------+    +---------------+    +----------------+    +----------------+
|   RentalCar    |    |  RentalTruck  |    |   RentalBoat   |    | RentalSailBoat |
+----------------+    +---------------+    +----------------+    +----------------+

Whoops! We've programmed ourselves into a corner: a sailboat shouldn't be a vehicle!
*/

public class Program
{
    public static void Main()
    {

        List<RentalVehicle> vehicles = new()
        {
            new RentalCar(),
            new RentalTruck(),
            new RentalBoat(),
            new RentalSailboat(), //Sailboats don't have an engine!
        };

        //Now we have to keep in mind to make an exception for SailBoats. :(
        foreach (var vehicle in vehicles)
        {
            try
            {
                vehicle.StartEngine();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{vehicle.ToString()} says: {ex.Message}");
            }

            try
            {
                vehicle.StopEngine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{vehicle.ToString()} says: {ex.Message}");
            }
        }
    }
}
