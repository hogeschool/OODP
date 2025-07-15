using System.Collections;

class MyList<T> : IEnumerable<T>
{
    private List<T> _list = new();
    
    public void Add(T item) => _list.Add(item);

    //Implement the IEnumerable interface method.
    public IEnumerator<T> GetEnumerator() => _list.GetEnumerator();
    //Implement the IEnumerable interface method
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}