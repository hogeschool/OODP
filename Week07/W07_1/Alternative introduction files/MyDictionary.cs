//No need to understand this code or to even look at it!
//It's just here to make the picture complete.

public class MyDictionary<TKey, TValue>
{
    private readonly List<KeyValuePair<TKey, TValue>> _list = new();

    public void Add(TKey key, TValue value)
    {
        var kvp = new KeyValuePair<TKey, TValue>(key, value);
        _list.Add(kvp);
    }

    public bool ContainsKey(TKey key)
    {
        foreach (var kvp in _list)
        {
            if (kvp.Key.Equals(key))
            {
                return true;
            }
        }
        return false;
    }

    public TValue this[TKey key]
    {
        get
        {
            foreach (var kvp in _list)
            {
                if (kvp.Key.Equals(key))
                {
                    return kvp.Value;
                }
            }
            throw new KeyNotFoundException();
        }
        set
        {
            for (int i = 0; i < _list.Count; i++)
            {
                var kvp = _list[i];
                if (kvp.Key.Equals(key))
                {
                    _list[i] = new KeyValuePair<TKey, TValue>(key, value);
                    return;
                }
            }
            throw new KeyNotFoundException();
        }
    }

    public bool Remove(TKey key)
    {
        for (int i = 0; i < _list.Count; i++)
        {
            var kvp = _list[i];
            if (kvp.Key.Equals(key))
            {
                _list.RemoveAt(i);
                return true;
            }
        }
        return false;
    }
}