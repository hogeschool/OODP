using System.Collections;

public class YieldIEnum
{
    public static void YieldEnum()
    {
        //Case1();
        Case2();
    }

    public static void Case1()
    {
        var First = EvenNumbers(9);
        foreach (var x in First)
        {
            Console.WriteLine(x);
        }
        //An iterator is an object that loops over a container
        foreach (var y in ProduceEvenNumbers(9)) //Performing an action on each item in a collection.
            Console.WriteLine(y);

        foreach (var z in CombinedEvenNumber(9, false))
        {
            Console.WriteLine(z);
        }
    }

    //This method will consume a significant amount of memory
    //to store the entire list of even numbers, if 'upto' is large.
    public static List<int> EvenNumbers(int upto)
    {
        List<int> result = new();
        for (int i = 0; i <= upto; i += 2)
            result.Add(i);
        return result;
    }
    
    //This method instead uses a 'yield return', which will generate
    //the next value to be returned on each individual method call.
    //This is also how the 'range' function works in Python.
    public static IEnumerable<int> ProduceEvenNumbers(int upto)
    {
        for (int i = 0; i <= upto; i += 2)
        {
            yield return i;
        }
        //You can't have both a return statement and a
        //yield return statement in the same method.
    }

    public static IEnumerable<int> CombinedEvenNumber(int upto, bool useList)
    {
        if (useList)
        {
            //Advantage: can be iterated over multiple times
            //Disadvantage: can consume a lot of memory
            return EvenNumbers(upto); 
        }
        else
        {
            //Advantage: low memory consumption
            //Disadvantage: cannot be iterated over multiple times (need to generate again) 
            return ProduceEvenNumbers(upto);

        }
    }

    public static void Case2()
    {
        ProductListing productListing = new();
        productListing.AddRange(new List<Product>() {
            new(1, "P1", 10),
            new(2, "P2", 20),
            new(3, "P3", 30) });
        LoopThrough(productListing);
        //foreach (var product in productListing)
        //{
        //    Console.WriteLine(product);
        //}
    }
    public static void LoopThrough<T>(T collectionObject) where T : IEnumerable
    {
        foreach (var item in collectionObject)
        {
            Console.WriteLine(item);
        }
    }
}

public class Product
{
    private int _id;
    private string _name;
    private double _price;
    
    public Product(int id, string name, double price)
    {
        _id = id;
        _name = name;
        _price = price;
    }
    
    public override string ToString() => $"id: {_id}, name: {_name}, price: {_price}";
}

public class ProductListing : IEnumerable
{
    private List<Product> _products = new();

    public void AddProduct(Product p) => _products.Add(p);
    public void AddProduct(int id, string name, double price)
    {
        AddProduct(new Product(id, name, price));
    }
    public void AddRange(List<Product> products) => _products.AddRange(products);

    public IEnumerable<Product> GetProducts()
    {
        foreach (Product p in _products)
            yield return p;
    }

    public IEnumerator GetEnumerator()
    {
        return ((IEnumerable)_products).GetEnumerator();
    }
}