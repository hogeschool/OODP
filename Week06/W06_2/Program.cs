/*
 Contents:
  * PART 1: abstract class
    - abstract methods & overriding them (W06.2.C01 & 02)
    - List of abstract class objects (W06.2.C03)
  * PART 2: new method (W06.2.C04 & 05)
*/

public class Program
{
    public static void Main(string[] args)
    {
        //Part 1
        AbstractMethods();
        CastToAbstractClass();

        //Part 2
        NewMethod();
    }

    public static void AbstractMethods()
    {
        Console.WriteLine("=== Abstract methods ===");
        /*
        Abstract classes cannot be instantiated.
        Therefore, this would cause an error:
        Vehicle vehicle = new Vehicle(200, 1500);

        This is good, because abstract classes are not yet ready to be
        instantiated. In the case of Vehicle, it has an abstract method
        EstimateTopSpeedKph(). It has no implementation, because we don't
        yet know how to; this depends on the derived class.

        Derived classes Car and Motorcycle have their own calculations
        of estimating their top speed, since they rely on members that
        are exclusive to them.
        */

        Motorcycle motorcycle = new(150, 300, 500);
        Console.WriteLine("This motorcycle's estimated top speed: "
            + motorcycle.EstimateTopSpeedKph());

        Car car = new(200, 1500);
        Console.WriteLine("This car's estimated top speed: "
            + car.EstimateTopSpeedKph());
    }

    public static void CastToAbstractClass()
    {
        Console.WriteLine("\n=== Cast to abstract class ===");
        List<Vehicle> vehicles = new()
        {
            new Car(200, 1500),
            new Motorcycle(150, 300, 500),
        };

        foreach (Vehicle vehicle in vehicles)
        {
            /*
            Cars and Motorcycles have in common that they
            are Vehicles, meaning we can group them together.
            However, they will be cast to their base class
            Vehicle, so they will only be able to access
            members of the Vehicle class
            */
            Console.WriteLine("Estimated top speed (km/h): "
                + vehicle.EstimateTopSpeedKph());
            vehicle.Travel();
            Console.WriteLine(vehicle.Info());
            Console.WriteLine(vehicle.ToString());

            //We need to cast back to Motorcycle
            //in order to do a wheelie
            if (vehicle is Motorcycle)
            {
                ((Motorcycle)vehicle).DoWheelie();
            }
        }
    }

    public static void NewMethod()
    {
        Console.WriteLine("\n=== New method ===");

        //A sports car will use its own EstimateTopSpeedKph method...
        SportsCar sportsCar = new(200, 2000);
        Console.WriteLine("Sports car's estimated top speed (km/h): "
            + sportsCar.EstimateTopSpeedKph());

        List<Vehicle> vehicles = new()
        {
            sportsCar,
            new Car(200, 1500),
            new Motorcycle(150, 300, 500),
        };

        foreach (Vehicle vehicle in vehicles)
        {
            //... but when cast to a Vehicle, it will use
            //the Vehicle's EstimateTopSpeedKph method.
            //Let's pretend it runs on Eco mode. :)
            Console.WriteLine("Estimated top speed (km/h): "
                + vehicle.EstimateTopSpeedKph());
        }
    }
}
