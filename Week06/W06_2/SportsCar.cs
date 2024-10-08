class SportsCar : Car
{
    public SportsCar(int horsepower, int weight) : base(horsepower, weight) { }

    public new double EstimateTopSpeedKph()
    {
        return base.EstimateTopSpeedKph() * 1.5; //Increase top speed by 50%
    }
}
