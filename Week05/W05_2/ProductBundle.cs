public class ProductBundle : Product
{
    private string _description; //backing field
    public override string Description
    { 
        get => _description;
        set => _description = value + $" Quantity: {Quantity}";
    }

    public int Quantity { get; } //read-only
    public int BundlesSold { get; private set; } //different access modifiers

    public ProductBundle(string name, double price, string description, int quantity)
        : base(name, price, description)
    {
        if (quantity < 2)
            throw new ArgumentException("Must be sold in quantities of at least 2");
        Quantity = quantity;
    }

    public override void Sell()
    {
        Sold += Quantity;
        BundlesSold++;
    }
}