using System;

namespace Les1;

public class Vehicle
{
    public readonly int PassengerCapacity;
    public Vehicle(int passengerCapacity)
    {
        this.PassengerCapacity = passengerCapacity;
    }
}

public class Bike : Vehicle
{
    public Bike(int passengerCapacity)
        : base(passengerCapacity)
    {
        
    }

    public Bike() : this(1)
    {
        
    }

    public void RingBell()
    {
        Console.WriteLine("Ring Ring");
    }
}

public class Tandem : Bike
{
    public Tandem() : base(2)
    {
        
    }

    public void DoubleRingBell()
    {
        this.RingBell();
        this.RingBell();
    }
}

public class Car : Vehicle
{
    public readonly double HP;
    public Car(int passengerCapacity, double HP) : base(passengerCapacity)
    {
        this.HP = HP;
    }
}
