public static class AndThen
{
    public static Func<int, int> Then(Func<int, int> f, Func<int, int> g)
    {
        return x => g(f(x));
    }

    public static void TestThen()
    {
        Func<int, int> add2mul2 = Then(x => x + 2, x => x * 2);
        int result = add2mul2(5);
    }
}