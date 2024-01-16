/* 
   Contents:
   * String Methods
   * String Equality
   * String Escape Sequences
   * Relational Operators
   * Logical Operators
   * Selection If / Else
   * Selection Scope
   * Selection Ternary
   * Selection If / Else / If Else

    Class Exercises: W_01_1_C04 - W_01_1_C07
*/
public static class W_01_1_02_Lesson
{
    // https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-6.0
    public static void StringMethods()
    {
        string word = "supercalifragilisticexpialidocious";
        int length = word.Length;
        string wordUpper = word.ToUpper();
        string wordLower = word.ToLower();
        //Note this has no effect
        word.ToLower();
    }

    public static void StringEquality()
    {
        /*
            Two string are equal when both of them are null or both string 
            instances are of the same length and have identical characters 
            in each character position. We can use the == operator to check 
            for string equality (There are other ways).
        */
        string s1 = "hello!";
        string s2 = "hello!";
        Console.WriteLine(s1 == s2);  // output: True

        string s3 = "Hello!";
        Console.WriteLine(s1 == s3);  // output: False
    }

    public static void StringEscapeSequences()
    {
        string quote = "\"First, solve the problem. Then, write the code.\"\n\t- John Johnson";
        Console.WriteLine(quote);
        string escapeInfo = "To print a backslash (\\) write \\\\";
        Console.WriteLine(escapeInfo);
    }

    public static void RelationalOperators()
    {
        // Same as in Python
        // ==, !=, >, >=, <, <=
        int num1 = 1, num2 = 2;
        bool result = num1 > num2;
    }

    public static void LogicalOperators()
    {
        bool sad = true;
        sad = !sad; // not

        bool cold = true;
        bool raining = false;
        bool stayIn = cold && raining; // and
        bool wearCoat = cold || raining; // or

        /*
            Operator precedence (High to low)
            Logical negation operator !
            Conditional logical AND operator &&
            Conditional logical OR operator ||
        */
    }

    public static void SelectionIfElse()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        string result = "";
        if (num % 2 == 0)
        {
            result = "even";
        }
        else
        {
            result = "odd";
        }
        Console.WriteLine($"{num} is {result}");
    }

    public static void SelectionScope()
    {
        int age = 18;
        if (age < 18)
        {
            double price = 5.5;
        }
        else
        {
            // Error
            // price = 10.5;
        }
        // Error
        // Console.WriteLine(price);
    }

    public static void SelectionTernary()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        string result = (num % 2 == 0) ? "even" : "odd";
        Console.WriteLine($"{num} is {result}");
    }

    public static void SelectionIfElseIfElse()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        string result = "";
        if (num > 0)
        {
            result = "positive";
        }
        else if (num < 0)
        {
            result = "negative";
        }
        else
        {
            result = "zero";
        }
        Console.WriteLine($"{num} is {result}");
    }

    /**********************************************
    *           W_01_1_C04 - W_01_1_C07           *
    ***********************************************/
}
