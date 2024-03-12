/*
 * Inheritance is not code-sharing
 * Is-a relationship
 * Need to share common logic
 * Sharing just properties or method signatures is not enough
 * Inheritance can put you in a corner
 * You need to ask the question: What is the point?
 * 
 */

// Rental agency in Miami, FL
namespace Inheritance;

public class RentalSailboat : RentalVehicle
{
    public override void StartEngine()
    {
        throw new Exception("I do not have an engine to start");
    }

    public override void StopEngine()
    {
        throw new Exception("I do not have an engine to stop");
    }
}
