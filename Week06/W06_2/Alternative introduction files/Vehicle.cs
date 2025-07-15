public abstract class Vehicle<T>
{
    public T Engine { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }

    public override string ToString()
    {
        return $"Make: {Make}, Model: {Model}, Engine: {Engine}";
    }
}