using System;

namespace Les1;

public class Circle
{
    public int Size;
    public bool Filled = false;

    public Circle()
    {
        this.Size = 1;
    }

    public Circle(int size)
    {
        this.Size = size;
    }

    public Circle(int size, bool filled)
        : this(size)
    {
        this.Filled = filled;
    }
}
