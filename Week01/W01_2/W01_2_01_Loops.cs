public static class W01_2_01
{
    public static void Main1()
    {
        // * while - count 1 to 3
        int count = 1;
        while (count < 3)
        {
            Console.WriteLine(count);
            count++;
        }
        // while - best usage when a loop needs to run 
        // anywhere between 0 to an unknown number of times 

        // Find the first number that a given number divides into
        int divisor = 3;
        // Loop runs 0 times for 3 and 2 times for 7
        int start = 6;

        int result = start;
        while (result % divisor != 0)
        {
            result++;
        }

        Console.WriteLine($"The first number that {divisor} divides into from {start} is: {result}");

        // Enter a number 1 -> 10 with code repetition
        Console.WriteLine("Enter a number between 1 and 10");
        int number = Convert.ToInt32(Console.ReadLine());
        while (number < 1 || number > 10)
        {
            Console.WriteLine("Enter a number between 1 and 10");
            number = Convert.ToInt32(Console.ReadLine());
        }

        // do-while  - best usage when a loop needs to run
        // anywhere between 1 to an unknown number of times 
        // do {} while();
        // Enter a number 1 -> 10 - notice no code repetition
        number = 0;
        do
        {
            Console.WriteLine("Enter a number between 1 and 10");
            number = Convert.ToInt32(Console.ReadLine());
        } while (number < 1 || number > 10);

        // for - best usage, when you know exactly how many 
        // times something will happen

        // count 1 -> 3
        for (int i = 1; i < 3; i++)
        {
            Console.WriteLine(i);
        }

        // scope 
        // Console.WriteLine(i); error

        // If you want to use the looping variable outside of the loop
        int j = 0;
        for (; j < 10; j += 2)
        {
            Console.WriteLine(j);
        }
        Console.WriteLine(j);
    }
}