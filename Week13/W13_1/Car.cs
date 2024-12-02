class Car
{
    public readonly string Brand;
    public readonly string Color;

    public Car(string brand, string color)
    {
        Brand = brand;
        Color = color;
    }

    public override string ToString() => $"{Brand} {Color}";
}
