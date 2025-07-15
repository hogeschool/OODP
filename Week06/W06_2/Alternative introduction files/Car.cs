public class Car<T, U> : Vehicle<T>
{
    public U Transmission { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()}, Transmission: {Transmission}";
    }
}