class Vehicle
{
    public string Make;
    public string Model;
    public int Year;

    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    ////Code duplication

    //public Vehicle(string make, int year)
    //{
    //    Make = make;
    //    Model = "unknown model";
    //    Year = year;
    //}

    //public Vehicle(int year)
    //{
    //    Make = "unknown make";
    //    Model = "unknown model";
    //    Year = year;
    //}

    //public Vehicle(Vehicle other) //Copy constructor
    //{
    //    Make = other.Make;
    //    Model = other.Model;
    //    Year = other.Year;
    //}

    //Constructor chaining
    public Vehicle(string make, int year) : this(make, "unknown model", year) { }
    public Vehicle(int year) : this("unknown make", "unknown model", year) { }
    public Vehicle(Vehicle other) : this(other.Make, other.Model, other.Year) { }
}
