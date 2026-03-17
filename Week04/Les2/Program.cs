
using Les2;


Vehicle v1 = new Vehicle(0);

v1 = new Tandem();

// error
// v1.DoubleRingBell()
((Tandem)v1).DoubleRingBell();
(v1 as Tandem).DoubleRingBell();
(v1 as Tandem)?.DoubleRingBell();

if (v1 is Tandem t)
{
    t.DoubleRingBell();

    // error: t = new Bike();
    // allowed
    Bike b = t;
    b = (Bike)v1;

}

List<Vehicle> myVehicles = new List<Vehicle>()
{
    new Car(4, 100),
    new Bike(2),
    new Tandem(),
};

foreach(Vehicle v in myVehicles)
{
    // You only know it is a vehicle
    if (v is Car)
    {
        Console.WriteLine(((Car)v).maxSpeed);
    }

    Console.WriteLine(v.Identify());
}

Vehicle bike = new Bike();
Vehicle tandem = new Tandem();

Console.WriteLine(bike.Identify());
Console.WriteLine(tandem.Identify());


// private vs public 
// access modifiers are saying something about who can do what.
// private is the most restrictive and public is the most loose.

// If something is private it can only be accessed from within the same class
// If something is public it can be accessed everywhere.


// go to class car
Car c = new Car(4, 100);
Person p = new Person("Jip");

c.CalculateMaxSpeed();


// The base of all objects is: `Object`

object o = new Tandem();
o.Equals(v1);
o.GetHashCode();
o.GetType();
o.ToString();


Console.WriteLine(o);



