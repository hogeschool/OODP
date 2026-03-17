using System;

namespace Les2;

public class Vehicle
{
    public readonly int PassengerCapacity;
    public Vehicle(int passengerCapacity)
    {
        this.PassengerCapacity = passengerCapacity;
    }

    public virtual string Identify() => $"I'm a {nameof(Vehicle)}";
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

    public override string Identify()=> $"I'm a {nameof(Tandem)}";

    public override string ToString()
    {
        return this.Identify();
    }
}

public class Car : Vehicle
{
    public readonly double HP;
    public readonly double maxSpeed;

    public Car(int passengerCapacity, double HP) : base(passengerCapacity)
    {
        this.HP = HP;
        this.maxSpeed = this.CalculateMaxSpeed();
    }

    public double CalculateMaxSpeed()
    {
        // Base speed in km/h based on aerodynamic drag (cube root of HP)
        double aeroSpeedKmh = 40 * Math.Pow(HP, 1.0 / 3.0);
        
        // Minor penalty (2.5 km/h per person) for rolling resistance
        double passengerPenalty = PassengerCapacity * 2.5;
        
        // Calculate final speed, ensuring it doesn't drop below 0
        double maxSpeedKmh = aeroSpeedKmh - passengerPenalty;
        
        return Math.Max(0, Math.Round(maxSpeedKmh, 1));
    }
}
