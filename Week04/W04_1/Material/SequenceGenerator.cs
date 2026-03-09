static class SequenceGenerator
{

    // Sequence of integers from 'start' to 'end' with a given 'step' and a 'delimiter'
    public static string Generate(int start, int end, int step, string delimiter)
    {
        string seq = "";
        for (int i = start; i <= end; i = i + step)
        {
            seq += i + delimiter;
        }
        return seq;
    }

    // Overload with different types 
    // Sequence of integers from 'start' to 'end' with a given 'step' and a character `delimiter`
    public static string Generate(int start, int end, int step, char delimiter) 
    {
        string seq = "";
        for (int i = start; i <= end; i = i + step)
        {
            seq += i + delimiter;
        }
        return seq;
    }

    // Same as above but shorter
    // public static string Generate(int start, int end, int step, char delimiter)  => Generate(start, end, step, Convert.ToString(delimiter));
    
    // Generates a sequence of integers from 'start' to 'end' with a given 'step' and newline delimiter
    public static string Generate(int start, int end, int step) => Generate(start, end, step, "\n");


    // A return type of a method is not part of the signature of the method for the purposes of method overloading.
    // Error
    // public static int Generate(int start, int end, int step) => Convert.ToInt32(Generate(start, end, step, ""));

    // Generates a sequence of integers from 'start' to 'end' with a step of 1
    public static int Generate(int start, int end) => Convert.ToInt32(Generate(start, end, 1, ""));

    // Generates a sequence of integers from 1 to 'end' with a step of 1
    public static string Generate(int end) => Generate(1, end, 1);
}