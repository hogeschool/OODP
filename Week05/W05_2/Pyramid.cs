class Pyramid : IsoscelesTriangle
{
    public Pyramid(double _base, double apex, string color)
        : base(_base, apex, color) { }

    //Not even a derived class can access its base class' private members
    //public double GetBase() => _base;

    public void SetApex(double apex) //Apex is the Pyramid's height
    {
        if (!IsValidSide(apex))
            return;
        SetHeight(apex);
    }

    public override void Paint(string color)
    {
        Paint(color, color, color, color, color);
    }
    public void Paint(string c1, string c2, string c3, string c4, string c5)
    {
        Color = $"{c1} {c2} {c3} {c4} {c5}";
    }
}
