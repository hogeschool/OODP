public static class ListExtensions
{
    private static readonly Random _rng = new();

    //Out of scope, but the `this` keyword here allows you
    //to call the method directly on the list. For example:
    //myList.PickRandom()
    //In other words: it is an extension to the List class.
    public static T PickRandom<T>(this IList<T> list)
    {
        int index = _rng.Next(list.Count);
        return list[index];
    }

    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = _rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
