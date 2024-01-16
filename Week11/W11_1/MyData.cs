public class MyData
{
    private int[] _data;
    public MyData(int[] data) => _data = data;

    public int this[int index] //Convenient!
    {
        get => _data[index];
        set => _data[index] = value;
    }
}