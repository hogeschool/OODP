// See https://aka.ms/new-console-template for more information


// We start with method overloading.
// That is multiple methods with the same name but with different parameter signatures.
// Have we seen this before

// what is the type of print in python?

// how can we solve this in C#
// https://learn.microsoft.com/en-us/dotnet/api/system.console.writeline?view=net-10.0

using Les1;

void exampleMethodOverloadingInFramework()
{
    Console.WriteLine();
    Console.WriteLine(0);
    Console.WriteLine(0.0);
    Console.WriteLine(true);
    Console.WriteLine("test");
    Console.WriteLine("With parameters {0}", 0);
    Console.WriteLine("With two parameters {0} {1}", 0, 1);
}


Vehicle drone = new Vehicle(0);

Bike bike = new Bike();

Vehicle v = bike;
bike = (Bike)v;

bike.RingBell();

