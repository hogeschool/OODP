static class Program
{
    static void Main()
    {
        ArrayBasics();
        ArrayClass();
        ArraysAreReferenceTypes();
    }

    /*
        List vs array
        Memory:     List takes up more memory than an array 
                    (The list class is built using an array, 
                    so it has that + more)
        Length:     Lists have a variable length, arrays have 
                    a fixed length which cannot be changed

        Use arrays if one of these is true: 
            - The size of your data is fixed
            - Your data is fixed
            - you will frequently access elements   
            - memory/processing efficiency is important

        Use Lists if one of these is true:
            - You do not have a fixed size for your data
            - You will frequently insert and/or delete elements

    */
    public static void ArrayBasics()
    {
        // type[] name = new type[]{value1, value2, ...};
        int[] numbers = { 1, 2, 3, 4, 5 };


        // Length
        int length = numbers.Length;

        // First value        
        int first = numbers[0];

        // Last value ^1 .Last()
        int last = numbers[^1];
        int otherLast = numbers.Last();

        // index last value
        int lastIndex = numbers.Length - 1;

        // type[] name = [value1, value2, ...];
        string[] names2 = ["Tom", "Sarah", "Lisa"];

        // type[] name = new type[size];
        // Will contain the default value for that type
        int[] oneToOneHundred = new int[100]; // contains 100 zeros

        // make array 1 -> 100
        for (int i = 0; i < oneToOneHundred.Length; i++)
        {
            oneToOneHundred[i] = i+1;
            // How can we change this to make it 100 -> 1?
            // oneToOneHundred[i] = 100 - i;
        }
    }

    private static void ArraysAreReferenceTypes()
    {
        int[] numbers = [7, 9, 4, 8, 4, 3];
        // Like lists, arrays are stored by reference
        UpdateFirst(numbers);

        // So if I wish to make a copy...this is not the way to do it!
        int[] badCopy = numbers;
        badCopy[0] = 1; //changes both badCopy and numbers

        // We can do so using a loop....or use built in methods Clone, Copy, etc
        int[] goodCopy = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            goodCopy[i] = numbers[i];
        }
    }

    public static void UpdateFirst(int[] array)
    {
        array[0] = 99;
    }

    // https://learn.microsoft.com/en-us/dotnet/api/system.array?view=net-8.0
    public static void ArrayClass()
    {
        int[] numbers = { 5, 3, 1, 4, 2 };
        Array.Sort(numbers);
        Array.Reverse(numbers);
    }
}
