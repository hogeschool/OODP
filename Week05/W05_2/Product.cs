public class Product
{
    public string Name { get; set; } //auto-implemented property
    public virtual string Description { get; set; } = "none"; //virtual; default value

    private double _price; //backing field
    public double Price
    {
        get => _price;
        set => _price = value >= 0 ? value : 0;
    }

    public int Sold { get; protected set; } //different access modifiers

    public Product(string name, double price) : this(name, price, null) { }
    public Product(string name, double price, string description)
    {
        Name = name;
        Price = price;
        if (description != null)
            Description = description;
    }

    public virtual void Sell() => Sold++;
}