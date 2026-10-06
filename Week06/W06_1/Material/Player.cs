/*
    Abstract classes:
    ----------------------
    * An abstract class is sort of in between a 
      class you inherit from and an interface
    * An abstract class cannot be instantiated
      but it can contain a constructor
    * Abstract classes can contain both implemented 
      members (including 'virtual' members)
      and non implemented ('abstract') members 
      (properties and methods)
      - Note: if there are abstract members,
        then the class must be abstract
    * When a class inherits from an abstract class,
      this class can either be abstract or it must
      implement the inherited abstract members
      and use the keyword 'override' to do so
    * You can still only inherit from one class 
      (either an abstract one or a non abstract one)
    * Use an abstract class when:
        - you have multiple classes that share members but 
          some of the members will be different 
        - you do not want the (base) class to be instantiated

  Different for each object that inherits from player
    - ASCII
    - Attack()

  Can be different but does not have to be for each object that inherits from player
    - Defend
*/
public abstract class Player
{
    public string Name { get; }
    public int X { get; private set; }
    public int Y { get; private set; }
    public string CurrentPosition => $"({X}, {Y})";

    private readonly int _maximumHitPoints;

    public int CurrentHitPoints
    {
        get;
        protected set => field = Math.Clamp(value, 0, _maximumHitPoints);
    }
    protected static readonly Random RandomGenerator = new();
    public abstract string ASCII { get; }

    public Player(string name, int maximumHitPoints)
    {
        Name = name;
        _maximumHitPoints = Math.Max(maximumHitPoints, 10);
        CurrentHitPoints = _maximumHitPoints;
    }

    public void MoveLeft(int distance) => X -= distance;
    public void MoveRight(int distance) => X += distance;

    public abstract int Attack();
  
    public virtual void Defend(int damage)
    {
        CurrentHitPoints -= damage;
    }
}
