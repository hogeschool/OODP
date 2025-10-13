static class JaggedArray
{
    public static void Run()
    {
        Console.WriteLine("Welcome to the Observation Tracker!");

        int[][] observations = CreateObservationData();
        PrintObservations(observations);
    }

    private static int[][] CreateObservationData()
    {
        Console.Write("How many days would you like to track observations for? ");
        int numDays = int.Parse(Console.ReadLine());

        int[][] observations = new int[numDays][];

        for (int day = 0; day < observations.Length; day++)
        {
            observations[day] = ReadObservationsForDay(day + 1);
        }

        return observations;
    }

    private static int[] ReadObservationsForDay(int dayNumber)
    {
        Console.Write($"How many observations did you make on day {dayNumber}? ");
        int numObs = int.Parse(Console.ReadLine());
        int[] dayObservations = new int[numObs];

        for (int j = 0; j < dayObservations.Length; j++)
        {
            Console.Write($"Enter observation {j + 1} for day {dayNumber}: ");
            dayObservations[j] = int.Parse(Console.ReadLine());
        }

        return dayObservations;
    }

    private static void PrintObservations(int[][] observations)
    {
        Console.WriteLine("\nObservation tracker complete! Here are the results:");
        for (int day = 0; day < observations.Length; day++)
        {
            Console.Write($"Day {day + 1}: {observations[day].Length} observations\n -");
            foreach (int obs in observations[day])
                Console.Write(" " + obs);
            Console.WriteLine();
        }
    }
}