/* 
   Contents:
   * Switch Statements and expressions with the constant pattern
   * Grouping cases in switch statements and expressions
   * Switch Statements and expressions with the relational pattern

    Class Exercises: W_01_1_C08 - W_01_1_C09

    Switch statements:
    https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements#the-switch-statement

    Switch expressions:
    https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/switch-expression

    Optional - more advanced resource for switch expression for those that are interested:
    https://drakelambert.dev/2019/12/C%23-8-Switch-Expressions-with-Pattern-Matching.html

    Note: Switch statements are not always faster: https://www.dotnetperls.com/if-switch-performance
*/

public static class W_01_1_03_Lesson
{
    /*
        Switch with constant pattern - test if an expression result equals a specified constant
        https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/patterns#constant-pattern
    */
    public static void SwitchStatementAndExpression()
    {
        Console.WriteLine("Enter a number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a symbol");
        string symbol = Console.ReadLine();

        // switch statement
        string result1 = $"{num1} {symbol} {num2} = ";


        if (symbol == "+")
        {
            result1 += (num1 + num2);
        }
        else if (symbol == "-")
        {
            result1 += (num1 - num2);
        }
        else if (symbol == "*")
        {
            result1 += (num1 * num2);
        }
        else if (symbol == "/")
        {
            result1 += (num1 / num2);
        }
        //The default case specifies statements to execute when a match expression doesn't match any other case pattern.
        else
        {
            result1 += "Operation not supported";
        }

        /*
            selects a statement list to execute based on a pattern match
            Do you think this is easier to read/write?
        */
        switch (symbol)
        {
            case "+":
                result1 += (num1 + num2);
                /* 
                    You use the break statement at the end of each switch section to 
                    pass control out of a switch statement. Could also use return instead
                */
                break;
            case "-":
                result1 += (num1 - num2);
                break;
            case "*":
                result1 += (num1 * num2);
                break;
            case "/":
                result1 += (num1 / num2);
                break;
            //The default case specifies statements to execute when a match expression doesn't match any other case pattern.
            default:
                result1 += "Operation not supported";
                break;
        }

        // switch expression
        // Is this easier to read/write?
        string result2 = $"{num1} {symbol} {num2} = ";
        result2 += symbol switch
        {
            "+" => (num1 + num2),
            "-" => (num1 - num2),
            "*" => (num1 * num2),
            "/" => (num1 / num2),
            // default case
            _ => "Operation not supported"
        };
    }

    public static void SwitchGroupCases()
    {
        Console.WriteLine("Enter a day");
        string day = Console.ReadLine();
        string result = "";
        //  switch statement 
        switch (day)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":
                result = "Week day";
                break;
            case "Saturday":
            case "Sunday":
                result = "Weekend";
                break;
                //Default optional
        }

        // switch statement
        switch (day)
        {
            case "Monday" or "Tuesday" or "Wednesday" or "Thursday" or "Friday":
                result = "Week day";
                break;
            case "Saturday" or "Sunday":
                result = "Weekend";
                break;
                //Default optional
        }
    }

    /* 
        Switch statement with relational pattern - compare an expression result with a constant
        https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/patterns#relational-patterns
    */
    public static void RelationalPattern()
    {
        string result1 = "";
        Console.WriteLine("Enter a day number (Monday = 1, etc)");
        int dayNum = Convert.ToInt32(Console.ReadLine());


        // switch statement 
        switch (dayNum)
        {
            case >= 1 and <= 5:
                result1 = "Week day";
                break;
            case 6 or 7:
                result1 = "Weekend";
                break;
            default:
                result1 = "Invalid day";
                break;
        }

        // switch expression
        string result2 = dayNum switch
        {
            >= 1 and <= 5 => "Week day",
            6 or 7 => "Weekend",
            _ => "Invalid day"
        };
    }

    /**********************************************
    *           W_01_1_C08 - W_01_1_C09           *
    ***********************************************/
}
