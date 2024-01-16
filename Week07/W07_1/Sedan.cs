public class Sedan : Car<int, string>
{
    public Sedan()
    {
        Make = "Honda";
        Model = "Civic";
        Engine = 4; //Alternatively, an electric car could have for example "Electric motor"
        Transmission = "Automatic"; //Alternatively, could be for example 5
    }
}