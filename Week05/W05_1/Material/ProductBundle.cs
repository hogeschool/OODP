class ProductBundle : Product
{
    public override string Description => base.Description + $" (quantity: {Quantity})"; //read-only
    // same as: public override string Description { get => base.Description + $" (quantity: {Quantity}) }";

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
