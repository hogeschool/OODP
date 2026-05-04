static class ArraysRevision
{
    /*
        Exercise
        ---
        - Create an array to store the following names: "Maggy", "Lisa", "Bart", "Homer", "Marge"
        - Write some code to make a copy of this array
        - In the copy, change Maggy to Maggie 
        - Print out this new array
    */

    public static void Run()
    {
        string[] simpsons = ["Maggy", "Lisa", "Bart", "Homer", "Marge"];

        string[] simpsonsFixed = new string[simpsons.Length];
        for (int i = 0; i < simpsons.Length; i++)
        {
            simpsonsFixed[i] = simpsons[i];
        }
        // Change first element
        simpsonsFixed[0] = "Maggie";

        // Print out contents using foreach
        foreach (string item in simpsonsFixed)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(string.Join("\n", simpsonsFixed));
    }
}