class Car
{
    public Engine CarEngine; //Object as field

    public Car(Engine engine)
    {
        //In the constructor, it is impossible to return.
        //So if engine is null, we will be stuck with a CarEngine that is null
        //(or we could throw an Exception).
        CarEngine = engine;
    }

    public string Info()
    {
        if (CarEngine is null) { return "This car has no engine"; }
        return $"This car's engine has {CarEngine.Horsepower} horsepower";
    }
}
