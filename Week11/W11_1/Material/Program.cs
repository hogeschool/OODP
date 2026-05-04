static class Program
{
    static void Main()
    {
        ArraysRevision.Run();

        JaggedArrays.Run();
        int[][] array = JaggedArrays.GetTriangle(4);

        MultiDimArrays.Run();
    }
}