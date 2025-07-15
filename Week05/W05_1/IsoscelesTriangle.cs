class IsoscelesTriangle
{
    // Notice the naming convention for private fields (_camelCase)
    private double _base, _height, _slantHeight;
    protected string Color;

    public IsoscelesTriangle(double _base, double height, string color)
    {
        if (!(IsValidSide(_base) && IsValidSide(height)))
            throw new ArgumentException("Invalid triangle");

        this._base = _base;
        _height = height;
        SetSlantHeight();
        Color = color;
    }

    public void SetBase(double _base)
    {
        if (!IsValidSide(_base))
            return;
        this._base = _base;
        SetSlantHeight();
    }
    public void SetHeight(double height)
    {
        if (!IsValidSide(height))
            return;
        _height = height;
        SetSlantHeight();
    }
    private void SetSlantHeight()
    {
        _slantHeight = Math.Sqrt(Math.Pow(_base / 2, 2) + Math.Pow(_height, 2));
    }

    protected static bool IsValidSide(double side) => side > 0;

    public virtual void Paint(string color) => Color = color;

    public override string ToString()
    {
        return $"{base.ToString()} with base: {_base}, " +
            $"height: {_height}, slant height: {_slantHeight}, " +
            $"color: {Color}";
    }
}

/*
 IsoscelesTriangle:

      *
    *****
  *********
************
 */
