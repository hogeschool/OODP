public class KeyValuePair<TKey, TValue>
{
    public TKey Key { get; }
    public TValue Value { get; }

    public KeyValuePair(TKey key, TValue val)
    {
        Key = key;
        Value = val;
    }
}