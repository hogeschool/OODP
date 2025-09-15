public class Car
{
    /*
        Look at the data associated with a Car 
        and determine if you need to add 
        nothing, static, const, readonly, or static readonly
    */

    // *** The data associated with a Car starts here ***

    // Belongs to the object & can be changed
    public int TopSpeed;
    public int Key;
    public bool IsLocked;
    public string Color;

    /*
    Belongs to the object.
    Can be set during declaration
    and in the in the constructor, but
    cannot be changed after that
    */
    public readonly string Make;

    /*
    Belongs to the object.
    Can be set during declaration
    and in the in the constructor,
    but cannot be changed after that.
    */
    public readonly List<string> Owners = [];

    // Belongs to the class & can be changed
    public static int MaxTopSpeed = 400;
    public static int NumCarsCreated; // defaults to 0

    /*
    Belongs to the class.
    Can only be set during declaration;
    never ever changes.
    */
    public const int NumberOfWheels = 4;

    /* 
    Belongs to the class.
    Can be set during declaration 
    and in the in the constructor,
    but cannot be changed after that
    */
    public static readonly Random randGen = new Random();

    // *** the data associated with a Car ends here ***

    /*
    Alternatively, you can use a static constructor
    to assign values to static fields.
    No need for access modifiers.
    Runs first time class Car is interacted with,
    for example if a Car is created, or a static member is accessed.
    */
    static Car()
    {
        MaxTopSpeed = 400;
    }

    public Car(string color, string make, int topSpeed)
    {
        Color = color;
        Make = make;
        TopSpeed = topSpeed < MaxTopSpeed ? topSpeed : MaxTopSpeed;
        Key = randGen.Next();
        NumCarsCreated++;
    }

    public string GetInfo()
    {
        return
            $"This {Color} {Make} has a top speed of {TopSpeed}\n" +
            $"It is currently {(IsLocked ? "locked" : "open")}\n" +
            $"It is car number {NumCarsCreated}\n" +
            $"Like all cars, it has {NumberOfWheels} wheels" +
            $"It has had {Owners.Count} owners";
    }

    public void Lock(int key)
    {
        if (IsLocked && this.Key == key)
            IsLocked = true;
    }

    public void Unlock(int key)
    {
        if (!IsLocked && this.Key == key)
            IsLocked = false;
    }

    public void AddOwner(string owner) => Owners.Add(owner);

    /*
        Create a static method that takes in 2 cars
        and evaluates which is faster.
        Remember to consider null Cars.
    */
    public static Car WhichIsFaster(Car car1, Car car2)
    {
        if (car1 == null && car2 == null)
        {
            return null;
        }
        if (car1 == null)
        {
            return car2;
        }
        if (car2 == null)
        {
            return car1;
        }
        return car1.TopSpeed > car2.TopSpeed ? car1 : car2;
    }
}
