public static class W01_2_04_Random
{
    public static void Main4()
    {
        // Built-in classes: Random
        // Creating a random object (Pseudorandom - uses system clock to generate)
        Random randomGenerator = new Random();

        // Next (int maxValue) int [0, maxValue)
        int rNum1 = randomGenerator.Next(10);

        // ext (int minValue, int maxValue) [minValue, maxValue)
        int rNum2 = randomGenerator.Next(5, 10);

        // NextDouble () (0.0, 1.0)
        double rNum3 = randomGenerator.NextDouble();

        // How to get a random double between 4 and 10?
        // -> r * (max - min) + min
        int min = 4;
        int max = 10;
        double rNum4 = (randomGenerator.NextDouble()) * (max - min) + min;
        // 0.0 * 6 = 0.0 + 4 = 4.0 -> 0.9 * 6 = 5.4 + 4 = 9

        // Reproducible sequence of random numbers - supply the seed
        Random predictable1 = new Random(1);
        Random predictable2 = new Random(1);

        int p1n1 = predictable1.Next(10);
        int p1n2 = predictable1.Next(10);

        int p2n1 = predictable2.Next(10);
        int p2n2 = predictable2.Next(10);

        // Shortcut: new(), new(1)
        Random r = new(); // instead of Random()
        Random r1 = new(1); // instead of Random(1)
    }
}