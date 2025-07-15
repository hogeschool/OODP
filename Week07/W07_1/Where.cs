interface ISizeable 
{
    int Size { get; }
}

class Box : ISizeable
{
    public int Width { get; }
    public int Height { get; }

    public Box(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int Size => Width * Height;
}

class Ball : ISizeable
{
    public int Radius { get; }
    public Ball(int radius) => Radius = radius;

    public int Size => (int)(4 / 3.0 * Math.PI * Radius * Radius * Radius);
}

class Space
{
    private readonly int _maxCapacity;
    private int _usedCapacity;

    public Space(int maxCapacity) => _maxCapacity = maxCapacity;

    //public bool Load(ISizeable item)
    public bool Load<T>(T item) where T : ISizeable
    {           
        if (_usedCapacity + item.Size > _maxCapacity)
        {
            Console.WriteLine($"Failed to load {item.GetType().Name} (size: {item.Size}) into space (used capacity: {_usedCapacity}/{_maxCapacity}).");
            return false;
        }

        _usedCapacity += item.Size;
        Console.WriteLine($"Loaded {item.GetType().Name} (size: {item.Size}) into space (used capacity: {_usedCapacity}/{_maxCapacity}).");
        return true;
    }
}