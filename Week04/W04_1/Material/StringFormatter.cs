static class StringFormatter
{
    //Overloading by code duplication
    public static char Capitalize(char input) => char.ToUpper(input);
    public static string Capitalize(string input) => input.ToUpper(); //Duplication
    public static string Capitalize(string input, bool firstLetterOnly)
    {
        if (firstLetterOnly)
        {
            return char.ToUpper(input[0]) + input.Substring(1);
        }
        return input.ToUpper();
    }

    //Overloading by method forwarding
    public static char Lowercase(char input) => char.ToUpper(input); //Not forwarding. Can you see why not?
    public static string Lowercase(string input) => Lowercase(input, false); //Forwarding
    public static string Lowercase(string input, bool firstLetterOnly)
    {
        if (firstLetterOnly)
        {
            return char.ToLower(input[0]) + input.Substring(1);
        }
        return input.ToLower();
    }
}
